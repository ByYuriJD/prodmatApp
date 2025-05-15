namespace prodmatApp.ProductForms
{
    partial class FormProductHistory
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
            panel1 = new Panel();
            buttonDeleteHistory = new Button();
            buttonBack = new Button();
            panel2 = new Panel();
            labelName = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonDeleteHistory);
            panel1.Controls.Add(buttonBack);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 321);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(16, 8, 16, 8);
            panel1.Size = new Size(417, 62);
            panel1.TabIndex = 0;
            // 
            // buttonDeleteHistory
            // 
            buttonDeleteHistory.Dock = DockStyle.Fill;
            buttonDeleteHistory.Location = new Point(16, 8);
            buttonDeleteHistory.Name = "buttonDeleteHistory";
            buttonDeleteHistory.Size = new Size(145, 46);
            buttonDeleteHistory.TabIndex = 1;
            buttonDeleteHistory.Text = "Удалить историю";
            buttonDeleteHistory.UseVisualStyleBackColor = true;
            buttonDeleteHistory.Click += buttonDeleteHistory_Click;
            // 
            // buttonBack
            // 
            buttonBack.DialogResult = DialogResult.Cancel;
            buttonBack.Dock = DockStyle.Right;
            buttonBack.Location = new Point(161, 8);
            buttonBack.MinimumSize = new Size(0, 20);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(240, 46);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(417, 47);
            panel2.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.Dock = DockStyle.Fill;
            labelName.Location = new Point(0, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(417, 47);
            labelName.TabIndex = 0;
            labelName.Text = "label1";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 47);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(417, 274);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // FormProductHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(417, 383);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormProductHistory";
            Text = "История количества продукции";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonBack;
        private Panel panel2;
        private Label labelName;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonDeleteHistory;
    }
}