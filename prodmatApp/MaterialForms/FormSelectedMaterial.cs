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
using prodmatApp.ProductForms;

namespace prodmatApp
{
    public partial class FormSelectedMaterial : Form
    {
        private Material material;
        private FormMain main;
        public FormSelectedMaterial(Material material, FormMain main)
        {
            InitializeComponent();
            this.main = main;
            this.material = material;
            numericUpDownAdd.Value = material.AutoAmount;
            labelName.Text = material.NameOfMaterial;

            UpdateAmount();
        }
        private void UpdateAmount()
        {
            if (material.WarehouseMaterials.Count > 0)
            {
                int materialTotal = 0;
                foreach (WarehouseMaterial warehouseMaterial in material.WarehouseMaterials)
                {
                    if (warehouseMaterial.IsCanceled ||
                        warehouseMaterial.IdAddedProduct != null && warehouseMaterial.IdAddedProductNavigation.IsTemplateOnly) continue;
                    if (warehouseMaterial.IsMultipliedByProduct == true &&
                        warehouseMaterial.IdAddedProductNavigation != null)
                    {
                        materialTotal -= warehouseMaterial.Amount * warehouseMaterial.IdAddedProductNavigation.Amount;
                        continue;
                    }
                    materialTotal += warehouseMaterial.Amount * (warehouseMaterial.IsAdded ? 1 : -1);
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
                UpdateAmount();
            }
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            FormMaterialHistory formMaterialHistory = new FormMaterialHistory(material, main);
            formMaterialHistory.ShowDialog();
            UpdateAmount();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            WarehouseMaterial warehouseMaterial = new WarehouseMaterial
            {
                IdMaterial = material.Id,
                DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                IsAdded = true,
                Amount = (int)numericUpDownAdd.Value,
                IsCanceled = false
            };
            main.AddDB(warehouseMaterial);

            UpdateAmount();
        }

        private void buttonUse_Click(object sender, EventArgs e)
        {
            FormUseMaterial formUseMaterial = new FormUseMaterial(material, main);
            if (formUseMaterial.ShowDialog() == DialogResult.OK)
            {
                main.AddDB(new WarehouseMaterial
                {
                    IdMaterial = material.Id,
                    DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                    IsAdded = false,
                    Amount = (int)formUseMaterial.numericUpDown1.Value,
                    IsCanceled = false
                }); 
            }
        }
    }
}
