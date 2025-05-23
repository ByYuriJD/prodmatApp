using prodmatApp.Models;
using prodmatApp.ProductForms;
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
    /// Форма выбранной продукции.
    /// Показывает информацию о данной продукции и дает возможность добавлять и расходовать продукцию
    /// </summary>
    public partial class FormSelectedProduct : Form
    {
        private Product product;
        private FormMain main;

        // Конструктор
        public FormSelectedProduct(Product product, FormMain main)
        {
            InitializeComponent();
            this.main = main;
            this.product = product;
            labelName.Text = product.NameOfProduct;

            UpdateAmount();

            buttonAdd.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
            buttonBack.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
            buttonEdit.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
            buttonHistory.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
            numericUpDownUse.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
            buttonUse.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
            buttonDelete.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
            BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .3, 1);
            panelMain.BackColor = Color.White;
        }
        // Показывает количество продукции на складе
        private void UpdateAmount()
        {

            // Существуют ли операции
            if (product.WarehouseProducts.Count > 0)
            {
                // Кол-во продукции на складе
                float productTotal = main.getAmount(product);

                //Присваивание значения
                labelAmount.Text = productTotal.ToString();
            }
            else labelAmount.Text = "0";
        }

        // Нажатие на кнопку изменения продукции
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // Показывает форму редактирования матрериала с аргументом product
            FormEditProduct formEditProduct = new FormEditProduct(main, product);

            // Пользователь выбрал "Подтвердить"
            if (formEditProduct.ShowDialog() == DialogResult.OK)
            {
                // Обновление продукции с информацией введенной ползователем
                product.NameOfProduct = formEditProduct.textBoxProductName.Text;
                product.Hue = (short)formEditProduct.trackBarColour.Value;
                product.IdTemplate = (int)formEditProduct.warehouseProductId != -1 ? formEditProduct.warehouseProductId : null;

                // Обнавление продукции
                main.UpdateDB(product);

                // Обнавление вида формы
                labelName.Text = product.NameOfProduct;
                UpdateAmount();

                buttonAdd.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
                buttonBack.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
                buttonEdit.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
                buttonHistory.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
                numericUpDownUse.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
                buttonUse.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
                buttonDelete.BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .1, 1);
                BackColor = ColourFromHSV.ColorFromHSV(product.Hue, .3, 1);
                panelMain.BackColor = Color.White;
            }
        }

        // Нажатие на кнопку открытия истории
        private void buttonHistory_Click(object sender, EventArgs e)
        {
            FormProductHistory formProductHistory = new FormProductHistory(product, main);
            formProductHistory.ShowDialog();
            UpdateAmount();
        }

        // Нажатие на кнопку добавления материала в склад
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormProductCreation formProductCreation = new FormProductCreation(product, main);

            // Пользователь выбрал "Подтвердить" на форме создания продукции
            if (formProductCreation.ShowDialog() == DialogResult.OK)
            {
                List<float> amounts = new List<float>();
                List<Material> materials = new List<Material>();
                foreach (ProductCreationMaterialPanel materialPanel in formProductCreation.materials)
                {
                    amounts.Add((float)materialPanel.numericUpDownAmount.Value);
                    materials.Add(materialPanel.material);
                }
                if (!main.ContinueMaterialUsage(amounts.ToArray(), materials.ToArray())) return;

                // Добавляет операцию создания продукции в БД
                main.AddDB(new WarehouseProduct
                {
                    Amount = (float)formProductCreation.numericUpDown.Value,
                    DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                    IsAdded = true,
                    IdProduct = product.Id,
                    IsCanceled = false
                });
                // Получает данную операцию в БД
                WarehouseProduct warehouseProduct = main.GetLastWarehouseProduct(true);


                // Добавлят операцию расходования материла для каждого выбранного материала
                foreach (ProductCreationMaterialPanel materialPanel in formProductCreation.materials)
                {
                    main.AddDB(new WarehouseMaterial
                    {
                        DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                        Amount = (float)materialPanel.numericUpDownAmount.Value,
                        IsAdded = false,
                        IsCanceled = false,
                        IsMultipliedByProduct = materialPanel.checkBoxMultiply.Checked,
                        IdMaterial = materialPanel.material.Id,
                        IdAddedProduct = warehouseProduct.Id
                    });
                }
                UpdateAmount();
            }
        }

        // Нажатие на кнопку расходования материала
        private void buttonUse_Click(object sender, EventArgs e)
        {
            // Проверяет достаточно ли продукции и спрашивает пользователю стоит продолжить если нехватает
            if (!main.ContinueProductUsage((int)numericUpDownUse.Value, product)) return;

            // Создание новой операции продукции с количеством введенным пользователем
            WarehouseProduct warehouseProduct = new WarehouseProduct
            {
                IdProduct = product.Id,
                DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                IsAdded = false,
                Amount = (float)numericUpDownUse.Value,
                IsCanceled = false
            };
            // Добавление опреации в БД
            main.AddDB(warehouseProduct);

            UpdateAmount();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            if (product.WarehouseProducts.Count != 0)
            {
                MessageBox.Show("Невозможно удалить продукцию так как история не пуста", "Невозможно удалить продукцию",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Подтвердить удаление продукции?\nВозвратить продукцию невозможно", "Удаление продукции",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                main.RemoveDB(product);
                MessageBox.Show("Продукция удален", "Удаление продукции", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.Abort;
            }
        }
    }
}
