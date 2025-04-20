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
            button1 = new Button();
            textBox1 = new TextBox();
            SelLikeBtn_client = new Button();
            SelBtnAll_client = new Button();
            SelBtnWithoutRepeat_client = new Button();
            SelBtnF10_client = new Button();
            SelBtn_client = new Button();
            edit_client = new Button();
            add_client = new Button();
            Orders = new TabPage();
            SelStatusOrderCountBtn_order = new Button();
            groupBox2 = new GroupBox();
            numericBetweenScnd = new NumericUpDown();
            numericBetweenFrst = new NumericUpDown();
            numericLess = new NumericUpDown();
            numericMore = new NumericUpDown();
            ComBtnLess_order = new Button();
            ComBtnBetween_order = new Button();
            ComBtnMore_order = new Button();
            groupBox1 = new GroupBox();
            updateDateIssueButton = new Button();
            updateStatusButton = new Button();
            edit_order = new Button();
            add_order = new Button();
            dataGrid_order = new DataGridView();
            Product = new TabPage();
            DelBtn_product = new Button();
            edit_product = new Button();
            dataGrid_product = new DataGridView();
            Service = new TabPage();
            SelExepctBtn_service = new Button();
            AvgBtn_service = new Button();
            MinBtn_service = new Button();
            MaxBtn_service = new Button();
            edit_service = new Button();
            add_service = new Button();
            dataGrid_service = new DataGridView();
            Employee = new TabPage();
            button2 = new Button();
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
            SelBirthDateBtn_employee = new Button();
            ((System.ComponentModel.ISupportInitialize)datagrid_client).BeginInit();
            tabControl1.SuspendLayout();
            Clients.SuspendLayout();
            Orders.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericBetweenScnd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBetweenFrst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericLess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMore).BeginInit();
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
            datagrid_client.Size = new Size(759, 518);
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
            tabControl1.Size = new Size(1117, 550);
            tabControl1.TabIndex = 1;
            // 
            // Clients
            // 
            Clients.Controls.Add(button1);
            Clients.Controls.Add(textBox1);
            Clients.Controls.Add(SelLikeBtn_client);
            Clients.Controls.Add(SelBtnAll_client);
            Clients.Controls.Add(SelBtnWithoutRepeat_client);
            Clients.Controls.Add(SelBtnF10_client);
            Clients.Controls.Add(SelBtn_client);
            Clients.Controls.Add(edit_client);
            Clients.Controls.Add(add_client);
            Clients.Controls.Add(datagrid_client);
            Clients.Location = new Point(4, 24);
            Clients.Margin = new Padding(3, 2, 3, 2);
            Clients.Name = "Clients";
            Clients.Padding = new Padding(3, 2, 3, 2);
            Clients.Size = new Size(1109, 522);
            Clients.TabIndex = 0;
            Clients.Text = "Клиенты";
            Clients.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(784, 432);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(279, 46);
            button1.TabIndex = 9;
            button1.Text = "Вывести клиентов с заполненной почтой";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(944, 386);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // SelLikeBtn_client
            // 
            SelLikeBtn_client.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelLikeBtn_client.Cursor = Cursors.Hand;
            SelLikeBtn_client.Location = new Point(784, 373);
            SelLikeBtn_client.Margin = new Padding(3, 2, 3, 2);
            SelLikeBtn_client.Name = "SelLikeBtn_client";
            SelLikeBtn_client.Size = new Size(154, 46);
            SelLikeBtn_client.TabIndex = 7;
            SelLikeBtn_client.Text = "Вывести клиентов с почтой:";
            SelLikeBtn_client.UseVisualStyleBackColor = true;
            SelLikeBtn_client.Click += SelLikeBtn_client_Click;
            // 
            // SelBtnAll_client
            // 
            SelBtnAll_client.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelBtnAll_client.Cursor = Cursors.Hand;
            SelBtnAll_client.Location = new Point(784, 314);
            SelBtnAll_client.Margin = new Padding(3, 2, 3, 2);
            SelBtnAll_client.Name = "SelBtnAll_client";
            SelBtnAll_client.Size = new Size(279, 46);
            SelBtnAll_client.TabIndex = 6;
            SelBtnAll_client.Text = "Вывести все записи";
            SelBtnAll_client.UseVisualStyleBackColor = true;
            SelBtnAll_client.Click += SelBtnAll_client_Click;
            // 
            // SelBtnWithoutRepeat_client
            // 
            SelBtnWithoutRepeat_client.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelBtnWithoutRepeat_client.Cursor = Cursors.Hand;
            SelBtnWithoutRepeat_client.Location = new Point(784, 254);
            SelBtnWithoutRepeat_client.Margin = new Padding(3, 2, 3, 2);
            SelBtnWithoutRepeat_client.Name = "SelBtnWithoutRepeat_client";
            SelBtnWithoutRepeat_client.Size = new Size(279, 46);
            SelBtnWithoutRepeat_client.TabIndex = 5;
            SelBtnWithoutRepeat_client.Text = "Вывести записи без повторений";
            SelBtnWithoutRepeat_client.UseVisualStyleBackColor = true;
            SelBtnWithoutRepeat_client.Click += SelBtnWithoutRepeat_client_Click;
            // 
            // SelBtnF10_client
            // 
            SelBtnF10_client.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelBtnF10_client.Cursor = Cursors.Hand;
            SelBtnF10_client.Location = new Point(784, 195);
            SelBtnF10_client.Margin = new Padding(3, 2, 3, 2);
            SelBtnF10_client.Name = "SelBtnF10_client";
            SelBtnF10_client.Size = new Size(279, 46);
            SelBtnF10_client.TabIndex = 4;
            SelBtnF10_client.Text = "Вывести 10 первых записей";
            SelBtnF10_client.UseVisualStyleBackColor = true;
            SelBtnF10_client.Click += SelBtnF10_client_Click;
            // 
            // SelBtn_client
            // 
            SelBtn_client.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelBtn_client.Cursor = Cursors.Hand;
            SelBtn_client.Location = new Point(784, 134);
            SelBtn_client.Margin = new Padding(3, 2, 3, 2);
            SelBtn_client.Name = "SelBtn_client";
            SelBtn_client.Size = new Size(279, 46);
            SelBtn_client.TabIndex = 3;
            SelBtn_client.Text = "Вывести 15 последних записей";
            SelBtn_client.UseVisualStyleBackColor = true;
            SelBtn_client.Click += SelBtn_client_Click;
            // 
            // edit_client
            // 
            edit_client.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            edit_client.Cursor = Cursors.Hand;
            edit_client.Location = new Point(784, 74);
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
            Orders.Controls.Add(SelStatusOrderCountBtn_order);
            Orders.Controls.Add(groupBox2);
            Orders.Controls.Add(groupBox1);
            Orders.Controls.Add(edit_order);
            Orders.Controls.Add(add_order);
            Orders.Controls.Add(dataGrid_order);
            Orders.Location = new Point(4, 24);
            Orders.Margin = new Padding(3, 2, 3, 2);
            Orders.Name = "Orders";
            Orders.Padding = new Padding(3, 2, 3, 2);
            Orders.Size = new Size(1109, 522);
            Orders.TabIndex = 1;
            Orders.Text = "Заказы";
            Orders.UseVisualStyleBackColor = true;
            // 
            // SelStatusOrderCountBtn_order
            // 
            SelStatusOrderCountBtn_order.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelStatusOrderCountBtn_order.Cursor = Cursors.Hand;
            SelStatusOrderCountBtn_order.Location = new Point(788, 113);
            SelStatusOrderCountBtn_order.Margin = new Padding(3, 2, 3, 2);
            SelStatusOrderCountBtn_order.Name = "SelStatusOrderCountBtn_order";
            SelStatusOrderCountBtn_order.Size = new Size(279, 46);
            SelStatusOrderCountBtn_order.TabIndex = 10;
            SelStatusOrderCountBtn_order.Text = "Вывести количество заказов по статусам";
            SelStatusOrderCountBtn_order.UseVisualStyleBackColor = true;
            SelStatusOrderCountBtn_order.Click += SelStatusOrderCountBtn_order_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(numericBetweenScnd);
            groupBox2.Controls.Add(numericBetweenFrst);
            groupBox2.Controls.Add(numericLess);
            groupBox2.Controls.Add(numericMore);
            groupBox2.Controls.Add(ComBtnLess_order);
            groupBox2.Controls.Add(ComBtnBetween_order);
            groupBox2.Controls.Add(ComBtnMore_order);
            groupBox2.Location = new Point(789, 171);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(278, 198);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Команды сравнения";
            // 
            // numericBetweenScnd
            // 
            numericBetweenScnd.Location = new Point(225, 161);
            numericBetweenScnd.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numericBetweenScnd.Name = "numericBetweenScnd";
            numericBetweenScnd.Size = new Size(47, 23);
            numericBetweenScnd.TabIndex = 14;
            // 
            // numericBetweenFrst
            // 
            numericBetweenFrst.Location = new Point(144, 161);
            numericBetweenFrst.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numericBetweenFrst.Name = "numericBetweenFrst";
            numericBetweenFrst.Size = new Size(47, 23);
            numericBetweenFrst.TabIndex = 13;
            // 
            // numericLess
            // 
            numericLess.Location = new Point(187, 105);
            numericLess.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numericLess.Name = "numericLess";
            numericLess.Size = new Size(86, 23);
            numericLess.TabIndex = 12;
            // 
            // numericMore
            // 
            numericMore.Location = new Point(187, 38);
            numericMore.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numericMore.Name = "numericMore";
            numericMore.Size = new Size(86, 23);
            numericMore.TabIndex = 11;
            // 
            // ComBtnLess_order
            // 
            ComBtnLess_order.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComBtnLess_order.Cursor = Cursors.Hand;
            ComBtnLess_order.Location = new Point(6, 94);
            ComBtnLess_order.Margin = new Padding(3, 2, 3, 2);
            ComBtnLess_order.Name = "ComBtnLess_order";
            ComBtnLess_order.Size = new Size(174, 41);
            ComBtnLess_order.TabIndex = 10;
            ComBtnLess_order.Text = "Вывести заказы с стоимостью меньше";
            ComBtnLess_order.UseVisualStyleBackColor = true;
            ComBtnLess_order.Click += ComBtnLess_order_Click;
            // 
            // ComBtnBetween_order
            // 
            ComBtnBetween_order.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComBtnBetween_order.Cursor = Cursors.Hand;
            ComBtnBetween_order.Location = new Point(6, 148);
            ComBtnBetween_order.Margin = new Padding(3, 2, 3, 2);
            ComBtnBetween_order.Name = "ComBtnBetween_order";
            ComBtnBetween_order.Size = new Size(132, 45);
            ComBtnBetween_order.TabIndex = 9;
            ComBtnBetween_order.Text = "Вывести заказы с стоимостью между";
            ComBtnBetween_order.UseVisualStyleBackColor = true;
            ComBtnBetween_order.Click += ComBtnBetween_order_Click;
            // 
            // ComBtnMore_order
            // 
            ComBtnMore_order.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComBtnMore_order.Cursor = Cursors.Hand;
            ComBtnMore_order.Location = new Point(6, 21);
            ComBtnMore_order.Margin = new Padding(3, 2, 3, 2);
            ComBtnMore_order.Name = "ComBtnMore_order";
            ComBtnMore_order.Size = new Size(174, 53);
            ComBtnMore_order.TabIndex = 7;
            ComBtnMore_order.Text = "Вывести заказы с стоимостью больше";
            ComBtnMore_order.UseVisualStyleBackColor = true;
            ComBtnMore_order.Click += ComBtnMore_order_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(updateDateIssueButton);
            groupBox1.Controls.Add(updateStatusButton);
            groupBox1.Location = new Point(788, 389);
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
            edit_order.Location = new Point(788, 63);
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
            dataGrid_order.Size = new Size(759, 518);
            dataGrid_order.TabIndex = 3;
            // 
            // Product
            // 
            Product.Controls.Add(DelBtn_product);
            Product.Controls.Add(edit_product);
            Product.Controls.Add(dataGrid_product);
            Product.Location = new Point(4, 24);
            Product.Margin = new Padding(3, 2, 3, 2);
            Product.Name = "Product";
            Product.Size = new Size(1109, 522);
            Product.TabIndex = 2;
            Product.Text = "Вещи";
            Product.UseVisualStyleBackColor = true;
            // 
            // DelBtn_product
            // 
            DelBtn_product.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DelBtn_product.Cursor = Cursors.Hand;
            DelBtn_product.Location = new Point(788, 74);
            DelBtn_product.Margin = new Padding(3, 2, 3, 2);
            DelBtn_product.Name = "DelBtn_product";
            DelBtn_product.Size = new Size(279, 46);
            DelBtn_product.TabIndex = 6;
            DelBtn_product.Text = "Удаление данных";
            DelBtn_product.UseVisualStyleBackColor = true;
            DelBtn_product.Click += DelBtn_product_Click;
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
            dataGrid_product.Size = new Size(759, 522);
            dataGrid_product.TabIndex = 3;
            // 
            // Service
            // 
            Service.Controls.Add(SelExepctBtn_service);
            Service.Controls.Add(AvgBtn_service);
            Service.Controls.Add(MinBtn_service);
            Service.Controls.Add(MaxBtn_service);
            Service.Controls.Add(edit_service);
            Service.Controls.Add(add_service);
            Service.Controls.Add(dataGrid_service);
            Service.Location = new Point(4, 24);
            Service.Margin = new Padding(3, 2, 3, 2);
            Service.Name = "Service";
            Service.Size = new Size(1109, 522);
            Service.TabIndex = 3;
            Service.Text = "Услуги";
            Service.UseVisualStyleBackColor = true;
            // 
            // SelExepctBtn_service
            // 
            SelExepctBtn_service.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelExepctBtn_service.Cursor = Cursors.Hand;
            SelExepctBtn_service.Location = new Point(788, 321);
            SelExepctBtn_service.Margin = new Padding(3, 2, 3, 2);
            SelExepctBtn_service.Name = "SelExepctBtn_service";
            SelExepctBtn_service.Size = new Size(279, 46);
            SelExepctBtn_service.TabIndex = 9;
            SelExepctBtn_service.Text = "Вывести услуги которые никогда не использовались";
            SelExepctBtn_service.UseVisualStyleBackColor = true;
            SelExepctBtn_service.Click += SelExepctBtn_service_Click;
            // 
            // AvgBtn_service
            // 
            AvgBtn_service.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AvgBtn_service.Cursor = Cursors.Hand;
            AvgBtn_service.Location = new Point(788, 261);
            AvgBtn_service.Margin = new Padding(3, 2, 3, 2);
            AvgBtn_service.Name = "AvgBtn_service";
            AvgBtn_service.Size = new Size(279, 46);
            AvgBtn_service.TabIndex = 8;
            AvgBtn_service.Text = "Вывести среднию цену услуг";
            AvgBtn_service.UseVisualStyleBackColor = true;
            AvgBtn_service.Click += AvgBtn_service_Click;
            // 
            // MinBtn_service
            // 
            MinBtn_service.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MinBtn_service.Cursor = Cursors.Hand;
            MinBtn_service.Location = new Point(788, 200);
            MinBtn_service.Margin = new Padding(3, 2, 3, 2);
            MinBtn_service.Name = "MinBtn_service";
            MinBtn_service.Size = new Size(279, 46);
            MinBtn_service.TabIndex = 7;
            MinBtn_service.Text = "Вывести самую дешевую услугу";
            MinBtn_service.UseVisualStyleBackColor = true;
            MinBtn_service.Click += MinBtn_service_Click;
            // 
            // MaxBtn_service
            // 
            MaxBtn_service.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MaxBtn_service.Cursor = Cursors.Hand;
            MaxBtn_service.Location = new Point(788, 141);
            MaxBtn_service.Margin = new Padding(3, 2, 3, 2);
            MaxBtn_service.Name = "MaxBtn_service";
            MaxBtn_service.Size = new Size(279, 46);
            MaxBtn_service.TabIndex = 6;
            MaxBtn_service.Text = "Вывести самую дорогую услугу";
            MaxBtn_service.UseVisualStyleBackColor = true;
            MaxBtn_service.Click += MaxBtn_service_Click;
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
            dataGrid_service.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_service.Dock = DockStyle.Left;
            dataGrid_service.Location = new Point(0, 0);
            dataGrid_service.Margin = new Padding(3, 2, 3, 2);
            dataGrid_service.Name = "dataGrid_service";
            dataGrid_service.RowHeadersWidth = 51;
            dataGrid_service.Size = new Size(759, 522);
            dataGrid_service.TabIndex = 3;
            // 
            // Employee
            // 
            Employee.Controls.Add(SelBirthDateBtn_employee);
            Employee.Controls.Add(button2);
            Employee.Controls.Add(edit_employee);
            Employee.Controls.Add(add_employee);
            Employee.Controls.Add(dataGrid_employee);
            Employee.Location = new Point(4, 24);
            Employee.Margin = new Padding(3, 2, 3, 2);
            Employee.Name = "Employee";
            Employee.Size = new Size(1109, 522);
            Employee.TabIndex = 4;
            Employee.Text = "Сотрудники";
            Employee.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(788, 145);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(282, 46);
            button2.TabIndex = 6;
            button2.Text = "Вывести операторов химчистки";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
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
            dataGrid_employee.Size = new Size(759, 522);
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
            Report.Size = new Size(1109, 522);
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
            dataGridView_report.Size = new Size(759, 522);
            dataGridView_report.TabIndex = 4;
            // 
            // SelBirthDateBtn_employee
            // 
            SelBirthDateBtn_employee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelBirthDateBtn_employee.Cursor = Cursors.Hand;
            SelBirthDateBtn_employee.Location = new Point(788, 208);
            SelBirthDateBtn_employee.Margin = new Padding(3, 2, 3, 2);
            SelBirthDateBtn_employee.Name = "SelBirthDateBtn_employee";
            SelBirthDateBtn_employee.Size = new Size(282, 46);
            SelBirthDateBtn_employee.TabIndex = 7;
            SelBirthDateBtn_employee.Text = "Вывести сотрудников у которых будет юбилей в след.месяце";
            SelBirthDateBtn_employee.UseVisualStyleBackColor = true;
            SelBirthDateBtn_employee.Click += SelBirthDateBtn_employee_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 548);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Химчистка";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)datagrid_client).EndInit();
            tabControl1.ResumeLayout(false);
            Clients.ResumeLayout(false);
            Clients.PerformLayout();
            Orders.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericBetweenScnd).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBetweenFrst).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericLess).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMore).EndInit();
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
        private Button DelBtn_product;
        private Button SelBtn_client;
        private Button SelBtnF10_client;
        private Button SelBtnWithoutRepeat_client;
        private Button SelBtnAll_client;
        private Button MaxBtn_service;
        private Button MinBtn_service;
        private Button AvgBtn_service;
        private GroupBox groupBox2;
        private Button ComBtnLess_order;
        private Button ComBtnBetween_order;
        private Button ComBtnMore_order;
        private NumericUpDown numericBetweenFrst;
        private NumericUpDown numericLess;
        private NumericUpDown numericMore;
        private NumericUpDown numericBetweenScnd;
        private Button SelLikeBtn_client;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button SelStatusOrderCountBtn_order;
        private Button SelExepctBtn_service;
        private Button SelBirthDateBtn_employee;
    }
}
