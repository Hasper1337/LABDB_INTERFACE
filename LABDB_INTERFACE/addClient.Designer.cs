namespace LABDB_INTERFACE
{
    partial class addClient
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
            maskedTextBox_phone = new MaskedTextBox();
            textBox_firstname = new TextBox();
            textBox_lastname = new TextBox();
            maskedTextBox_email = new MaskedTextBox();
            textBox_address = new TextBox();
            label_firstname = new Label();
            label_lastname = new Label();
            label_phone = new Label();
            label_mail = new Label();
            label_address = new Label();
            addButton_client = new Button();
            SuspendLayout();
            // 
            // maskedTextBox_phone
            // 
            maskedTextBox_phone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox_phone.Location = new Point(12, 97);
            maskedTextBox_phone.Mask = "7 (000) 000-00-00";
            maskedTextBox_phone.Name = "maskedTextBox_phone";
            maskedTextBox_phone.Size = new Size(145, 23);
            maskedTextBox_phone.TabIndex = 0;
            // 
            // textBox_firstname
            // 
            textBox_firstname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_firstname.Location = new Point(12, 12);
            textBox_firstname.Name = "textBox_firstname";
            textBox_firstname.Size = new Size(145, 23);
            textBox_firstname.TabIndex = 1;
            textBox_firstname.TextChanged += textBox_firstname_TextChanged;
            // 
            // textBox_lastname
            // 
            textBox_lastname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_lastname.Location = new Point(12, 54);
            textBox_lastname.Name = "textBox_lastname";
            textBox_lastname.Size = new Size(145, 23);
            textBox_lastname.TabIndex = 2;
            // 
            // maskedTextBox_email
            // 
            maskedTextBox_email.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox_email.Location = new Point(12, 141);
            maskedTextBox_email.Name = "maskedTextBox_email";
            maskedTextBox_email.Size = new Size(145, 23);
            maskedTextBox_email.TabIndex = 3;
            // 
            // textBox_address
            // 
            textBox_address.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_address.Location = new Point(12, 182);
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(145, 23);
            textBox_address.TabIndex = 4;
            // 
            // label_firstname
            // 
            label_firstname.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_firstname.AutoSize = true;
            label_firstname.Location = new Point(161, 15);
            label_firstname.Name = "label_firstname";
            label_firstname.Size = new Size(31, 15);
            label_firstname.TabIndex = 5;
            label_firstname.Text = "Имя";
            // 
            // label_lastname
            // 
            label_lastname.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_lastname.AutoSize = true;
            label_lastname.Location = new Point(161, 57);
            label_lastname.Name = "label_lastname";
            label_lastname.Size = new Size(58, 15);
            label_lastname.TabIndex = 6;
            label_lastname.Text = "Фамилия";
            label_lastname.Click += label_lastname_Click;
            // 
            // label_phone
            // 
            label_phone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_phone.AutoSize = true;
            label_phone.Location = new Point(161, 100);
            label_phone.Name = "label_phone";
            label_phone.Size = new Size(101, 15);
            label_phone.TabIndex = 7;
            label_phone.Text = "Номер телефона";
            // 
            // label_mail
            // 
            label_mail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_mail.AutoSize = true;
            label_mail.Location = new Point(161, 144);
            label_mail.Name = "label_mail";
            label_mail.Size = new Size(41, 15);
            label_mail.TabIndex = 8;
            label_mail.Text = "Почта";
            // 
            // label_address
            // 
            label_address.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label_address.AutoSize = true;
            label_address.Location = new Point(159, 185);
            label_address.Name = "label_address";
            label_address.Size = new Size(40, 15);
            label_address.TabIndex = 9;
            label_address.Text = "Адрес";
            // 
            // addButton_client
            // 
            addButton_client.Cursor = Cursors.Hand;
            addButton_client.Dock = DockStyle.Bottom;
            addButton_client.Location = new Point(0, 234);
            addButton_client.Name = "addButton_client";
            addButton_client.Size = new Size(302, 63);
            addButton_client.TabIndex = 10;
            addButton_client.Text = "Добавить данные";
            addButton_client.UseVisualStyleBackColor = true;
            addButton_client.Click += addButton_client_Click;
            // 
            // addClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 297);
            Controls.Add(addButton_client);
            Controls.Add(label_address);
            Controls.Add(label_mail);
            Controls.Add(label_phone);
            Controls.Add(label_lastname);
            Controls.Add(label_firstname);
            Controls.Add(textBox_address);
            Controls.Add(maskedTextBox_email);
            Controls.Add(textBox_lastname);
            Controls.Add(textBox_firstname);
            Controls.Add(maskedTextBox_phone);
            Name = "addClient";
            Text = "Добавить клиента";
            Load += addClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox_phone;
        private TextBox textBox_firstname;
        private TextBox textBox_lastname;
        private MaskedTextBox maskedTextBox_email;
        private TextBox textBox_address;
        private Label label_firstname;
        private Label label_lastname;
        private Label label_phone;
        private Label label_mail;
        private Label label_address;
        private Button addButton_client;
    }
}