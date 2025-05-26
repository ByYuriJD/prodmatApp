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
    /// <summary>
    /// Форма для создания продукции и расходования материалов на него
    /// </summary>
    public partial class FormProductCreation : Form
    {
        public List<ProductCreationMaterialPanel> materials;
        private FormMain main;

        // Конструктор
        // material устанавливается если данная форма создана через меню
        public FormProductCreation(Product product, FormMain main, Material material = null, int materialAmount = 0)
        {
            InitializeComponent();
            this.main = main;
            WarehouseProduct template = product.IdTemplateNavigation;
            materials = new List<ProductCreationMaterialPanel>();
            labelProductName.Text = product.NameOfProduct;

            // На используется material
            if (material == null)
            {
                // Имеется шаблон
                if (template != null)
                {
                    numericUpDown.Value = (decimal)template.Amount;

                    // Добавляет материалы
                    foreach (WarehouseMaterial warehouseMaterial in template.WarehouseMaterials)
                    {
                        ProductCreationMaterialPanel materialPanel = new ProductCreationMaterialPanel(this, warehouseMaterial.IdMaterialNavigation,
                                warehouseMaterial.Amount, warehouseMaterial.IsMultipliedByProduct == true);

                        tableLayoutPanel.Controls.Add(materialPanel);
                        materials.Add(materialPanel);
                        materialPanel.Dock = DockStyle.Top;
                    }
                }
            }
            else
            {
                // Добавляет расходуемый материал
                ProductCreationMaterialPanel materialPanel = new ProductCreationMaterialPanel(this, material, materialAmount);
                tableLayoutPanel.Controls.Add(materialPanel);
                materials.Add(materialPanel);
            }

        }

        // Метод удаления панели материала
        public void removePanel(ProductCreationMaterialPanel materialPanel)
        {
            if (MessageBox.Show("Исключить материал: \"" + materialPanel.material.NameOfMaterial + "\"?",
                "Исключение материала", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            if (materials.Contains(materialPanel))
            {
                materials.Remove(materialPanel);
                tableLayoutPanel.Controls.Remove(materialPanel);
                materialPanel.Dispose();
            }
        }

        // Нажатие на кнопку добавления материала
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormMatProdChoice formChoice = new FormMatProdChoice(true, main);

            // Материал выбран
            if (formChoice.ShowDialog() == DialogResult.OK)
            {
                if (formChoice.chosenMaterial != null)
                {
                    ProductCreationMaterialPanel materialPanel = new ProductCreationMaterialPanel(this, formChoice.chosenMaterial);
                    tableLayoutPanel.Controls.Add(materialPanel);
                    materials.Add(materialPanel);
                    materialPanel.Dock = DockStyle.Top;
                }
            }
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Исключить все материалы?",
                "Исключение материалов", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            List<ProductCreationMaterialPanel> materialPanels = materials.ToList();
            foreach (ProductCreationMaterialPanel materialPanel in materialPanels)
            {
                materials.Remove(materialPanel);
                tableLayoutPanel.Controls.Remove(materialPanel);
                materialPanel.Dispose();
            }
        }
    }
}
