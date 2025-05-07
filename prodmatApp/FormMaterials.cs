using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using prodmatApp.Models;


namespace prodmatApp
{
    public partial class FormMaterials : Form
    {
        FormMain main;
        public FormMaterials(FormMain main)
        {
            InitializeComponent();
            this.main = main;
        }
        private void FormMaterials_Load(object sender, EventArgs e)
        {
            Update();
        }
        private void Update()
        {
            foreach (Material material in main.GetMaterials())
            {
                MatProdPanel matProdPanel = new MatProdPanel(material, main);
                materialsFlowPanel.Controls.Add(matProdPanel);
                
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEditMaterial formEditMaterials = new FormEditMaterial();
            if (formEditMaterials.ShowDialog() == DialogResult.OK)
            {
                Material newMaterial = new Material
                {
                    NameOfMaterial = formEditMaterials.textBoxMaterialName.Text,
                    Hue = (short)formEditMaterials.trackBarColour.Value,
                    AutoAmount = (int)formEditMaterials.numericStandartAmount.Value
                };
                main.AddDB(newMaterial);
            }
            Update();

        }
    }
}
