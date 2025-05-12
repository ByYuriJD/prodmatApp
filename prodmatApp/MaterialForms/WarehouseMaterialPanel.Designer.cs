namespace prodmatApp
{
    partial class WarehouseMaterialPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCancel = new Button();
            labelAmount = new Label();
            labelDate = new Label();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Dock = DockStyle.Right;
            buttonCancel.Location = new Point(207, 8);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 36);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelAmount
            // 
            labelAmount.Dock = DockStyle.Left;
            labelAmount.Location = new Point(8, 8);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(111, 36);
            labelAmount.TabIndex = 1;
            labelAmount.Text = "+999999999";
            labelAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDate
            // 
            labelDate.Dock = DockStyle.Fill;
            labelDate.Location = new Point(119, 8);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(88, 36);
            labelDate.TabIndex = 2;
            labelDate.Text = "31.12.2000";
            labelDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WarehouseMaterialPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelDate);
            Controls.Add(labelAmount);
            Controls.Add(buttonCancel);
            Name = "WarehouseMaterialPanel";
            Padding = new Padding(8);
            Size = new Size(309, 52);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCancel;
        private Label labelAmount;
        private Label labelDate;
    }
}
