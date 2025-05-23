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
            components = new System.ComponentModel.Container();
            textBoxProductName = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            trackBarColour = new TrackBar();
            labelColour = new Label();
            panel4 = new Panel();
            panel1 = new Panel();
            buttonOK = new Button();
            buttonBack = new Button();
            errorProvider = new ErrorProvider(components);
            buttonTemplate = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarColour).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // textBoxProductName
            // 
            textBoxProductName.Dock = DockStyle.Top;
            textBoxProductName.Location = new Point(8, 8);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.PlaceholderText = "Название продукции";
            textBoxProductName.Size = new Size(378, 27);
            textBoxProductName.TabIndex = 1;
            textBoxProductName.TextChanged += textBoxProductName_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(labelColour);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(8, 72);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(4);
            panel2.Size = new Size(378, 46);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(trackBarColour);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(187, 38);
            panel3.TabIndex = 2;
            // 
            // trackBarColour
            // 
            trackBarColour.Dock = DockStyle.Fill;
            trackBarColour.Location = new Point(0, 0);
            trackBarColour.Maximum = 360;
            trackBarColour.Name = "trackBarColour";
            trackBarColour.Size = new Size(187, 38);
            trackBarColour.TabIndex = 0;
            trackBarColour.ValueChanged += trackBarColour_ValueChanged;
            // 
            // labelColour
            // 
            labelColour.Dock = DockStyle.Right;
            labelColour.Location = new Point(191, 4);
            labelColour.Name = "labelColour";
            labelColour.Size = new Size(183, 38);
            labelColour.TabIndex = 1;
            labelColour.Text = "Цвет";
            labelColour.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(buttonBack);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(8, 118);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(4);
            panel4.Size = new Size(378, 43);
            panel4.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonOK);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 0, 30, 0);
            panel1.Size = new Size(246, 35);
            panel1.TabIndex = 1;
            // 
            // buttonOK
            // 
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Dock = DockStyle.Fill;
            buttonOK.Location = new Point(0, 0);
            buttonOK.Margin = new Padding(8);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(216, 35);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "Ок";
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.DialogResult = DialogResult.Cancel;
            buttonBack.Dock = DockStyle.Right;
            buttonBack.Location = new Point(250, 4);
            buttonBack.Margin = new Padding(8);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(124, 35);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Отмена";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // buttonTemplate
            // 
            buttonTemplate.Dock = DockStyle.Top;
            buttonTemplate.Location = new Point(8, 35);
            buttonTemplate.Name = "buttonTemplate";
            buttonTemplate.Size = new Size(378, 37);
            buttonTemplate.TabIndex = 2;
            buttonTemplate.Text = "Создать шаблон";
            buttonTemplate.UseVisualStyleBackColor = true;
            buttonTemplate.Click += buttonTemplate_Click;
            // 
            // FormEditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(394, 169);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(buttonTemplate);
            Controls.Add(textBoxProductName);
            MaximumSize = new Size(412, 216);
            MinimumSize = new Size(412, 216);
            Name = "FormEditProduct";
            Padding = new Padding(8);
            ShowIcon = false;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarColour).EndInit();
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBoxProductName;
        private Panel panel2;
        private Panel panel3;
        public TrackBar trackBarColour;
        private Label labelColour;
        private Panel panel4;
        private Button buttonBack;
        private Panel panel1;
        private Button buttonOK;
        private ErrorProvider errorProvider;
        private Button buttonTemplate;
    }
}