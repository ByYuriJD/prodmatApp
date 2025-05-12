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
    public partial class FormEditProduct : Form
    {

        private Product product;
        private FormMain main;
        public int warehouseProductId = -1;
        public FormEditProduct(FormMain main,Product product = null)
        {
            InitializeComponent();

            this.main = main;
            if (product == null)
            {
                trackBarColour.Value = 0;
                trackBarColour.BackColor = ColourFromHSV.ColorFromHSV(0, .4, 1);
                Text = "Новая продукция";
                return;
            }

            this.product = product;
            textBoxProductName.Text = product.NameOfProduct;
            trackBarColour.Value = product.Hue;
            trackBarColour.BackColor = ColourFromHSV.ColorFromHSV(trackBarColour.Value, .4, 1);
            Text = "Изменение продукции";
        }

        private void trackBarColour_ValueChanged(object sender, EventArgs e)
        {
            trackBarColour.BackColor = ColourFromHSV.ColorFromHSV(trackBarColour.Value, .4, 1);
        }
        private void buttonTemplate_Click(object sender, EventArgs e)
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
                    IsCanceled = false,
                    IsTemplateOnly = true,
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
                        IdAddedProduct = warehouseProduct.Id,
                    });
                }
                warehouseProductId = warehouseProduct.Id;
            }
        }
    }
}
