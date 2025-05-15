using prodmatApp.Models;
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
    /// <summary>
    /// Панель расходуемого на продукцию материала
    /// Используется в истории операций продукции
    /// </summary>
    public partial class MaterialOfProductPanel : UserControl
    {
        // Конструктор
        public MaterialOfProductPanel(WarehouseMaterial material)
        {
            InitializeComponent();
            labelName.Text = material.IdMaterialNavigation.NameOfMaterial;
            labelAmount.Text = material.Amount.ToString() + (material.IsMultipliedByProduct == true ? " x" +
                material.IdAddedProductNavigation.Amount : "");
        }
    }
}
