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
    public partial class FormMatProdChoice : Form
    {
        public Material chosenMaterial;
        public Product chosenProduct;
        private FormMain main;
        public FormMatProdChoice(bool isChoiceMaterial,FormMain main)
        {
            InitializeComponent();
            this.main = main;
            

            if (isChoiceMaterial)
            {
                foreach (Material material in main.GetMaterials())
                {
                    MatProdChoicePanel choicePanel = new MatProdChoicePanel(material, this);
                    flowLayoutPanel.Controls.Add(choicePanel);
                }
            }
            else
            {
                foreach(Product product in main.GetProducts())
                {
                    MatProdChoicePanel choicePanel = new MatProdChoicePanel(product,this);
                    flowLayoutPanel.Controls.Add(choicePanel);
                }
            }
        }
        public void chooseMatProd(Material material)
        {
            chosenMaterial = material;
            DialogResult = DialogResult.OK;
        }
        public void chooseMatProd(Product product)
        {
            chosenProduct = product;
            DialogResult = DialogResult.OK;
        }
    }
}
