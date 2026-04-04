using System;
using System.Windows.Forms;

namespace Програмування_ПР1
{
    internal static class Program
    {
        /// <summary>
        /// Головна точка входу для додатку. Ініціалізує та запускає головну форму FinanceTracker.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FinanceTracker());
        }
    }
}
