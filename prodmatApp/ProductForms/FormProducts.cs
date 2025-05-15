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

namespace prodmatApp
{
    /// <summary>
    /// Форма показывает список всей созданной продукции и дает возможность добавить новую продукцию
    /// </summary>
    public partial class FormProducts : Form
    {
        private FormMain main;
        
        // Конструктор
        public FormProducts(FormMain main)
        {
            InitializeComponent();
            this.main = main;
            UpdatePanels();
        }
        // Обновляет показываемые продукции
        private void UpdatePanels()
        {
            // Удаляет существующие элементы
            productsFlowPanel.Controls.Clear();

            // Создает панель для каждого существующего материала
            foreach (Product product in main.GetProducts())
            {
                productsFlowPanel.Controls.Clear();
                MatProdPanel matProdPanel = new MatProdPanel(product, main);
                productsFlowPanel.Controls.Add(matProdPanel);

            }
        }

        // Нажатие на кнопку создания новой продукции
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Показывает форму редактирования продукции с аргументом null
            FormEditProduct formEditProduct = new FormEditProduct(main);

            // Пользователь выбрал "Подтвердить"
            if (formEditProduct.ShowDialog() == DialogResult.OK)
            {
                // Новая продукция с информацией введенной пользователем
                Product newProduct = new Product
                {
                    NameOfProduct = formEditProduct.textBoxProductName.Text,
                    Hue = (short)formEditProduct.trackBarColour.Value,
                    IdTemplate = formEditProduct.warehouseProductId != -1 ? formEditProduct.warehouseProductId : null
                };
                // Добавление в форму
                main.AddDB(newProduct);
                // Обнавление меню
                UpdatePanels();
            }


        }
    }
}
