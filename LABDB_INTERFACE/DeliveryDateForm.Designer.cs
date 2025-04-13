namespace LABDB_INTERFACE
{
    partial class DeliveryDateForm
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
            datePicker = new DateTimePicker();
            btnSave = new Button();
            lblOrderId = new Label();
            SuspendLayout();
            // 
            // datePicker
            // 
            datePicker.Location = new Point(12, 50);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Bottom;
            btnSave.Location = new Point(0, 89);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(231, 47);
            btnSave.TabIndex = 1;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Location = new Point(12, 9);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(38, 15);
            lblOrderId.TabIndex = 2;
            lblOrderId.Text = "label1";
            // 
            // DeliveryDateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 136);
            Controls.Add(lblOrderId);
            Controls.Add(btnSave);
            Controls.Add(datePicker);
            Name = "DeliveryDateForm";
            Text = "Дата выдачи";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker datePicker;
        private Button btnSave;
        private Label lblOrderId;
    }
}