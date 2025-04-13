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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LABDB_INTERFACE
{
    public partial class DeliveryDateForm : Form
    {
        private readonly int _orderId;

        public DateTime DeliveryDate { get; private set; }

        public DeliveryDateForm(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
            lblOrderId.Text = $"Номер заказа: {_orderId}";
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (datePicker.Value >= DateTime.Now)
            {
                DeliveryDate = datePicker.Value;

                // Сохраняем в базу данных
                using (var connection = new NpgsqlConnection("Host = localhost; Port = 5432; Username = postgres; Password = 44961755; Database = db1.2;"))
                {
                    connection.Open();
                    var cmd = new NpgsqlCommand(
                        @"UPDATE public.""Order"" 
                            SET date_appr_readiness = @date 
                            WHERE id = @id",
                        connection);

                    cmd.Parameters.AddWithValue("@date", DeliveryDate);
                    cmd.Parameters.AddWithValue("@id", _orderId);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка сохранения: {ex.Message}");
                        DialogResult = DialogResult.None; // Отмена закрытия формы
                    }
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Дата доставки не может быть в прошлом");
            }
        }
    }
}
