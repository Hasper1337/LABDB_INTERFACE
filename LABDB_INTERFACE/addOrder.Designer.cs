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
            maskedTextBox1 = new MaskedTextBox();
            groupBox1 = new GroupBox();
            checkBox_Product_lining = new CheckBox();
            label_Product_typeProduct = new Label();
            label_Product_features = new Label();
            label_Product_color = new Label();
            label_Product_typeCloath = new Label();
            textBox_Product_typeProduct = new TextBox();
            textBox_Product_features = new TextBox();
            textBox_Product_color = new TextBox();
            textBox_typeCloath = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_idClient).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // addButton_order
            // 
            addButton_order.Cursor = Cursors.Hand;
            addButton_order.Dock = DockStyle.Bottom;
            addButton_order.Location = new Point(0, 338);
            addButton_order.Name = "addButton_order";
            addButton_order.Size = new Size(302, 63);
            addButton_order.TabIndex = 41;
            addButton_order.Text = "Добавить данные";
            addButton_order.UseVisualStyleBackColor = true;
            addButton_order.Click += addButton_order_Click;
            // 
            // label_pickupDate
            // 
            label_pickupDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_pickupDate.AutoSize = true;
            label_pickupDate.Location = new Point(178, 51);
            label_pickupDate.Name = "label_pickupDate";
            label_pickupDate.Size = new Size(77, 15);
            label_pickupDate.TabIndex = 38;
            label_pickupDate.Text = "Дата приема";
            // 
            // label_idClient_forOrder
            // 
            label_idClient_forOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_idClient_forOrder.AutoSize = true;
            label_idClient_forOrder.Location = new Point(178, 9);
            label_idClient_forOrder.Name = "label_idClient_forOrder";
            label_idClient_forOrder.Size = new Size(66, 15);
            label_idClient_forOrder.TabIndex = 37;
            label_idClient_forOrder.Text = "ID Клиента";
            // 
            // numericUpDown_idClient
            // 
            numericUpDown_idClient.Location = new Point(12, 7);
            numericUpDown_idClient.Name = "numericUpDown_idClient";
            numericUpDown_idClient.Size = new Size(162, 23);
            numericUpDown_idClient.TabIndex = 45;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(12, 48);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(162, 23);
            maskedTextBox1.TabIndex = 46;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox_Product_lining);
            groupBox1.Controls.Add(label_Product_typeProduct);
            groupBox1.Controls.Add(label_Product_features);
            groupBox1.Controls.Add(label_Product_color);
            groupBox1.Controls.Add(label_Product_typeCloath);
            groupBox1.Controls.Add(textBox_Product_typeProduct);
            groupBox1.Controls.Add(textBox_Product_features);
            groupBox1.Controls.Add(textBox_Product_color);
            groupBox1.Controls.Add(textBox_typeCloath);
            groupBox1.Location = new Point(12, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 234);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            groupBox1.Text = "Данные изделия";
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
            // addOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 401);
            Controls.Add(groupBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(numericUpDown_idClient);
            Controls.Add(addButton_order);
            Controls.Add(label_pickupDate);
            Controls.Add(label_idClient_forOrder);
            Name = "addOrder";
            Text = "addOrder";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_idClient).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addButton_order;
        private Label label_pickupDate;
        private Label label_idClient_forOrder;
        private NumericUpDown numericUpDown_idClient;
        private MaskedTextBox maskedTextBox1;
        private GroupBox groupBox1;
        private Label label_Product_typeCloath;
        private TextBox textBox_Product_typeProduct;
        private TextBox textBox_Product_features;
        private TextBox textBox_Product_color;
        private TextBox textBox_typeCloath;
        private Label label_Product_typeProduct;
        private Label label_Product_features;
        private Label label_Product_color;
        private CheckBox checkBox_Product_lining;
    }
}