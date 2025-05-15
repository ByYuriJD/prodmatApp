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

namespace prodmatApp.ProductForms
{
    /// <summary>
    /// Форма информации о выбранной операции продукции
    /// </summary>
    public partial class FormWarehouseProduct : Form
    {
        public int idWarehouseProduct;

        // Конструктор
        public FormWarehouseProduct(WarehouseProduct product)
        {
            InitializeComponent();
            idWarehouseProduct = product.Id;

            labelAmount.Text = product.Amount.ToString();
            labelDate.Text = product.DateOfAddition.ToString();
            labelName.Text = product.IdProductNavigation.NameOfProduct;

            // Добавляет панели расходоваемых материалов
            foreach (WarehouseMaterial material in product.WarehouseMaterials)
            {
                MaterialOfProductPanel panel = new MaterialOfProductPanel(material);
                panel.Dock = DockStyle.Fill;
                tableLayoutPanel.Controls.Add(panel);
            }
        }
    }
}
