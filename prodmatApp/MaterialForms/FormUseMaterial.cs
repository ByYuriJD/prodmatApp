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
    public partial class FormUseMaterial : Form
    {
        private FormMain main;
        private Material material;
        public FormUseMaterial(Material material,FormMain main)
        {
            InitializeComponent();
            this.main = main;
            this.material = material;
            labelName.Text = material.NameOfMaterial;

        }
        private void buttonWithProduct_Click(object sender, EventArgs e)
        {
            FormMatProdChoice formMatProdChoice = new FormMatProdChoice(false,main);
            if (formMatProdChoice.ShowDialog() == DialogResult.OK)
            {
                FormProductCreation formProductCreation = new FormProductCreation(formMatProdChoice.chosenProduct,main,material,(int)numericUpDown1.Value);
                if (formProductCreation.ShowDialog() == DialogResult.OK)
                {

                    main.AddDB(new WarehouseProduct
                    {
                        Amount = (int)formProductCreation.numericUpDown1.Value,
                        DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                        IsAdded = true,
                        IdProduct = formMatProdChoice.chosenProduct.Id,
                        IsCanceled = false
                    });
                    WarehouseProduct warehouseProduct = main.GetLastWarehouseProduct(true);

                    foreach (ProductCreationMaterialPanel materialPanel in formProductCreation.materials)
                    {
                        main.AddDB(new WarehouseMaterial
                        {
                            DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                            Amount = (int)materialPanel.numericUpDownAmount.Value,
                            IsAdded = false,
                            IsCanceled = false,
                            IsMultipliedByProduct = materialPanel.checkBoxMultiply.Checked,
                            IdMaterial = materialPanel.material.Id,
                            IdAddedProduct = warehouseProduct.Id
                        });
                    }
                    DialogResult = DialogResult.Cancel;
                }
            }
        }
    }
}
