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
            panelMain = new Panel();
            panelFill = new Panel();
            labelAmount = new Label();
            panelTop = new Panel();
            labelName = new Label();
            buttonDelete = new Button();
            panelUse = new Panel();
            buttonUse = new Button();
            panelAdd = new Panel();
            numericUpDownAdd = new NumericUpDown();
            buttonAdd = new Button();
            panelBottom = new Panel();
            buttonEdit = new Button();
            buttonHistory = new Button();
            buttonBack = new Button();
            panelMain.SuspendLayout();
            panelFill.SuspendLayout();
            panelTop.SuspendLayout();
            panelUse.SuspendLayout();
            panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAdd).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelFill);
            panelMain.Controls.Add(panelUse);
            panelMain.Controls.Add(panelAdd);
            panelMain.Controls.Add(panelBottom);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(4, 4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(394, 377);
            panelMain.TabIndex = 0;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(labelAmount);
            panelFill.Controls.Add(panelTop);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(12);
            panelFill.Size = new Size(394, 216);
            panelFill.TabIndex = 7;
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
            // panelTop
            // 
            panelTop.Controls.Add(labelName);
            panelTop.Controls.Add(buttonDelete);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(12, 12);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(370, 44);
            panelTop.TabIndex = 1;
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
            // panelUse
            // 
            panelUse.Controls.Add(buttonUse);
            panelUse.Dock = DockStyle.Bottom;
            panelUse.Location = new Point(0, 216);
            panelUse.Name = "panelUse";
            panelUse.Padding = new Padding(12, 4, 12, 4);
            panelUse.Size = new Size(394, 49);
            panelUse.TabIndex = 6;
            // 
            // buttonUse
            // 
            buttonUse.Dock = DockStyle.Fill;
            buttonUse.Location = new Point(12, 4);
            buttonUse.Name = "buttonUse";
            buttonUse.Size = new Size(370, 41);
            buttonUse.TabIndex = 0;
            buttonUse.Text = "Расходовать";
            buttonUse.UseVisualStyleBackColor = true;
            buttonUse.Click += buttonUse_Click;
            // 
            // panelAdd
            // 
            panelAdd.Controls.Add(numericUpDownAdd);
            panelAdd.Controls.Add(buttonAdd);
            panelAdd.Dock = DockStyle.Bottom;
            panelAdd.Location = new Point(0, 265);
            panelAdd.Name = "panelAdd";
            panelAdd.Padding = new Padding(8, 4, 8, 4);
            panelAdd.Size = new Size(394, 44);
            panelAdd.TabIndex = 5;
            // 
            // numericUpDownAdd
            // 
            numericUpDownAdd.Dock = DockStyle.Fill;
            numericUpDownAdd.Location = new Point(8, 4);
            numericUpDownAdd.Margin = new Padding(5);
            numericUpDownAdd.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDownAdd.Name = "numericUpDownAdd";
            numericUpDownAdd.Size = new Size(273, 27);
            numericUpDownAdd.TabIndex = 1;
            numericUpDownAdd.TextAlign = HorizontalAlignment.Right;
            numericUpDownAdd.ThousandsSeparator = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Right;
            buttonAdd.Location = new Point(281, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(105, 36);
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
            panelBottom.TabIndex = 4;
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
            // FormSelectedMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(402, 385);
            Controls.Add(panelMain);
            MinimumSize = new Size(420, 432);
            Name = "FormSelectedMaterial";
            Padding = new Padding(4);
            ShowIcon = false;
            Text = "Материал";
            panelMain.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelUse.ResumeLayout(false);
            panelAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownAdd).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelFill;
        private Label labelAmount;
        private Panel panelTop;
        private Label labelName;
        private Button buttonDelete;
        private Panel panelUse;
        private Button buttonUse;
        private Panel panelAdd;
        private NumericUpDown numericUpDownAdd;
        private Button buttonAdd;
        private Panel panelBottom;
        private Button buttonEdit;
        private Button buttonHistory;
        private Button buttonBack;
    }
}