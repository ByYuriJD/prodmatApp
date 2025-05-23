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
    /// Форма для редактирования продукции
    /// Значения введенные пользователем должны обрабатываться при завершении диалога с результатом "ОК"
    /// </summary>
    public partial class FormEditProduct : Form
    {

        private Product product;
        private FormMain main;
        public int warehouseProductId = -1;

        // Конструктор
        //Если создается новая продукция, то значение product должно быть null
        public FormEditProduct(FormMain main, Product product = null)
        {
            InitializeComponent();

            this.main = main;
            // Заполнение стандартными данными
            if (product == null)
            {
                trackBarColour.Value = 0;
                trackBarColour.BackColor = ColourFromHSV.ColorFromHSV(0, .4, 1);
                Text = "Новая продукция";
                buttonTemplate.Enabled = false;
                buttonTemplate.Text = "Создание шаблона доступно после добавления";
                ValidateForm();
                return;
            }

            // Заполнение данными существующей продукции
            this.product = product;
            textBoxProductName.Text = product.NameOfProduct;
            trackBarColour.Value = product.Hue;
            trackBarColour.BackColor = ColourFromHSV.ColorFromHSV(trackBarColour.Value, .4, 1);
            Text = "Изменение продукции";
            ValidateForm();
        }

        //Обновляет цвет бегунка взависимости от значения
        private void trackBarColour_ValueChanged(object sender, EventArgs e)
        {
            trackBarColour.BackColor = ColourFromHSV.ColorFromHSV(trackBarColour.Value, .4, 1);
        }

        //Нажатие на кнопку создания шаблона
        private void buttonTemplate_Click(object sender, EventArgs e)
        {
            FormProductCreation formProductCreation = new FormProductCreation(product, main);

            // Пользователь выбрал "Подтвердить" на форме создания продукции
            if (formProductCreation.ShowDialog() == DialogResult.OK)
            {
                // Добавляет операцию создания продукции в БД с параметром isTemplateOnly
                main.AddDB(new WarehouseProduct
                {
                    Amount = (int)formProductCreation.numericUpDown.Value,
                    DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                    IsAdded = true,
                    IdProduct = product.Id,
                    IsCanceled = false,
                    IsTemplateOnly = true,
                });

                // Получает данную операцию в БД
                WarehouseProduct warehouseProduct = main.GetLastWarehouseProduct(true);

                // Добавлят операцию расходования материла для каждого выбранного материала
                foreach (ProductCreationMaterialPanel materialPanel in formProductCreation.materials)
                {
                    main.AddDB(new WarehouseMaterial
                    {
                        DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                        Amount = (int)materialPanel.numericUpDownAmount.Value,
                        IsAdded = false,
                        IsCanceled = false,
                        IsMultipliedByProduct = materialPanel.checkBoxMultiply.Checked,
                        IdMaterial = materialPanel.material.Id,
                        IdAddedProduct = warehouseProduct.Id,
                    });
                }
                // Идентификатор шаблона
                warehouseProductId = warehouseProduct.Id;
            }
        }
        // Проверка на правильность заполнения формы
        private void ValidateForm()
        {
            if (textBoxProductName.Text.Trim().Length < 1)
            {
                errorProvider.SetError(buttonOK, "Название не может быть пустым");
                buttonOK.Enabled = false;
                return;
            }
            else if (textBoxProductName.Text.Trim().Length > 40)
            {
                errorProvider.SetError(buttonOK, "Название не может превышать 40 символов");
                buttonOK.Enabled = false;
                return;
            }
            errorProvider.Clear();
            buttonOK.Enabled = true;
        }

        private void textBoxProductName_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }
    }
}
