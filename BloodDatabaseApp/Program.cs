namespace BloodDatabaseApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Настройка приложения для поддержки высокого DPI и других параметров
            ApplicationConfiguration.Initialize();

            // Запуск основной формы
            Application.Run(new Form1());
        }
    }
}