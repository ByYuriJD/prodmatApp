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
using prodmatApp.ProductForms;

namespace prodmatApp
{
    /// <summary>
    /// Форма выбранного материала.
    /// Показывает информацию о данном материале и дает возможность добавлять и расходовать материал
    /// </summary>
    public partial class FormSelectedMaterial : Form
    {
        private Material material;
        private FormMain main;

        // Конструктор
        public FormSelectedMaterial(Material material, FormMain main)
        {
            InitializeComponent();
            this.main = main;
            this.material = material;
            numericUpDownAdd.Value = material.AutoAmount;
            labelName.Text = material.NameOfMaterial;

            UpdateAmount();
        }
        // Показывает количество материала на складе
        private void UpdateAmount()
        {
            // Существуют ли операции
            if (material.WarehouseMaterials.Count > 0)
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
                //Присваивание значения
                labelAmount.Text = materialTotal.ToString();
            }
            else labelAmount.Text = "0";
        }
        // Нажатие на кнопку изменения материала
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // Показывает форму редактирования матрериала с аргументом material
            FormEditMaterial formEditMaterials = new FormEditMaterial(material);

            // Пользователь выбрал "Подтвердить"
            if (formEditMaterials.ShowDialog() == DialogResult.OK)
            {
                // Обновление материала с информацией введенной ползователем
                material.NameOfMaterial = formEditMaterials.textBoxMaterialName.Text;
                material.Hue = (short)formEditMaterials.trackBarColour.Value;
                material.AutoAmount = (int)formEditMaterials.numericStandartAmount.Value;

                // Обнавление материала
                main.UpdateDB(material);

                // Обнавление вида формы
                numericUpDownAdd.Value = material.AutoAmount;
                labelName.Text = material.NameOfMaterial;
                UpdateAmount();
            }
        }

        // Нажатие на кнопку открытия истории
        private void buttonHistory_Click(object sender, EventArgs e)
        {
            FormMaterialHistory formMaterialHistory = new FormMaterialHistory(material, main);
            formMaterialHistory.ShowDialog();
            UpdateAmount();
        }

        // Нажатие на кнопку добавления материала в склад
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Создание новой операции материала с количеством введенным пользователем
            WarehouseMaterial warehouseMaterial = new WarehouseMaterial
            {
                IdMaterial = material.Id,
                DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                IsAdded = true,
                Amount = (int)numericUpDownAdd.Value,
                IsCanceled = false
            };
            // Добавление опреации в БД
            main.AddDB(warehouseMaterial);

            UpdateAmount();
        }

        // Нажатие на кнопку расходования материала
        private void buttonUse_Click(object sender, EventArgs e)
        {
            FormUseMaterial formUseMaterial = new FormUseMaterial(material, main);

            // Использование материала без добавления продукции
            if (formUseMaterial.ShowDialog() == DialogResult.OK)
            {
                main.AddDB(new WarehouseMaterial
                {
                    IdMaterial = material.Id,
                    DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                    IsAdded = false,
                    Amount = (int)formUseMaterial.numericUpDown1.Value,
                    IsCanceled = false
                }); 
            }
            UpdateAmount();
        }
    }
}
