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

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=labdb;Port=5432;Database=laba;User Id=postgres;";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Подключение к базе данных успешно");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключеия к базе данных: " + ex.Message);
                }
            }
        }

        private void Service_Click(object sender, EventArgs e)
        {

        }

        private void datagrid_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
