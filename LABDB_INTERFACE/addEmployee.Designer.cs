namespace LABDB_INTERFACE
{
    partial class addEmployee
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
            label_passportdata = new Label();
            label_phone = new Label();
            label_lastname = new Label();
            label_firstname = new Label();
            textBox_lastname = new TextBox();
            textBox_firstname = new TextBox();
            maskedTextBox_phone = new MaskedTextBox();
            addButton_client = new Button();
            textBox_role = new TextBox();
            label_role = new Label();
            maskedTextBox_passportdata = new MaskedTextBox();
            SuspendLayout();
            // 
            // label_passportdata
            // 
            label_passportdata.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_passportdata.AutoSize = true;
            label_passportdata.Location = new Point(176, 175);
            label_passportdata.Name = "label_passportdata";
            label_passportdata.Size = new Size(120, 15);
            label_passportdata.TabIndex = 29;
            label_passportdata.Text = "Паспортные данные";
            label_passportdata.Click += label_address_Click;
            // 
            // label_phone
            // 
            label_phone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_phone.AutoSize = true;
            label_phone.Location = new Point(178, 137);
            label_phone.Name = "label_phone";
            label_phone.Size = new Size(101, 15);
            label_phone.TabIndex = 27;
            label_phone.Text = "Номер телефона";
            // 
            // label_lastname
            // 
            label_lastname.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_lastname.AutoSize = true;
            label_lastname.Location = new Point(178, 57);
            label_lastname.Name = "label_lastname";
            label_lastname.Size = new Size(58, 15);
            label_lastname.TabIndex = 26;
            label_lastname.Text = "Фамилия";
            // 
            // label_firstname
            // 
            label_firstname.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_firstname.AutoSize = true;
            label_firstname.Location = new Point(178, 15);
            label_firstname.Name = "label_firstname";
            label_firstname.Size = new Size(31, 15);
            label_firstname.TabIndex = 25;
            label_firstname.Text = "Имя";
            // 
            // textBox_lastname
            // 
            textBox_lastname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_lastname.Location = new Point(12, 54);
            textBox_lastname.Name = "textBox_lastname";
            textBox_lastname.Size = new Size(162, 23);
            textBox_lastname.TabIndex = 22;
            // 
            // textBox_firstname
            // 
            textBox_firstname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_firstname.Location = new Point(12, 12);
            textBox_firstname.Name = "textBox_firstname";
            textBox_firstname.Size = new Size(162, 23);
            textBox_firstname.TabIndex = 21;
            // 
            // maskedTextBox_phone
            // 
            maskedTextBox_phone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox_phone.Location = new Point(12, 134);
            maskedTextBox_phone.Mask = "7 (000) 000-00-00";
            maskedTextBox_phone.Name = "maskedTextBox_phone";
            maskedTextBox_phone.Size = new Size(162, 23);
            maskedTextBox_phone.TabIndex = 20;
            // 
            // addButton_client
            // 
            addButton_client.Cursor = Cursors.Hand;
            addButton_client.Dock = DockStyle.Bottom;
            addButton_client.Location = new Point(0, 234);
            addButton_client.Name = "addButton_client";
            addButton_client.Size = new Size(302, 63);
            addButton_client.TabIndex = 30;
            addButton_client.Text = "Добавить данные";
            addButton_client.UseVisualStyleBackColor = true;
            // 
            // textBox_role
            // 
            textBox_role.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_role.Location = new Point(12, 93);
            textBox_role.Name = "textBox_role";
            textBox_role.Size = new Size(162, 23);
            textBox_role.TabIndex = 31;
            // 
            // label_role
            // 
            label_role.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_role.AutoSize = true;
            label_role.Location = new Point(178, 96);
            label_role.Name = "label_role";
            label_role.Size = new Size(69, 15);
            label_role.TabIndex = 32;
            label_role.Text = "Должность";
            // 
            // maskedTextBox_passportdata
            // 
            maskedTextBox_passportdata.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox_passportdata.Location = new Point(12, 172);
            maskedTextBox_passportdata.Mask = "____ ______";
            maskedTextBox_passportdata.Name = "maskedTextBox_passportdata";
            maskedTextBox_passportdata.Size = new Size(162, 23);
            maskedTextBox_passportdata.TabIndex = 33;
            // 
            // addEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 297);
            Controls.Add(maskedTextBox_passportdata);
            Controls.Add(label_role);
            Controls.Add(textBox_role);
            Controls.Add(addButton_client);
            Controls.Add(label_passportdata);
            Controls.Add(label_phone);
            Controls.Add(label_lastname);
            Controls.Add(label_firstname);
            Controls.Add(textBox_lastname);
            Controls.Add(textBox_firstname);
            Controls.Add(maskedTextBox_phone);
            Name = "addEmployee";
            Text = "Добавить сотрудника";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_passportdata;
        private Label label_phone;
        private Label label_lastname;
        private Label label_firstname;
        private TextBox textBox_lastname;
        private TextBox textBox_firstname;
        private MaskedTextBox maskedTextBox_phone;
        private Button addButton_client;
        private TextBox textBox_role;
        private Label label_role;
        private MaskedTextBox maskedTextBox_passportdata;
    }
}