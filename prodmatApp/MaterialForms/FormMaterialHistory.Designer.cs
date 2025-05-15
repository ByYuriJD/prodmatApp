namespace prodmatApp
{
    partial class FormMaterialHistory
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
            labelMaterialName = new Label();
            panelBottom = new Panel();
            buttonDelete = new Button();
            buttonBack = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelMaterialName);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(8);
            panelTop.Size = new Size(407, 47);
            panelTop.TabIndex = 0;
            // 
            // labelMaterialName
            // 
            labelMaterialName.Dock = DockStyle.Fill;
            labelMaterialName.Location = new Point(8, 8);
            labelMaterialName.Name = "labelMaterialName";
            labelMaterialName.Size = new Size(391, 31);
            labelMaterialName.TabIndex = 0;
            labelMaterialName.Text = "label1";
            labelMaterialName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonDelete);
            panelBottom.Controls.Add(buttonBack);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 393);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(12, 8, 12, 8);
            panelBottom.Size = new Size(407, 60);
            panelBottom.TabIndex = 1;
            // 
            // buttonDelete
            // 
            buttonDelete.Dock = DockStyle.Fill;
            buttonDelete.Location = new Point(12, 8);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(141, 44);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Удалить историю";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonBack
            // 
            buttonBack.DialogResult = DialogResult.Cancel;
            buttonBack.Dock = DockStyle.Right;
            buttonBack.Location = new Point(153, 8);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(242, 44);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoScroll = true;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 47);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(407, 346);
            tableLayoutPanel.TabIndex = 2;
            // 
            // FormMaterialHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(407, 453);
            Controls.Add(tableLayoutPanel);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            MinimumSize = new Size(425, 500);
            Name = "FormMaterialHistory";
            Text = "История количества материала";
            panelTop.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelMaterialName;
        private Panel panelBottom;
        private Button buttonBack;
        private TableLayoutPanel tableLayoutPanel;
        private Button buttonDelete;
    }
}