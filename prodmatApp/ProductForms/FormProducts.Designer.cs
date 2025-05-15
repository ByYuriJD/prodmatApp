namespace prodmatApp
{
    partial class FormProducts
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
            productsFlowPanel = new FlowLayoutPanel();
            panelBottom = new Panel();
            buttonAdd = new Button();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // productsFlowPanel
            // 
            productsFlowPanel.AutoScroll = true;
            productsFlowPanel.Dock = DockStyle.Fill;
            productsFlowPanel.Location = new Point(0, 0);
            productsFlowPanel.Name = "productsFlowPanel";
            productsFlowPanel.Size = new Size(629, 380);
            productsFlowPanel.TabIndex = 3;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonAdd);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 380);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(30, 10, 30, 10);
            panelBottom.Size = new Size(629, 70);
            panelBottom.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Location = new Point(30, 10);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(569, 50);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить продукцию";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(629, 450);
            Controls.Add(productsFlowPanel);
            Controls.Add(panelBottom);
            Name = "FormProduct";
            Text = "Выбор продукции";
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel productsFlowPanel;
        private Panel panelBottom;
        private Button buttonAdd;
    }
}