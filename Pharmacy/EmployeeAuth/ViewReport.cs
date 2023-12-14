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
    public partial class ViewReport : Form
    {
        public ViewReport()
        {
            InitializeComponent();
        }
        public object report;
        public void ini()
        {
            if (this.Text == "View Report")
            {
                Report rpt = (Report)report;
                dateTitle.Text = rpt.RptDate.ToShortDateString();
                contentLbl.Text = rpt.RptContent;
            }
            else
            {
                Feedback rpt = (Feedback)report;
                dateTitle.Text = rpt.FdDate.ToShortDateString();
                contentLbl.Text = rpt.FdContent;
            }
        }
    }
}
