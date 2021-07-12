using System;
using System.Windows.Forms;
using MainMenu = FortuneWheel.Views.MainMenu;

namespace FortuneWheel
{
    public static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
