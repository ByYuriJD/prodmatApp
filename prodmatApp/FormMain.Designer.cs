namespace prodmatApp
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelBottom = new Panel();
            buttonReport = new Button();
            panelFill = new Panel();
            tablePanelsLayout = new TableLayoutPanel();
            panelProduct = new Panel();
            tableProductsLayout = new TableLayoutPanel();
            buttonLastProduct = new Button();
            buttonProduct = new Button();
            label1 = new Label();
            panelMaterials = new Panel();
            tableMaterialLayout = new TableLayoutPanel();
            buttonLastMat = new Button();
            buttonMat = new Button();
            labelMaterials = new Label();
            panelBottom.SuspendLayout();
            panelFill.SuspendLayout();
            tablePanelsLayout.SuspendLayout();
            panelProduct.SuspendLayout();
            tableProductsLayout.SuspendLayout();
            panelMaterials.SuspendLayout();
            tableMaterialLayout.SuspendLayout();
            SuspendLayout();
            // 
            // panelBottom
            // 
            panelBottom.BorderStyle = BorderStyle.FixedSingle;
            panelBottom.Controls.Add(buttonReport);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 470);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(10);
            panelBottom.Size = new Size(437, 67);
            panelBottom.TabIndex = 0;
            // 
            // buttonReport
            // 
            buttonReport.Dock = DockStyle.Fill;
            buttonReport.Location = new Point(10, 10);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(415, 45);
            buttonReport.TabIndex = 0;
            buttonReport.Text = "Создать отчет";
            buttonReport.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.BorderStyle = BorderStyle.FixedSingle;
            panelFill.Controls.Add(tablePanelsLayout);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(437, 470);
            panelFill.TabIndex = 1;
            // 
            // tablePanelsLayout
            // 
            tablePanelsLayout.ColumnCount = 1;
            tablePanelsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablePanelsLayout.Controls.Add(panelProduct, 0, 1);
            tablePanelsLayout.Controls.Add(panelMaterials, 0, 0);
            tablePanelsLayout.Dock = DockStyle.Fill;
            tablePanelsLayout.Location = new Point(0, 0);
            tablePanelsLayout.Name = "tablePanelsLayout";
            tablePanelsLayout.Padding = new Padding(20, 20, 20, 10);
            tablePanelsLayout.RowCount = 2;
            tablePanelsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablePanelsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablePanelsLayout.Size = new Size(435, 468);
            tablePanelsLayout.TabIndex = 0;
            // 
            // panelProduct
            // 
            panelProduct.Controls.Add(tableProductsLayout);
            panelProduct.Dock = DockStyle.Fill;
            panelProduct.Location = new Point(23, 242);
            panelProduct.Name = "panelProduct";
            panelProduct.Padding = new Padding(20);
            panelProduct.Size = new Size(389, 213);
            panelProduct.TabIndex = 1;
            panelProduct.Paint += panelProduct_Paint;
            // 
            // tableProductsLayout
            // 
            tableProductsLayout.BackColor = Color.Transparent;
            tableProductsLayout.ColumnCount = 1;
            tableProductsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableProductsLayout.Controls.Add(buttonLastProduct, 0, 2);
            tableProductsLayout.Controls.Add(buttonProduct, 0, 1);
            tableProductsLayout.Controls.Add(label1, 0, 0);
            tableProductsLayout.Dock = DockStyle.Fill;
            tableProductsLayout.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableProductsLayout.Location = new Point(20, 20);
            tableProductsLayout.Name = "tableProductsLayout";
            tableProductsLayout.RowCount = 3;
            tableProductsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 23.0769234F));
            tableProductsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 38.46154F));
            tableProductsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 38.46154F));
            tableProductsLayout.Size = new Size(349, 173);
            tableProductsLayout.TabIndex = 0;
            // 
            // buttonLastProduct
            // 
            buttonLastProduct.BackColor = Color.White;
            buttonLastProduct.Dock = DockStyle.Fill;
            buttonLastProduct.Location = new Point(4, 109);
            buttonLastProduct.Margin = new Padding(4);
            buttonLastProduct.Name = "buttonLastProduct";
            buttonLastProduct.Size = new Size(341, 60);
            buttonLastProduct.TabIndex = 3;
            buttonLastProduct.Text = "Последняя используемая продукция";
            buttonLastProduct.UseVisualStyleBackColor = false;
            // 
            // buttonProduct
            // 
            buttonProduct.BackColor = Color.White;
            buttonProduct.Dock = DockStyle.Fill;
            buttonProduct.FlatAppearance.BorderSize = 2;
            buttonProduct.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 255);
            buttonProduct.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 245, 255);
            buttonProduct.Location = new Point(4, 43);
            buttonProduct.Margin = new Padding(4);
            buttonProduct.Name = "buttonProduct";
            buttonProduct.Size = new Size(341, 58);
            buttonProduct.TabIndex = 2;
            buttonProduct.Text = "Выбор продукции";
            buttonProduct.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(240, 240, 255);
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(4, 4);
            label1.Margin = new Padding(4);
            label1.Name = "label1";
            label1.Size = new Size(341, 31);
            label1.TabIndex = 4;
            label1.Text = "Работа с продукцией";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMaterials
            // 
            panelMaterials.Controls.Add(tableMaterialLayout);
            panelMaterials.Dock = DockStyle.Fill;
            panelMaterials.Location = new Point(23, 23);
            panelMaterials.Margin = new Padding(3, 3, 3, 10);
            panelMaterials.Name = "panelMaterials";
            panelMaterials.Padding = new Padding(20);
            panelMaterials.Size = new Size(389, 206);
            panelMaterials.TabIndex = 0;
            panelMaterials.Paint += panelMaterials_Paint;
            // 
            // tableMaterialLayout
            // 
            tableMaterialLayout.BackColor = Color.Transparent;
            tableMaterialLayout.ColumnCount = 1;
            tableMaterialLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableMaterialLayout.Controls.Add(buttonLastMat, 0, 2);
            tableMaterialLayout.Controls.Add(buttonMat, 0, 1);
            tableMaterialLayout.Controls.Add(labelMaterials, 0, 0);
            tableMaterialLayout.Dock = DockStyle.Fill;
            tableMaterialLayout.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableMaterialLayout.Location = new Point(20, 20);
            tableMaterialLayout.Name = "tableMaterialLayout";
            tableMaterialLayout.RowCount = 3;
            tableMaterialLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 23.0769234F));
            tableMaterialLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 38.46154F));
            tableMaterialLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 38.46154F));
            tableMaterialLayout.Size = new Size(349, 166);
            tableMaterialLayout.TabIndex = 0;
            // 
            // buttonLastMat
            // 
            buttonLastMat.BackColor = Color.White;
            buttonLastMat.Dock = DockStyle.Fill;
            buttonLastMat.Location = new Point(4, 105);
            buttonLastMat.Margin = new Padding(4);
            buttonLastMat.Name = "buttonLastMat";
            buttonLastMat.Size = new Size(341, 57);
            buttonLastMat.TabIndex = 3;
            buttonLastMat.Text = "Последний используемый материал";
            buttonLastMat.UseVisualStyleBackColor = false;
            // 
            // buttonMat
            // 
            buttonMat.BackColor = Color.White;
            buttonMat.Dock = DockStyle.Fill;
            buttonMat.FlatAppearance.BorderSize = 2;
            buttonMat.Location = new Point(4, 42);
            buttonMat.Margin = new Padding(4);
            buttonMat.Name = "buttonMat";
            buttonMat.Size = new Size(341, 55);
            buttonMat.TabIndex = 2;
            buttonMat.Text = "Выбор материала";
            buttonMat.UseVisualStyleBackColor = false;
            buttonMat.Click += buttonMat_Click;
            // 
            // labelMaterials
            // 
            labelMaterials.BackColor = Color.FromArgb(255, 235, 235);
            labelMaterials.Dock = DockStyle.Fill;
            labelMaterials.Location = new Point(4, 4);
            labelMaterials.Margin = new Padding(4);
            labelMaterials.Name = "labelMaterials";
            labelMaterials.Size = new Size(341, 30);
            labelMaterials.TabIndex = 4;
            labelMaterials.Text = "Работа с материалами";
            labelMaterials.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(437, 537);
            Controls.Add(panelFill);
            Controls.Add(panelBottom);
            Name = "FormMain";
            Text = "Продмат";
            Resize += Form1_Resize;
            panelBottom.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            tablePanelsLayout.ResumeLayout(false);
            panelProduct.ResumeLayout(false);
            tableProductsLayout.ResumeLayout(false);
            panelMaterials.ResumeLayout(false);
            tableMaterialLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBottom;
        private Panel panelFill;
        private TableLayoutPanel tablePanelsLayout;
        private Panel panelMaterials;
        private TableLayoutPanel tableMaterialLayout;
        private Button buttonLastMat;
        private Button buttonMat;
        private Label labelMaterials;
        private Button buttonReport;
        private Panel panelProduct;
        private TableLayoutPanel tableProductsLayout;
        private Button buttonLastProduct;
        private Button buttonProduct;
        private Label label1;
    }
}
