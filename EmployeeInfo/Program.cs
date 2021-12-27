using System;
using System.IO;
using System.Windows.Forms;

namespace EmployeeInfo
{
    static class Program
    {
        public static string _path = Path.Combine(Environment.CurrentDirectory, "Pracownicy.txt");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
