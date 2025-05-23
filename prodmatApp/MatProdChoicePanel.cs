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
    /// <summary>
    ///  Панель для отображения материала или продукции в списках для выбора пользователем
    /// </summary>
    public partial class MatProdChoicePanel : UserControl
    {
        private Material material;
        private Product product;
        private FormMatProdChoice formChoice;
        //Конструктор
        public MatProdChoicePanel(Object prodMat, FormMatProdChoice formChoice, FormMain main)
        {
            InitializeComponent();
            this.formChoice = formChoice;

            if (prodMat is Material) // Объект - материал
            {
                material = (Material)prodMat;
                buttonChoose.Text = material.NameOfMaterial;
                buttonChoose.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
                labelAmount.Text = main.getAmount(material).ToString();
            }
            else if (prodMat is Product) // Объект - продукция
            {
                product = (Product)prodMat;
                buttonChoose.Text = product.NameOfProduct;
                buttonChoose.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
                labelAmount.Text = main.getAmount(product).ToString();
            }
            if (TextRenderer.MeasureText(buttonChoose.Text, buttonChoose.Font).Width > 176 &&
                TextRenderer.MeasureText(buttonChoose.Text, buttonChoose.Font).Width < 191)
            {
                buttonChoose.Font = new Font("Segoe UI", 8);
            }
            else if (TextRenderer.MeasureText(buttonChoose.Text, buttonChoose.Font).Width < 215)
            {
                buttonChoose.Font = new Font("Segoe UI", 7);
            }
            else
            {
                buttonChoose.Font = new Font("Segoe UI", 6);
            }
        }

        // Вид панели
        private void MatProdChoicePanel_Paint(object sender, PaintEventArgs e)
        {
            int hue = 0;
            if (material != null) // Объект - материал
            {
                hue = material.Hue;
            }
            else if (product != null) // Объект - продукция
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

        // Нажатие на кнопку с названием
        private void buttonChoose_Click(object sender, EventArgs e)
        {
            if (material != null) // Объект - материал
            {
                formChoice.chooseMatProd(material); 
            }
            else if (product != null) // Объект - продукция
            {
                formChoice.chooseMatProd(product);
            }
        }
    }
}
