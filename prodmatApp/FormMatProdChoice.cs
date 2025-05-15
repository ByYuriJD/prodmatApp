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
    /// Форма выбора материала или продукции пользователем
    /// </summary>
    public partial class FormMatProdChoice : Form
    {
        public Material chosenMaterial;
        public Product chosenProduct;
        private FormMain main;
        
        // Конструктор
        public FormMatProdChoice(bool isChoiceMaterial,FormMain main)
        {
            InitializeComponent();
            this.main = main;
            

            if (isChoiceMaterial) // Выбирается материал
            {
                foreach (Material material in main.GetMaterials())
                {
                    MatProdChoicePanel choicePanel = new MatProdChoicePanel(material, this);
                    flowLayoutPanel.Controls.Add(choicePanel);
                }
            }
            else // Выбирается продукция
            {
                foreach(Product product in main.GetProducts())
                {
                    MatProdChoicePanel choicePanel = new MatProdChoicePanel(product,this);
                    flowLayoutPanel.Controls.Add(choicePanel);
                }
            }
        }
        // Материал выбран
        public void chooseMatProd(Material material)
        {
            chosenMaterial = material;
            DialogResult = DialogResult.OK;
        }
        // Продукция выбрана
        public void chooseMatProd(Product product)
        {
            chosenProduct = product;
            DialogResult = DialogResult.OK;
        }
    }
}
