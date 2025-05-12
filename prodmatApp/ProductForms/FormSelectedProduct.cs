using prodmatApp.Models;
using prodmatApp.ProductForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prodmatApp
{
    public partial class FormSelectedProduct : Form
    {
        private Product product;
        private FormMain main;
        public FormSelectedProduct(Product product, FormMain main)
        {
            InitializeComponent();
            this.main = main;
            this.product = product;
            labelName.Text = product.NameOfProduct;
            if (product.WarehouseProducts.Count > 0)
            {
                int materialTotal = 0;
                foreach (WarehouseProduct warehouseProduct in product.WarehouseProducts)
                {
                    if (warehouseProduct.IsCanceled) continue;
                    materialTotal += warehouseProduct.Amount;
                }
                labelAmount.Text = materialTotal.ToString();
            }
            else labelAmount.Text = "0";

        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormEditProduct formEditProduct = new FormEditProduct(main,product);
            if (formEditProduct.ShowDialog() == DialogResult.OK)
            {
                product.NameOfProduct = formEditProduct.textBoxProductName.Text;
                product.Hue = (short)formEditProduct.trackBarColour.Value;
                product.IdTemplate = (int)formEditProduct.warehouseProductId != -1 ? formEditProduct.warehouseProductId : null;

                main.UpdateDB(product);

                labelName.Text = product.NameOfProduct;
                if (product.WarehouseProducts.Count > 0)
                {
                    int materialTotal = 0;
                    foreach (WarehouseProduct warehouseProduct in product.WarehouseProducts)
                    {
                        if (warehouseProduct.IsCanceled || warehouseProduct.IsTemplateOnly) continue;
                        materialTotal += warehouseProduct.Amount * (warehouseProduct.IsAdded ? 1 : -1);
                    }
                    labelAmount.Text = materialTotal.ToString();
                }
                else labelAmount.Text = "0";
            }
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
        }

        private void buttonUse_Click(object sender, EventArgs e)
        {
            WarehouseProduct warehouseProduct = new WarehouseProduct
            {
                IdProduct = product.Id,
                DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                IsAdded = false,
                Amount = (int)numericUpDownUse.Value,
                IsCanceled = false
            };
            main.AddDB(warehouseProduct);

            labelAmount.Text = (Int32.Parse(labelAmount.Text) - warehouseProduct.Amount).ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
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
                    IsCanceled=false
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
}
