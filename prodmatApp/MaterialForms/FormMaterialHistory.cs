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

namespace prodmatApp
{
    /// <summary>
    /// История добавлений и использований материалов
    /// </summary>
    public partial class FormMaterialHistory : Form
    {
        private Material material;
        private FormMain main;

        // Конструктор
        public FormMaterialHistory(Material material, FormMain main)
        {
            InitializeComponent();

            this.material = material;
            this.main = main;

            labelMaterialName.Text = material.NameOfMaterial;


            //Список всех материалов, которые не являются шаблоном, сортированные по добавлению в БД

            List<WarehouseMaterial> warehouseMaterials = material.WarehouseMaterials.Where(e => e.IdAddedProductNavigation == null ||
                !e.IdAddedProductNavigation.IsTemplateOnly).OrderByDescending(e => e.Id).ToList();

            //Добавление панелей

            foreach (WarehouseMaterial warehouseMaterial in warehouseMaterials)
            {
                WarehouseMaterialPanel panel = new WarehouseMaterialPanel(warehouseMaterial, main);
                tableLayoutPanel.Controls.Add(panel);
                panel.Dock = DockStyle.Fill;
            }
        }
        // Удаление истории
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Хотите ли вы удалить всю историю операций?","Удаление истории",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DialogResult deleteProductHistories = DialogResult.No;

                int materialsDeleted = 0;
                int productsDeleted = 0;

                foreach (WarehouseMaterial warehouseMaterial in material.WarehouseMaterials)
                {
                    if (warehouseMaterial.IdAddedProductNavigation != null)
                    {
                        deleteProductHistories = MessageBox.Show("Некоторые материалы являются частью операции создания продукции.\nУдалить данные операции продукции?" 
                            , "Удаление истории", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        break;
                    }
                }
                WarehouseMaterial[] materialsInWarehouse = material.WarehouseMaterials.ToArray();
                foreach (WarehouseMaterial material in materialsInWarehouse)
                {
                    if (material.IdAddedProductNavigation != null)
                    {
                        if (deleteProductHistories == DialogResult.Yes)
                        {
                            WarehouseProduct product = material.IdAddedProductNavigation;
                            WarehouseMaterial[] materialsOfWarehouseProduct = product.WarehouseMaterials.ToArray();
                            foreach (WarehouseMaterial productMaterial in materialsOfWarehouseProduct)
                            {
                                main.RemoveDB(productMaterial);
                                materialsDeleted++;
                            }

                            if (product.IdProductNavigation.IdTemplate == product.Id)
                            {
                                product.IdProductNavigation.IdTemplateNavigation = null;
                                main.UpdateDB(product);
                            }
                            main.RemoveDB(product);
                            productsDeleted++;
                        }
                        continue;
                    }
                    main.RemoveDB(material);
                    materialsDeleted++;
                }
                MessageBox.Show("Удалено " + materialsDeleted.ToString() + " операций материалов" +
                    (productsDeleted != 0 ? " и " + productsDeleted.ToString() + " операций продукции." : "."),
                    "Операция успена",MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
