using System;
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
    public partial class addService : Form
    {
        public addService()
        {
            InitializeComponent();
        }

        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=44961755;Database=db1.2;";

        private void AddService(string firstName, string description, Int16 price)
        {
            using NpgsqlConnection conn = new(connectionString);
            try
            {
                conn.Open();
                string query = @"
                INSERT INTO public.""Service"" 
                    (name, description, cost_per_count) 
                VALUES 
                    (@name, @description, @cost_per_count)";

                using NpgsqlCommand cmd = new(query, conn);

                cmd.Parameters.AddWithValue("@name", firstName);
                cmd.Parameters.AddWithValue("@description", description ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@cost_per_count", price);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Услуга добавлена успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении услуги: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void addButton_service_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_firstname.Text) ||
                string.IsNullOrWhiteSpace(numericUpDown_price.Text))
            {
                MessageBox.Show("Название услуги и стоимость обязательны для заполнения!");
                return;
            }
            // Собираем данные с формы
            string firstName = textBox_firstname.Text;
            string description = textBox_description.Text;
            Int16 price = (short)numericUpDown_price.Value;

            // Добавляем клиента в базу данных
            AddService(firstName, description, price);

            // Закрываем форму после сохранения
            this.Close();
        }
    }
}
