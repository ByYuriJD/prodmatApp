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
            panelMain = new Panel();
            panel1 = new Panel();
            labelAmount = new Label();
            panel2 = new Panel();
            labelName = new Label();
            buttonDelete = new Button();
            panelAdd = new Panel();
            numericUpDownUse = new NumericUpDown();
            buttonUse = new Button();
            panelUse = new Panel();
            buttonAdd = new Button();
            panelBottom = new Panel();
            buttonEdit = new Button();
            buttonHistory = new Button();
            buttonBack = new Button();
            panelMain.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUse).BeginInit();
            panelUse.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panel1);
            panelMain.Controls.Add(panelAdd);
            panelMain.Controls.Add(panelUse);
            panelMain.Controls.Add(panelBottom);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(4, 4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(394, 377);
            panelMain.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelAmount);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(12);
            panel1.Size = new Size(394, 216);
            panel1.TabIndex = 9;
            // 
            // labelAmount
            // 
            labelAmount.Dock = DockStyle.Fill;
            labelAmount.Location = new Point(12, 56);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(370, 148);
            labelAmount.TabIndex = 3;
            labelAmount.Text = "label2";
            labelAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelName);
            panel2.Controls.Add(buttonDelete);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 44);
            panel2.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.Dock = DockStyle.Fill;
            labelName.Location = new Point(90, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(280, 44);
            labelName.TabIndex = 4;
            labelName.Text = "label1";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonDelete
            // 
            buttonDelete.Dock = DockStyle.Left;
            buttonDelete.Location = new Point(0, 0);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(90, 44);
            buttonDelete.TabIndex = 0;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // panelAdd
            // 
            panelAdd.Controls.Add(numericUpDownUse);
            panelAdd.Controls.Add(buttonUse);
            panelAdd.Dock = DockStyle.Bottom;
            panelAdd.Location = new Point(0, 216);
            panelAdd.Name = "panelAdd";
            panelAdd.Padding = new Padding(8, 4, 8, 4);
            panelAdd.Size = new Size(394, 44);
            panelAdd.TabIndex = 8;
            // 
            // numericUpDownUse
            // 
            numericUpDownUse.Dock = DockStyle.Fill;
            numericUpDownUse.Location = new Point(8, 4);
            numericUpDownUse.Margin = new Padding(5);
            numericUpDownUse.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDownUse.Name = "numericUpDownUse";
            numericUpDownUse.Size = new Size(273, 27);
            numericUpDownUse.TabIndex = 1;
            numericUpDownUse.TextAlign = HorizontalAlignment.Right;
            numericUpDownUse.ThousandsSeparator = true;
            numericUpDownUse.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonUse
            // 
            buttonUse.Dock = DockStyle.Right;
            buttonUse.Location = new Point(281, 4);
            buttonUse.Name = "buttonUse";
            buttonUse.Size = new Size(105, 36);
            buttonUse.TabIndex = 0;
            buttonUse.Text = "Расходовать";
            buttonUse.UseVisualStyleBackColor = true;
            buttonUse.Click += buttonUse_Click;
            // 
            // panelUse
            // 
            panelUse.Controls.Add(buttonAdd);
            panelUse.Dock = DockStyle.Bottom;
            panelUse.Location = new Point(0, 260);
            panelUse.Name = "panelUse";
            panelUse.Padding = new Padding(12, 4, 12, 4);
            panelUse.Size = new Size(394, 49);
            panelUse.TabIndex = 7;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Location = new Point(12, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(370, 41);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonEdit);
            panelBottom.Controls.Add(buttonHistory);
            panelBottom.Controls.Add(buttonBack);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 309);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(8);
            panelBottom.Size = new Size(394, 68);
            panelBottom.TabIndex = 6;
            // 
            // buttonEdit
            // 
            buttonEdit.Dock = DockStyle.Fill;
            buttonEdit.Location = new Point(102, 8);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(179, 52);
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
            buttonBack.Location = new Point(281, 8);
            buttonBack.Margin = new Padding(10);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(105, 52);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // FormSelectedProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(402, 385);
            Controls.Add(panelMain);
            MinimumSize = new Size(420, 432);
            Name = "FormSelectedProduct";
            Padding = new Padding(4);
            Text = "Продукция";
            panelMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panelAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownUse).EndInit();
            panelUse.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panel1;
        private Label labelAmount;
        private Panel panel2;
        private Label labelName;
        private Button buttonDelete;
        private Panel panelAdd;
        private NumericUpDown numericUpDownUse;
        private Button buttonUse;
        private Panel panelUse;
        private Button buttonAdd;
        private Panel panelBottom;
        private Button buttonEdit;
        private Button buttonHistory;
        private Button buttonBack;
    }
}