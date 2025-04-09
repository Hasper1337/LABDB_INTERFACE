﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LABDB_INTERFACE
{
    public partial class updateStatusOrder : Form
    {
        public updateStatusOrder()
        {
            InitializeComponent();
        }

        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=44961755;Database=db1.2;";
        private void updateButton_Click(object sender, EventArgs e)
        {
            using var conn = new NpgsqlConnection(connectionString);
            conn.Open();
            string cmd = (@"UPDATE public.""Order"" SET status = @status WHERE id = @id");

            using NpgsqlCommand update_command = new(cmd, conn);

            update_command.Parameters.AddWithValue("@status", comboBox_status.SelectedItem.ToString());
            update_command.Parameters.AddWithValue("@id", (int)numericUpDown_idOrder.Value);

            update_command.ExecuteNonQuery();
            this.Close();
        }
    }
}
