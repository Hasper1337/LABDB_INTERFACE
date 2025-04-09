namespace LABDB_INTERFACE
{
    partial class updateStatusOrder
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
            updateButton = new Button();
            comboBox_status = new ComboBox();
            label_status = new Label();
            numericUpDown_idOrder = new NumericUpDown();
            label_idOrder = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_idOrder).BeginInit();
            SuspendLayout();
            // 
            // updateButton
            // 
            updateButton.Dock = DockStyle.Bottom;
            updateButton.Location = new Point(0, 111);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(353, 38);
            updateButton.TabIndex = 0;
            updateButton.Text = "Обновить статус";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // comboBox_status
            // 
            comboBox_status.FormattingEnabled = true;
            comboBox_status.Items.AddRange(new object[] { "В обработке", "Готов к выдаче", "Выдан", "Отменен" });
            comboBox_status.Location = new Point(12, 42);
            comboBox_status.Name = "comboBox_status";
            comboBox_status.Size = new Size(212, 23);
            comboBox_status.TabIndex = 1;
            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.Location = new Point(230, 45);
            label_status.Name = "label_status";
            label_status.Size = new Size(80, 15);
            label_status.TabIndex = 2;
            label_status.Text = "Статус заказа";
            // 
            // numericUpDown_idOrder
            // 
            numericUpDown_idOrder.Location = new Point(12, 12);
            numericUpDown_idOrder.Name = "numericUpDown_idOrder";
            numericUpDown_idOrder.Size = new Size(212, 23);
            numericUpDown_idOrder.TabIndex = 3;
            // 
            // label_idOrder
            // 
            label_idOrder.AutoSize = true;
            label_idOrder.Location = new Point(230, 14);
            label_idOrder.Name = "label_idOrder";
            label_idOrder.Size = new Size(55, 15);
            label_idOrder.TabIndex = 4;
            label_idOrder.Text = "ID заказа";
            // 
            // updateStatusOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 149);
            Controls.Add(label_idOrder);
            Controls.Add(numericUpDown_idOrder);
            Controls.Add(label_status);
            Controls.Add(comboBox_status);
            Controls.Add(updateButton);
            Name = "updateStatusOrder";
            Text = "Обновление статуса заказа";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_idOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateButton;
        private ComboBox comboBox_status;
        private Label label_status;
        private NumericUpDown numericUpDown_idOrder;
        private Label label_idOrder;
    }
}