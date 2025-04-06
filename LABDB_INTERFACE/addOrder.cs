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
    public partial class addOrder : Form
    {
        public addOrder()
        {
            InitializeComponent();
        }

        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=44961755;Database=db1.2;";
        private void AddOrder(int id_client, string pickupDate, string status, string totalCost, string date_apppr)
        {
            using NpgsqlConnection conn = new(connectionString);
            try
            {
                conn.Open();
                string query = @"
                INSERT INTO public.""Order"" 
                    (id_Client, pickup_date, status, total_cost, date_appr_readliness) 
                VALUES 
                    (@id_client, @typecloath, @color, @email, @address)";

                using NpgsqlCommand cmd = new(query, conn);

                decimal? phoneNumber = null;
                if (!string.IsNullOrWhiteSpace(phone))
                {
                    // Удаляем все нецифровые символы
                    string cleanPhone = new(phone.Where(char.IsDigit).ToArray());

                    if (decimal.TryParse(cleanPhone, out decimal parsedPhone))
                    {
                        phoneNumber = parsedPhone;
                    }
                    else
                    {
                        MessageBox.Show("Некорректный формат номера телефона!");
                        return;
                    }
                }

                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@phone", phoneNumber ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@email", email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@address", address ?? (object)DBNull.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Клиент добавлен успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении клиента: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void addButton_order_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_firstname.Text) ||
                string.IsNullOrWhiteSpace(textBox_lastname.Text))
            {
                MessageBox.Show("Имя и фамилия обязательны для заполнения!");
                return;
            }
            // Собираем данные с формы
            string firstName = textBox_firstname.Text;
            string lastName = textBox_lastname.Text;
            string phone = maskedTextBox_phone.Text;
            string email = maskedTextBox_email.Text;
            string address = textBox_address.Text;

            // Добавляем клиента в базу данных
            AddOrder(firstName, lastName, phone, email, address);

            // Закрываем форму после сохранения
            this.Close();
        }
    }
}
