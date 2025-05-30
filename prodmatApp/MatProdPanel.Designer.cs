namespace prodmatApp
{
    partial class MatProdPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            errorProvider = new ErrorProvider(components);
            panelBorder = new Panel();
            panelBack = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonUse = new Button();
            buttonAdd = new Button();
            buttonName = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            panelBorder.SuspendLayout();
            panelBack.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // panelBorder
            // 
            panelBorder.Controls.Add(panelBack);
            panelBorder.Dock = DockStyle.Fill;
            panelBorder.Location = new Point(4, 4);
            panelBorder.Name = "panelBorder";
            panelBorder.Padding = new Padding(2);
            panelBorder.Size = new Size(212, 104);
            panelBorder.TabIndex = 0;
            // 
            // panelBack
            // 
            panelBack.Controls.Add(tableLayoutPanel1);
            panelBack.Controls.Add(buttonName);
            panelBack.Dock = DockStyle.Fill;
            panelBack.Location = new Point(2, 2);
            panelBack.Name = "panelBack";
            panelBack.Padding = new Padding(8);
            panelBack.Size = new Size(208, 100);
            panelBack.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonUse, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonAdd, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(8, 43);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(12, 6, 12, 2);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(192, 49);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // buttonUse
            // 
            buttonUse.Dock = DockStyle.Fill;
            buttonUse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonUse.Location = new Point(99, 9);
            buttonUse.Name = "buttonUse";
            buttonUse.Size = new Size(78, 35);
            buttonUse.TabIndex = 1;
            buttonUse.Text = "-";
            buttonUse.UseVisualStyleBackColor = true;
            buttonUse.Click += buttonUse_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAdd.Location = new Point(15, 9);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(78, 35);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonName
            // 
            buttonName.Dock = DockStyle.Top;
            buttonName.Font = new Font("Segoe UI", 9F);
            buttonName.Location = new Point(8, 8);
            buttonName.Name = "buttonName";
            buttonName.Size = new Size(192, 35);
            buttonName.TabIndex = 4;
            buttonName.Text = "button1";
            buttonName.UseVisualStyleBackColor = true;
            buttonName.Click += buttonName_Click;
            // 
            // MatProdPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panelBorder);
            Name = "MatProdPanel";
            Padding = new Padding(4);
            Size = new Size(220, 112);
            Load += MatProdPanel_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            panelBorder.ResumeLayout(false);
            panelBack.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorProvider;
        private Panel panelBorder;
        private Panel panelBack;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonUse;
        private Button buttonAdd;
        private Button buttonName;
    }
}
