using System;
using System.Windows.Forms;

namespace SpeakingClock
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Forms.Frm_Main().Show();
            Application.Run();
        }
    }
}
