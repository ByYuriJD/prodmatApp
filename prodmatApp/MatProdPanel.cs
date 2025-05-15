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
using prodmatApp.Models;
using prodmatApp.ProductForms;

namespace prodmatApp
{
    /// <summary>
    /// Панель для отображения материала или продукции в списках для редактирования
    /// </summary>
    public partial class MatProdPanel : UserControl
    {
        private Material material;
        private Product product;
        private FormMain main;

        // Конструктор
        public MatProdPanel(Object prodMat, FormMain main)
        {
            InitializeComponent();
            this.main = main;

            if (prodMat is Material)  // Объект - продукция
            {
                material = (Material)prodMat;
                buttonName.Text = material.NameOfMaterial;
                buttonAdd.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
                buttonUse.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
            }
            else if (prodMat is Product) // Объект - материал
            {
                product = (Product)prodMat;
                buttonName.Text = product.NameOfProduct;
                buttonAdd.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
                buttonUse.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
            }
        }
        // Вид панели
        private void MatProdPanel_Paint(object sender, PaintEventArgs e)
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
        private void buttonName_Click(object sender, EventArgs e)
        {
            if (material != null) // Объект - материал
            {
                FormSelectedMaterial formSelectedMaterial = new FormSelectedMaterial(material, main);
                formSelectedMaterial.ShowDialog();
                Update();
            }
            else if (product != null) // Объект - продукция
            {
                FormSelectedProduct formSelectedProduct = new FormSelectedProduct(product, main);
                formSelectedProduct.ShowDialog();
                Update();
            }
        }


        // Нажатие на кнопку добавления
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (material != null) // Объект - материал
            {

                WarehouseMaterial warehouseMaterial = new WarehouseMaterial
                {
                    IdMaterial = material.Id,
                    DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                    IsAdded = true,
                    Amount = (int)material.AutoAmount,
                    IsCanceled = false
                };
                main.AddDB(warehouseMaterial);
            }
            else if (product != null) // Объект - продукция
            {
                FormProductCreation formProductCreation = new FormProductCreation(product, main);
                if (formProductCreation.ShowDialog() == DialogResult.OK)
                {
                    main.AddDB(new WarehouseProduct
                    {
                        Amount = (int)formProductCreation.numericUpDown1.Value,
                        DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                        IsAdded = true,
                        IdProduct = product.Id,
                        IsCanceled = false
                    });
                    WarehouseProduct warehouseProduct = main.GetLastWarehouseProduct(true);

                    foreach (ProductCreationMaterialPanel materialPanel in formProductCreation.materials)
                    {
                        main.AddDB(new WarehouseMaterial
                        {
                            DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                            Amount = (int)materialPanel.numericUpDownAmount.Value,
                            IsAdded = false,
                            IsCanceled = false,
                            IsMultipliedByProduct = materialPanel.checkBoxMultiply.Checked,
                            IdMaterial = materialPanel.material.Id,
                            IdAddedProduct = warehouseProduct.Id
                        });
                    }
                }
            }
        }

        // Нажатие на кнопку расходования
        private void buttonUse_Click(object sender, EventArgs e)
        {
            if (material != null) // Объект - материал
            {
                FormUseMaterial formUseMaterial = new FormUseMaterial(material, main);
                if (formUseMaterial.ShowDialog() == DialogResult.OK)
                {
                    main.AddDB(new WarehouseMaterial
                    {
                        IdMaterial = material.Id,
                        DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                        IsAdded = false,
                        Amount = (int)formUseMaterial.numericUpDown1.Value,
                        IsCanceled = false
                    });
                }
            }
            else if (product != null) // Объект - продукция
            {

                WarehouseProduct warehouseProduct = new WarehouseProduct
                {
                    IdProduct = product.Id,
                    DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                    IsAdded = false,
                    Amount = (int)1,
                    IsCanceled = false
                };
                main.AddDB(warehouseProduct);
            }
        }
    }
}