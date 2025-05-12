namespace prodmatApp.ProductForms
{
    partial class FormProductCreation
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
            panelTop = new Panel();
            numericUpDown1 = new NumericUpDown();
            labelProductName = new Label();
            panelBottom = new Panel();
            buttonOk = new Button();
            buttonBack = new Button();
            panelAdd = new Panel();
            buttonAdd = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panelBottom.SuspendLayout();
            panelAdd.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(numericUpDown1);
            panelTop.Controls.Add(labelProductName);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(8);
            panelTop.Size = new Size(399, 43);
            panelTop.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Dock = DockStyle.Fill;
            numericUpDown1.Location = new Point(188, 8);
            numericUpDown1.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(203, 27);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelProductName
            // 
            labelProductName.Dock = DockStyle.Left;
            labelProductName.Location = new Point(8, 8);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(180, 27);
            labelProductName.TabIndex = 0;
            labelProductName.Text = "label1";
            labelProductName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonOk);
            panelBottom.Controls.Add(buttonBack);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 392);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(8);
            panelBottom.Size = new Size(399, 58);
            panelBottom.TabIndex = 1;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Dock = DockStyle.Fill;
            buttonOk.Location = new Point(8, 8);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(240, 42);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "Подтвердить выбор";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.DialogResult = DialogResult.Cancel;
            buttonBack.Dock = DockStyle.Right;
            buttonBack.Location = new Point(248, 8);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(143, 42);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // panelAdd
            // 
            panelAdd.Controls.Add(buttonAdd);
            panelAdd.Dock = DockStyle.Bottom;
            panelAdd.Location = new Point(0, 331);
            panelAdd.Name = "panelAdd";
            panelAdd.Padding = new Padding(16, 8, 16, 8);
            panelAdd.Size = new Size(399, 61);
            panelAdd.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Location = new Point(16, 8);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(367, 45);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить материал";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoScroll = true;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 43);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(8);
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(399, 288);
            tableLayoutPanel.TabIndex = 4;
            // 
            // FormProductCreation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 450);
            Controls.Add(tableLayoutPanel);
            Controls.Add(panelAdd);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Name = "FormProductCreation";
            Text = "Создание продукции";
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panelBottom.ResumeLayout(false);
            panelAdd.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelProductName;
        private Panel panelBottom;
        private Button buttonOk;
        private Button buttonBack;
        private Panel panelAdd;
        private TableLayoutPanel tableLayoutPanel;
        private Button buttonAdd;
        public NumericUpDown numericUpDown1;
    }
}