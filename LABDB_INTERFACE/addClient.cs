using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LABDB_INTERFACE
{
    public partial class addClient : Form
    {
        public addClient()
        {
            InitializeComponent();
        }

        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=44961755;Database=db1.2;";
        private void AddClient(string firstName, string lastName, string phone, string email, string address)
        {
            using NpgsqlConnection conn = new(connectionString);
            try
            {
                conn.Open();
                string query = @"
                INSERT INTO public.""Client"" 
                    (first_name, last_name, phone_number, email, address) 
                VALUES 
                    (@firstName, @lastName, @phone, @email, @address)";

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

        private void addButton_client_Click(object sender, EventArgs e)
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
            AddClient(firstName, lastName, phone, email, address);

            // Закрываем форму после сохранения
            this.Close();
        }

        private void label_lastname_Click(object sender, EventArgs e)
        {

        }

        private void addClient_Load(object sender, EventArgs e)
        {

        }
    }
}