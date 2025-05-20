using Microsoft.EntityFrameworkCore;
using prodmatApp.Models;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace prodmatApp
{
    /// <summary>
    /// Главная форма для работы с материалами и продукцией
    /// </summary>
    public partial class FormMain : Form
    {
        private ProdMatDbContext? db;

        // Конструктор
        public FormMain()
        {
            InitializeComponent();


            db = new ProdMatDbContext();


            db.Materials.Load();
            db.Products.Load();
            db.WarehouseMaterials.Load();
            db.WarehouseProducts.Load();
        }
        // Деструктор
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
            db = null;
        }
        // Вид панели материалов
        private void panelMaterials_Paint(object sender, PaintEventArgs e)
        {
            base.DoubleBuffered = true;

            Graphics g = e.Graphics;

            g.FillRoundedRectangle(new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#FFF0F0")), 0, 0, panelMaterials.Width, panelMaterials.Height, 40);

            g.FillRoundedRectangle(new LinearGradientBrush(new PointF(0, 0), new PointF(0, panelMaterials.Height), Color.White, System.Drawing.ColorTranslator.FromHtml("#FFF0F0")), 2, 2, panelMaterials.Width - 4, panelMaterials.Height - 4, 40);
            g.Dispose();

        }

        // Вид панели продукции
        private void panelProduct_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#EDF1FF")), 0, 0, panelProduct.Width, panelProduct.Height, 40);

            g.FillRoundedRectangle(new LinearGradientBrush(new PointF(0, 0), new PointF(0, panelProduct.Height), Color.White, System.Drawing.ColorTranslator.FromHtml("#EDF1FF")), 2, 2, panelProduct.Width - 4, panelProduct.Height - 4, 40);
            g.Dispose();
        }

        // Обнавление стилей при изменении размера формы
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
            else if (materialsInvalid.Count == 1) return MessageBox.Show("Нодостаточно материала: " + materialsInvalid.First() + ".\nПродолжить?",
                "Нодостаточно материала", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            return MessageBox.Show("Нодостаточно материалов: " + string.Join(", ",materialsInvalid) + ".\nПродолжить?",
                "Нодостаточно материала", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
        public bool ContinueProductUsage(int amount, Product product)
        {
            int productTotal = getAmount(product);
            if (productTotal - amount >= 0) return true;
            return MessageBox.Show("Нодостаточно продукции: " + product.NameOfProduct + ".\nПродолжить?",
                "Нодостаточно продукции", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public int getAmount(Material material)
        {

            // Кол-во материала на складе
            int materialTotal = 0;

            // Все операции
            foreach (WarehouseMaterial warehouseMaterial in material.WarehouseMaterials)
            {
                // Операция отменена или является частью шаблона
                if (warehouseMaterial.IsCanceled ||
                    warehouseMaterial.IdAddedProduct != null && warehouseMaterial.IdAddedProductNavigation.IsTemplateOnly) continue;
                // Кол-во материала умножается на кол-во продукции
                if (warehouseMaterial.IsMultipliedByProduct == true &&
                    warehouseMaterial.IdAddedProductNavigation != null)
                {
                    materialTotal -= warehouseMaterial.Amount * warehouseMaterial.IdAddedProductNavigation.Amount;
                    continue;
                }
                // Кол-во не умножается
                materialTotal += warehouseMaterial.Amount * (warehouseMaterial.IsAdded ? 1 : -1);
            }
            return materialTotal;
        }
        public int getAmount(Product product)
        {
            int productTotal = 0;
            // Все операции
            foreach (WarehouseProduct warehouseProduct in product.WarehouseProducts)
            {
                // Операция отменена или является шаблоном
                if (warehouseProduct.IsCanceled || warehouseProduct.IsTemplateOnly) continue;
                productTotal += warehouseProduct.Amount * (warehouseProduct.IsAdded ? 1 : -1);
            }
            return productTotal;
        }

    // Добавление материала в БД
    public void AddDB(Material material)
        {
            db.Materials.Add(material);
            db.SaveChanges();
        }
        // Удаление материала из БД
        public void RemoveDB(Material material)
        {
            db.Remove(material);
            db.SaveChanges();
        }
        // Обновление материала в БД
        public void UpdateDB(Material material)
        {
            db.Materials.Update(material);
            db.SaveChanges();
        }
        // Добавление продукции в БД
        public void AddDB(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }
        // Удаление продукции из БД
        public void RemoveDB(Product product)
        {
            db.Remove(product);
            db.SaveChanges();
        }
        // Обновление продукции в БД
        public void UpdateDB(Product product)
        {
            db.Products.Update(product);
            db.SaveChanges();
        }
        // Добавление складМатериала в БД
        public void AddDB(WarehouseMaterial warehouseMaterial)
        {
            db.WarehouseMaterials.Add(warehouseMaterial);
            db.SaveChanges();
        }
        // Удаление складМатериала из БД
        public void RemoveDB(WarehouseMaterial warehouseMaterial)
        {
            db.Remove(warehouseMaterial);
            db.SaveChanges();
        }
        // Обновление складМатериала в БД
        public void UpdateDB(WarehouseMaterial warehouseMaterial)
        {
            db.WarehouseMaterials.Update(warehouseMaterial);
            db.SaveChanges();
        }
        // Добавление складПродукции в БД
        public void AddDB(WarehouseProduct warehouseProduct)
        {
            db.WarehouseProducts.Add(warehouseProduct);
            db.SaveChanges();
        }
        // Удаление складПродукции из БД
        public void RemoveDB(WarehouseProduct warehouseProduct)
        {
            db.Remove(warehouseProduct);
            db.SaveChanges();
        }
        // Обновление складПродукции в БД
        public void UpdateDB(WarehouseProduct warehouseProduct)
        {
            db.WarehouseProducts.Update(warehouseProduct);
            db.SaveChanges();
        }

        // Возвращает список всех материалов
        public List<Material> GetMaterials()
        {
            return db.Materials.OrderBy(e => e.Id).ToList();
        }
        // Возвращает список всей продукции
        public List<Product> GetProducts()
        {
            return db.Products.OrderBy(e => e.Id).ToList();
        }
        // Возвращает продукцию из последней операции
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
        // Возвращает материал из последней операции
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


        // Нажатие на кнопку материалы
        private void buttonMat_Click(object sender, EventArgs e)
        {
            FormMaterials formMaterials = new FormMaterials(this);
            formMaterials.ShowDialog();
        }
        // Нажатие на кнопку продукция
        private void buttonProduct_Click(object sender, EventArgs e)
        {
            FormProducts formProduct = new FormProducts(this);
            formProduct.ShowDialog();
        }

        // Нажатие на кнопку последний материал
        private void buttonLastMat_Click(object sender, EventArgs e)
        {
            WarehouseMaterial lastMat = GetLastWarehouseMaterial(null, true);
            if (lastMat == null)
            {
                MessageBox.Show("Последний используемый материал не найден","Материал не найден",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            FormSelectedMaterial formSelectedMaterial = new
                FormSelectedMaterial(lastMat.IdMaterialNavigation, this);
            formSelectedMaterial.ShowDialog();
        }

        // Нажатие на кнопку последняя продукция
        private void buttonLastProduct_Click(object sender, EventArgs e)
        {
            WarehouseProduct lastProd = GetLastWarehouseProduct(null);
            if (lastProd == null)
            {
                MessageBox.Show("Последняя используемая продукция не найдена", "Продукция не найдена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FormSelectedProduct formSelectedProduct = new
                FormSelectedProduct(lastProd.IdProductNavigation, this);
            formSelectedProduct.ShowDialog();
        }

        // Нажатие на кнопку отчет
        private void buttonReport_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport(this);
            formReport.ShowDialog();
        }

    }
}
