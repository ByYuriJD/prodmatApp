namespace prodmatApp.ProductForms
{
    partial class FormUseMaterial
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
            buttonBack = new Button();
            buttonNoProduct = new Button();
            numericUpDown1 = new NumericUpDown();
            panel1 = new Panel();
            labelName = new Label();
            buttonWithProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.DialogResult = DialogResult.Cancel;
            buttonBack.Dock = DockStyle.Bottom;
            buttonBack.Location = new Point(8, 117);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(346, 38);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonNoProduct
            // 
            buttonNoProduct.DialogResult = DialogResult.OK;
            buttonNoProduct.Dock = DockStyle.Bottom;
            buttonNoProduct.Location = new Point(8, 79);
            buttonNoProduct.Name = "buttonNoProduct";
            buttonNoProduct.Size = new Size(346, 38);
            buttonNoProduct.TabIndex = 2;
            buttonNoProduct.Text = "Расходовать без продукции";
            buttonNoProduct.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Dock = DockStyle.Right;
            numericUpDown1.Location = new Point(200, 0);
            numericUpDown1.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(146, 27);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel1
            // 
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(numericUpDown1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(8, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 31);
            panel1.TabIndex = 5;
            // 
            // labelName
            // 
            labelName.Dock = DockStyle.Fill;
            labelName.Location = new Point(0, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(200, 31);
            labelName.TabIndex = 5;
            labelName.Text = "aaaaaaaaaaaaaaaaaaaaaa";
            labelName.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonWithProduct
            // 
            buttonWithProduct.Dock = DockStyle.Bottom;
            buttonWithProduct.Location = new Point(8, 41);
            buttonWithProduct.Name = "buttonWithProduct";
            buttonWithProduct.Size = new Size(346, 38);
            buttonWithProduct.TabIndex = 6;
            buttonWithProduct.Text = "Выбрать продукцию";
            buttonWithProduct.UseVisualStyleBackColor = true;
            buttonWithProduct.Click += buttonWithProduct_Click;
            // 
            // FormUseMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(362, 163);
            Controls.Add(buttonWithProduct);
            Controls.Add(panel1);
            Controls.Add(buttonNoProduct);
            Controls.Add(buttonBack);
            MinimumSize = new Size(380, 210);
            Name = "FormUseMaterial";
            Padding = new Padding(8);
            Text = "Расходавание материала";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button buttonBack;
        private Button buttonNoProduct;
        private Panel panel1;
        private Label labelName;
        private Button buttonWithProduct;
        public NumericUpDown numericUpDown1;
    }
}