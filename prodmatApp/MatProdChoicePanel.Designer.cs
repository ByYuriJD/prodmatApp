namespace prodmatApp
{
    partial class MatProdChoicePanel
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
            buttonChoose = new Button();
            labelAmount = new Label();
            SuspendLayout();
            // 
            // buttonChoose
            // 
            buttonChoose.Dock = DockStyle.Top;
            buttonChoose.Font = new Font("Segoe UI", 7F);
            buttonChoose.Location = new Point(8, 8);
            buttonChoose.Name = "buttonChoose";
            buttonChoose.Size = new Size(204, 34);
            buttonChoose.TabIndex = 2;
            buttonChoose.Text = "Выбрать";
            buttonChoose.UseVisualStyleBackColor = true;
            buttonChoose.Click += buttonChoose_Click;
            // 
            // labelAmount
            // 
            labelAmount.Dock = DockStyle.Fill;
            labelAmount.Location = new Point(8, 42);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(204, 61);
            labelAmount.TabIndex = 3;
            labelAmount.Text = "label1";
            labelAmount.TextAlign = ContentAlignment.TopCenter;
            // 
            // MatProdChoicePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelAmount);
            Controls.Add(buttonChoose);
            Name = "MatProdChoicePanel";
            Padding = new Padding(8);
            Size = new Size(220, 111);
            Paint += MatProdChoicePanel_Paint;
            ResumeLayout(false);
        }

        #endregion
        private Button buttonChoose;
        private Label labelAmount;
    }
}
