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
            }
            else if (prodMat is Product) // Объект - материал
            {
                product = (Product)prodMat;
            }
            UpdatePanel();
        }

        private void UpdatePanel()
        {
            if (material != null)
            {
                buttonName.Text = material.NameOfMaterial;
                buttonAdd.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
                buttonUse.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
                if (main.getAmount(material) < 0)
                {
                    errorProvider.SetError(buttonName, "Отрицательное количество материала");
                }
                else
                {
                    errorProvider.Clear();
                }
            }
            else if (product != null)
            {
                buttonName.Text = product.NameOfProduct;
                buttonAdd.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
                buttonUse.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
                if (main.getAmount(product) < 0)
                {
                    errorProvider.SetError(buttonName, "Отрицательное количество продукции");
                }
                else
                {
                    errorProvider.Clear();
                }
            }
        
            if (TextRenderer.MeasureText(buttonName.Text, buttonName.Font).Width > 176 &&
                TextRenderer.MeasureText(buttonName.Text, buttonName.Font).Width < 191)
            {
                buttonName.Font = new Font("Segoe UI", 8);
            }
            else if (TextRenderer.MeasureText(buttonName.Text, buttonName.Font).Width < 215)
            {
                buttonName.Font = new Font("Segoe UI", 7);
            }
            else
            {
                buttonName.Font = new Font("Segoe UI", 6);
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
                if (formSelectedMaterial.ShowDialog() == DialogResult.Abort)
                {
                    Dispose();
                    return;
                }
                Update();
                UpdatePanel();
            }
            else if (product != null) // Объект - продукция
            {
                FormSelectedProduct formSelectedProduct = new FormSelectedProduct(product, main);
                if (formSelectedProduct.ShowDialog() == DialogResult.Abort)
                {
                    Dispose();
                    return;
                }
                Update();
                UpdatePanel();

            }
        }


        // Нажатие на кнопку добавления
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (material != null) // Объект - материал
            {
                if (MessageBox.Show("Добавить " + material.AutoAmount + " материала?", "Добавление материала",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                WarehouseMaterial warehouseMaterial = new WarehouseMaterial
                {
                    IdMaterial = material.Id,
                    DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                    IsAdded = true,
                    Amount = (float)material.AutoAmount,
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
                        Amount = (float)formProductCreation.numericUpDown.Value,
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
                            Amount = (float)materialPanel.numericUpDownAmount.Value,
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
                    // Проверяет достаточно ли материала и спрашивает пользователю стоит продолжить если нехватает
                    if (!main.ContinueMaterialUsage([(float)formUseMaterial.numericUpDown1.Value], [material])) return;
                    main.AddDB(new WarehouseMaterial
                    {
                        IdMaterial = material.Id,
                        DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                        IsAdded = false,
                        Amount = (float)formUseMaterial.numericUpDown1.Value,
                        IsCanceled = false
                    });
                }
            }
            else if (product != null) // Объект - продукция
            {
                if (MessageBox.Show("Расходовать 1 продукцию?", "Расходование продукции", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                // Проверяет достаточно ли продукции и спрашивает пользователю стоит продолжить если нехватает
                if (!main.ContinueProductUsage(1, product)) return;

                WarehouseProduct warehouseProduct = new WarehouseProduct
                {
                    IdProduct = product.Id,
                    DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                    IsAdded = false,
                    Amount = 1,
                    IsCanceled = false
                };
                main.AddDB(warehouseProduct);
            }
        }
    }
}