using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.EmployeeAuth
{
    public partial class SendReport : Form
    {
        public SendReport()
        {
            InitializeComponent();
        }
        public object user;

        private void sendReportBtn_Click(object sender, EventArgs e)
        {
            if (contentLbl.Text.Length == 0)
            {
                Program.MessageWarn($"{this.Text}!", "You should enter report content\n");
                return;
            }
            if (this.Text == "Send Report")
            {
                Report.AddReport(contentLbl.Text, DateTime.Now, ((Cashier)user).Username);
                this.Close();
            }
            else
            {
                Feedback.AddFeedback(contentLbl.Text, DateTime.Now, ((Customer)user).Username);
                this.Close();
            }
        }
    }
}
