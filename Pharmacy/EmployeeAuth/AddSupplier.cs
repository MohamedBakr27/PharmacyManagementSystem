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
    public partial class AddSupplier : Form
    {
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void addSupplierBtn_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (supIDTxtbx.Text.Length == 0) msg += "You should enter supplier ID\n";
            if (supNameTxtbx.Text.Length == 0) msg += "You should enter supplier name\n";
            if (supEmailTxtbx.Text.Length == 0) msg += "You should enter supplier email\n";
            if (supAddressTxtbx.Text.Length == 0) msg += "You should enter supplier address\n";
            if (msg.Length > 0)
            {
                Program.MessageWarn("Add Supplier", msg);
                return;
            }
            if (Supplier.AddSupplier(supIDTxtbx.Text, supEmailTxtbx.Text, supNameTxtbx.Text, supAddressTxtbx.Text))
            {
                Program.MessageSuccess("Add Suppler!", "Supplier Added Successful!");
                this.Close();
            }
        }
    }
}
