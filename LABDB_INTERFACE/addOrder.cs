using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
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
            LoadComboBoxData();
        }

        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=44961755;Database=db1.2;";
        
        private void LoadComboBoxData()
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                // Загрузка услуг
                var serviceDt = new DataTable();
                using (var cmd = new NpgsqlCommand(@"SELECT id, name FROM public.""Service""", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    serviceDt.Load(reader);
                }

                ConfigureComboBox(comboBox_Service1, serviceDt);
                ConfigureComboBox(comboBox_Service2, serviceDt);
                ConfigureComboBox(comboBox_Service3, serviceDt);

                // Загрузка сотрудников с объединенным именем
                var employeeDt = new DataTable();
                using (var cmd = new NpgsqlCommand(@"SELECT id, first_name || ' ' || last_name AS full_name FROM public.""Employee""", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    employeeDt.Load(reader);
                }

                ConfigureComboBox(comboBox_Employee1, employeeDt, "full_name");
                ConfigureComboBox(comboBox_Employee2, employeeDt, "full_name");
                ConfigureComboBox(comboBox_Employee3, employeeDt, "full_name");
                ConfigureComboBox(comboBox_Employee4, employeeDt, "full_name");
            }
        }

        private void ConfigureComboBox(System.Windows.Forms.ComboBox comboBox, DataTable dataTable, string displayMember = "name")
        {
            comboBox.BeginUpdate();
            comboBox.BindingContext = new BindingContext();
            comboBox.DataSource = dataTable;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = "id";
            comboBox.EndUpdate();
        }


        private void AddOrder(int id_Client, DateTime pickupDate, string status, double totalCost, DateTime date_apppr,
            string type_cloath, string color, string features, bool lining, string type_product)
        {
            using NpgsqlConnection conn = new(connectionString);
            try
            {
                conn.Open();
                using NpgsqlTransaction transaction = conn.BeginTransaction();
                int id_Order;
                string query_Order = @"
                INSERT INTO public.""Order"" 
                    (id_Client, pickup_date, status, total_cost, date_appr_readiness) 
                VALUES 
                    (@id_Client, @pickup_date, @status, @total_cost, @date_appr_readliness) RETURNING id;";

                using NpgsqlCommand order_command = new(query_Order, conn, transaction);

                order_command.Parameters.AddWithValue("@id_Client", id_Client);
                order_command.Parameters.AddWithValue("@pickup_date", pickupDate);
                order_command.Parameters.AddWithValue("@status", status);
                order_command.Parameters.AddWithValue("@total_cost", totalCost);
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

        //private void AddProduct(int id_order, string type_cloath, string color, string features, bool lining, string type_product)
        //{
        //    using NpgsqlConnection conn = new(connectionString);
        //    try
        //    {
        //        conn.Open();
        //        string query = @"
        //        INSERT INTO public.""Product"" 
        //            (id_Order, type_cloath, color, features, lining, type_product) 
        //        VALUES 
        //            (@id_Order, @type_cloath, @color, @features, @lining, @type_product)";

        //        using NpgsqlCommand cmd = new(query, conn);

        //        cmd.Parameters.AddWithValue("@id_Order", id_Order);
        //        cmd.Parameters.AddWithValue("@type_cloath", type_cloath);
        //        cmd.Parameters.AddWithValue("@color", color);
        //        cmd.Parameters.AddWithValue("@features", features ?? (object)DBNull.Value);
        //        cmd.Parameters.AddWithValue("@lining", lining);
        //        cmd.Parameters.AddWithValue("@type_product", type_product);

        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Клиент добавлен успешно!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ошибка при добавлении клиента: " + ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}


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
            double totalCost = 1.1;
            DateTime date_apppr = pickupDate.AddDays(7);

            //int ServiceID1 = (int)comboBox_Service1.SelectedValue;
            //int ServiceID2 = (int)comboBox_Service2.SelectedValue;
            //int ServiceID3 = (int)comboBox_Service3.SelectedValue;

            //int EmployeeID1 = (int)comboBox_Employee1.SelectedValue;
            //int EmployeeID2 = (int)comboBox_Employee2.SelectedValue;
            //int EmployeeID3 = (int)comboBox_Employee3.SelectedValue;
            //int EmployeeID4 = (int)comboBox_Employee4.SelectedValue;


            string type_cloath = textBox_typeCloath.Text;
            string color = textBox_Product_color.Text;
            string features = textBox_Product_features.Text;
            bool lining = checkBox_Product_lining.Checked;
            string type_product = textBox_Product_typeProduct.Text;


            // Добавляем клиента в базу данных
            AddOrder(id_Client, pickupDate, status, totalCost, date_apppr, type_cloath, color, features, lining, type_product);
            //AddProduct(id_order, type_cloath, color, features, lining, type_product);

            // Закрываем форму после сохранения
            this.Close();
        }
    }
}
