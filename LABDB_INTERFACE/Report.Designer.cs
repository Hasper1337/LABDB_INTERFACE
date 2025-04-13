namespace LABDB_INTERFACE
{
    partial class Report
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
            EmployeeReportBtn = new Button();
            OrdersReportBtn = new Button();
            ClientsReportBtn = new Button();
            SuspendLayout();
            // 
            // EmployeeReportBtn
            // 
            EmployeeReportBtn.Location = new Point(12, 21);
            EmployeeReportBtn.Name = "EmployeeReportBtn";
            EmployeeReportBtn.Size = new Size(131, 52);
            EmployeeReportBtn.TabIndex = 0;
            EmployeeReportBtn.Text = "Сотрудники";
            EmployeeReportBtn.UseVisualStyleBackColor = true;
            EmployeeReportBtn.Click += EmployeeReportBtn_Click;
            // 
            // OrdersReportBtn
            // 
            OrdersReportBtn.Location = new Point(12, 90);
            OrdersReportBtn.Name = "OrdersReportBtn";
            OrdersReportBtn.Size = new Size(131, 52);
            OrdersReportBtn.TabIndex = 1;
            OrdersReportBtn.Text = "Заказы";
            OrdersReportBtn.UseVisualStyleBackColor = true;
            OrdersReportBtn.Click += OrdersReportBtn_Click;
            // 
            // ClientsReportBtn
            // 
            ClientsReportBtn.Location = new Point(12, 159);
            ClientsReportBtn.Name = "ClientsReportBtn";
            ClientsReportBtn.Size = new Size(131, 52);
            ClientsReportBtn.TabIndex = 2;
            ClientsReportBtn.Text = "Клиенты";
            ClientsReportBtn.UseVisualStyleBackColor = true;
            ClientsReportBtn.Click += ClientsReportBtn_Click;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 256);
            Controls.Add(ClientsReportBtn);
            Controls.Add(OrdersReportBtn);
            Controls.Add(EmployeeReportBtn);
            Name = "Report";
            Text = "Генерация отчета";
            ResumeLayout(false);
        }

        #endregion

        private Button EmployeeReportBtn;
        private Button OrdersReportBtn;
        private Button ClientsReportBtn;
    }
}