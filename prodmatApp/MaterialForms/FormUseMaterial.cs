using prodmatApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prodmatApp.ProductForms
{
    /// <summary>
    /// Форма, которая позволяет выбрать количество расходуемого материала
    /// 
    /// Количество введенное пользователем должно обрабатываться отдельно,
    /// при нажатии на кнопку продолжения без создания материала, завершеная диалог с результатом "ОК"
    /// 
    /// При нажатии на кнопку использования с добавлением продукции, результат обрабатывается в данной форме
    /// </summary>
    public partial class FormUseMaterial : Form
    {
        private FormMain main;
        private Material material;

        //Конструктор
        public FormUseMaterial(Material material,FormMain main)
        {
            InitializeComponent();
            this.main = main;
            this.material = material;
            labelName.Text = material.NameOfMaterial;

        }

        // Нажатие на кнопку расходывания с созданием продукции
        private void buttonWithProduct_Click(object sender, EventArgs e)
        {
            FormMatProdChoice formMatProdChoice = new FormMatProdChoice(false,main);

            // Пользователь выбрал продукцию
            if (formMatProdChoice.ShowDialog() == DialogResult.OK)
            {
                FormProductCreation formProductCreation = new FormProductCreation(formMatProdChoice.chosenProduct,main,material,(int)numericUpDown1.Value);
                
                // Пользователь выбрал "Подтвердить" на форме создания продукции
                if (formProductCreation.ShowDialog() == DialogResult.OK)
                {
                    List<int> amounts = new List<int>();
                    List<Material> materials = new List<Material>();
                    foreach (ProductCreationMaterialPanel materialPanel in formProductCreation.materials)
                    {
                        amounts.Add((int)materialPanel.numericUpDownAmount.Value);
                        materials.Add(materialPanel.material);
                    }

                    if (!main.ContinueMaterialUsage(amounts.ToArray(), materials.ToArray())) DialogResult = DialogResult.Cancel;


                    // Добавляет операцию создания продукции в БД
                    main.AddDB(new WarehouseProduct
                    {
                        Amount = (int)formProductCreation.numericUpDown1.Value,
                        DateOfAddition = DateOnly.FromDateTime(DateTime.Now),
                        IsAdded = true,
                        IdProduct = formMatProdChoice.chosenProduct.Id,
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
                            Amount = (int)materialPanel.numericUpDownAmount.Value,
                            IsAdded = false,
                            IsCanceled = false,
                            IsMultipliedByProduct = materialPanel.checkBoxMultiply.Checked,
                            IdMaterial = materialPanel.material.Id,
                            IdAddedProduct = warehouseProduct.Id
                        });
                    }
                    // Отмена, чтобы не добавить новую операцию в БД
                    DialogResult = DialogResult.Cancel;
                }
            }
        }
    }
}
