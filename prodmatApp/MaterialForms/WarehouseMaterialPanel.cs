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
    public partial class WarehouseMaterialPanel : UserControl
    {
        WarehouseMaterial warehouseMaterial;
        FormMain main;
        public WarehouseMaterialPanel(WarehouseMaterial warehouseMaterial, FormMain main)
        {
            InitializeComponent();
            this.warehouseMaterial = warehouseMaterial;
            this.main = main;
            labelAmount.Text = (warehouseMaterial.IsAdded ? "+" : "-") +
                warehouseMaterial.Amount.ToString();
            labelDate.Text = warehouseMaterial.DateOfAddition.ToString();

            if (warehouseMaterial.IsCanceled)
            {
                buttonCancel.Text = "Возвратить";
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            warehouseMaterial.IsCanceled = !warehouseMaterial.IsCanceled;
            main.UpdateDB(warehouseMaterial);

            buttonCancel.Text = warehouseMaterial.IsCanceled ? "Возвратить" : "Отменить";
        }
    }
}
