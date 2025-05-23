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
            buttonName = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonUse = new Button();
            buttonAdd = new Button();
            errorProvider = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // buttonName
            // 
            buttonName.Dock = DockStyle.Top;
            buttonName.Font = new Font("Segoe UI", 9F);
            buttonName.Location = new Point(16, 16);
            buttonName.Name = "buttonName";
            buttonName.Size = new Size(188, 35);
            buttonName.TabIndex = 2;
            buttonName.Text = "button1";
            buttonName.UseVisualStyleBackColor = true;
            buttonName.Click += buttonName_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonUse, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonAdd, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(16, 51);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(12, 6, 12, 2);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(188, 53);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // buttonUse
            // 
            buttonUse.Dock = DockStyle.Fill;
            buttonUse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonUse.Location = new Point(97, 9);
            buttonUse.Name = "buttonUse";
            buttonUse.Size = new Size(76, 39);
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
            buttonAdd.Size = new Size(76, 39);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // MatProdPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonName);
            Name = "MatProdPanel";
            Padding = new Padding(16, 16, 16, 8);
            Size = new Size(220, 112);
            Paint += MatProdPanel_Paint;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonName;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonUse;
        private Button buttonAdd;
        private ErrorProvider errorProvider;
    }
}
