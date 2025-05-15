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
    /// <summary>
    /// Форма для редактирования материалов
    /// Значения введенные пользователем должны обрабатываться при завершении диалога с результатом "ОК"
    /// </summary>
    public partial class FormEditMaterial : Form
    {
        private Material material;

        //Конструктор
        //Если создается новый материал, то значение material должно быть null
        public FormEditMaterial(Material material = null)
        {
            InitializeComponent();

            // Заполнение стандартными данными
            if (material == null)
            {
                numericStandartAmount.Value = 1;
                trackBarColour.Value = 0;
                trackBarColour.BackColor = ColourFromHSV.ColorFromHSV(0, .4, 1);
                Text = "Новый материал";

                ValidateForm();
                return;
            }

            // Заполнение данными существующего материала
            this.material = material;

            numericStandartAmount.Value = material.AutoAmount;
            textBoxMaterialName.Text = material.NameOfMaterial;
            trackBarColour.Value = material.Hue;
            trackBarColour.BackColor = ColourFromHSV.ColorFromHSV(trackBarColour.Value, .4, 1);
            Text = "Изменение материала";

            ValidateForm();
        }

        //Обновляет цвет бегунка взависимости от значения
        private void trackBarColour_ValueChanged(object sender, EventArgs e)
        {
            trackBarColour.BackColor = ColourFromHSV.ColorFromHSV(trackBarColour.Value, .4, 1);
        }

        // Проверка на правильность заполнения формы
        private void ValidateForm()
        {
            if (textBoxMaterialName.Text.Trim().Length < 1)
            {
                errorProvider.SetError(buttonOK, "Название не может быть пустым");
                buttonOK.Enabled = false;
                return;
            }
            else if (textBoxMaterialName.Text.Trim().Length > 40)
            {
                errorProvider.SetError(buttonOK, "Название не может превышать 40 символов");
                buttonOK.Enabled = false;
                return;
            }
            buttonOK.Enabled = true;
        }

        // Название материала изменено
        private void textBoxMaterialName_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }
    }
}
