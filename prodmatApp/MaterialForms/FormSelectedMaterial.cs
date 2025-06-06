﻿using System;
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
            numericUpDownAdd.Value = (decimal)material.AutoAmount;
            labelName.Text = material.NameOfMaterial;

            buttonAdd.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
            buttonBack.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
            buttonEdit.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
            buttonHistory.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
            numericUpDownAdd.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
            buttonUse.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
            buttonDelete.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
            BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .3, 1);
            panelMain.BackColor = Color.White;

            UpdateAmount();
        }
        // Показывает количество материала на складе
        private void UpdateAmount()
        {

            // Существуют ли операции
            if (material.WarehouseMaterials.Count > 0)
            {
                // Кол-во материала на складе
                float materialTotal = main.getAmount(material);
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

            Hide();
            // Пользователь выбрал "Подтвердить"
            if (formEditMaterials.ShowDialog() == DialogResult.OK)
            {
                // Обновление материала с информацией введенной ползователем
                material.NameOfMaterial = formEditMaterials.textBoxMaterialName.Text;
                material.Hue = (short)formEditMaterials.trackBarColour.Value;
                material.AutoAmount = (float)formEditMaterials.numericStandartAmount.Value;

                // Обнавление материала
                main.UpdateDB(material);

                // Обнавление вида формы
                numericUpDownAdd.Value = (decimal)material.AutoAmount;
                labelName.Text = material.NameOfMaterial;

                UpdateAmount();

                buttonAdd.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
                buttonBack.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
                buttonEdit.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
                buttonHistory.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
                numericUpDownAdd.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
                buttonUse.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
                buttonDelete.BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .1, 1);
                BackColor = ColourFromHSV.ColorFromHSV(material.Hue, .3, 1);
                panelMain.BackColor = Color.White;
            }
            Show();
        }

        // Нажатие на кнопку открытия истории
        private void buttonHistory_Click(object sender, EventArgs e)
        {
            FormMaterialHistory formMaterialHistory = new FormMaterialHistory(material, main);
            Hide();
            formMaterialHistory.ShowDialog();
            Show();
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
                Amount = (float)numericUpDownAdd.Value,
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

            Hide();

            // Использование материала без добавления продукции
            if (formUseMaterial.ShowDialog() == DialogResult.OK)
            {
                // Проверяет достаточно ли материала и спрашивает пользователю стоит продолжить если нехватает
                if (!main.ContinueMaterialUsage([(float)formUseMaterial.numericUpDown1.Value], [material])) return;
                main.AddDB(new WarehouseMaterial
                {
                    IdMaterial = material.Id,
                    DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                    IsAdded = false,
                    Amount = (float)formUseMaterial.numericUpDown1.Value,
                    IsCanceled = false
                });
            }
            Show();
            UpdateAmount();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (material.WarehouseMaterials.Count != 0)
            {
                MessageBox.Show("Невозможно удалить материал так как история не пуста","Невозможно удалить материал",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Подтвердить удаление материала?\nВозвратить материал невозможно", "Удаление материала",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                main.RemoveDB(material);
                MessageBox.Show("Материал удален","Удаление материала",MessageBoxButtons.OK,MessageBoxIcon.Information);
                DialogResult = DialogResult.Abort;
            }
        }
    }
}
