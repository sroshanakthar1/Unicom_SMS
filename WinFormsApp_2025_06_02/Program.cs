using WinFormsApp_2025_06_02.Data;

namespace WinFormsApp_2025_06_02
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBInitializer.InitializeDatabase();
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}