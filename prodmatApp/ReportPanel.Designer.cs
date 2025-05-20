namespace prodmatApp
{
    partial class ReportPanel
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
            labelAmount = new Label();
            labelName = new Label();
            SuspendLayout();
            // 
            // labelAmount
            // 
            labelAmount.Dock = DockStyle.Right;
            labelAmount.Location = new Point(194, 8);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(118, 31);
            labelAmount.TabIndex = 0;
            labelAmount.Text = "label1";
            labelAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelName
            // 
            labelName.Dock = DockStyle.Fill;
            labelName.Location = new Point(8, 8);
            labelName.Name = "labelName";
            labelName.Size = new Size(186, 31);
            labelName.TabIndex = 1;
            labelName.Text = "label1";
            labelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ReportPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(labelName);
            Controls.Add(labelAmount);
            Name = "ReportPanel";
            Padding = new Padding(8);
            Size = new Size(320, 47);
            ResumeLayout(false);
        }

        #endregion

        private Label labelAmount;
        private Label labelName;
    }
}
