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

namespace prodmatApp
{
    public partial class FormMaterialHistory : Form
    {

        public FormMaterialHistory(Material material,FormMain main)
        {
            InitializeComponent();
            labelMaterialName.Text = material.NameOfMaterial;

            foreach (WarehouseMaterial warehouseMaterial in material.WarehouseMaterials)
            {
                WarehouseMaterialPanel panel = new WarehouseMaterialPanel(warehouseMaterial, main);
                tableLayoutPanel.Controls.Add(panel);
                panel.Dock = DockStyle.Fill;
            }
        }
    }
}
