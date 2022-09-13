using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CMM
{
    static class Program
    {
        public static Form1 MainForm;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new it());
        }
    }
}
