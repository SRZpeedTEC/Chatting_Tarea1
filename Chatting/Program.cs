using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatting
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var startupForm = new StartupForm())
            {
                if (startupForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Form1(startupForm.userPort));
                }
            }
        }
    }
}
