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
                MessageBox.Show("����������� � ���� ������ �� �������.\n�������� ��� ���������� ���� ������ ���� PostgreSQL � ��������� \"prodMatDB\"",
                    "������ ����������� � ��", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(new FormMain());
        }
    }
}