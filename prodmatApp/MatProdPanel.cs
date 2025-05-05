using prodmatApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prodmatApp
{
    public partial class MatProdPanel : UserControl
    {
        Object matProdObject;
        bool is_product;
        public MatProdPanel(Object matProdObject)
        {
            if (matProdObject is Material)
            {
                matProdObject = (Material)matProdObject;
                is_product = false;
            }
            else if (matProdObject is Product)
            {
                matProdObject = (Product)matProdObject;
                is_product = true;
            }
            InitializeComponent();
        }

        private void MatProdPanel_Load(object sender, EventArgs e)
        {
        }
        private void MatProdPanel_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#EDF1FF")), 0, 0, this.Width, this.Height, 40);

            g.FillRoundedRectangle(new LinearGradientBrush(new PointF(0, 0), new PointF(0, this.Height), Color.White, System.Drawing.ColorTranslator.FromHtml("#EDF1FF")), 2, 2, this.Width - 4, this.Height - 4, 40);
            g.Dispose();
        }
    }
}