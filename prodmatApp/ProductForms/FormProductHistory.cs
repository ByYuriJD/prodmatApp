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
    /// Форма для просмотра истории операций продукции
    /// </summary>
    public partial class FormProductHistory : Form
    {
        private Product product;
        private FormMain main;
        //Конструктор
        public FormProductHistory(Product product, FormMain main)
        {
            InitializeComponent();
            this.product = product;
            this.main = main;
            labelName.Text = product.NameOfProduct;
            foreach (WarehouseProduct warehouseProduct in product.WarehouseProducts)
            {
                WarehouseProductPanel warehouseProductPanel = new WarehouseProductPanel(warehouseProduct, main);
                tableLayoutPanel1.Controls.Add(warehouseProductPanel);
            }
        }

        private void buttonDeleteHistory_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Хотите ли вы удалить всю историю операций?", "Удаление истории", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                DialogResult deleteMaterialHistory = DialogResult.No;

                int materialsDeleted = 0;
                int productsDeleted = 0;

                foreach (WarehouseProduct warehouseProduct in product.WarehouseProducts)
                {
                    if (warehouseProduct.WarehouseMaterials.Count() != 0)
                    {
                        deleteMaterialHistory = MessageBox.Show("Некоторые продукции хранят операции расходования материалов.\nУдалить данные операции материалов?"
                            , "Удаление истории", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        break;
                    }
                }
                WarehouseProduct[] productsInWarehouse  = product.WarehouseProducts.ToArray();
                foreach (WarehouseProduct warehouseProduct in productsInWarehouse)
                {
                    if (warehouseProduct.WarehouseMaterials.Count() != 0)
                    {
                        if (deleteMaterialHistory == DialogResult.Yes)
                        {
                            WarehouseMaterial[] materialsOfWarehouseProduct = warehouseProduct.WarehouseMaterials.ToArray();
                            foreach (WarehouseMaterial productMaterial in materialsOfWarehouseProduct)
                            {
                                main.RemoveDB(productMaterial);
                                materialsDeleted++;
                            }

                            if (warehouseProduct.IdProductNavigation.IdTemplate == warehouseProduct.Id)
                            {
                                warehouseProduct.IdProductNavigation.IdTemplateNavigation = null;
                                main.UpdateDB(warehouseProduct);
                            }
                            main.RemoveDB(warehouseProduct);
                            productsDeleted++;
                        }
                        continue;
                    }
                    if (warehouseProduct.IdProductNavigation.IdTemplate == warehouseProduct.Id)
                    {
                        warehouseProduct.IdProductNavigation.IdTemplateNavigation = null;
                        main.UpdateDB(warehouseProduct);
                    }
                    main.RemoveDB(warehouseProduct);
                    productsDeleted++;
                }
                MessageBox.Show("Удалено " + productsDeleted.ToString() + " операций продукции" +
                    (materialsDeleted != 0 ? " и " + materialsDeleted.ToString() + " операций материалов." : "."),
                    "Операция успена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
