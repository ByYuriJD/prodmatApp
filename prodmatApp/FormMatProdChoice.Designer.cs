namespace prodmatApp
{
    partial class FormMatProdChoice
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
            flowLayoutPanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonBack);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 303);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(16, 8, 16, 8);
            panel1.Size = new Size(622, 57);
            panel1.TabIndex = 0;
            // 
            // buttonBack
            // 
            buttonBack.DialogResult = DialogResult.Cancel;
            buttonBack.Dock = DockStyle.Fill;
            buttonBack.Location = new Point(16, 8);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(590, 41);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(622, 303);
            flowLayoutPanel.TabIndex = 1;
            // 
            // FormMatProdChoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(622, 360);
            Controls.Add(flowLayoutPanel);
            Controls.Add(panel1);
            Name = "FormMatProdChoice";
            Text = "Выбор";
            TopMost = true;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonBack;
        private FlowLayoutPanel flowLayoutPanel;
    }
}