using prodmatApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prodmatApp
{
    public partial class MatProdPanel : UserControl
    {
        private Material material;
        private Product product;
        private FormMain main;
        public MatProdPanel(Object matProdObject, FormMain main)
        {
            InitializeComponent();
            this.main = main;

            if (matProdObject is Material)
            {
                material = (Material)matProdObject;
            }
            else if (matProdObject is Product)
            {
                product = (Product)matProdObject;
            }
        }

        private void MatProdPanel_Load(object sender, EventArgs e)
        {
            if (material != null)
            {
                labelName.Text = material.NameOfMaterial;
                buttonAdd.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
                buttonUse.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
            }
            else if (product != null)
            {
                labelName.Text = product.NameOfProduct;
                buttonAdd.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
                buttonUse.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
            }
        }
        private void Update()
        {
            if (material != null)
            {
                labelName.Text = material.NameOfMaterial;
                buttonAdd.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
                buttonUse.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
            }
            else if (product != null)
            {
                labelName.Text = product.NameOfProduct;
                buttonAdd.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
                buttonUse.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
            }
            UpdateStyles();
        }
        private void MatProdPanel_Paint(object sender, PaintEventArgs e)
        {
            int hue = 0;
            if (material != null)
            {
                hue = material.Hue;
            }
            else if (product != null)
            {
                hue = product.Hue;
            }
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(ColourFromHSV.ColorFromHSV(hue, .5, 1)),
                0, 0, Width, Height, 40);

            g.FillRoundedRectangle(new LinearGradientBrush(new PointF(0, 0), new PointF(0, Height),
                Color.White, ColourFromHSV.ColorFromHSV(hue, .2, 1)),
                2, 2, this.Width - 4, this.Height - 4, 40);
            g.Dispose();
        }

        private void MatProdPanel_MouseClick(object sender, MouseEventArgs e)
        {
            FormSelectedMaterial formSelectedMaterial = new FormSelectedMaterial(material, main);
            formSelectedMaterial.ShowDialog();
            Update();
        }
    }
}