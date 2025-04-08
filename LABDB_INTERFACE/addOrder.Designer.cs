namespace LABDB_INTERFACE
{
    partial class addOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addButton_order = new Button();
            label_pickupDate = new Label();
            label_idClient_forOrder = new Label();
            numericUpDown_idClient = new NumericUpDown();
            groupBox_Product = new GroupBox();
            checkBox_Product_lining = new CheckBox();
            label_Product_typeProduct = new Label();
            label_Product_features = new Label();
            label_Product_color = new Label();
            label_Product_typeCloath = new Label();
            textBox_Product_typeProduct = new TextBox();
            textBox_Product_features = new TextBox();
            textBox_Product_color = new TextBox();
            textBox_typeCloath = new TextBox();
            dateTimePicker_pickupdate = new DateTimePicker();
            groupBox_Service = new GroupBox();
            label7 = new Label();
            comboBox_Employee4 = new ComboBox();
            label6 = new Label();
            comboBox_Employee3 = new ComboBox();
            label5 = new Label();
            comboBox_Employee2 = new ComboBox();
            label4 = new Label();
            comboBox_Employee1 = new ComboBox();
            label3 = new Label();
            comboBox_Service3 = new ComboBox();
            label2 = new Label();
            comboBox_Service2 = new ComboBox();
            label1 = new Label();
            comboBox_Service1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_idClient).BeginInit();
            groupBox_Product.SuspendLayout();
            groupBox_Service.SuspendLayout();
            SuspendLayout();
            // 
            // addButton_order
            // 
            addButton_order.Cursor = Cursors.Hand;
            addButton_order.Dock = DockStyle.Bottom;
            addButton_order.Location = new Point(0, 338);
            addButton_order.Name = "addButton_order";
            addButton_order.Size = new Size(680, 63);
            addButton_order.TabIndex = 41;
            addButton_order.Text = "Добавить данные";
            addButton_order.UseVisualStyleBackColor = true;
            addButton_order.Click += addButton_order_Click;
            // 
            // label_pickupDate
            // 
            label_pickupDate.AutoSize = true;
            label_pickupDate.Location = new Point(189, 51);
            label_pickupDate.Name = "label_pickupDate";
            label_pickupDate.Size = new Size(77, 15);
            label_pickupDate.TabIndex = 38;
            label_pickupDate.Text = "Дата приема";
            // 
            // label_idClient_forOrder
            // 
            label_idClient_forOrder.Location = new Point(189, 9);
            label_idClient_forOrder.Name = "label_idClient_forOrder";
            label_idClient_forOrder.Size = new Size(66, 15);
            label_idClient_forOrder.TabIndex = 37;
            label_idClient_forOrder.Text = "ID Клиента";
            // 
            // numericUpDown_idClient
            // 
            numericUpDown_idClient.Location = new Point(12, 7);
            numericUpDown_idClient.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numericUpDown_idClient.Name = "numericUpDown_idClient";
            numericUpDown_idClient.Size = new Size(162, 23);
            numericUpDown_idClient.TabIndex = 45;
            // 
            // groupBox_Product
            // 
            groupBox_Product.Controls.Add(checkBox_Product_lining);
            groupBox_Product.Controls.Add(label_Product_typeProduct);
            groupBox_Product.Controls.Add(label_Product_features);
            groupBox_Product.Controls.Add(label_Product_color);
            groupBox_Product.Controls.Add(label_Product_typeCloath);
            groupBox_Product.Controls.Add(textBox_Product_typeProduct);
            groupBox_Product.Controls.Add(textBox_Product_features);
            groupBox_Product.Controls.Add(textBox_Product_color);
            groupBox_Product.Controls.Add(textBox_typeCloath);
            groupBox_Product.Location = new Point(12, 91);
            groupBox_Product.Name = "groupBox_Product";
            groupBox_Product.Size = new Size(278, 234);
            groupBox_Product.TabIndex = 47;
            groupBox_Product.TabStop = false;
            groupBox_Product.Text = "Данные изделия";
            // 
            // checkBox_Product_lining
            // 
            checkBox_Product_lining.AutoSize = true;
            checkBox_Product_lining.Location = new Point(6, 153);
            checkBox_Product_lining.Name = "checkBox_Product_lining";
            checkBox_Product_lining.Size = new Size(136, 19);
            checkBox_Product_lining.TabIndex = 10;
            checkBox_Product_lining.Text = "Наличие подкладки";
            checkBox_Product_lining.UseVisualStyleBackColor = true;
            // 
            // label_Product_typeProduct
            // 
            label_Product_typeProduct.AutoSize = true;
            label_Product_typeProduct.Location = new Point(150, 194);
            label_Product_typeProduct.Name = "label_Product_typeProduct";
            label_Product_typeProduct.Size = new Size(74, 15);
            label_Product_typeProduct.TabIndex = 9;
            label_Product_typeProduct.Text = "Тип изделия";
            // 
            // label_Product_features
            // 
            label_Product_features.AutoSize = true;
            label_Product_features.Location = new Point(150, 116);
            label_Product_features.Name = "label_Product_features";
            label_Product_features.Size = new Size(81, 15);
            label_Product_features.TabIndex = 7;
            label_Product_features.Text = "Особенности";
            // 
            // label_Product_color
            // 
            label_Product_color.AutoSize = true;
            label_Product_color.Location = new Point(150, 76);
            label_Product_color.Name = "label_Product_color";
            label_Product_color.Size = new Size(33, 15);
            label_Product_color.TabIndex = 6;
            label_Product_color.Text = "Цвет";
            // 
            // label_Product_typeCloath
            // 
            label_Product_typeCloath.AutoSize = true;
            label_Product_typeCloath.Location = new Point(150, 35);
            label_Product_typeCloath.Name = "label_Product_typeCloath";
            label_Product_typeCloath.Size = new Size(61, 15);
            label_Product_typeCloath.TabIndex = 5;
            label_Product_typeCloath.Text = "Тип ткани";
            // 
            // textBox_Product_typeProduct
            // 
            textBox_Product_typeProduct.Location = new Point(6, 191);
            textBox_Product_typeProduct.Name = "textBox_Product_typeProduct";
            textBox_Product_typeProduct.Size = new Size(134, 23);
            textBox_Product_typeProduct.TabIndex = 4;
            // 
            // textBox_Product_features
            // 
            textBox_Product_features.Location = new Point(6, 113);
            textBox_Product_features.Name = "textBox_Product_features";
            textBox_Product_features.Size = new Size(134, 23);
            textBox_Product_features.TabIndex = 2;
            // 
            // textBox_Product_color
            // 
            textBox_Product_color.Location = new Point(6, 73);
            textBox_Product_color.Name = "textBox_Product_color";
            textBox_Product_color.Size = new Size(134, 23);
            textBox_Product_color.TabIndex = 1;
            // 
            // textBox_typeCloath
            // 
            textBox_typeCloath.Location = new Point(6, 32);
            textBox_typeCloath.Name = "textBox_typeCloath";
            textBox_typeCloath.Size = new Size(134, 23);
            textBox_typeCloath.TabIndex = 0;
            // 
            // dateTimePicker_pickupdate
            // 
            dateTimePicker_pickupdate.Location = new Point(12, 45);
            dateTimePicker_pickupdate.Name = "dateTimePicker_pickupdate";
            dateTimePicker_pickupdate.Size = new Size(160, 23);
            dateTimePicker_pickupdate.TabIndex = 48;
            // 
            // groupBox_Service
            // 
            groupBox_Service.Controls.Add(label7);
            groupBox_Service.Controls.Add(comboBox_Employee4);
            groupBox_Service.Controls.Add(label6);
            groupBox_Service.Controls.Add(comboBox_Employee3);
            groupBox_Service.Controls.Add(label5);
            groupBox_Service.Controls.Add(comboBox_Employee2);
            groupBox_Service.Controls.Add(label4);
            groupBox_Service.Controls.Add(comboBox_Employee1);
            groupBox_Service.Controls.Add(label3);
            groupBox_Service.Controls.Add(comboBox_Service3);
            groupBox_Service.Controls.Add(label2);
            groupBox_Service.Controls.Add(comboBox_Service2);
            groupBox_Service.Controls.Add(label1);
            groupBox_Service.Controls.Add(comboBox_Service1);
            groupBox_Service.Location = new Point(310, 12);
            groupBox_Service.Name = "groupBox_Service";
            groupBox_Service.Size = new Size(358, 313);
            groupBox_Service.TabIndex = 49;
            groupBox_Service.TabStop = false;
            groupBox_Service.Text = "Выбор услуг(и) и сотрудника(ов)";
            // 
            // label7
            // 
            label7.Location = new Point(273, 276);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 50;
            label7.Text = "Сотрудник";
            // 
            // comboBox_Employee4
            // 
            comboBox_Employee4.FormattingEnabled = true;
            comboBox_Employee4.Location = new Point(6, 273);
            comboBox_Employee4.Name = "comboBox_Employee4";
            comboBox_Employee4.Size = new Size(261, 23);
            comboBox_Employee4.TabIndex = 49;
            // 
            // label6
            // 
            label6.Location = new Point(273, 247);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 48;
            label6.Text = "Сотрудник";
            // 
            // comboBox_Employee3
            // 
            comboBox_Employee3.FormattingEnabled = true;
            comboBox_Employee3.Location = new Point(6, 244);
            comboBox_Employee3.Name = "comboBox_Employee3";
            comboBox_Employee3.Size = new Size(261, 23);
            comboBox_Employee3.TabIndex = 47;
            // 
            // label5
            // 
            label5.Location = new Point(273, 213);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 46;
            label5.Text = "Сотрудник";
            // 
            // comboBox_Employee2
            // 
            comboBox_Employee2.FormattingEnabled = true;
            comboBox_Employee2.Location = new Point(6, 210);
            comboBox_Employee2.Name = "comboBox_Employee2";
            comboBox_Employee2.Size = new Size(261, 23);
            comboBox_Employee2.TabIndex = 45;
            // 
            // label4
            // 
            label4.Location = new Point(273, 178);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 44;
            label4.Text = "Сотрудник";
            // 
            // comboBox_Employee1
            // 
            comboBox_Employee1.FormattingEnabled = true;
            comboBox_Employee1.Location = new Point(6, 175);
            comboBox_Employee1.Name = "comboBox_Employee1";
            comboBox_Employee1.Size = new Size(261, 23);
            comboBox_Employee1.TabIndex = 43;
            // 
            // label3
            // 
            label3.Location = new Point(273, 92);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 42;
            label3.Text = "Услуга";
            // 
            // comboBox_Service3
            // 
            comboBox_Service3.FormattingEnabled = true;
            comboBox_Service3.Location = new Point(6, 89);
            comboBox_Service3.Name = "comboBox_Service3";
            comboBox_Service3.Size = new Size(261, 23);
            comboBox_Service3.TabIndex = 41;
            // 
            // label2
            // 
            label2.Location = new Point(273, 63);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 40;
            label2.Text = "Услуга";
            // 
            // comboBox_Service2
            // 
            comboBox_Service2.FormattingEnabled = true;
            comboBox_Service2.Location = new Point(6, 60);
            comboBox_Service2.Name = "comboBox_Service2";
            comboBox_Service2.Size = new Size(261, 23);
            comboBox_Service2.TabIndex = 39;
            // 
            // label1
            // 
            label1.Location = new Point(273, 34);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 38;
            label1.Text = "Услуга";
            // 
            // comboBox_Service1
            // 
            comboBox_Service1.FormattingEnabled = true;
            comboBox_Service1.Location = new Point(6, 31);
            comboBox_Service1.Name = "comboBox_Service1";
            comboBox_Service1.Size = new Size(261, 23);
            comboBox_Service1.TabIndex = 0;
            // 
            // addOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 401);
            Controls.Add(groupBox_Service);
            Controls.Add(dateTimePicker_pickupdate);
            Controls.Add(groupBox_Product);
            Controls.Add(numericUpDown_idClient);
            Controls.Add(addButton_order);
            Controls.Add(label_pickupDate);
            Controls.Add(label_idClient_forOrder);
            Name = "addOrder";
            Text = "Добавление заказа";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_idClient).EndInit();
            groupBox_Product.ResumeLayout(false);
            groupBox_Product.PerformLayout();
            groupBox_Service.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addButton_order;
        private Label label_pickupDate;
        private Label label_idClient_forOrder;
        private NumericUpDown numericUpDown_idClient;
        private GroupBox groupBox_Product;
        private Label label_Product_typeCloath;
        private TextBox textBox_Product_typeProduct;
        private TextBox textBox_Product_features;
        private TextBox textBox_Product_color;
        private TextBox textBox_typeCloath;
        private Label label_Product_typeProduct;
        private Label label_Product_features;
        private Label label_Product_color;
        private CheckBox checkBox_Product_lining;
        private DateTimePicker dateTimePicker_pickupdate;
        private GroupBox groupBox_Service;
        private ComboBox comboBox_Service1;
        private Label label3;
        private ComboBox comboBox_Service3;
        private Label label2;
        private ComboBox comboBox_Service2;
        private Label label1;
        private Label label4;
        private ComboBox comboBox_Employee1;
        private Label label7;
        private ComboBox comboBox_Employee4;
        private Label label6;
        private ComboBox comboBox_Employee3;
        private Label label5;
        private ComboBox comboBox_Employee2;
    }
}