using Microsoft.EntityFrameworkCore;
using prodmatApp.Models;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace prodmatApp
{
    public partial class FormMain : Form
    {
        protected ProdMatDbContext? db;
        public FormMain()
        {
            InitializeComponent();

            db = new ProdMatDbContext();
            db.Materials.Load();
            db.Products.Load();
            db.WarehouseMaterials.Load();
            db.WarehouseProducts.Load();
        }

        private void panelMaterials_Paint(object sender, PaintEventArgs e)
        {
            base.DoubleBuffered = true;

            Graphics g = e.Graphics;

            g.FillRoundedRectangle(new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#FFF0F0")), 0, 0, panelMaterials.Width, panelMaterials.Height, 40);

            g.FillRoundedRectangle(new LinearGradientBrush(new PointF(0, 0), new PointF(0, panelMaterials.Height), Color.White, System.Drawing.ColorTranslator.FromHtml("#FFF0F0")), 2, 2, panelMaterials.Width - 4, panelMaterials.Height - 4, 40);
            g.Dispose();

        }

        private void panelProduct_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#EDF1FF")), 0, 0, panelProduct.Width, panelProduct.Height, 40);

            g.FillRoundedRectangle(new LinearGradientBrush(new PointF(0, 0), new PointF(0, panelProduct.Height), Color.White, System.Drawing.ColorTranslator.FromHtml("#EDF1FF")), 2, 2, panelProduct.Width - 4, panelProduct.Height - 4, 40);
            g.Dispose();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

            UpdateStyles();
        }
        public void AddMaterial(Material material)
        {
            db.Materials.Add(material);
            db.SaveChanges();
        }

        private void buttonMat_Click(object sender, EventArgs e)
        {
            FormMaterials formMaterials = new FormMaterials(this);
            formMaterials.Show();
        }
        public List<Material> GetMaterials()
        {
            return db.Materials.ToList();
        }
    }
}
