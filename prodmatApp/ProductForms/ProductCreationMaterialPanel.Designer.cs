namespace prodmatApp.ProductForms
{
    partial class ProductCreationMaterialPanel
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
            buttonRemove = new Button();
            panel1 = new Panel();
            labelName = new Label();
            numericUpDownAmount = new NumericUpDown();
            checkBoxMultiply = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // buttonRemove
            // 
            buttonRemove.Dock = DockStyle.Right;
            buttonRemove.Location = new Point(381, 8);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(38, 39);
            buttonRemove.TabIndex = 0;
            buttonRemove.Text = "X";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(numericUpDownAmount);
            panel1.Controls.Add(checkBoxMultiply);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(8, 8);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4);
            panel1.Size = new Size(373, 39);
            panel1.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.Dock = DockStyle.Fill;
            labelName.Location = new Point(4, 4);
            labelName.Name = "labelName";
            labelName.Size = new Size(127, 29);
            labelName.TabIndex = 2;
            labelName.Text = "label1";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.Dock = DockStyle.Right;
            numericUpDownAmount.Location = new Point(131, 4);
            numericUpDownAmount.Margin = new Padding(8);
            numericUpDownAmount.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDownAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(129, 27);
            numericUpDownAmount.TabIndex = 1;
            numericUpDownAmount.TextAlign = HorizontalAlignment.Right;
            numericUpDownAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // checkBoxMultiply
            // 
            checkBoxMultiply.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxMultiply.Checked = true;
            checkBoxMultiply.CheckState = CheckState.Checked;
            checkBoxMultiply.Dock = DockStyle.Right;
            checkBoxMultiply.Location = new Point(260, 4);
            checkBoxMultiply.Margin = new Padding(8);
            checkBoxMultiply.Name = "checkBoxMultiply";
            checkBoxMultiply.Size = new Size(107, 29);
            checkBoxMultiply.TabIndex = 0;
            checkBoxMultiply.Text = "Умножать";
            checkBoxMultiply.TextAlign = ContentAlignment.MiddleRight;
            checkBoxMultiply.UseVisualStyleBackColor = true;
            // 
            // ProductCreationMaterialPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(buttonRemove);
            Name = "ProductCreationMaterialPanel";
            Padding = new Padding(8);
            Size = new Size(427, 55);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRemove;
        private Panel panel1;
        private Label labelName;
        public NumericUpDown numericUpDownAmount;
        public CheckBox checkBoxMultiply;
    }
}
