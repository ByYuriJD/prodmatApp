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
    /// Панель расходования материала при создании продукции
    /// </summary>
    public partial class ProductCreationMaterialPanel : UserControl
    {
        public Material material;
        private FormProductCreation FormProductCreation;
        
        // Конструктор
        public ProductCreationMaterialPanel(FormProductCreation formProductCreation, Material material, float amount = 1, bool isMultipliedByProduct = true)
        {
            InitializeComponent();

            try
            {
                this.material = material;
                this.FormProductCreation = formProductCreation;
                labelName.Text = material.NameOfMaterial;
                numericUpDownAmount.Value = (decimal)amount;
                checkBoxMultiply.Checked = isMultipliedByProduct;
            }
            catch(ArgumentOutOfRangeException e)
            {
                this.material = material;
                this.FormProductCreation = formProductCreation;
                labelName.Text = material.NameOfMaterial;
                numericUpDownAmount.Value = 1;
                checkBoxMultiply.Checked = isMultipliedByProduct;
            }

        }

        // Нажатие на кнопку удаления панели
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            FormProductCreation.removePanel(this);
        }
    }
}
