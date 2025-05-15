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
    /// Форма для вывода отчета
    /// </summary>
    public partial class FormReport : Form
    {
        // Конструктор
        public FormReport(FormMain main)
        {
            InitializeComponent();
            foreach (Material material in main.GetMaterials())
            {
                ReportPanel reportPanel = new ReportPanel(material);
                tableLayoutPanel.Controls.Add(reportPanel);
            }
            foreach (Product product in main.GetProducts())
            {
                ReportPanel reportPanel = new ReportPanel(product);
                tableLayoutPanel.Controls.Add(reportPanel);
            }
        }
    }
}
