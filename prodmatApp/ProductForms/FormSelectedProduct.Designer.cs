namespace prodmatApp
{
    partial class FormSelectedProduct
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
            labelName = new Label();
            panelBottom = new Panel();
            buttonEdit = new Button();
            buttonHistory = new Button();
            buttonBack = new Button();
            panelUse = new Panel();
            buttonAdd = new Button();
            panelAdd = new Panel();
            numericUpDownUse = new NumericUpDown();
            buttonUse = new Button();
            labelAmount = new Label();
            panelBottom.SuspendLayout();
            panelUse.SuspendLayout();
            panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUse).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.Dock = DockStyle.Top;
            labelName.Location = new Point(0, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(390, 40);
            labelName.TabIndex = 1;
            labelName.Text = "label1";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonEdit);
            panelBottom.Controls.Add(buttonHistory);
            panelBottom.Controls.Add(buttonBack);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 320);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(8);
            panelBottom.Size = new Size(390, 68);
            panelBottom.TabIndex = 2;
            // 
            // buttonEdit
            // 
            buttonEdit.Dock = DockStyle.Fill;
            buttonEdit.Location = new Point(102, 8);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(175, 52);
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
            // 
            // buttonBack
            // 
            buttonBack.DialogResult = DialogResult.Cancel;
            buttonBack.Dock = DockStyle.Right;
            buttonBack.Location = new Point(277, 8);
            buttonBack.Margin = new Padding(10);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(105, 52);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // panelUse
            // 
            panelUse.Controls.Add(buttonAdd);
            panelUse.Dock = DockStyle.Bottom;
            panelUse.Location = new Point(0, 271);
            panelUse.Name = "panelUse";
            panelUse.Padding = new Padding(12, 4, 12, 4);
            panelUse.Size = new Size(390, 49);
            panelUse.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Location = new Point(12, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(366, 41);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panelAdd
            // 
            panelAdd.Controls.Add(numericUpDownUse);
            panelAdd.Controls.Add(buttonUse);
            panelAdd.Dock = DockStyle.Bottom;
            panelAdd.Location = new Point(0, 227);
            panelAdd.Name = "panelAdd";
            panelAdd.Padding = new Padding(8, 4, 8, 4);
            panelAdd.Size = new Size(390, 44);
            panelAdd.TabIndex = 4;
            // 
            // numericUpDownUse
            // 
            numericUpDownUse.Dock = DockStyle.Fill;
            numericUpDownUse.Location = new Point(8, 4);
            numericUpDownUse.Margin = new Padding(5);
            numericUpDownUse.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDownUse.Name = "numericUpDownUse";
            numericUpDownUse.Size = new Size(269, 27);
            numericUpDownUse.TabIndex = 1;
            numericUpDownUse.TextAlign = HorizontalAlignment.Right;
            numericUpDownUse.ThousandsSeparator = true;
            numericUpDownUse.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonUse
            // 
            buttonUse.Dock = DockStyle.Right;
            buttonUse.Location = new Point(277, 4);
            buttonUse.Name = "buttonUse";
            buttonUse.Size = new Size(105, 36);
            buttonUse.TabIndex = 0;
            buttonUse.Text = "Расходовать";
            buttonUse.UseVisualStyleBackColor = true;
            buttonUse.Click += buttonUse_Click;
            // 
            // labelAmount
            // 
            labelAmount.Dock = DockStyle.Fill;
            labelAmount.Location = new Point(0, 40);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(390, 187);
            labelAmount.TabIndex = 5;
            labelAmount.Text = "label2";
            labelAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormSelectedProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(390, 388);
            Controls.Add(labelAmount);
            Controls.Add(panelAdd);
            Controls.Add(panelUse);
            Controls.Add(panelBottom);
            Controls.Add(labelName);
            Name = "FormSelectedProduct";
            Text = "Продукция";
            panelBottom.ResumeLayout(false);
            panelUse.ResumeLayout(false);
            panelAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownUse).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelName;
        private Panel panelBottom;
        private Button buttonEdit;
        private Button buttonHistory;
        private Button buttonBack;
        private Panel panelUse;
        private Button buttonAdd;
        private Panel panelAdd;
        private NumericUpDown numericUpDownUse;
        private Button buttonUse;
        private Label labelAmount;
    }
}