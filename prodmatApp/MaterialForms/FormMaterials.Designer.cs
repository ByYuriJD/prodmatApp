namespace prodmatApp
{
    partial class FormMaterials
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
            buttonAdd = new Button();
            materialsFlowPanel = new FlowLayoutPanel();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonAdd);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 393);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(30, 10, 30, 10);
            panelBottom.Size = new Size(628, 70);
            panelBottom.TabIndex = 0;
            panelBottom.Paint += panel1_Paint;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Location = new Point(30, 10);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(568, 50);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить материал";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += button1_Click;
            // 
            // materialsFlowPanel
            // 
            materialsFlowPanel.AutoScroll = true;
            materialsFlowPanel.Dock = DockStyle.Fill;
            materialsFlowPanel.Location = new Point(0, 0);
            materialsFlowPanel.Name = "materialsFlowPanel";
            materialsFlowPanel.Size = new Size(628, 393);
            materialsFlowPanel.TabIndex = 1;
            // 
            // FormMaterials
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(628, 463);
            Controls.Add(materialsFlowPanel);
            Controls.Add(panelBottom);
            Name = "FormMaterials";
            Text = "Выбор материала";
            Load += FormMaterials_Load;
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBottom;
        private FlowLayoutPanel materialsFlowPanel;
        private Button buttonAdd;
    }
}