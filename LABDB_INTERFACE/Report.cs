using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace LABDB_INTERFACE
{
    public partial class Report : Form
    {
        //private readonly ReportGenerator _reportGenerator;
        public string SelectedReportType { get; private set; } = string.Empty;
        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=44961755;Database=db1.2;";
        public enum ReportType { Employees, Orders, Clients }
        public Report(string connectionString)
        {
            InitializeComponent();
            //SetupButtons();
            //_reportGenerator = new ReportGenerator(connectionString);
        }

        //private DataTable GenerateReport(ReportType reportType)
        //{
        //    string query = reportType switch
        //    {
        //        ReportType.Employees => GetEmployeeQuery(),
        //        ReportType.Orders => GetOrderQuery(),
        //        ReportType.Clients => GetClientQuery(),
        //        _ => throw new ArgumentException("Неизвестный тип отчета")
        //    };

        //    try
        //    {
        //        using var conn = new NpgsqlConnection(_connectionString);
        //        conn.Open();

        //        using var cmd = new NpgsqlCommand(query, conn);
        //        using var adapter = new NpgsqlDataAdapter(cmd);

        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Ошибка: {ex.Message}");
        //        return null;
        //    }
        //}

        private string GetEmployeeQuery() => @"
            SELECT 
                e.id,
                e.fist_name ||' '|| e.last_name AS ""Сотрудник"",
                o.id AS ""Номер заказа""
                o.pickup_date AS ""Дата приёма"",
                p.type_product AS ""Изделие"",
            FROM public.""Employee"" e
            JOIN public.""Service_record"" sr ON e.id = sr.""id_employee""
            JOIN public.""Order"" o ON o.id = sr.""id_order""
            JOIN public.""Product"" p ON o.id = p.""id_order""
            WHERE e.id = @employeeID
            ORDER BY e.id asc;";

        private void EmployeeReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = new NpgsqlConnection(connectionString);
                conn.Open();

                string query = @"
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
            WHERE e.id = 2
            ORDER BY e.id asc;";

                using var cmd = new NpgsqlCommand(query, conn);
                using var adapter = new NpgsqlDataAdapter(cmd);



                DataTable dt = new DataTable();
                adapter.Fill(dt);

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ошибка" + ex);
            }


            this.Close();
        }

        private void OrdersReportBtn_Click(object sender, EventArgs e)
        {

        }

        private void ClientsReportBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
