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
        FormMain formMain;
        public FormMaterials(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }
        private void FormMaterials_Load(object sender, EventArgs e)
        {
            foreach (Material material in formMain.GetMaterials())
            {
                MatProdPanel matProdPanel = new MatProdPanel(material);
                materialsFlowPanel.Controls.Add(matProdPanel);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEditMaterials formEditMaterials = new FormEditMaterials();
            if (formEditMaterials.ShowDialog() == DialogResult.OK)
            {
                Material newMaterial = new Material
                {
                    NameOfMaterial = formEditMaterials.textBoxMaterialName.Text,
                    Hue = (short)formEditMaterials.trackBarColour.Value,
                    AutoAmount = (int)formEditMaterials.numericStandartAmount.Value
                };
                formMain.AddMaterial(newMaterial);
            }

        }
    }
}
