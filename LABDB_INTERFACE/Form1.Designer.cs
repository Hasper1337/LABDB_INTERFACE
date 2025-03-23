namespace LABDB_INTERFACE
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
            Orders = new TabPage();
            add_client = new Button();
            edit_client = new Button();
            Product = new TabPage();
            Service = new TabPage();
            Employee = new TabPage();
            edit_order = new Button();
            add_order = new Button();
            dataGrid_order = new DataGridView();
            edit_product = new Button();
            add_product = new Button();
            dataGrid_product = new DataGridView();
            edit_service = new Button();
            add_service = new Button();
            dataGrid_service = new DataGridView();
            edit_employee = new Button();
            add_employee = new Button();
            dataGrid_employee = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)datagrid_client).BeginInit();
            tabControl1.SuspendLayout();
            Clients.SuspendLayout();
            Orders.SuspendLayout();
            Product.SuspendLayout();
            Service.SuspendLayout();
            Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_order).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_service).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_employee).BeginInit();
            SuspendLayout();
            // 
            // datagrid_client
            // 
            datagrid_client.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid_client.Location = new Point(0, 0);
            datagrid_client.Name = "datagrid_client";
            datagrid_client.RowHeadersWidth = 51;
            datagrid_client.Size = new Size(867, 359);
            datagrid_client.TabIndex = 0;
            datagrid_client.CellContentClick += datagrid_client_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Clients);
            tabControl1.Controls.Add(Orders);
            tabControl1.Controls.Add(Product);
            tabControl1.Controls.Add(Service);
            tabControl1.Controls.Add(Employee);
            tabControl1.Location = new Point(12, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1206, 392);
            tabControl1.TabIndex = 1;
            // 
            // Clients
            // 
            Clients.Controls.Add(edit_client);
            Clients.Controls.Add(add_client);
            Clients.Controls.Add(datagrid_client);
            Clients.Location = new Point(4, 29);
            Clients.Name = "Clients";
            Clients.Padding = new Padding(3);
            Clients.Size = new Size(1198, 359);
            Clients.TabIndex = 0;
            Clients.Text = "Клиенты";
            Clients.UseVisualStyleBackColor = true;
            // 
            // Orders
            // 
            Orders.Controls.Add(edit_order);
            Orders.Controls.Add(add_order);
            Orders.Controls.Add(dataGrid_order);
            Orders.Location = new Point(4, 29);
            Orders.Name = "Orders";
            Orders.Padding = new Padding(3);
            Orders.Size = new Size(1198, 359);
            Orders.TabIndex = 1;
            Orders.Text = "Заказы";
            Orders.UseVisualStyleBackColor = true;
            // 
            // add_client
            // 
            add_client.Location = new Point(900, 17);
            add_client.Name = "add_client";
            add_client.Size = new Size(272, 61);
            add_client.TabIndex = 1;
            add_client.Text = "Добавить клиента";
            add_client.UseVisualStyleBackColor = true;
            // 
            // edit_client
            // 
            edit_client.Location = new Point(900, 109);
            edit_client.Name = "edit_client";
            edit_client.Size = new Size(272, 69);
            edit_client.TabIndex = 2;
            edit_client.Text = "Редактирование данных";
            edit_client.UseVisualStyleBackColor = true;
            // 
            // Product
            // 
            Product.Controls.Add(edit_product);
            Product.Controls.Add(add_product);
            Product.Controls.Add(dataGrid_product);
            Product.Location = new Point(4, 29);
            Product.Name = "Product";
            Product.Size = new Size(1198, 359);
            Product.TabIndex = 2;
            Product.Text = "Вещи";
            Product.UseVisualStyleBackColor = true;
            // 
            // Service
            // 
            Service.Controls.Add(edit_service);
            Service.Controls.Add(add_service);
            Service.Controls.Add(dataGrid_service);
            Service.Location = new Point(4, 29);
            Service.Name = "Service";
            Service.Size = new Size(1198, 359);
            Service.TabIndex = 3;
            Service.Text = "Услуги";
            Service.UseVisualStyleBackColor = true;
            // 
            // Employee
            // 
            Employee.Controls.Add(edit_employee);
            Employee.Controls.Add(add_employee);
            Employee.Controls.Add(dataGrid_employee);
            Employee.Location = new Point(4, 29);
            Employee.Name = "Employee";
            Employee.Size = new Size(1198, 359);
            Employee.TabIndex = 4;
            Employee.Text = "Сотрудники";
            Employee.UseVisualStyleBackColor = true;
            // 
            // edit_order
            // 
            edit_order.Location = new Point(900, 109);
            edit_order.Name = "edit_order";
            edit_order.Size = new Size(272, 69);
            edit_order.TabIndex = 5;
            edit_order.Text = "Редактирование данных";
            edit_order.UseVisualStyleBackColor = true;
            // 
            // add_order
            // 
            add_order.Location = new Point(900, 17);
            add_order.Name = "add_order";
            add_order.Size = new Size(272, 61);
            add_order.TabIndex = 4;
            add_order.Text = "Добавить заказ";
            add_order.UseVisualStyleBackColor = true;
            // 
            // dataGrid_order
            // 
            dataGrid_order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_order.Location = new Point(0, 0);
            dataGrid_order.Name = "dataGrid_order";
            dataGrid_order.RowHeadersWidth = 51;
            dataGrid_order.Size = new Size(867, 359);
            dataGrid_order.TabIndex = 3;
            // 
            // edit_product
            // 
            edit_product.Location = new Point(900, 109);
            edit_product.Name = "edit_product";
            edit_product.Size = new Size(272, 69);
            edit_product.TabIndex = 5;
            edit_product.Text = "Редактирование данных";
            edit_product.UseVisualStyleBackColor = true;
            // 
            // add_product
            // 
            add_product.Location = new Point(900, 17);
            add_product.Name = "add_product";
            add_product.Size = new Size(272, 61);
            add_product.TabIndex = 4;
            add_product.Text = "Добавить вещь";
            add_product.UseVisualStyleBackColor = true;
            // 
            // dataGrid_product
            // 
            dataGrid_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_product.Location = new Point(0, 0);
            dataGrid_product.Name = "dataGrid_product";
            dataGrid_product.RowHeadersWidth = 51;
            dataGrid_product.Size = new Size(867, 359);
            dataGrid_product.TabIndex = 3;
            // 
            // edit_service
            // 
            edit_service.Location = new Point(900, 109);
            edit_service.Name = "edit_service";
            edit_service.Size = new Size(272, 69);
            edit_service.TabIndex = 5;
            edit_service.Text = "Редактирование данных";
            edit_service.UseVisualStyleBackColor = true;
            // 
            // add_service
            // 
            add_service.Location = new Point(900, 17);
            add_service.Name = "add_service";
            add_service.Size = new Size(272, 61);
            add_service.TabIndex = 4;
            add_service.Text = "Добавить услугу";
            add_service.UseVisualStyleBackColor = true;
            // 
            // dataGrid_service
            // 
            dataGrid_service.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_service.Location = new Point(0, 0);
            dataGrid_service.Name = "dataGrid_service";
            dataGrid_service.RowHeadersWidth = 51;
            dataGrid_service.Size = new Size(867, 359);
            dataGrid_service.TabIndex = 3;
            // 
            // edit_employee
            // 
            edit_employee.Location = new Point(900, 109);
            edit_employee.Name = "edit_employee";
            edit_employee.Size = new Size(272, 69);
            edit_employee.TabIndex = 5;
            edit_employee.Text = "Редактирование данных";
            edit_employee.UseVisualStyleBackColor = true;
            // 
            // add_employee
            // 
            add_employee.Location = new Point(900, 17);
            add_employee.Name = "add_employee";
            add_employee.Size = new Size(272, 61);
            add_employee.TabIndex = 4;
            add_employee.Text = "Добавить сотрудника";
            add_employee.UseVisualStyleBackColor = true;
            // 
            // dataGrid_employee
            // 
            dataGrid_employee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_employee.Location = new Point(0, 0);
            dataGrid_employee.Name = "dataGrid_employee";
            dataGrid_employee.RowHeadersWidth = 51;
            dataGrid_employee.Size = new Size(867, 359);
            dataGrid_employee.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 423);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)datagrid_client).EndInit();
            tabControl1.ResumeLayout(false);
            Clients.ResumeLayout(false);
            Orders.ResumeLayout(false);
            Product.ResumeLayout(false);
            Service.ResumeLayout(false);
            Employee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid_order).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_product).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_service).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_employee).EndInit();
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
        private Button add_product;
        private DataGridView dataGrid_product;
        private Button edit_service;
        private Button add_service;
        private DataGridView dataGrid_service;
        private Button edit_employee;
        private Button add_employee;
        private DataGridView dataGrid_employee;
    }
}
