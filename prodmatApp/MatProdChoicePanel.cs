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

            int hue = 0;

            if (prodMat is Material) // Объект - материал
            {
                material = (Material)prodMat;

                hue = material.Hue;
                buttonChoose.Text = material.NameOfMaterial;
                buttonChoose.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
                labelAmount.Text = main.getAmount(material).ToString();
            }
            else if (prodMat is Product) // Объект - продукция
            {
                product = (Product)prodMat;

                hue = product.Hue;
                buttonChoose.Text = product.NameOfProduct;
                labelAmount.Text = main.getAmount(product).ToString();
            }
            panelBack.BackColor = ColourFromHSV.ColorFromHSV(hue, .2, 1);
            panelBorder.BackColor = ColourFromHSV.ColorFromHSV(hue, .5, 1);
            buttonChoose.BackColor = ColourFromHSV.ColorFromHSV(hue, .1, 1);
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
