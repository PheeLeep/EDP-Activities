namespace TextFileLabExer
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

            // Remove comment below for normal exercise.
            // Application.Run(new FrmLab1());

            Application.Run(new FrmRegistration());
        }
    }
}