// ============================================================
//  Program.cs  —  Leader (Member 3)
//  Entry point. Do not modify unless you know what you're doing.
// ============================================================
namespace JollibeeKiosk
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enables visual styles (rounded buttons, themed controls)
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
