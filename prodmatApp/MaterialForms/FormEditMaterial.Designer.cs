namespace prodmatApp
{
    partial class FormEditMaterial
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
            textBoxMaterialName = new TextBox();
            panel1 = new Panel();
            numericStandartAmount = new NumericUpDown();
            labelStandartAmount = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            trackBarColour = new TrackBar();
            labelColour = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            buttonOK = new Button();
            buttonBack = new Button();
            errorProvider = new ErrorProvider(components);
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericStandartAmount).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarColour).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // textBoxMaterialName
            // 
            textBoxMaterialName.Dock = DockStyle.Top;
            textBoxMaterialName.Location = new Point(8, 8);
            textBoxMaterialName.Name = "textBoxMaterialName";
            textBoxMaterialName.PlaceholderText = "Название материала";
            textBoxMaterialName.Size = new Size(378, 27);
            textBoxMaterialName.TabIndex = 0;
            textBoxMaterialName.TextChanged += textBoxMaterialName_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(numericStandartAmount);
            panel1.Controls.Add(labelStandartAmount);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(8, 35);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4, 8, 0, 8);
            panel1.Size = new Size(378, 42);
            panel1.TabIndex = 1;
            // 
            // numericStandartAmount
            // 
            numericStandartAmount.DecimalPlaces = 2;
            numericStandartAmount.Dock = DockStyle.Fill;
            numericStandartAmount.Location = new Point(4, 8);
            numericStandartAmount.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericStandartAmount.Name = "numericStandartAmount";
            numericStandartAmount.Size = new Size(187, 27);
            numericStandartAmount.TabIndex = 1;
            numericStandartAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelStandartAmount
            // 
            labelStandartAmount.Dock = DockStyle.Right;
            labelStandartAmount.Location = new Point(191, 8);
            labelStandartAmount.Name = "labelStandartAmount";
            labelStandartAmount.Size = new Size(187, 26);
            labelStandartAmount.TabIndex = 0;
            labelStandartAmount.Text = "Стандартное количество";
            labelStandartAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(labelColour);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(8, 77);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(4);
            panel2.Size = new Size(378, 41);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(trackBarColour);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(187, 33);
            panel3.TabIndex = 2;
            // 
            // trackBarColour
            // 
            trackBarColour.Dock = DockStyle.Fill;
            trackBarColour.Location = new Point(0, 0);
            trackBarColour.Maximum = 360;
            trackBarColour.Name = "trackBarColour";
            trackBarColour.Size = new Size(187, 33);
            trackBarColour.TabIndex = 0;
            trackBarColour.ValueChanged += trackBarColour_ValueChanged;
            // 
            // labelColour
            // 
            labelColour.Dock = DockStyle.Right;
            labelColour.Location = new Point(191, 4);
            labelColour.Name = "labelColour";
            labelColour.Size = new Size(183, 33);
            labelColour.TabIndex = 1;
            labelColour.Text = "Цвет";
            labelColour.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(buttonBack);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(8, 118);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(4);
            panel4.Size = new Size(378, 43);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(buttonOK);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(4, 4);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 0, 30, 0);
            panel5.Size = new Size(241, 35);
            panel5.TabIndex = 1;
            // 
            // buttonOK
            // 
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Dock = DockStyle.Fill;
            buttonOK.Location = new Point(0, 0);
            buttonOK.Margin = new Padding(8);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(211, 35);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "Ок";
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.DialogResult = DialogResult.Cancel;
            buttonBack.Dock = DockStyle.Right;
            buttonBack.Location = new Point(245, 4);
            buttonBack.Margin = new Padding(8);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(129, 35);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Отмена";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormEditMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(394, 169);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBoxMaterialName);
            MaximizeBox = false;
            MaximumSize = new Size(412, 216);
            MinimizeBox = false;
            MinimumSize = new Size(412, 216);
            Name = "FormEditMaterial";
            Padding = new Padding(8);
            ShowIcon = false;
            Text = "Form1";
            TopMost = true;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericStandartAmount).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarColour).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label labelStandartAmount;
        private Panel panel2;
        private Label labelColour;
        private Panel panel3;
        public TextBox textBoxMaterialName;
        public NumericUpDown numericStandartAmount;
        public TrackBar trackBarColour;
        private Panel panel4;
        private Button buttonBack;
        private Panel panel5;
        private Button buttonOK;
        private ErrorProvider errorProvider;
        private ErrorProvider errorProvider1;
    }
}