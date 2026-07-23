namespace JollibeeKiosk
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            JollibeeKiosk.Services.DatabaseService.InitializeDatabase();
            Application.Run(new Form1());
        }
    }
}

