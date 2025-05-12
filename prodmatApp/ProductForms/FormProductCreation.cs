using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prodmatApp.Models;

namespace prodmatApp.ProductForms
{
    public partial class FormProductCreation : Form
    {
        public List<ProductCreationMaterialPanel> materials;
        private FormMain main;
        public FormProductCreation(Product product, FormMain main, Material material = null, int materialAmount = 0)
        {
            InitializeComponent();
            this.main = main;
            WarehouseProduct template = product.IdTemplateNavigation;
            materials = new List<ProductCreationMaterialPanel>();
            labelProductName.Text = product.NameOfProduct;
            
            if (material == null)
            {
                if (template != null)
                {
                    numericUpDown1.Value = template.Amount;
                    foreach (WarehouseMaterial warehouseMaterial in template.WarehouseMaterials)
                    {
                        ProductCreationMaterialPanel materialPanel = new ProductCreationMaterialPanel(this, warehouseMaterial.IdMaterialNavigation,
                                warehouseMaterial.Amount, warehouseMaterial.IsMultipliedByProduct == true);

                        tableLayoutPanel.Controls.Add(materialPanel);
                        materials.Add(materialPanel);
                    }
                }
            }
            else
            {
                ProductCreationMaterialPanel materialPanel = new ProductCreationMaterialPanel(this, material, materialAmount);
                tableLayoutPanel.Controls.Add(materialPanel);
                materials.Add(materialPanel);
            }

        }
        public void removePanel(ProductCreationMaterialPanel materialPanel)
        {
            if (materials.Contains(materialPanel))
            {
                materials.Remove(materialPanel);
                tableLayoutPanel.Controls.Remove(materialPanel);
                materialPanel.Dispose();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormMatProdChoice formChoice = new FormMatProdChoice(true, main);

            if (formChoice.ShowDialog() == DialogResult.OK)
            {
                if (formChoice.chosenMaterial != null)
                {
                    ProductCreationMaterialPanel materialPanel = new ProductCreationMaterialPanel(this,formChoice.chosenMaterial);
                    tableLayoutPanel.Controls.Add(materialPanel);
                    materials.Add(materialPanel);
                }
            }
        }
    }
}
