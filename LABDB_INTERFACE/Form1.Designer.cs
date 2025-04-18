﻿namespace LABDB_INTERFACE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            datagrid_client = new DataGridView();
            tabControl1 = new TabControl();
            Clients = new TabPage();
            edit_client = new Button();
            add_client = new Button();
            Orders = new TabPage();
            groupBox1 = new GroupBox();
            updateDateIssueButton = new Button();
            updateStatusButton = new Button();
            edit_order = new Button();
            add_order = new Button();
            dataGrid_order = new DataGridView();
            Product = new TabPage();
            edit_product = new Button();
            dataGrid_product = new DataGridView();
            Service = new TabPage();
            edit_service = new Button();
            add_service = new Button();
            dataGrid_service = new DataGridView();
            Employee = new TabPage();
            edit_employee = new Button();
            add_employee = new Button();
            dataGrid_employee = new DataGridView();
            Report = new TabPage();
            numericUpDown_order = new NumericUpDown();
            numericUpDown_client = new NumericUpDown();
            numericUpDown_employee = new NumericUpDown();
            WriteReportBtn_order = new Button();
            WriteReportBtn_client = new Button();
            WriteReportBtn = new Button();
            dataGridView_report = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)datagrid_client).BeginInit();
            tabControl1.SuspendLayout();
            Clients.SuspendLayout();
            Orders.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_order).BeginInit();
            Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_product).BeginInit();
            Service.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_service).BeginInit();
            Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_employee).BeginInit();
            Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_order).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_client).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_employee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_report).BeginInit();
            SuspendLayout();
            // 
            // datagrid_client
            // 
            datagrid_client.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid_client.Dock = DockStyle.Left;
            datagrid_client.Location = new Point(3, 2);
            datagrid_client.Margin = new Padding(3, 2, 3, 2);
            datagrid_client.Name = "datagrid_client";
            datagrid_client.RowHeadersWidth = 51;
            datagrid_client.Size = new Size(759, 333);
            datagrid_client.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(Clients);
            tabControl1.Controls.Add(Orders);
            tabControl1.Controls.Add(Product);
            tabControl1.Controls.Add(Service);
            tabControl1.Controls.Add(Employee);
            tabControl1.Controls.Add(Report);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1117, 365);
            tabControl1.TabIndex = 1;
            // 
            // Clients
            // 
            Clients.Controls.Add(edit_client);
            Clients.Controls.Add(add_client);
            Clients.Controls.Add(datagrid_client);
            Clients.Location = new Point(4, 24);
            Clients.Margin = new Padding(3, 2, 3, 2);
            Clients.Name = "Clients";
            Clients.Padding = new Padding(3, 2, 3, 2);
            Clients.Size = new Size(1109, 337);
            Clients.TabIndex = 0;
            Clients.Text = "Клиенты";
            Clients.UseVisualStyleBackColor = true;
            // 
            // edit_client
            // 
            edit_client.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edit_client.Cursor = Cursors.Hand;
            edit_client.Location = new Point(784, 85);
            edit_client.Margin = new Padding(3, 2, 3, 2);
            edit_client.Name = "edit_client";
            edit_client.Size = new Size(279, 46);
            edit_client.TabIndex = 2;
            edit_client.Text = "Редактирование данных";
            edit_client.UseVisualStyleBackColor = true;
            edit_client.Click += edit_client_Click;
            // 
            // add_client
            // 
            add_client.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            add_client.Cursor = Cursors.Hand;
            add_client.Location = new Point(784, 12);
            add_client.Margin = new Padding(3, 2, 3, 2);
            add_client.Name = "add_client";
            add_client.Size = new Size(279, 46);
            add_client.TabIndex = 1;
            add_client.Text = "Добавить клиента";
            add_client.UseVisualStyleBackColor = true;
            add_client.Click += add_client_Click;
            // 
            // Orders
            // 
            Orders.Controls.Add(groupBox1);
            Orders.Controls.Add(edit_order);
            Orders.Controls.Add(add_order);
            Orders.Controls.Add(dataGrid_order);
            Orders.Location = new Point(4, 24);
            Orders.Margin = new Padding(3, 2, 3, 2);
            Orders.Name = "Orders";
            Orders.Padding = new Padding(3, 2, 3, 2);
            Orders.Size = new Size(1109, 337);
            Orders.TabIndex = 1;
            Orders.Text = "Заказы";
            Orders.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(updateDateIssueButton);
            groupBox1.Controls.Add(updateStatusButton);
            groupBox1.Location = new Point(788, 186);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 123);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Обновление данных";
            // 
            // updateDateIssueButton
            // 
            updateDateIssueButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            updateDateIssueButton.Cursor = Cursors.Hand;
            updateDateIssueButton.Location = new Point(49, 64);
            updateDateIssueButton.Margin = new Padding(3, 2, 3, 2);
            updateDateIssueButton.Name = "updateDateIssueButton";
            updateDateIssueButton.Size = new Size(174, 45);
            updateDateIssueButton.TabIndex = 8;
            updateDateIssueButton.Text = "Указать дату выдачи\r\n(статус - выданно)";
            updateDateIssueButton.UseVisualStyleBackColor = true;
            updateDateIssueButton.Click += updateDateIssueButton_Click;
            // 
            // updateStatusButton
            // 
            updateStatusButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            updateStatusButton.Cursor = Cursors.Hand;
            updateStatusButton.Location = new Point(49, 21);
            updateStatusButton.Margin = new Padding(3, 2, 3, 2);
            updateStatusButton.Name = "updateStatusButton";
            updateStatusButton.Size = new Size(174, 29);
            updateStatusButton.TabIndex = 7;
            updateStatusButton.Text = "Обновить статус заказа";
            updateStatusButton.UseVisualStyleBackColor = true;
            updateStatusButton.Click += updateStatusButton_Click;
            // 
            // edit_order
            // 
            edit_order.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edit_order.Cursor = Cursors.Hand;
            edit_order.Location = new Point(788, 82);
            edit_order.Margin = new Padding(3, 2, 3, 2);
            edit_order.Name = "edit_order";
            edit_order.Size = new Size(279, 46);
            edit_order.TabIndex = 5;
            edit_order.Text = "Редактирование данных";
            edit_order.UseVisualStyleBackColor = true;
            edit_order.Click += edit_order_Click;
            // 
            // add_order
            // 
            add_order.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            add_order.Cursor = Cursors.Hand;
            add_order.Location = new Point(788, 13);
            add_order.Margin = new Padding(3, 2, 3, 2);
            add_order.Name = "add_order";
            add_order.Size = new Size(279, 46);
            add_order.TabIndex = 4;
            add_order.Text = "Добавить заказ";
            add_order.UseVisualStyleBackColor = true;
            add_order.Click += add_order_Click;
            // 
            // dataGrid_order
            // 
            dataGrid_order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_order.Dock = DockStyle.Left;
            dataGrid_order.Location = new Point(3, 2);
            dataGrid_order.Margin = new Padding(3, 2, 3, 2);
            dataGrid_order.Name = "dataGrid_order";
            dataGrid_order.RowHeadersWidth = 51;
            dataGrid_order.Size = new Size(759, 333);
            dataGrid_order.TabIndex = 3;
            // 
            // Product
            // 
            Product.Controls.Add(edit_product);
            Product.Controls.Add(dataGrid_product);
            Product.Location = new Point(4, 24);
            Product.Margin = new Padding(3, 2, 3, 2);
            Product.Name = "Product";
            Product.Size = new Size(1109, 337);
            Product.TabIndex = 2;
            Product.Text = "Вещи";
            Product.UseVisualStyleBackColor = true;
            // 
            // edit_product
            // 
            edit_product.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edit_product.Cursor = Cursors.Hand;
            edit_product.Location = new Point(788, 13);
            edit_product.Margin = new Padding(3, 2, 3, 2);
            edit_product.Name = "edit_product";
            edit_product.Size = new Size(279, 46);
            edit_product.TabIndex = 5;
            edit_product.Text = "Редактирование данных";
            edit_product.UseVisualStyleBackColor = true;
            edit_product.Click += edit_product_Click;
            // 
            // dataGrid_product
            // 
            dataGrid_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_product.Dock = DockStyle.Left;
            dataGrid_product.Location = new Point(0, 0);
            dataGrid_product.Margin = new Padding(3, 2, 3, 2);
            dataGrid_product.Name = "dataGrid_product";
            dataGrid_product.RowHeadersWidth = 51;
            dataGrid_product.Size = new Size(759, 337);
            dataGrid_product.TabIndex = 3;
            // 
            // Service
            // 
            Service.Controls.Add(edit_service);
            Service.Controls.Add(add_service);
            Service.Controls.Add(dataGrid_service);
            Service.Location = new Point(4, 24);
            Service.Margin = new Padding(3, 2, 3, 2);
            Service.Name = "Service";
            Service.Size = new Size(1109, 337);
            Service.TabIndex = 3;
            Service.Text = "Услуги";
            Service.UseVisualStyleBackColor = true;
            // 
            // edit_service
            // 
            edit_service.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edit_service.Cursor = Cursors.Hand;
            edit_service.Location = new Point(788, 82);
            edit_service.Margin = new Padding(3, 2, 3, 2);
            edit_service.Name = "edit_service";
            edit_service.Size = new Size(279, 46);
            edit_service.TabIndex = 5;
            edit_service.Text = "Редактирование данных";
            edit_service.UseVisualStyleBackColor = true;
            edit_service.Click += edit_service_Click;
            // 
            // add_service
            // 
            add_service.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            add_service.Cursor = Cursors.Hand;
            add_service.Location = new Point(788, 13);
            add_service.Margin = new Padding(3, 2, 3, 2);
            add_service.Name = "add_service";
            add_service.Size = new Size(279, 46);
            add_service.TabIndex = 4;
            add_service.Text = "Добавить услугу";
            add_service.UseVisualStyleBackColor = true;
            add_service.Click += add_service_Click;
            // 
            // dataGrid_service
            // 
            dataGrid_service.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGrid_service.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_service.Location = new Point(0, 0);
            dataGrid_service.Margin = new Padding(3, 2, 3, 2);
            dataGrid_service.Name = "dataGrid_service";
            dataGrid_service.RowHeadersWidth = 51;
            dataGrid_service.Size = new Size(759, 332);
            dataGrid_service.TabIndex = 3;
            // 
            // Employee
            // 
            Employee.Controls.Add(edit_employee);
            Employee.Controls.Add(add_employee);
            Employee.Controls.Add(dataGrid_employee);
            Employee.Location = new Point(4, 24);
            Employee.Margin = new Padding(3, 2, 3, 2);
            Employee.Name = "Employee";
            Employee.Size = new Size(1109, 337);
            Employee.TabIndex = 4;
            Employee.Text = "Сотрудники";
            Employee.UseVisualStyleBackColor = true;
            // 
            // edit_employee
            // 
            edit_employee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edit_employee.Cursor = Cursors.Hand;
            edit_employee.Location = new Point(788, 82);
            edit_employee.Margin = new Padding(3, 2, 3, 2);
            edit_employee.Name = "edit_employee";
            edit_employee.Size = new Size(282, 46);
            edit_employee.TabIndex = 5;
            edit_employee.Text = "Редактирование данных";
            edit_employee.UseVisualStyleBackColor = true;
            edit_employee.Click += edit_employee_Click;
            // 
            // add_employee
            // 
            add_employee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            add_employee.Cursor = Cursors.Hand;
            add_employee.Location = new Point(788, 13);
            add_employee.Margin = new Padding(3, 2, 3, 2);
            add_employee.Name = "add_employee";
            add_employee.Size = new Size(282, 46);
            add_employee.TabIndex = 4;
            add_employee.Text = "Добавить сотрудника";
            add_employee.UseVisualStyleBackColor = true;
            add_employee.Click += add_employee_Click;
            // 
            // dataGrid_employee
            // 
            dataGrid_employee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_employee.Dock = DockStyle.Left;
            dataGrid_employee.Location = new Point(0, 0);
            dataGrid_employee.Margin = new Padding(3, 2, 3, 2);
            dataGrid_employee.Name = "dataGrid_employee";
            dataGrid_employee.RowHeadersWidth = 51;
            dataGrid_employee.Size = new Size(759, 337);
            dataGrid_employee.TabIndex = 3;
            // 
            // Report
            // 
            Report.Controls.Add(numericUpDown_order);
            Report.Controls.Add(numericUpDown_client);
            Report.Controls.Add(numericUpDown_employee);
            Report.Controls.Add(WriteReportBtn_order);
            Report.Controls.Add(WriteReportBtn_client);
            Report.Controls.Add(WriteReportBtn);
            Report.Controls.Add(dataGridView_report);
            Report.Location = new Point(4, 24);
            Report.Name = "Report";
            Report.Size = new Size(1109, 337);
            Report.TabIndex = 5;
            Report.Text = "Сформировать отчёт";
            Report.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_order
            // 
            numericUpDown_order.Location = new Point(1001, 165);
            numericUpDown_order.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numericUpDown_order.Name = "numericUpDown_order";
            numericUpDown_order.Size = new Size(54, 23);
            numericUpDown_order.TabIndex = 10;
            // 
            // numericUpDown_client
            // 
            numericUpDown_client.Location = new Point(1001, 97);
            numericUpDown_client.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numericUpDown_client.Name = "numericUpDown_client";
            numericUpDown_client.Size = new Size(54, 23);
            numericUpDown_client.TabIndex = 9;
            // 
            // numericUpDown_employee
            // 
            numericUpDown_employee.Location = new Point(1001, 32);
            numericUpDown_employee.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numericUpDown_employee.Name = "numericUpDown_employee";
            numericUpDown_employee.Size = new Size(54, 23);
            numericUpDown_employee.TabIndex = 8;
            // 
            // WriteReportBtn_order
            // 
            WriteReportBtn_order.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            WriteReportBtn_order.Cursor = Cursors.Hand;
            WriteReportBtn_order.Location = new Point(789, 151);
            WriteReportBtn_order.Margin = new Padding(3, 2, 3, 2);
            WriteReportBtn_order.Name = "WriteReportBtn_order";
            WriteReportBtn_order.Size = new Size(206, 46);
            WriteReportBtn_order.TabIndex = 7;
            WriteReportBtn_order.Text = "Сформировать отчет по заказам";
            WriteReportBtn_order.UseVisualStyleBackColor = true;
            WriteReportBtn_order.Click += WriteReportBtn_order_Click;
            // 
            // WriteReportBtn_client
            // 
            WriteReportBtn_client.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            WriteReportBtn_client.Cursor = Cursors.Hand;
            WriteReportBtn_client.Location = new Point(789, 83);
            WriteReportBtn_client.Margin = new Padding(3, 2, 3, 2);
            WriteReportBtn_client.Name = "WriteReportBtn_client";
            WriteReportBtn_client.Size = new Size(206, 46);
            WriteReportBtn_client.TabIndex = 6;
            WriteReportBtn_client.Text = "Сформировать отчет по клиентам";
            WriteReportBtn_client.UseVisualStyleBackColor = true;
            WriteReportBtn_client.Click += WriteReportBtn_client_Click;
            // 
            // WriteReportBtn
            // 
            WriteReportBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            WriteReportBtn.Cursor = Cursors.Hand;
            WriteReportBtn.Location = new Point(789, 18);
            WriteReportBtn.Margin = new Padding(3, 2, 3, 2);
            WriteReportBtn.Name = "WriteReportBtn";
            WriteReportBtn.Size = new Size(206, 46);
            WriteReportBtn.TabIndex = 5;
            WriteReportBtn.Text = "Сформировать отчет по сотрудникам";
            WriteReportBtn.UseVisualStyleBackColor = true;
            WriteReportBtn.Click += WriteReportBtn_Click;
            // 
            // dataGridView_report
            // 
            dataGridView_report.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_report.Dock = DockStyle.Left;
            dataGridView_report.Location = new Point(0, 0);
            dataGridView_report.Margin = new Padding(3, 2, 3, 2);
            dataGridView_report.Name = "dataGridView_report";
            dataGridView_report.RowHeadersWidth = 51;
            dataGridView_report.Size = new Size(759, 337);
            dataGridView_report.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 363);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Химчистка";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)datagrid_client).EndInit();
            tabControl1.ResumeLayout(false);
            Clients.ResumeLayout(false);
            Orders.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid_order).EndInit();
            Product.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid_product).EndInit();
            Service.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid_service).EndInit();
            Employee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid_employee).EndInit();
            Report.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_order).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_client).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_employee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_report).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView datagrid_client;
        private TabControl tabControl1;
        private TabPage Clients;
        private TabPage Orders;
        private Button edit_client;
        private Button add_client;
        private TabPage Product;
        private TabPage Service;
        private TabPage Employee;
        private Button edit_order;
        private Button add_order;
        private DataGridView dataGrid_order;
        private Button edit_product;
        private DataGridView dataGrid_product;
        private Button edit_service;
        private Button add_service;
        private DataGridView dataGrid_service;
        private Button edit_employee;
        private Button add_employee;
        private DataGridView dataGrid_employee;
        private GroupBox groupBox1;
        private Button updateDateIssueButton;
        private Button updateStatusButton;
        private TabPage Report;
        private DataGridView dataGridView_report;
        private Button WriteReportBtn;
        private NumericUpDown numericUpDown_order;
        private NumericUpDown numericUpDown_client;
        private NumericUpDown numericUpDown_employee;
        private Button WriteReportBtn_order;
        private Button WriteReportBtn_client;
    }
}
