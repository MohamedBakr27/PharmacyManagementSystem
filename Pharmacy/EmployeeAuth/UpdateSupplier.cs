using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace Pharmacy.EmployeeAuth
{
    public partial class UpdateSupplier : Form
    {
        public UpdateSupplier()
        {
            InitializeComponent();
        }
        public object supplier;
        public void ini()
        {
            Supplier sup = (Supplier)supplier;
            supIDTxtbx.Text = sup.SupID;
            supAddressTxtbx.Text = sup.Address;
            supEmailTxtbx.Text = sup.Email;
            supNameTxtbx.Text = sup.Company;
        }

        private void updateSupplierBtn_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (supNameTxtbx.Text.Length == 0) msg += "You should enter supplier name\n";
            if (supEmailTxtbx.Text.Length == 0) msg += "You should enter supplier email\n";
            if (supAddressTxtbx.Text.Length == 0) msg += "You should enter supplier address\n";
            if (msg.Length > 0)
            {
                Program.MessageWarn("Update Supplier!", msg);
                return;
            }
            if (Supplier.UpdateSupplier(supIDTxtbx.Text, supEmailTxtbx.Text, supNameTxtbx.Text, supAddressTxtbx.Text))
            {
                Program.MessageSuccess("Update Supplier!", "Supplier Updated Successful!");
                this.Close();
            }
        }
    }
}
