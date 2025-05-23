using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using prodmatApp.Models;


namespace prodmatApp
{
    /// <summary>
    /// Форма показывает список всех созданных материалов и дает возможность добавить новый материал
    /// </summary>
    public partial class FormMaterials : Form
    {
       private FormMain main;

        // Конструктор
        public FormMaterials(FormMain main)
        {
            InitializeComponent();
            this.main = main;
            UpdatePanels();
        }
        // Обновляет показываемые материалы
        private void UpdatePanels()
        {
            // Удаляет существующие элементы
            materialsFlowPanel.Controls.Clear();
            
            // Создает панель для каждого существующего материала
            foreach (Material material in main.GetMaterials())
            {
                MatProdPanel matProdPanel = new MatProdPanel(material, main);
                materialsFlowPanel.Controls.Add(matProdPanel);
                matProdPanel.Disposed += UpdatePanels;
            }
        }

        private void UpdatePanels(object? sender, EventArgs e)
        {
            // Удаляет существующие элементы
            materialsFlowPanel.Controls.Clear();

            // Создает панель для каждого существующего материала
            foreach (Material material in main.GetMaterials())
            {
                MatProdPanel matProdPanel = new MatProdPanel(material, main);
                materialsFlowPanel.Controls.Add(matProdPanel);
                matProdPanel.Disposed += UpdatePanels;
            }
        }

        // Нажатие на кнопку создания нового материала
        private void CreateNewMaterial(object sender, EventArgs e)
        {
            // Показывает форму редактирования матрериала с аргументом null
            FormEditMaterial formEditMaterials = new FormEditMaterial();

            Hide();
            // Пользователь выбрал "Подтвердить"
            if (formEditMaterials.ShowDialog() == DialogResult.OK)
            {
                // Новый материал с информацией введенной пользователем
                Material newMaterial = new Material
                {
                    NameOfMaterial = formEditMaterials.textBoxMaterialName.Text,
                    Hue = (short)formEditMaterials.trackBarColour.Value,
                    AutoAmount = (int)formEditMaterials.numericStandartAmount.Value
                };
                // Добавление в форму
                main.AddDB(newMaterial);
                // Обнавление меню
                UpdatePanels();
            }
            Show();

        }
    }
}
