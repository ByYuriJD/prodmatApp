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
    ///  Панель отчета
    /// </summary>
    public partial class ReportPanel : UserControl
    {
        // Конструктор принимает продукцию или материал
        public ReportPanel(object prodMat)
        {
            InitializeComponent();

            if (prodMat is Product) // Объект - продукция
            {
                Product product = (Product)prodMat;

                labelName.Text = "[П] " + product.NameOfProduct;
                labelName.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .2, 1);
                // Расчитывает количество продукции
                int amount = 0;
                foreach (WarehouseProduct warehouseProduct in product.WarehouseProducts)
                {
                    if (warehouseProduct.IsCanceled || warehouseProduct.IsTemplateOnly) continue;
                    amount += warehouseProduct.Amount * (warehouseProduct.IsAdded?1:-1);
                }
                labelAmount.Text = amount.ToString();
            }
            else if (prodMat is Material) // Объект - материал
            {
                Material material = (Material)prodMat;

                labelName.Text = "[М] " + material.NameOfMaterial;
                labelName.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .2, 1);

                // Расчитывает количество материала
                int amount = 0;
                foreach (WarehouseMaterial warehouseMaterial in material.WarehouseMaterials)
                {
                    if (warehouseMaterial.IsCanceled || warehouseMaterial.IdAddedProductNavigation != null &&
                        warehouseMaterial.IdAddedProductNavigation.IsTemplateOnly) continue;

                    if (warehouseMaterial.IdAddedProductNavigation != null)
                    {
                        amount -= warehouseMaterial.Amount * (warehouseMaterial.IsMultipliedByProduct == true ? 
                            warehouseMaterial.IdAddedProductNavigation.Amount : 1);
                    }
                    else
                    {
                        amount += warehouseMaterial.Amount * (warehouseMaterial.IsAdded ? 1 : -1);
                    }
                }
                labelAmount.Text = amount.ToString();
            }
        }
    }
}
