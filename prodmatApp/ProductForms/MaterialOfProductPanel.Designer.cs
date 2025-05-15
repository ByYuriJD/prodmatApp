namespace prodmatApp
{
    partial class MaterialOfProductPanel
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
            labelAmount.Location = new Point(154, 8);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(146, 24);
            labelAmount.TabIndex = 0;
            labelAmount.Text = "label1";
            labelAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            labelName.Dock = DockStyle.Fill;
            labelName.Location = new Point(8, 8);
            labelName.Name = "labelName";
            labelName.Size = new Size(146, 24);
            labelName.TabIndex = 1;
            labelName.Text = "label1";
            labelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MaterialOfProductPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelName);
            Controls.Add(labelAmount);
            Name = "MaterialOfProductPanel";
            Padding = new Padding(8);
            Size = new Size(308, 40);
            ResumeLayout(false);
        }

        #endregion

        private Label labelAmount;
        private Label labelName;
    }
}
