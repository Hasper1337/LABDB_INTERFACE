namespace LABDB_INTERFACE
{
    partial class addService
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
            label_role = new Label();
            addButton_service = new Button();
            label_description = new Label();
            label_ServiceName = new Label();
            textBox_description = new TextBox();
            textBox_firstname = new TextBox();
            numericUpDown_price = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_price).BeginInit();
            SuspendLayout();
            // 
            // label_role
            // 
            label_role.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_role.AutoSize = true;
            label_role.Location = new Point(178, 90);
            label_role.Name = "label_role";
            label_role.Size = new Size(107, 15);
            label_role.TabIndex = 43;
            label_role.Text = "Стоимость услуги";
            // 
            // addButton_service
            // 
            addButton_service.Cursor = Cursors.Hand;
            addButton_service.Dock = DockStyle.Bottom;
            addButton_service.Location = new Point(0, 130);
            addButton_service.Name = "addButton_service";
            addButton_service.Size = new Size(302, 63);
            addButton_service.TabIndex = 41;
            addButton_service.Text = "Добавить данные";
            addButton_service.UseVisualStyleBackColor = true;
            addButton_service.Click += addButton_service_Click;
            // 
            // label_description
            // 
            label_description.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_description.AutoSize = true;
            label_description.Location = new Point(178, 51);
            label_description.Name = "label_description";
            label_description.Size = new Size(62, 15);
            label_description.TabIndex = 38;
            label_description.Text = "Описание";
            // 
            // label_ServiceName
            // 
            label_ServiceName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_ServiceName.AutoSize = true;
            label_ServiceName.Location = new Point(178, 9);
            label_ServiceName.Name = "label_ServiceName";
            label_ServiceName.Size = new Size(99, 15);
            label_ServiceName.TabIndex = 37;
            label_ServiceName.Text = "Название услуги";
            // 
            // textBox_description
            // 
            textBox_description.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_description.Location = new Point(12, 48);
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(162, 23);
            textBox_description.TabIndex = 36;
            // 
            // textBox_firstname
            // 
            textBox_firstname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_firstname.Location = new Point(12, 6);
            textBox_firstname.Name = "textBox_firstname";
            textBox_firstname.Size = new Size(162, 23);
            textBox_firstname.TabIndex = 35;
            // 
            // numericUpDown_price
            // 
            numericUpDown_price.Location = new Point(12, 88);
            numericUpDown_price.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            numericUpDown_price.Name = "numericUpDown_price";
            numericUpDown_price.Size = new Size(162, 23);
            numericUpDown_price.TabIndex = 45;
            // 
            // addService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 193);
            Controls.Add(numericUpDown_price);
            Controls.Add(label_role);
            Controls.Add(addButton_service);
            Controls.Add(label_description);
            Controls.Add(label_ServiceName);
            Controls.Add(textBox_description);
            Controls.Add(textBox_firstname);
            Name = "addService";
            Text = "Добавление услуги";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_price).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox_passportdata;
        private Label label_role;
        private Button addButton_service;
        private Label label_passportdata;
        private Label label_phone;
        private Label label_description;
        private Label label_ServiceName;
        private TextBox textBox_description;
        private TextBox textBox_firstname;
        private MaskedTextBox maskedTextBox_phone;
        private NumericUpDown numericUpDown_price;
    }
}