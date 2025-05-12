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
    public partial class FormProduct : Form
    {
        FormMain main;
        public FormProduct(FormMain main)
        {
            InitializeComponent();
            this.main = main;
            Update();
        }
        private void Update()
        {
            foreach (Product product in main.GetProducts())
            {
                MatProdPanel matProdPanel = new MatProdPanel(product, main);
                productsFlowPanel.Controls.Add(matProdPanel);

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormEditProduct formEditProduct = new FormEditProduct(main);
            if (formEditProduct.ShowDialog() == DialogResult.OK)
            {
                Product newProduct = new Product
                {
                    NameOfProduct = formEditProduct.textBoxProductName.Text,
                    Hue = (short)formEditProduct.trackBarColour.Value,
                    IdTemplate = formEditProduct.warehouseProductId != -1 ? formEditProduct.warehouseProductId : null
                };
                main.AddDB(newProduct);
            }
            Update();


        }
    }
}
