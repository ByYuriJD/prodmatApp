namespace prodmatApp
{
    partial class FormSelectedMaterial
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
            panelBottom = new Panel();
            buttonEdit = new Button();
            buttonHistory = new Button();
            buttonBack = new Button();
            panelAdd = new Panel();
            numericUpDownAdd = new NumericUpDown();
            buttonAdd = new Button();
            panelUse = new Panel();
            buttonUse = new Button();
            panel1 = new Panel();
            labelAmount = new Label();
            labelName = new Label();
            panelBottom.SuspendLayout();
            panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAdd).BeginInit();
            panelUse.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonEdit);
            panelBottom.Controls.Add(buttonHistory);
            panelBottom.Controls.Add(buttonBack);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 317);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(8);
            panelBottom.Size = new Size(400, 68);
            panelBottom.TabIndex = 0;
            // 
            // buttonEdit
            // 
            buttonEdit.Dock = DockStyle.Fill;
            buttonEdit.Location = new Point(102, 8);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(185, 52);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonHistory
            // 
            buttonHistory.Dock = DockStyle.Left;
            buttonHistory.Location = new Point(8, 8);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Size = new Size(94, 52);
            buttonHistory.TabIndex = 1;
            buttonHistory.Text = "История";
            buttonHistory.UseVisualStyleBackColor = true;
            buttonHistory.Click += buttonHistory_Click;
            // 
            // buttonBack
            // 
            buttonBack.DialogResult = DialogResult.Cancel;
            buttonBack.Dock = DockStyle.Right;
            buttonBack.Location = new Point(287, 8);
            buttonBack.Margin = new Padding(10);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(105, 52);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // panelAdd
            // 
            panelAdd.Controls.Add(numericUpDownAdd);
            panelAdd.Controls.Add(buttonAdd);
            panelAdd.Dock = DockStyle.Bottom;
            panelAdd.Location = new Point(0, 273);
            panelAdd.Name = "panelAdd";
            panelAdd.Padding = new Padding(8, 4, 8, 4);
            panelAdd.Size = new Size(400, 44);
            panelAdd.TabIndex = 1;
            // 
            // numericUpDownAdd
            // 
            numericUpDownAdd.Dock = DockStyle.Fill;
            numericUpDownAdd.Location = new Point(8, 4);
            numericUpDownAdd.Margin = new Padding(5);
            numericUpDownAdd.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDownAdd.Name = "numericUpDownAdd";
            numericUpDownAdd.Size = new Size(279, 27);
            numericUpDownAdd.TabIndex = 1;
            numericUpDownAdd.TextAlign = HorizontalAlignment.Right;
            numericUpDownAdd.ThousandsSeparator = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Right;
            buttonAdd.Location = new Point(287, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(105, 36);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panelUse
            // 
            panelUse.Controls.Add(buttonUse);
            panelUse.Dock = DockStyle.Bottom;
            panelUse.Location = new Point(0, 224);
            panelUse.Name = "panelUse";
            panelUse.Padding = new Padding(12, 4, 12, 4);
            panelUse.Size = new Size(400, 49);
            panelUse.TabIndex = 2;
            // 
            // buttonUse
            // 
            buttonUse.Dock = DockStyle.Fill;
            buttonUse.Location = new Point(12, 4);
            buttonUse.Name = "buttonUse";
            buttonUse.Size = new Size(376, 41);
            buttonUse.TabIndex = 0;
            buttonUse.Text = "Расходовать";
            buttonUse.UseVisualStyleBackColor = true;
            buttonUse.Click += buttonUse_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelAmount);
            panel1.Controls.Add(labelName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12);
            panel1.Size = new Size(400, 224);
            panel1.TabIndex = 3;
            // 
            // labelAmount
            // 
            labelAmount.Dock = DockStyle.Fill;
            labelAmount.Location = new Point(12, 52);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(376, 160);
            labelAmount.TabIndex = 1;
            labelAmount.Text = "label2";
            labelAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            labelName.Dock = DockStyle.Top;
            labelName.Location = new Point(12, 12);
            labelName.Name = "labelName";
            labelName.Size = new Size(376, 40);
            labelName.TabIndex = 0;
            labelName.Text = "label1";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormSelectedMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 385);
            Controls.Add(panel1);
            Controls.Add(panelUse);
            Controls.Add(panelAdd);
            Controls.Add(panelBottom);
            Name = "FormSelectedMaterial";
            Text = "Материал";
            panelBottom.ResumeLayout(false);
            panelAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownAdd).EndInit();
            panelUse.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBottom;
        private Button buttonEdit;
        private Button buttonHistory;
        private Button buttonBack;
        private Panel panelAdd;
        private NumericUpDown numericUpDownAdd;
        private Button buttonAdd;
        private Panel panelUse;
        private Button buttonUse;
        private Panel panel1;
        private Label labelAmount;
        private Label labelName;
    }
}