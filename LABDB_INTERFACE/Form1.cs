//using System;
//using System.Data;
//using System.Data.Common;
//using System.Drawing.Text;
//using System.Globalization;
//using System.Net;
//using System.Windows.Forms;
//using Npgsql;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

using System;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using Npgsql;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace LABDB_INTERFACE
{
    public partial class Form1 : Form
    {
        private const string Schema = "public";
        private readonly DataManager _dataManager;
        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=44961755;Database=db1.2;";

        private BindingSource _bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            _dataManager = new DataManager("Host=localhost;Port=5432;Username=postgres;Password=44961755;Database=db1.2;");
            ConfigureGrigs();
        }

        private void ConfigureGrigs()
        {
            var grids = new[] { datagrid_client, dataGrid_order, dataGrid_product, dataGrid_service, dataGrid_employee };
            foreach (var grid in grids)
            {
                grid.Columns.Cast<DataGridViewColumn>()
                    .ToList()
                    .ForEach(c => c.SortMode = DataGridViewColumnSortMode.NotSortable);

                grid.SuspendLayout();
                grid.ResumeLayout();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            using NpgsqlConnection connection = new(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Подключение к базе данных успешно");

                LoadData(datagrid_client, "Client");
                LoadData(dataGrid_order, "Order");
                LoadData(dataGrid_product, "Product");
                LoadData(dataGrid_service, "Service");
                LoadData(dataGrid_employee, "Employee");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключеия: " + ex.Message);
            }
        }

        ///
        /// Классы
        public static class AddData
        {
            public static void ShowFormAndReload<TForm>(Action reloadAction)
                where TForm : Form, new()
            {
                using (TForm form = new())
                {
                    form.ShowDialog();
                }
                reloadAction?.Invoke();
            }
        }

        public class DataManager(string connectionString) //Класс заполнения и сохранения
        {
            private readonly string _connectionString = connectionString;

            public void Fill(DataGridView grid, string tableName)
            {
                string query = $@"SELECT * 
                      FROM {tableName} 
                      ORDER BY order_id DESC";
                using var connection = new NpgsqlConnection(_connectionString);
                using var adapter = new NpgsqlDataAdapter($"SELECT * FROM {tableName}", connection);
                var dt = new DataTable();
                adapter.Fill(dt);
                grid.DataSource = dt;
            }

            public void Save(DataGridView grid, string tableName)
            {
                if (grid.DataSource is not DataTable dt) return;

                DataTable changes = dt.GetChanges(DataRowState.Modified | DataRowState.Added);

                if (changes != null)
                {
                    try
                    {
                        using var connection = new NpgsqlConnection(connectionString);
                        connection.Open();

                        using var adapter = new NpgsqlDataAdapter($"SELECT * FROM {tableName}", connection);
                        var commandBuilder = new NpgsqlCommandBuilder(adapter);

                        adapter.Update(changes);

                        dt.AcceptChanges();

                        MessageBox.Show("Данные успешно сохранены");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}");
                        dt.RejectChanges(); // Откатываем изменения при ошибке
                    }
                }
            }
        }
        /// Классы
        ///


        ///
        /// Базовые функции
        private void LoadData(DataGridView grid, string tableName)
            => _dataManager.Fill(grid, $"{Schema}.\"{tableName}\"");

        private void SaveData(DataGridView grid, string tableName)
            => _dataManager.Save(grid, $"{Schema}.\"{tableName}\"");
        /// Базовые функции
        ///


        ///
        /// Кнопки добавления
        private void add_client_Click(object sender, EventArgs e)
            => AddData.ShowFormAndReload<addClient>(() => LoadData(datagrid_client, "Client"));

        private void add_order_Click(object sender, EventArgs e)
            => AddData.ShowFormAndReload<addOrder>(() => LoadData(dataGrid_order, "Order"));

        private void add_employee_Click(object sender, EventArgs e)
            => AddData.ShowFormAndReload<addEmployee>(() => LoadData(dataGrid_employee, "Employee"));

        private void add_service_Click(object sender, EventArgs e)
            => AddData.ShowFormAndReload<addService>(() => LoadData(dataGrid_service, "Service"));

        private void WriteReportBtn_Click(object sender, EventArgs e) // запрос на возвращение определенного кортежа по первичному ключу
        {
            try
            {
                using var conn = new NpgsqlConnection(connectionString);
                conn.Open();

                int id = (int)numericUpDown_employee.Value;
                if (id <= 0)
                {
                    string queryifidnull = @"
            SELECT 
                e.id,
                e.first_name ||' '|| e.last_name AS ""Сотрудник"",
                o.id AS ""Номер заказа"",
                o.pickup_date AS ""Дата приёма"",
                p.type_product AS ""Изделие""
            FROM public.""Employee"" e
            JOIN public.""Service_record"" sr ON e.id = sr.""id_employee""
            JOIN public.""Order"" o ON o.id = sr.""id_order""
            JOIN public.""Product"" p ON o.id = p.""id_order""
            ORDER BY e.id asc;";
                    using var cmd = new NpgsqlCommand(queryifidnull, conn);
                    using var adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView_report.DataSource = dt;
                }
                else
                {
                    string queryifidnotnull = @"
            SELECT 
                e.id,
                e.first_name ||' '|| e.last_name AS ""Сотрудник"",
                o.id AS ""Номер заказа"",
                o.pickup_date AS ""Дата приёма"",
                p.type_product AS ""Изделие""
            FROM public.""Employee"" e
            JOIN public.""Service_record"" sr ON e.id = sr.""id_employee""
            JOIN public.""Order"" o ON o.id = sr.""id_order""
            JOIN public.""Product"" p ON o.id = p.""id_order""
            WHERE e.id = @id
            ORDER BY e.id asc;";
                    using var cmd = new NpgsqlCommand(queryifidnotnull, conn);
                    using var adapter = new NpgsqlDataAdapter(cmd);

                    cmd.Parameters.AddWithValue("@id", id);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView_report.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }
        }

        private void WriteReportBtn_client_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = new NpgsqlConnection(connectionString);
                conn.Open();

                int id = (int)numericUpDown_client.Value;
                if (id <= 0)
                {
                    string queryifidnull = @"
            SELECT 
                c.id,
                c.first_name ||' '|| c.last_name AS ""Клиент"",
                o.id AS ""Номер заказа"",
                o.pickup_date AS ""Дата приёма"",
                STRING_AGG(s.name, ', ') AS ""Услуги""
            FROM public.""Client"" c
            JOIN public.""Order"" o ON c.id = o.""id_client""
            JOIN public.""Service_record"" sr ON o.id = sr.""id_order""
            JOIN public.""Service"" s ON s.id = sr.""id_service""
            GROUP BY c.id, c.first_name, c.last_name, o.id, o.pickup_date       
            ORDER BY c.id asc;";
                    using var cmd = new NpgsqlCommand(queryifidnull, conn);
                    using var adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView_report.DataSource = dt;
                }
                else
                {
                    string queryifidnotnull = @"
            SELECT 
                c.id,
                c.first_name ||' '|| c.last_name AS ""Клиент"",
                o.id AS ""Номер заказа"",
                o.pickup_date AS ""Дата приёма"",
                STRING_AGG(s.name, ', ') AS ""Услуги""
            FROM public.""Client"" c
            JOIN public.""Order"" o ON c.id = o.""id_client""
            JOIN public.""Service_record"" sr ON o.id = sr.""id_order""
            JOIN public.""Service"" s ON s.id = sr.""id_service""
            WHERE c.id = @id
            GROUP BY c.id, c.first_name, c.last_name, o.id, o.pickup_date       
            ORDER BY c.id asc;";
                    using var cmd = new NpgsqlCommand(queryifidnotnull, conn);
                    using var adapter = new NpgsqlDataAdapter(cmd);

                    cmd.Parameters.AddWithValue("@id", id);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView_report.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }
        }

        private void WriteReportBtn_order_Click(object sender, EventArgs e)
        {

        }
        /// Кнопки добавления
        /// 


        ///
        /// Кнопки редактирования
        private void edit_client_Click(object sender, EventArgs e)
            => SaveData(datagrid_client, "Client");

        private void edit_order_Click(object sender, EventArgs e)
            => SaveData(dataGrid_order, "Order");

        private void updateStatusButton_Click(object sender, EventArgs e)
        {
            if (dataGrid_order.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите заказ из таблицы");
                return;
            }

            DataGridViewRow selectedRow = dataGrid_order.SelectedRows[0];

            if (selectedRow.Cells["id"].Value != DBNull.Value)
            {
                int orderId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                // 4. Создаем и показываем форму для ввода даты
                using var UpdStatus = new updateStatusOrder(orderId);
                if (UpdStatus.ShowDialog() == DialogResult.OK)
                {
                    // 6. Обновляем данные после сохранения
                    LoadData(dataGrid_order, "Order");
                }
                else
                {
                    MessageBox.Show("Идентификатор заказа не найден");
                }
            }
        }
        //=> AddData.ShowFormAndReload<updateStatusOrder>(() => LoadData(dataGrid_order, "Order"));

        private void edit_product_Click(object sender, EventArgs e) // Над вещами надо поработать
            => SaveData(dataGrid_product, "Product");

        private void edit_service_Click(object sender, EventArgs e)
            => SaveData(dataGrid_service, "Service");

        private void edit_employee_Click(object sender, EventArgs e)
            => SaveData(dataGrid_employee, "Employee");

        private void updateDateIssueButton_Click(object sender, EventArgs e)
        {
            if (dataGrid_order.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите заказ из списка");
                return;
            }

            DataGridViewRow selectedRow = dataGrid_order.SelectedRows[0];

            if (selectedRow.Cells["id"].Value != DBNull.Value)
            {
                int orderId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                // 4. Создаем и показываем форму для ввода даты
                using var dateForm = new DeliveryDateForm(orderId);
                if (dateForm.ShowDialog() == DialogResult.OK)
                {
                    // 6. Обновляем данные после сохранения
                    LoadData(dataGrid_order, "Order");
                }
                else
                {
                    MessageBox.Show("Идентификатор заказа не найден");
                }
            }
        }

        private void DelBtn_product_Click(object sender, EventArgs e) // Запрос на удаление. 
        {
            using var conn = new NpgsqlConnection(connectionString);
            conn.Open();
            string cmd = (@"DELETE FROM public.""Product"" WHERE id = @id;");

            if (dataGrid_product.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите вещь из таблицы");
                return;
            }

            DataGridViewRow selectedRow = dataGrid_product.SelectedRows[0];

            if (selectedRow.Cells["id"].Value != DBNull.Value)
            {
                int productId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                using NpgsqlCommand update_command = new(cmd, conn);
                update_command.Parameters.AddWithValue("@id", productId);
                try
                {
                    update_command.ExecuteNonQuery();
                    LoadData(dataGrid_product, "Product");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}");
                }
            }

        }

        private void SelBtn_client_Click(object sender, EventArgs e) // Запрос на выборку последних 15 записей. 
        {
            using NpgsqlConnection conn = new(connectionString);
            conn.Open();
            string cmd = (@"SELECT * FROM public.""Client""
                            ORDER BY id DESC LIMIT 15");

            using var adapter = new NpgsqlDataAdapter(cmd, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            datagrid_client.DataSource = dt;
        }

        private void SelBtnF10_client_Click(object sender, EventArgs e) // Запрос на выборку первых 10 записей
        {
            using NpgsqlConnection conn = new(connectionString);
            conn.Open();
            string cmd = (@"SELECT * FROM public.""Client""
                            ORDER BY id ASC LIMIT 10");

            using var adapter = new NpgsqlDataAdapter(cmd, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            datagrid_client.DataSource = dt;
        }

        private void SelBtnWithoutRepeat_client_Click(object sender, EventArgs e) // Запрос на выборку данных без повторений
        {
            using NpgsqlConnection conn = new(connectionString);
            conn.Open();
            string cmd = (@"SELECT DISTINCT on(first_name) id as ""Идентификатор"", first_name as ""Имя"", last_name as ""Фамилия"", phone_number as ""Номер телефона"", email as ""Почта"", address as ""Адрес"" FROM public.""Client"" 
                            ORDER BY first_name ASC");

            using var adapter = new NpgsqlDataAdapter(cmd, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            datagrid_client.DataSource = dt;
        }

        private void SelBtnAll_client_Click(object sender, EventArgs e) // Запрос на полную выборку данных. 
        {
            using NpgsqlConnection conn = new(connectionString);
            conn.Open();
            string cmd = (@"SELECT * FROM public.""Client""");

            using var adapter = new NpgsqlDataAdapter(cmd, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            datagrid_client.DataSource = dt;
        }

        private void MaxBtn_service_Click(object sender, EventArgs e) // Запрос MAX
        {
            using NpgsqlConnection conn = new(connectionString);
            conn.Open();
            string cmd = (@"SELECT name as ""Название услуги"", cost_per_count as ""Стоимость услуги"" from public.""Service"" 
                            where cost_per_count = (select max(cost_per_count) from public.""Service"")");

            using var adapter = new NpgsqlDataAdapter(cmd, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            dataGrid_service.DataSource = dt;
        }

        private void MinBtn_service_Click(object sender, EventArgs e) // Запрос MIN
        {
            using NpgsqlConnection conn = new(connectionString);
            conn.Open();
            string cmd = (@"SELECT name as ""Название услуги"", cost_per_count as ""Стоимость услуги"" from public.""Service"" 
                            where cost_per_count = (select min(cost_per_count) from public.""Service"")");

            using var adapter = new NpgsqlDataAdapter(cmd, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            dataGrid_service.DataSource = dt;
        }

        private void AvgBtn_service_Click(object sender, EventArgs e) // Запрос AVG
        {
            using NpgsqlConnection conn = new(connectionString);
            conn.Open();
            string cmd = (@"SELECT avg(cost_per_count)::numeric(10, 2) as ""Средняя цена"" from public.""Service""");

            using var adapter = new NpgsqlDataAdapter(cmd, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            dataGrid_service.DataSource = dt;
        }

        private void ComBtnMore_order_Click(object sender, EventArgs e) // Запросы на возвращение значения по условиям больше, меньше и между
        {
            int cost = (int)numericMore.Value;

            using NpgsqlConnection conn = new(connectionString);
            conn.Open();
            string cmd = ($"SELECT * from public.\"Order\" where total_cost > {cost}");
            using var adapter = new NpgsqlDataAdapter(cmd, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            dataGrid_order.DataSource = dt;
        }

        private void ComBtnLess_order_Click(object sender, EventArgs e)
        {
            int cost = (int)numericLess.Value;

            using NpgsqlConnection conn = new(connectionString);
            conn.Open();
            string cmd = ($"SELECT * from public.\"Order\" where total_cost < {cost}");
            using var adapter = new NpgsqlDataAdapter(cmd, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            dataGrid_order.DataSource = dt;
        }

        private void ComBtnBetween_order_Click(object sender, EventArgs e)
        {
            int frst = (int)numericBetweenFrst.Value;
            int scnd = (int)numericBetweenScnd.Value;
            using NpgsqlConnection conn = new(connectionString);
            conn.Open();
            string cmd = ($"SELECT * from public.\"Order\" where total_cost between {frst} and {scnd}");
            using var adapter = new NpgsqlDataAdapter(cmd, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            dataGrid_order.DataSource = dt;
        }

        private void SelLikeBtn_client_Click(object sender, EventArgs e) // Запросы с оператором LIKE
        {
            string mail = textBox1.Text;
            using NpgsqlConnection conn = new(connectionString);
            conn.Open();
            string cmd = ($"SELECT * from public.\"Client\" where email like '%{mail}%';");
            using var adapter = new NpgsqlDataAdapter(cmd, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            datagrid_client.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e) //  Запрос с NOT NULL
        {
            using NpgsqlConnection conn = new(connectionString);
            conn.Open();
            string cmd = ($"SELECT * from public.\"Client\" where email is NOT NULL;");
            using var adapter = new NpgsqlDataAdapter(cmd, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            datagrid_client.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e) // Запросы с сортировкой
        {
            using NpgsqlConnection conn = new(connectionString);
            conn.Open();
            string cmd = ($"SELECT * FROM \"Employee\" WHERE role = 'Оператор химчистки' ORDER BY last_name asc;");
            using var adapter = new NpgsqlDataAdapter(cmd, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            dataGrid_employee.DataSource = dt;
        }

        private void SelStatusOrderCountBtn_order_Click(object sender, EventArgs e) // Запрос с групповыми операциями
        {
            using NpgsqlConnection conn = new(connectionString);
            conn.Open();
            string cmd = ($"SELECT status, COUNT(*) as order_count FROM \"Order\" GROUP BY status;");
            using var adapter = new NpgsqlDataAdapter(cmd, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            dataGrid_order.DataSource = dt;
        }

        private void SelExepctBtn_service_Click(object sender, EventArgs e) // Запрос с операциями над множествами
        {
            using NpgsqlConnection conn = new(connectionString);
            conn.Open();
            string cmd = ($"SELECT id FROM \"Service\" EXCEPT SELECT DISTINCT id_service FROM \"Service_record\" ORDER BY id;");
            using var adapter = new NpgsqlDataAdapter(cmd, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            dataGrid_service.DataSource = dt;
        }

        private void SelBirthDateBtn_employee_Click(object sender, EventArgs e)
        {
            using NpgsqlConnection conn = new(connectionString);
            conn.Open();
            string cmd = (@"SELECT 
    CONCAT(last_name, ' ', LEFT(first_name, 1), '.') AS ""Фамилия И."",
    EXTRACT(YEAR FROM AGE(CURRENT_DATE + INTERVAL '1 month', birth_date))::int AS ""Возраст"",
    TO_CHAR(birth_date, 'DD.MM.YYYY') AS ""Дата рождения"",
    TO_CHAR(birth_date + (EXTRACT(YEAR FROM AGE(CURRENT_DATE + INTERVAL '1 month', birth_date)) + 1) * INTERVAL '1 year', 'DD.MM.YYYY') AS ""Дата юбилея""
FROM ""Employee""
WHERE 
    -- Проверяем, что день и месяц рождения совпадают с следующим месяцем
    EXTRACT(MONTH FROM birth_date) = EXTRACT(MONTH FROM CURRENT_DATE + INTERVAL '1 month')
    AND 
    -- Проверяем, что возраст кратен 5 (юбилей)
    EXTRACT(YEAR FROM AGE(CURRENT_DATE + INTERVAL '1 month', birth_date))::int % 5 = 0
ORDER BY 
    EXTRACT(DAY FROM birth_date), last_name;");
            using var adapter = new NpgsqlDataAdapter(cmd, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            dataGrid_employee.DataSource = dt;
        }

        /// Кнопки редактирования
        /// 
    }
}