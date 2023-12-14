using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
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
            int ch = 2;
            switch (ch)
            {
                case 1:
                    Application.Run(new Admin.AdminDashboard());
                    break;
                case 2:
                    Application.Run(new EmployeeAuth.AuthEmployee());
                    break;
                case 3:
                    Application.Run(new CustomerAuth.AuthCustomer());
                    break;
                default:
                    break;
            }
        }

        // Functions
        public static void MessageWarn(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void MessageSuccess(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
