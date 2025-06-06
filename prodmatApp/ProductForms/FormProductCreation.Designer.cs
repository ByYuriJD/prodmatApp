﻿namespace prodmatApp.ProductForms
{
    partial class FormProductCreation
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
            panelTop = new Panel();
            numericUpDown = new NumericUpDown();
            labelProductName = new Label();
            panelBottom = new Panel();
            buttonOk = new Button();
            buttonBack = new Button();
            panelAdd = new Panel();
            buttonAdd = new Button();
            buttonRemoveAll = new Button();
            tableLayoutPanel = new TableLayoutPanel();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            panelBottom.SuspendLayout();
            panelAdd.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(numericUpDown);
            panelTop.Controls.Add(labelProductName);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(8);
            panelTop.Size = new Size(399, 43);
            panelTop.TabIndex = 0;
            // 
            // numericUpDown
            // 
            numericUpDown.DecimalPlaces = 2;
            numericUpDown.Dock = DockStyle.Fill;
            numericUpDown.Location = new Point(188, 8);
            numericUpDown.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(203, 27);
            numericUpDown.TabIndex = 1;
            numericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelProductName
            // 
            labelProductName.Dock = DockStyle.Left;
            labelProductName.Location = new Point(8, 8);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(180, 27);
            labelProductName.TabIndex = 0;
            labelProductName.Text = "label1";
            labelProductName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonOk);
            panelBottom.Controls.Add(buttonBack);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 392);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(8);
            panelBottom.Size = new Size(399, 58);
            panelBottom.TabIndex = 1;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Dock = DockStyle.Fill;
            buttonOk.Location = new Point(8, 8);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(240, 42);
            buttonOk.TabIndex = 1;
            buttonOk.Text = "Подтвердить выбор";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.DialogResult = DialogResult.Cancel;
            buttonBack.Dock = DockStyle.Right;
            buttonBack.Location = new Point(248, 8);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(143, 42);
            buttonBack.TabIndex = 0;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // panelAdd
            // 
            panelAdd.Controls.Add(buttonAdd);
            panelAdd.Controls.Add(buttonRemoveAll);
            panelAdd.Dock = DockStyle.Bottom;
            panelAdd.Location = new Point(0, 337);
            panelAdd.Name = "panelAdd";
            panelAdd.Padding = new Padding(16, 8, 16, 0);
            panelAdd.Size = new Size(399, 55);
            panelAdd.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.Dock = DockStyle.Fill;
            buttonAdd.Location = new Point(143, 8);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(240, 47);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Добавить материал";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemoveAll
            // 
            buttonRemoveAll.Dock = DockStyle.Left;
            buttonRemoveAll.Location = new Point(16, 8);
            buttonRemoveAll.Name = "buttonRemoveAll";
            buttonRemoveAll.Size = new Size(127, 47);
            buttonRemoveAll.TabIndex = 0;
            buttonRemoveAll.Text = "Исключить все";
            buttonRemoveAll.UseVisualStyleBackColor = true;
            buttonRemoveAll.Click += buttonRemoveAll_Click;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoScroll = true;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 43);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(8);
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(399, 294);
            tableLayoutPanel.TabIndex = 4;
            // 
            // FormProductCreation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 450);
            Controls.Add(tableLayoutPanel);
            Controls.Add(panelAdd);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            MaximizeBox = false;
            Name = "FormProductCreation";
            ShowIcon = false;
            Text = "Создание продукции";
            TopMost = true;
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            panelBottom.ResumeLayout(false);
            panelAdd.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelProductName;
        private Panel panelBottom;
        private Button buttonOk;
        private Button buttonBack;
        private Panel panelAdd;
        private TableLayoutPanel tableLayoutPanel;
        public NumericUpDown numericUpDown;
        private Button buttonRemoveAll;
        private Button buttonAdd;
    }
}