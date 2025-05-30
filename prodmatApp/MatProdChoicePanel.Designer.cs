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
            panelBorder = new Panel();
            panelBack = new Panel();
            labelAmount = new Label();
            buttonChoose = new Button();
            panelBorder.SuspendLayout();
            panelBack.SuspendLayout();
            SuspendLayout();
            // 
            // panelBorder
            // 
            panelBorder.Controls.Add(panelBack);
            panelBorder.Dock = DockStyle.Fill;
            panelBorder.Location = new Point(4, 4);
            panelBorder.Name = "panelBorder";
            panelBorder.Padding = new Padding(2);
            panelBorder.Size = new Size(212, 103);
            panelBorder.TabIndex = 0;
            // 
            // panelBack
            // 
            panelBack.Controls.Add(labelAmount);
            panelBack.Controls.Add(buttonChoose);
            panelBack.Dock = DockStyle.Fill;
            panelBack.Location = new Point(2, 2);
            panelBack.Name = "panelBack";
            panelBack.Padding = new Padding(8);
            panelBack.Size = new Size(208, 99);
            panelBack.TabIndex = 0;
            // 
            // labelAmount
            // 
            labelAmount.BackColor = Color.Transparent;
            labelAmount.Dock = DockStyle.Fill;
            labelAmount.Font = new Font("Segoe UI", 8F);
            labelAmount.Location = new Point(8, 51);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(192, 40);
            labelAmount.TabIndex = 5;
            labelAmount.Text = "label1";
            labelAmount.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonChoose
            // 
            buttonChoose.Dock = DockStyle.Top;
            buttonChoose.Font = new Font("Segoe UI", 7F);
            buttonChoose.Location = new Point(8, 8);
            buttonChoose.Name = "buttonChoose";
            buttonChoose.Size = new Size(192, 43);
            buttonChoose.TabIndex = 4;
            buttonChoose.Text = "Выбрать";
            buttonChoose.UseVisualStyleBackColor = true;
            buttonChoose.Click += buttonChoose_Click;
            // 
            // MatProdChoicePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBorder);
            Name = "MatProdChoicePanel";
            Padding = new Padding(4);
            Size = new Size(220, 111);
            panelBorder.ResumeLayout(false);
            panelBack.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBorder;
        private Panel panelBack;
        private Label labelAmount;
        private Button buttonChoose;
    }
}
