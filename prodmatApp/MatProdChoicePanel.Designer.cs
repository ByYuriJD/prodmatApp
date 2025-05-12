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
            SuspendLayout();
            // 
            // buttonChoose
            // 
            buttonChoose.Dock = DockStyle.Top;
            buttonChoose.Location = new Point(8, 8);
            buttonChoose.Name = "buttonChoose";
            buttonChoose.Size = new Size(176, 34);
            buttonChoose.TabIndex = 2;
            buttonChoose.Text = "Выбрать";
            buttonChoose.UseVisualStyleBackColor = true;
            buttonChoose.Click += buttonChoose_Click;
            // 
            // MatProdChoicePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonChoose);
            Name = "MatProdChoicePanel";
            Padding = new Padding(8);
            Size = new Size(192, 111);
            Paint += MatProdChoicePanel_Paint;
            ResumeLayout(false);
        }

        #endregion
        private Button buttonChoose;
    }
}
