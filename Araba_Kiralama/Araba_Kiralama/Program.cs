using System.IO;
using System.Windows.Forms;

namespace araba_kiralama
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
            AppDomain.CurrentDomain.SetData("DataDirectory",
                Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\..\..\araba_kiralama");
            Application.Run(new AnaMenu());
        }
    }
}