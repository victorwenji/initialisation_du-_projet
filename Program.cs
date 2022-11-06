namespace ValidationCompetence
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //ApplicationConfiguration.Initialize();
            //new Form1().Show(); 
            //Application.Run();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //new FrmUser().Show();
            new Form1().Show();
            Application.Run();
        }
    }
}