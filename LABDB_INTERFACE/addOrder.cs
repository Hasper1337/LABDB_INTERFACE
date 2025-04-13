using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LABDB_INTERFACE
{
    public partial class addOrder : Form
    {
        public addOrder()
        {
            InitializeComponent();
            InitializeServiceEmployeePairs();
            LoadComboBoxData();
        }

        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=44961755;Database=db1.2;";
        private DataTable _serviceDt;
        private DataTable _employeeDt;

        private List<Tuple<System.Windows.Forms.ComboBox, System.Windows.Forms.ComboBox>> _serviceEmployeePairs;

        private void InitializeServiceEmployeePairs()
        {
            _serviceEmployeePairs = [
                Tuple.Create(comboBox_Service1, comboBox_Employee1),
                Tuple.Create(comboBox_Service2, comboBox_Employee2),
                Tuple.Create(comboBox_Service3, comboBox_Employee3)
        ];
        }

        private async void LoadComboBoxData()
        {
            using var conn = new NpgsqlConnection(connectionString);
            await conn.OpenAsync();

            // Загрузка услуг
            _serviceDt = new DataTable();
            using (var cmd = new NpgsqlCommand(@"SELECT id, name FROM public.""Service""", conn))
            using (var reader = await cmd.ExecuteReaderAsync())
            {
                _serviceDt.Load(reader);
            }

            // Загрузка сотрудников с объединенным именем
            _employeeDt = new DataTable();
            using (var cmd = new NpgsqlCommand(@"SELECT id, first_name || ' ' || last_name AS full_name FROM public.""Employee""", conn))
            using (var reader = await cmd.ExecuteReaderAsync())
            {
                _employeeDt.Load(reader);
            }

            foreach (var (serviceCombo, employeeCombo) in _serviceEmployeePairs)
            {
                InitializeComboBox(serviceCombo, _serviceDt, "name");
                InitializeComboBox(employeeCombo, _employeeDt, "full_name");
            }
        }


        private void InitializeComboBox(System.Windows.Forms.ComboBox comboBox, DataTable dataTable, string displayMember)
        {
            comboBox.DataSource = dataTable.Copy();
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = "id";
            comboBox.SelectedIndex = -1;
        }

        private void AddOrder(int id_Client, DateTime pickupDate, string status, DateTime date_apppr,
            string type_cloath, string color, string features, bool lining, string type_product)
        {
            using NpgsqlConnection conn = new(connectionString);
            try
            {
                conn.Open();
                using NpgsqlTransaction transaction = conn.BeginTransaction();
                int id_Order;

                var selectedServiceIds = _serviceEmployeePairs
                    .Where(pair => pair.Item1.SelectedValue != null)
                    .Select(pair => (int)pair.Item1.SelectedValue)
                    .Distinct()
                    .ToList();

                if (!selectedServiceIds.Any())
                {
                    MessageBox.Show("Не выбранно не одной услуги");
                    return;
                }

                double totalcost = CalculateCost(selectedServiceIds);

                string query_Order = @"
                INSERT INTO public.""Order"" 
                    (id_Client, pickup_date, status, total_cost, date_appr_readiness) 
                VALUES 
                    (@id_Client, @pickup_date, @status, @total_cost, @date_appr_readliness) RETURNING id;";

                using NpgsqlCommand order_command = new(query_Order, conn, transaction);

                order_command.Parameters.AddWithValue("@id_Client", id_Client);
                order_command.Parameters.AddWithValue("@pickup_date", pickupDate);
                order_command.Parameters.AddWithValue("@status", status);
                order_command.Parameters.AddWithValue("@total_cost", totalcost);
                order_command.Parameters.AddWithValue("@date_appr_readliness", date_apppr);

                id_Order = Convert.ToInt32(order_command.ExecuteScalar()); // Получение ID заказа

                string query_Product = @"
                INSERT INTO public.""Product"" 
                    (id_order, type_cloath, color, features, lining, type_product) 
                VALUES 
                    (@id_Order, @type_cloath, @color, @features, @lining, @type_product)";

                using NpgsqlCommand product_command = new(query_Product, conn, transaction);

                product_command.Parameters.AddWithValue("@id_Order", id_Order);
                product_command.Parameters.AddWithValue("@type_cloath", type_cloath);
                product_command.Parameters.AddWithValue("@color", color);
                product_command.Parameters.AddWithValue("@features", features ?? (object)DBNull.Value);
                product_command.Parameters.AddWithValue("@lining", lining);
                product_command.Parameters.AddWithValue("@type_product", type_product);

                /// Блок кода для пары сотрудник-услуга
                foreach (var (serviceCombo, employeeCombo) in _serviceEmployeePairs)
                {
                    if (serviceCombo.SelectedValue == null || employeeCombo.SelectedValue == null) continue;
                    int serviceId = Convert.ToInt32(serviceCombo.SelectedValue);
                    int employeeId = Convert.ToInt32(employeeCombo.SelectedValue);

                    using var cmd = new NpgsqlCommand(@"INSERT INTO public.""Service_record""
                                                    (id_order, id_service, id_employee)
                                                    VALUES (@id_order, @id_service, @id_employee)", conn, transaction);
                    cmd.Parameters.AddWithValue("@id_order", id_Order);
                    cmd.Parameters.AddWithValue("@id_service", serviceId);
                    cmd.Parameters.AddWithValue("@id_employee", employeeId);

                    cmd.ExecuteNonQuery();
                }
                ///

                product_command.ExecuteNonQuery();
                transaction.Commit();
                MessageBox.Show("Заказ добавлен успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении заказа: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private double CalculateCost(List<int> serviceIds)
        {
            double totalCost = 0.0;
            using var conn = new NpgsqlConnection(connectionString);
            conn.Open();

            string sql = $"SELECT SUM(cost_per_count) FROM public.\"Service\" WHERE id IN " +
                $"({string.Join(",", serviceIds.Select((_, i) => $"@id{i}"))})";
            using var cmd = new NpgsqlCommand(sql, conn);
            for (int i = 0; i < serviceIds.Count; i++)
            {
                cmd.Parameters.AddWithValue($"@id{i}", serviceIds[i]);
            }
            var result = cmd.ExecuteScalar();
            if (result != DBNull.Value && result != null)
            {
                totalCost = Convert.ToDouble(result);
            }

            return totalCost;
        }

        private void addButton_order_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numericUpDown_idClient.Text) ||
                string.IsNullOrWhiteSpace(dateTimePicker_pickupdate.Text))
            {
                MessageBox.Show("ID клиента и дата приема обязательны для заполнения!");
                return;
            }
            // Собираем данные с формы
            int id_Client = (int)numericUpDown_idClient.Value;
            DateTime pickupDate = dateTimePicker_pickupdate.Value;
            string status = "Принят";
            DateTime date_apppr = pickupDate.AddDays(7);

            /////  Блок кода сотрудник-услуга для Service_record
            bool hasValidPiar = _serviceEmployeePairs.Any(pair => pair.Item1.SelectedValue != null &&
            pair.Item2.SelectedValue != null);


            if (!hasValidPiar)
            {
                MessageBox.Show("Необходимо указать хотя бы одну пару Услуга-Сотрудник!");
                return;
            }

            var employeeIds = new HashSet<int>();
            foreach (var (_, employeeCombo) in _serviceEmployeePairs)
            {
                if (employeeCombo.SelectedValue == null) continue;

                int id = (int)employeeCombo.SelectedValue;
                if (!employeeIds.Add(id))
                {
                    MessageBox.Show("Сотрудник не может быть назначен на несколько услуг!");
                    return;
                }
            }
            /////
            string type_cloath = textBox_typeCloath.Text;
            string color = textBox_Product_color.Text;
            string features = textBox_Product_features.Text;
            bool lining = checkBox_Product_lining.Checked;
            string type_product = textBox_Product_typeProduct.Text;


            // Добавляем клиента в базу данных
            AddOrder(id_Client, pickupDate, status, date_apppr, type_cloath, color, features, lining, type_product);

            // Закрываем форму после сохранения
            this.Close();
        }

        private void numericUpDown_idClient_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
