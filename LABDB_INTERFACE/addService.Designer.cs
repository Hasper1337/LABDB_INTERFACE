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
            addButton_client = new Button();
            label_description = new Label();
            label_ServiceName = new Label();
            textBox_description = new TextBox();
            textBox_firstname = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
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
            // addButton_client
            // 
            addButton_client.Cursor = Cursors.Hand;
            addButton_client.Dock = DockStyle.Bottom;
            addButton_client.Location = new Point(0, 130);
            addButton_client.Name = "addButton_client";
            addButton_client.Size = new Size(302, 63);
            addButton_client.TabIndex = 41;
            addButton_client.Text = "Добавить данные";
            addButton_client.UseVisualStyleBackColor = true;
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
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(12, 87);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(160, 23);
            maskedTextBox1.TabIndex = 44;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // addService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 193);
            Controls.Add(maskedTextBox1);
            Controls.Add(label_role);
            Controls.Add(addButton_client);
            Controls.Add(label_description);
            Controls.Add(label_ServiceName);
            Controls.Add(textBox_description);
            Controls.Add(textBox_firstname);
            Name = "addService";
            Text = "Добавление услуги";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox_passportdata;
        private Label label_role;
        private Button addButton_client;
        private Label label_passportdata;
        private Label label_phone;
        private Label label_description;
        private Label label_ServiceName;
        private TextBox textBox_description;
        private TextBox textBox_firstname;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox_phone;
    }
}