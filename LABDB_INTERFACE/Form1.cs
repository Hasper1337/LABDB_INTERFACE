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
using System.Windows.Forms;
using Npgsql;

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


        //public static class AddData
        //{
        //    public static void ShowFormAndReload<TForm>(Action reloadAction)
        //        where TForm : Form, new()
        //    {
        //        using (TForm form = new())
        //        {
        //            form.ShowDialog();
        //        }
        //        reloadAction?.Invoke();
        //    }
        //}


        //public class DataManager(string connectionString) //����� ���������� � ����������
        //{
        //    private readonly string _connectionString = connectionString;

        //    public void Fill(DataGridView grid, string tableName)
        //    {
        //        using var connection = new NpgsqlConnection(_connectionString);
        //        using var adapter = new NpgsqlDataAdapter($"SELECT * FROM {tableName}", connection);
        //        var dt = new DataTable();
        //        adapter.Fill(dt);
        //        grid.DataSource = dt;
        //    }

        //    public void Save(DataGridView grid, string tableName)
        //    {
        //        try
        //        {
        //            if (grid.InvokeRequired || grid.DataSource is not DataTable dt) return;

        //            using var connection = new NpgsqlConnection(connectionString);
        //            connection.Open();

        //            using var adapter = new NpgsqlDataAdapter($"SELECT * FROM {tableName}", connection);
        //            new NpgsqlCommandBuilder(adapter);
        //            adapter.Update(dt);
        //            dt.AcceptChanges();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new ApplicationException($"������ ���������� ������ ��� ������� {tableName}", ex);
        //        }
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            using NpgsqlConnection connection = new(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("����������� � ���� ������ �������");

                LoadData(datagrid_client, "Client");
                LoadData(dataGrid_order, "Order");
                LoadData(dataGrid_product, "Product");
                LoadData(dataGrid_service, "Service");
                LoadData(dataGrid_employee, "Employee");
            }
            catch (Exception ex)
            {
                MessageBox.Show("������ ����������: " + ex.Message);
            }
        }

        ///
        /// ������
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

        public class DataManager(string connectionString) //����� ���������� � ����������
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
                //try
                //{
                //    if (grid.InvokeRequired || grid.DataSource is not DataTable dt) return;

                //    using var connection = new NpgsqlConnection(connectionString);
                //    connection.Open();

                //    using var adapter = new NpgsqlDataAdapter($"SELECT * FROM {tableName}", connection);
                //    new NpgsqlCommandBuilder(adapter);
                //    adapter.Update(dt);
                //    dt.AcceptChanges();
                //}
                //catch (Exception ex)
                //{
                //    throw new ApplicationException($"������ ���������� ������ ��� ������� {tableName}", ex);
                //}


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

                        MessageBox.Show("������ ������� ���������");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"������: {ex.Message}");
                        dt.RejectChanges(); // ���������� ��������� ��� ������
                    }
                }
            }
        }
        /// ������
        ///


        ///
        /// ������� �������
        private void LoadData(DataGridView grid, string tableName)
            => _dataManager.Fill(grid, $"{Schema}.\"{tableName}\"");

        private void SaveData(DataGridView grid, string tableName)
            => _dataManager.Save(grid, $"{Schema}.\"{tableName}\"");
        /// ������� �������
        ///


        ///
        /// ������ ����������
        private void add_client_Click(object sender, EventArgs e)
            => AddData.ShowFormAndReload<addClient>(() => LoadData(datagrid_client, "Client"));

        private void add_order_Click(object sender, EventArgs e)
            => AddData.ShowFormAndReload<addOrder>(() => LoadData(dataGrid_order, "Order"));

        private void add_employee_Click(object sender, EventArgs e)
            => AddData.ShowFormAndReload<addEmployee>(() => LoadData(dataGrid_employee, "Employee"));

        private void add_service_Click(object sender, EventArgs e)
            => AddData.ShowFormAndReload<addService>(() => LoadData(dataGrid_service, "Service"));
        /// ������ ����������
        /// 


        ///
        /// ������ ��������������
        private void edit_client_Click(object sender, EventArgs e)
            => SaveData(datagrid_client, "Client");

        private void edit_order_Click(object sender, EventArgs e)
            => SaveData(dataGrid_order, "Order");

        private void updateStatusButton_Click(object sender, EventArgs e)
        {
            if (dataGrid_order.SelectedRows.Count == 0)
            {
                MessageBox.Show("����������, �������� ����� �� ������");
                return;
            }

            DataGridViewRow selectedRow = dataGrid_order.SelectedRows[0];

            if (selectedRow.Cells["id"].Value != DBNull.Value)
            {
                int orderId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                // 4. ������� � ���������� ����� ��� ����� ����
                using var UpdStatus = new updateStatusOrder(orderId);
                if (UpdStatus.ShowDialog() == DialogResult.OK)
                {
                    // 6. ��������� ������ ����� ����������
                    LoadData(dataGrid_order, "Order");
                }
                else
                {
                    MessageBox.Show("������������� ������ �� ������");
                }
            }
        }
            //=> AddData.ShowFormAndReload<updateStatusOrder>(() => LoadData(dataGrid_order, "Order"));

        private void edit_product_Click(object sender, EventArgs e) // ��� ������ ���� ����������
            => SaveData(dataGrid_product, "Product");

        private void edit_service_Click(object sender, EventArgs e)
            => SaveData(dataGrid_service, "Service");

        private void edit_employee_Click(object sender, EventArgs e)
            => SaveData(dataGrid_employee, "Employee");

        private void updateDateIssueButton_Click(object sender, EventArgs e)
        {
            if (dataGrid_order.SelectedRows.Count == 0)
            {
                MessageBox.Show("����������, �������� ����� �� ������");
                return;
            }

            DataGridViewRow selectedRow = dataGrid_order.SelectedRows[0];
            
            if (selectedRow.Cells["id"].Value != DBNull.Value)
            {
                int orderId = Convert.ToInt32(selectedRow.Cells["id"].Value);

                // 4. ������� � ���������� ����� ��� ����� ����
                using var dateForm = new DeliveryDateForm(orderId);
                if (dateForm.ShowDialog() == DialogResult.OK)
                {
                    // 6. ��������� ������ ����� ����������
                    LoadData(dataGrid_order, "Order");
                }
                else
                {
                    MessageBox.Show("������������� ������ �� ������");
                }
            }
        }
        /// ������ ��������������
        /// 
    }
}