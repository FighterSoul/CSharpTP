using System;
using System.Windows.Forms;

namespace TP2EX7
{
    static class Program
    {
        /// <summary>
        ///  Point d'entr�e principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
