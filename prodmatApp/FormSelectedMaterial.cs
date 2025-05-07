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
    public partial class FormSelectedMaterial : Form
    {
        private Material material;
        private FormMain main;
        public FormSelectedMaterial(Material material,FormMain main)
        {
            InitializeComponent();
            this.main = main;
            this.material = material;
            numericUpDownAdd.Value = material.AutoAmount;
            labelName.Text = material.NameOfMaterial;
            if (material.WarehouseMaterials.Count > 0)
            {
                int materialTotal = 0;
                foreach(WarehouseMaterial warehouseMaterial in material.WarehouseMaterials)
                {
                    if (warehouseMaterial.IsCanceled) continue;
                    if (warehouseMaterial.IsMultipliedByProduct == true && 
                        warehouseMaterial.IdAddedProductNavigation != null)
                    {
                        materialTotal += warehouseMaterial.Amount * warehouseMaterial.IdAddedProductNavigation.Amount;
                        continue;
                    }
                    materialTotal += warehouseMaterial.Amount * (warehouseMaterial.IsAdded?-1:1);
                }
                labelAmount.Text = materialTotal.ToString();
            }
            else labelAmount.Text = "0";

        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormEditMaterial formEditMaterials = new FormEditMaterial(material);
            if (formEditMaterials.ShowDialog() == DialogResult.OK)
            {
                material.NameOfMaterial = formEditMaterials.textBoxMaterialName.Text;
                material.Hue = (short)formEditMaterials.trackBarColour.Value;
                material.AutoAmount = (int)formEditMaterials.numericStandartAmount.Value;

                main.UpdateDB(material);

                numericUpDownAdd.Value = material.AutoAmount;
                labelName.Text = material.NameOfMaterial;
                if (material.WarehouseMaterials.Count > 0)
                {
                    int materialTotal = 0;
                    foreach (WarehouseMaterial warehouseMaterial in material.WarehouseMaterials)
                    {
                        if (warehouseMaterial.IsCanceled) continue;
                        if (warehouseMaterial.IsMultipliedByProduct == true &&
                            warehouseMaterial.IdAddedProductNavigation != null)
                        {
                            materialTotal += warehouseMaterial.Amount * warehouseMaterial.IdAddedProductNavigation.Amount;
                            continue;
                        }
                        materialTotal += warehouseMaterial.Amount * (warehouseMaterial.IsAdded ? -1 : 1);
                    }
                    labelAmount.Text = materialTotal.ToString();
                }
                else labelAmount.Text = "0";
            }
        }
    }
}
