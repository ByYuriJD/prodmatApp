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
    /// Панель для истории всех операций продукции
    /// </summary>
    public partial class WarehouseProductPanel : UserControl
    {
        private FormMain main;
        private WarehouseProduct product;

        // Конструктор
        public WarehouseProductPanel(WarehouseProduct product, FormMain main)
        {
            InitializeComponent();
            this.main = main;
            this.product = product;
            labelAmount.Text = (product.IsAdded ? "+" : "-") + product.Amount.ToString();
            labelDate.Text = product.DateOfAddition.ToString();
            buttonMore.Visible = product.IsAdded;
        }
        // Нажатие на кнопку больше
        public void buttonMore_Click(object sender, EventArgs e)
        {
            FormWarehouseProduct formWarehouseProduct = new FormWarehouseProduct(product);

            // Пользователь выбрал опцию использования как шаблон
            if (formWarehouseProduct.ShowDialog() == DialogResult.OK)
            {
                product.IdProductNavigation.IdTemplate = product.Id;
                main.UpdateDB(product.IdProductNavigation);
            }
        }

        // Нажатие на кнопку отмены
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            product.IsCanceled = !product.IsCanceled;
            main.UpdateDB(product);

            buttonCancel.Text = product.IsCanceled ? "Возвратить" : "Отменить";
        }
    }
}
