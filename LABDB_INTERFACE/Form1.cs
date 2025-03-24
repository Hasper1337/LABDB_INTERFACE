using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace LABDB_INTERFACE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=44961755;Database=db1.2;";

        private void Form1_Load(object sender, EventArgs e)
        {
            using NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Подключение к базе данных успешно");
                LoadClients();
                LoadOrders();
                LoadProduct();
                LoadService();
                LoadEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключеия к базе данных: " + ex.Message);
            }
        }

        private void LoadClients()
        {
            string query = "SELECT * FROM public.\"Client\";";

            using NpgsqlConnection connection = new(connectionString);
            using NpgsqlDataAdapter adapter = new(query, connection);
            DataTable dataTable = new();
            adapter.Fill(dataTable);

            datagrid_client.DataSource = dataTable;
        }

        private void LoadOrders()
        {
            string query = "SELECT * FROM public.\"Order\";";

            using NpgsqlConnection connection = new(connectionString);
            using NpgsqlDataAdapter adapter = new(query, connection);
            DataTable dataTable = new();
            adapter.Fill(dataTable);

            dataGrid_order.DataSource = dataTable;
        }

        private void LoadProduct()
        {
            string query = "SELECT * FROM public.\"Product\";";

            using NpgsqlConnection connection = new(connectionString);
            using NpgsqlDataAdapter adapter = new(query, connection);
            DataTable dataTable = new();
            adapter.Fill(dataTable);

            dataGrid_product.DataSource = dataTable;
        }

        private void LoadService()
        {
            string query = "SELECT * FROM public.\"Service\";";

            using NpgsqlConnection connection = new(connectionString);
            using NpgsqlDataAdapter adapter = new(query, connection);
            DataTable dataTable = new();
            adapter.Fill(dataTable);

            dataGrid_service.DataSource = dataTable;
        }

        private void LoadEmployee()
        {
            string query = "SELECT * FROM public.\"Employee\";";

            using NpgsqlConnection connection = new(connectionString);
            using NpgsqlDataAdapter adapter = new(query, connection);
            DataTable dataTable = new();
            adapter.Fill(dataTable);

            dataGrid_employee.DataSource = dataTable;
        }

        private void Service_Click(object sender, EventArgs e)
        {

        }

        private void datagrid_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_client_Click(object sender, EventArgs e)
        {
            addClient AddClientForm = new();
            AddClientForm.ShowDialog();
            LoadClients();
        }

        private void add_order_Click(object sender, EventArgs e)
        {
            addOrder AddOrderForm = new();
            AddOrderForm.ShowDialog();
            LoadOrders();
        }
    }
}
