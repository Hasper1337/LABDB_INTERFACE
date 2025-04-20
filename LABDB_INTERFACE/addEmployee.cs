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
    public partial class addEmployee : Form
    {
        public addEmployee()
        {
            InitializeComponent();
        }

        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=44961755;Database=db1.2;";

        private void AddEmployee(string firstName, string lastName, string role, string phone_number, string passport_data)
        {
            using NpgsqlConnection conn = new(connectionString);
            try
            {
                conn.Open();
                string query = @"
                INSERT INTO public.""Employee"" 
                    (first_name, last_name, role, phone_number, passport_data, birth_date) 
                VALUES 
                    (@firstName, @lastName, @role, @phone_number, @passport_data, @birth_date)";

                using NpgsqlCommand cmd = new(query, conn);

                decimal? phoneNumber = null;
                if (!string.IsNullOrWhiteSpace(phone_number))
                {
                    // Удаляем все нецифровые символы
                    string cleanPhone = new(phone_number.Where(char.IsDigit).ToArray());

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

                decimal? passportData = null;
                if (!string.IsNullOrWhiteSpace(passport_data))
                {
                    // Удаляем все нецифровые символы
                    string cleanData = new(passport_data.Where(char.IsDigit).ToArray());

                    if (decimal.TryParse(cleanData, out decimal parsedData))
                    {
                        passportData = parsedData;
                    }
                    else
                    {
                        MessageBox.Show("Некорректный формат паспортных данных!");
                        return;
                    }
                }

                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@phone_number", phoneNumber);
                cmd.Parameters.AddWithValue("@passport_data", passportData);
                cmd.Parameters.AddWithValue("@birth_date", dateTimePicker1.Value);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Сотрудник добавлен успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении сотрудника: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void label_address_Click(object sender, EventArgs e)
        {

        }

        private void addButton_employee_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_firstname.Text) ||
                string.IsNullOrWhiteSpace(textBox_lastname.Text) ||
                string.IsNullOrWhiteSpace(textBox_role.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBox_phone.Text) ||
                string.IsNullOrWhiteSpace(maskedTextBox_passportdata.Text))
            {
                MessageBox.Show("Все поля обязательны для заполнения!");
                return;
            }
            // Собираем данные с формы
            string firstName = textBox_firstname.Text;
            string lastName = textBox_lastname.Text;
            string role = textBox_role.Text;
            string phoneNumber = maskedTextBox_phone.Text;
            string passportData = maskedTextBox_passportdata.Text;

            // Добавляем клиента в базу данных
            AddEmployee(firstName, lastName, role, phoneNumber, passportData);

            // Закрываем форму после сохранения
            this.Close();
        }
    }
}
