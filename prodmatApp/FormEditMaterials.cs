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
    public partial class FormEditMaterials : Form
    {
        Material material;
        public FormEditMaterials(Material material = null)
        {
            InitializeComponent();
            if (material == null)
            {
                numericStandartAmount.Value = 1;
                trackBarColour.Value = 0;
                trackBarColour.BackColor = ColourFromHSV.ColorFromHSV(0, .4, 1);
                Text = "Новый материал";
                return;
            } 
            
            this.material = material;
            numericStandartAmount.Value = material.AutoAmount;
            textBoxMaterialName.Text = material.NameOfMaterial;
            trackBarColour.Value = material.Hue;
            trackBarColour.BackColor = ColourFromHSV.ColorFromHSV(trackBarColour.Value, .4, 1);
            Text = "Изменение материала";
        }

        private void trackBarColour_ValueChanged(object sender, EventArgs e)
        {
            trackBarColour.BackColor = ColourFromHSV.ColorFromHSV(trackBarColour.Value,.4,1);
        }
    }
}
