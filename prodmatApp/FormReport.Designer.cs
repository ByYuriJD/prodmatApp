namespace prodmatApp
{
    partial class FormReport
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
            buttonBack = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonBack);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 311);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(16, 8, 16, 8);
            panel1.Size = new Size(417, 68);
            panel1.TabIndex = 0;
            // 
            // buttonBack
            // 
            buttonBack.DialogResult = DialogResult.Cancel;
            buttonBack.Dock = DockStyle.Fill;
            buttonBack.Location = new Point(16, 8);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(385, 52);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(8);
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(417, 311);
            tableLayoutPanel.TabIndex = 1;
            // 
            // FormReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 379);
            Controls.Add(tableLayoutPanel);
            Controls.Add(panel1);
            MinimumSize = new Size(320, 120);
            Name = "FormReport";
            Text = "Отчет";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonBack;
        private TableLayoutPanel tableLayoutPanel;
    }
}