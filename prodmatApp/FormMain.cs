using Microsoft.EntityFrameworkCore;
using prodmatApp.Models;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace prodmatApp
{
    /// <summary>
    /// ������� ����� ��� ������ � ����������� � ����������
    /// </summary>
    public partial class FormMain : Form
    {
        private ProdMatDbContext? db;

        // �����������
        public FormMain()
        {
            InitializeComponent();


            db = new ProdMatDbContext();


            db.Materials.Load();
            db.Products.Load();
            db.WarehouseMaterials.Load();
            db.WarehouseProducts.Load();
        }
        // ����������
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
            db = null;
        }
        // ��� ������ ����������
        private void panelMaterials_Paint(object sender, PaintEventArgs e)
        {
            base.DoubleBuffered = true;

            Graphics g = e.Graphics;

            g.FillRoundedRectangle(new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#FFF0F0")), 0, 0, panelMaterials.Width, panelMaterials.Height, 40);

            g.FillRoundedRectangle(new LinearGradientBrush(new PointF(0, 0), new PointF(0, panelMaterials.Height), Color.White, System.Drawing.ColorTranslator.FromHtml("#FFF0F0")), 2, 2, panelMaterials.Width - 4, panelMaterials.Height - 4, 40);
            g.Dispose();

        }

        // ��� ������ ���������
        private void panelProduct_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#EDF1FF")), 0, 0, panelProduct.Width, panelProduct.Height, 40);

            g.FillRoundedRectangle(new LinearGradientBrush(new PointF(0, 0), new PointF(0, panelProduct.Height), Color.White, System.Drawing.ColorTranslator.FromHtml("#EDF1FF")), 2, 2, panelProduct.Width - 4, panelProduct.Height - 4, 40);
            g.Dispose();
        }

        // ���������� ������ ��� ��������� ������� �����
        private void Form1_Resize(object sender, EventArgs e)
        {
            UpdateStyles();
        }

        public bool ContinueMaterialUsage(int[] amounts, Material[] materials)
        {
            List<string> materialsInvalid = new List<string>();
            for (int i = 0; i < materials.Length; i++)
            {
                int materialTotal = getAmount(materials[i]);

                if (materialTotal - amounts[i] >= 0) continue;

                materialsInvalid.Add(materials[i].NameOfMaterial);

            }
            if (materialsInvalid.Count == 0) return true;
            else if (materialsInvalid.Count == 1) return MessageBox.Show("������������ ���������: " + materialsInvalid.First() + ".\n����������?",
                "������������ ���������", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            return MessageBox.Show("������������ ����������: " + string.Join(", ",materialsInvalid) + ".\n����������?",
                "������������ ���������", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
        public bool ContinueProductUsage(int amount, Product product)
        {
            int productTotal = getAmount(product);
            if (productTotal - amount >= 0) return true;
            return MessageBox.Show("������������ ���������: " + product.NameOfProduct + ".\n����������?",
                "������������ ���������", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public int getAmount(Material material)
        {

            // ���-�� ��������� �� ������
            int materialTotal = 0;

            // ��� ��������
            foreach (WarehouseMaterial warehouseMaterial in material.WarehouseMaterials)
            {
                // �������� �������� ��� �������� ������ �������
                if (warehouseMaterial.IsCanceled ||
                    warehouseMaterial.IdAddedProduct != null && warehouseMaterial.IdAddedProductNavigation.IsTemplateOnly) continue;
                // ���-�� ��������� ���������� �� ���-�� ���������
                if (warehouseMaterial.IsMultipliedByProduct == true &&
                    warehouseMaterial.IdAddedProductNavigation != null)
                {
                    materialTotal -= warehouseMaterial.Amount * warehouseMaterial.IdAddedProductNavigation.Amount;
                    continue;
                }
                // ���-�� �� ����������
                materialTotal += warehouseMaterial.Amount * (warehouseMaterial.IsAdded ? 1 : -1);
            }
            return materialTotal;
        }
        public int getAmount(Product product)
        {
            int productTotal = 0;
            // ��� ��������
            foreach (WarehouseProduct warehouseProduct in product.WarehouseProducts)
            {
                // �������� �������� ��� �������� ��������
                if (warehouseProduct.IsCanceled || warehouseProduct.IsTemplateOnly) continue;
                productTotal += warehouseProduct.Amount * (warehouseProduct.IsAdded ? 1 : -1);
            }
            return productTotal;
        }

    // ���������� ��������� � ��
    public void AddDB(Material material)
        {
            db.Materials.Add(material);
            db.SaveChanges();
        }
        // �������� ��������� �� ��
        public void RemoveDB(Material material)
        {
            db.Remove(material);
            db.SaveChanges();
        }
        // ���������� ��������� � ��
        public void UpdateDB(Material material)
        {
            db.Materials.Update(material);
            db.SaveChanges();
        }
        // ���������� ��������� � ��
        public void AddDB(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }
        // �������� ��������� �� ��
        public void RemoveDB(Product product)
        {
            db.Remove(product);
            db.SaveChanges();
        }
        // ���������� ��������� � ��
        public void UpdateDB(Product product)
        {
            db.Products.Update(product);
            db.SaveChanges();
        }
        // ���������� �������������� � ��
        public void AddDB(WarehouseMaterial warehouseMaterial)
        {
            db.WarehouseMaterials.Add(warehouseMaterial);
            db.SaveChanges();
        }
        // �������� �������������� �� ��
        public void RemoveDB(WarehouseMaterial warehouseMaterial)
        {
            db.Remove(warehouseMaterial);
            db.SaveChanges();
        }
        // ���������� �������������� � ��
        public void UpdateDB(WarehouseMaterial warehouseMaterial)
        {
            db.WarehouseMaterials.Update(warehouseMaterial);
            db.SaveChanges();
        }
        // ���������� �������������� � ��
        public void AddDB(WarehouseProduct warehouseProduct)
        {
            db.WarehouseProducts.Add(warehouseProduct);
            db.SaveChanges();
        }
        // �������� �������������� �� ��
        public void RemoveDB(WarehouseProduct warehouseProduct)
        {
            db.Remove(warehouseProduct);
            db.SaveChanges();
        }
        // ���������� �������������� � ��
        public void UpdateDB(WarehouseProduct warehouseProduct)
        {
            db.WarehouseProducts.Update(warehouseProduct);
            db.SaveChanges();
        }

        // ���������� ������ ���� ����������
        public List<Material> GetMaterials()
        {
            return db.Materials.OrderBy(e => e.Id).ToList();
        }
        // ���������� ������ ���� ���������
        public List<Product> GetProducts()
        {
            return db.Products.OrderBy(e => e.Id).ToList();
        }
        // ���������� ��������� �� ��������� ��������
        public WarehouseProduct GetLastWarehouseProduct(bool? added)
        {
            try
            {
                return db.WarehouseProducts.Where(e => added == null || added == false ||
                e.IsAdded && !e.IsCanceled).OrderByDescending(e => e.Id).First();
            }
            catch (Exception ex)
            {
                return null;
            }
}
        // ���������� �������� �� ��������� ��������
        public WarehouseMaterial GetLastWarehouseMaterial(bool? added, bool noProduct)
        {
            try
            {
                return db.WarehouseMaterials.Where(e => added == null || added == false || e.IsAdded && !e.IsCanceled
                    && !noProduct || e.IdAddedProduct == null).OrderByDescending(e => e.Id).First();
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }


        // ������� �� ������ ���������
        private void buttonMat_Click(object sender, EventArgs e)
        {
            FormMaterials formMaterials = new FormMaterials(this);
            formMaterials.ShowDialog();
        }
        // ������� �� ������ ���������
        private void buttonProduct_Click(object sender, EventArgs e)
        {
            FormProducts formProduct = new FormProducts(this);
            formProduct.ShowDialog();
        }

        // ������� �� ������ ��������� ��������
        private void buttonLastMat_Click(object sender, EventArgs e)
        {
            WarehouseMaterial lastMat = GetLastWarehouseMaterial(null, true);
            if (lastMat == null)
            {
                MessageBox.Show("��������� ������������ �������� �� ������","�������� �� ������",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            FormSelectedMaterial formSelectedMaterial = new
                FormSelectedMaterial(lastMat.IdMaterialNavigation, this);
            formSelectedMaterial.ShowDialog();
        }

        // ������� �� ������ ��������� ���������
        private void buttonLastProduct_Click(object sender, EventArgs e)
        {
            WarehouseProduct lastProd = GetLastWarehouseProduct(null);
            if (lastProd == null)
            {
                MessageBox.Show("��������� ������������ ��������� �� �������", "��������� �� �������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FormSelectedProduct formSelectedProduct = new
                FormSelectedProduct(lastProd.IdProductNavigation, this);
            formSelectedProduct.ShowDialog();
        }

        // ������� �� ������ �����
        private void buttonReport_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport(this);
            formReport.ShowDialog();
        }

    }
}
