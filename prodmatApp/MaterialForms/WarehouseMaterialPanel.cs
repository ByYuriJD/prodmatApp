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
    /// Панель для истории всех операций материала
    /// </summary>
    public partial class WarehouseMaterialPanel : UserControl
    {
        private WarehouseMaterial warehouseMaterial;
        private FormMain main;
        
        // Конструктор
        public WarehouseMaterialPanel(WarehouseMaterial warehouseMaterial, FormMain main)
        {
            InitializeComponent();
            this.warehouseMaterial = warehouseMaterial;
            this.main = main;

            // Кол-во (Показывает на сколько продукции расходовано)
            labelAmount.Text = (warehouseMaterial.IsAdded ? "+" : "-") +
                warehouseMaterial.Amount.ToString() + (warehouseMaterial.IsMultipliedByProduct==true?" x"+
                warehouseMaterial.IdAddedProductNavigation.Amount:"");
            labelDate.Text = warehouseMaterial.DateOfAddition.ToString();

            // Надпись на кнопке отмены операции
            if (warehouseMaterial.IsCanceled)
            {
                buttonCancel.Text = "Возвратить";
            }
        }

        // Нажатие на кнопку отмены операции
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            warehouseMaterial.IsCanceled = !warehouseMaterial.IsCanceled;
            main.UpdateDB(warehouseMaterial);

            buttonCancel.Text = warehouseMaterial.IsCanceled ? "Возвратить" : "Отменить";
        }
    }
}
