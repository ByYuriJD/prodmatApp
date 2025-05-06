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
            labelName = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonUse = new Button();
            buttonAdd = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.Dock = DockStyle.Top;
            labelName.Location = new Point(8, 8);
            labelName.Name = "labelName";
            labelName.Size = new Size(185, 35);
            labelName.TabIndex = 0;
            labelName.Text = "label1";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            labelName.MouseClick += MatProdPanel_MouseClick;
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
            tableLayoutPanel1.Padding = new Padding(12, 6, 12, 6);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(185, 61);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.MouseClick += MatProdPanel_MouseClick;
            // 
            // buttonUse
            // 
            buttonUse.Dock = DockStyle.Fill;
            buttonUse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonUse.Location = new Point(95, 9);
            buttonUse.Name = "buttonUse";
            buttonUse.Size = new Size(75, 43);
            buttonUse.TabIndex = 1;
            buttonUse.Text = "-";
            buttonUse.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAdd.Location = new Point(15, 9);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(74, 43);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // MatProdPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(labelName);
            Name = "MatProdPanel";
            Padding = new Padding(8);
            Size = new Size(201, 112);
            Load += MatProdPanel_Load;
            Paint += MatProdPanel_Paint;
            MouseClick += MatProdPanel_MouseClick;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelName;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonAdd;
        private Button buttonUse;
    }
}
