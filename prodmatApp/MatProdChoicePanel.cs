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
    public partial class MatProdChoicePanel : UserControl
    {
        private Material material;
        private Product product;
        private FormMatProdChoice formChoice;
        public MatProdChoicePanel(Object matProdObject, FormMatProdChoice formChoice)
        {
            InitializeComponent();
            this.formChoice = formChoice;

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
                buttonChoose.Text = material.NameOfMaterial;
                buttonChoose.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
            }
            else if (product != null)
            {
                buttonChoose.Text = product.NameOfProduct;
                buttonChoose.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
            }
        }
        private void warehouseMaterialUpdate()
        {
            if (material != null)
            {
                buttonChoose.Text = material.NameOfMaterial;
                buttonChoose.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
            }
            else if (product != null)
            {
                buttonChoose.Text = product.NameOfProduct;
                buttonChoose.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
            }
            UpdateStyles();
        }
        private void MatProdChoicePanel_Paint(object sender, PaintEventArgs e)
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
            if (material != null)
            {
                formChoice.chooseMatProd(material);
            }
            else if (product != null)
            {
                formChoice.chooseMatProd(product);
            }
        }
        private void buttonChoose_Click(object sender, EventArgs e)
        {
            if (material != null)
            {
                formChoice.chooseMatProd(material);
            }
            else if (product != null)
            {
                formChoice.chooseMatProd(product);
            }
        }
    }
}
