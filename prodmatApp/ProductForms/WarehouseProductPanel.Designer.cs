namespace prodmatApp.ProductForms
{
    partial class WarehouseProductPanel
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
            buttonMore = new Button();
            labelDate = new Label();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.White;
            buttonCancel.Dock = DockStyle.Right;
            buttonCancel.Location = new Point(293, 0);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 41);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelAmount
            // 
            labelAmount.Dock = DockStyle.Left;
            labelAmount.Location = new Point(0, 0);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(111, 41);
            labelAmount.TabIndex = 4;
            labelAmount.Text = "+999999999";
            labelAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonMore
            // 
            buttonMore.Dock = DockStyle.Right;
            buttonMore.Location = new Point(209, 0);
            buttonMore.Name = "buttonMore";
            buttonMore.Size = new Size(84, 41);
            buttonMore.TabIndex = 5;
            buttonMore.Text = "Больше";
            buttonMore.UseVisualStyleBackColor = true;
            buttonMore.Click += buttonMore_Click;
            // 
            // labelDate
            // 
            labelDate.Dock = DockStyle.Fill;
            labelDate.Location = new Point(111, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(98, 41);
            labelDate.TabIndex = 6;
            labelDate.Text = "31.12.2000";
            labelDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WarehouseProductPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelDate);
            Controls.Add(buttonMore);
            Controls.Add(labelAmount);
            Controls.Add(buttonCancel);
            Name = "WarehouseProductPanel";
            Size = new Size(387, 41);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCancel;
        private Label labelAmount;
        private Button buttonMore;
        private Label labelDate;
    }
}
