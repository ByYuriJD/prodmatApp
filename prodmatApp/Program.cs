using prodmatApp.Models;

namespace prodmatApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            if (!new ProdMatDbContext().Database.CanConnect())
            {
                MessageBox.Show("Подключение к Базе Данных не удалось.\nПроверте что существует база данных типа PostgreSQL с названием \"prodMatDB\"",
                    "Ошибка подключения к БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(new FormMain());
        }
    }
}