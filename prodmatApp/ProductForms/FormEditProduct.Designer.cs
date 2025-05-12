namespace prodmatApp
{
    partial class FormEditProduct
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
            textBoxProductName = new TextBox();
            buttonTemplate = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            trackBarColour = new TrackBar();
            labelColour = new Label();
            panel4 = new Panel();
            buttonOK = new Button();
            buttonBack = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarColour).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxProductName
            // 
            textBoxProductName.Dock = DockStyle.Top;
            textBoxProductName.Location = new Point(8, 8);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.PlaceholderText = "Название продукции";
            textBoxProductName.Size = new Size(354, 27);
            textBoxProductName.TabIndex = 1;
            // 
            // buttonTemplate
            // 
            buttonTemplate.Dock = DockStyle.Top;
            buttonTemplate.Location = new Point(8, 35);
            buttonTemplate.Name = "buttonTemplate";
            buttonTemplate.Size = new Size(354, 29);
            buttonTemplate.TabIndex = 2;
            buttonTemplate.Text = "Создать шаблон";
            buttonTemplate.UseVisualStyleBackColor = true;
            buttonTemplate.Click += buttonTemplate_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(labelColour);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(8, 64);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(4);
            panel2.Size = new Size(354, 41);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(trackBarColour);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(163, 33);
            panel3.TabIndex = 2;
            // 
            // trackBarColour
            // 
            trackBarColour.Dock = DockStyle.Fill;
            trackBarColour.Location = new Point(0, 0);
            trackBarColour.Maximum = 360;
            trackBarColour.Name = "trackBarColour";
            trackBarColour.Size = new Size(163, 33);
            trackBarColour.TabIndex = 0;
            trackBarColour.ValueChanged += trackBarColour_ValueChanged;
            // 
            // labelColour
            // 
            labelColour.Dock = DockStyle.Right;
            labelColour.Location = new Point(167, 4);
            labelColour.Name = "labelColour";
            labelColour.Size = new Size(183, 33);
            labelColour.TabIndex = 1;
            labelColour.Text = "Цвет";
            labelColour.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(buttonOK);
            panel4.Controls.Add(buttonBack);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(8, 105);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(4);
            panel4.Size = new Size(354, 46);
            panel4.TabIndex = 4;
            // 
            // buttonOK
            // 
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Dock = DockStyle.Fill;
            buttonOK.Location = new Point(4, 4);
            buttonOK.Margin = new Padding(8);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(206, 38);
            buttonOK.TabIndex = 1;
            buttonOK.Text = "Ок";
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.DialogResult = DialogResult.Cancel;
            buttonBack.Dock = DockStyle.Right;
            buttonBack.Location = new Point(210, 4);
            buttonBack.Margin = new Padding(8);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(140, 38);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Отмена";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // FormEditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(370, 159);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(buttonTemplate);
            Controls.Add(textBoxProductName);
            Name = "FormEditProduct";
            Padding = new Padding(8);
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarColour).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBoxProductName;
        private Button buttonTemplate;
        private Panel panel2;
        private Panel panel3;
        public TrackBar trackBarColour;
        private Label labelColour;
        private Panel panel4;
        private Button buttonOK;
        private Button buttonBack;
    }
}