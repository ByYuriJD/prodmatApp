namespace prodmatApp.ProductForms
{
    partial class FormWarehouseProduct
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
            panelName = new Panel();
            labelName = new Label();
            headerName = new Label();
            panelBottom = new Panel();
            buttonTemplate = new Button();
            buttonBack = new Button();
            panelAmount = new Panel();
            labelAmount = new Label();
            headerAmount = new Label();
            panel1 = new Panel();
            labelDate = new Label();
            headerDate = new Label();
            tableLayoutPanel = new TableLayoutPanel();
            panelName.SuspendLayout();
            panelBottom.SuspendLayout();
            panelAmount.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelName
            // 
            panelName.Controls.Add(labelName);
            panelName.Controls.Add(headerName);
            panelName.Dock = DockStyle.Top;
            panelName.Location = new Point(0, 0);
            panelName.Name = "panelName";
            panelName.Padding = new Padding(8);
            panelName.Size = new Size(356, 39);
            panelName.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.Dock = DockStyle.Fill;
            labelName.Location = new Point(97, 8);
            labelName.Name = "labelName";
            labelName.Size = new Size(251, 23);
            labelName.TabIndex = 1;
            labelName.Text = "label1";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // headerName
            // 
            headerName.Dock = DockStyle.Left;
            headerName.Location = new Point(8, 8);
            headerName.Name = "headerName";
            headerName.Size = new Size(89, 23);
            headerName.TabIndex = 0;
            headerName.Text = "Продукция:";
            headerName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonTemplate);
            panelBottom.Controls.Add(buttonBack);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 304);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(8);
            panelBottom.Size = new Size(356, 51);
            panelBottom.TabIndex = 1;
            // 
            // buttonTemplate
            // 
            buttonTemplate.DialogResult = DialogResult.OK;
            buttonTemplate.Dock = DockStyle.Fill;
            buttonTemplate.Location = new Point(8, 8);
            buttonTemplate.Name = "buttonTemplate";
            buttonTemplate.Size = new Size(207, 35);
            buttonTemplate.TabIndex = 1;
            buttonTemplate.Text = "Использовать как шаблон";
            buttonTemplate.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.DialogResult = DialogResult.Cancel;
            buttonBack.Dock = DockStyle.Right;
            buttonBack.Location = new Point(215, 8);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(133, 35);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // panelAmount
            // 
            panelAmount.Controls.Add(labelAmount);
            panelAmount.Controls.Add(headerAmount);
            panelAmount.Dock = DockStyle.Top;
            panelAmount.Location = new Point(0, 39);
            panelAmount.Name = "panelAmount";
            panelAmount.Padding = new Padding(8);
            panelAmount.Size = new Size(356, 40);
            panelAmount.TabIndex = 2;
            // 
            // labelAmount
            // 
            labelAmount.Dock = DockStyle.Fill;
            labelAmount.Location = new Point(181, 8);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(167, 24);
            labelAmount.TabIndex = 3;
            labelAmount.Text = "label1";
            labelAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // headerAmount
            // 
            headerAmount.Dock = DockStyle.Left;
            headerAmount.Location = new Point(8, 8);
            headerAmount.Name = "headerAmount";
            headerAmount.Size = new Size(173, 24);
            headerAmount.TabIndex = 2;
            headerAmount.Text = "Количество продукции:";
            headerAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelDate);
            panel1.Controls.Add(headerDate);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 79);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(8);
            panel1.Size = new Size(356, 35);
            panel1.TabIndex = 3;
            // 
            // labelDate
            // 
            labelDate.Dock = DockStyle.Fill;
            labelDate.Location = new Point(202, 8);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(146, 19);
            labelDate.TabIndex = 5;
            labelDate.Text = "label1";
            labelDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // headerDate
            // 
            headerDate.Dock = DockStyle.Left;
            headerDate.Location = new Point(8, 8);
            headerDate.Name = "headerDate";
            headerDate.Size = new Size(194, 19);
            headerDate.TabIndex = 4;
            headerDate.Text = "Дата создания продукции:";
            headerDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoScroll = true;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 114);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(356, 190);
            tableLayoutPanel.TabIndex = 4;
            // 
            // FormWarehouseProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(356, 355);
            Controls.Add(tableLayoutPanel);
            Controls.Add(panel1);
            Controls.Add(panelAmount);
            Controls.Add(panelBottom);
            Controls.Add(panelName);
            Name = "FormWarehouseProduct";
            Text = "Данные о создании";
            panelName.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            panelAmount.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelName;
        private Label labelName;
        private Label headerName;
        private Panel panelBottom;
        private Panel panelAmount;
        private Label labelAmount;
        private Label headerAmount;
        private Button buttonBack;
        private Button buttonTemplate;
        private Panel panel1;
        private Label labelDate;
        private Label headerDate;
        private TableLayoutPanel tableLayoutPanel;
    }
}