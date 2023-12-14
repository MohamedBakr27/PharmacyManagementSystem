using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.CustomerAuth
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        public object user;
        public int cur = 0;
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (cur == 0)
            {
                Customer cust = (Customer)user;
                DBCon db = DBCon.GetCon();
                db.con.Open();
                string oldPass = new SqlCommand($"select password from customer where customer_username = '{cust.Username}'", db.con).ExecuteScalar().ToString();
                db.con.Close();
                if (oldPassTxtbx.Text.Length == 0 || oldPassTxtbx.Text != oldPass)
                {
                    Program.MessageWarn("Change Password!", "You should enter valid old password");
                    return;
                }
                if (newPassTxtbx.Text.Length == 0)
                {
                    Program.MessageWarn("Change Password!", "You should enter new password");
                    return;
                }
                if (confPassTxtbx.Text.Length == 0 || newPassTxtbx.Text != confPassTxtbx.Text)
                {
                    Program.MessageWarn("Change Password!", "You should enter valid confirmation");
                    return;
                }
                Customer.UpdateCustomer(cust.Username, cust.Fname, cust.Lname, newPassTxtbx.Text);
                Program.MessageSuccess("Change Password!", "Password changed successful");
                this.Close();
            }
            else if (cur == 1)
            {
                Cashier cust = (Cashier)user;
                DBCon db = DBCon.GetCon();
                db.con.Open();
                string oldPass = new SqlCommand($"select password from cashier where cashier_username = '{cust.Username}'", db.con).ExecuteScalar().ToString();
                db.con.Close();
                if (oldPassTxtbx.Text.Length == 0 || oldPassTxtbx.Text != oldPass)
                {
                    Program.MessageWarn("Change Password!", "You should enter valid old password");
                    return;
                }
                if (newPassTxtbx.Text.Length == 0)
                {
                    Program.MessageWarn("Change Password!", "You should enter new password");
                    return;
                }
                if (confPassTxtbx.Text.Length == 0 || newPassTxtbx.Text != confPassTxtbx.Text)
                {
                    Program.MessageWarn("Change Password!", "You should enter valid confirmation");
                    return;
                }
                Cashier.UpdateCashier(cust.Username, cust.Fname, cust.Lname, newPassTxtbx.Text,cust.Shift);
                Program.MessageSuccess("Change Password!", "Password changed successful");
                this.Close();
            }
            else
            {
                Doctor cust = (Doctor)user;
                DBCon db = DBCon.GetCon();
                db.con.Open();
                string oldPass = new SqlCommand($"select password from doctor where doc_username = '{cust.Username}'", db.con).ExecuteScalar().ToString();
                db.con.Close();
                if (oldPassTxtbx.Text.Length == 0 || oldPassTxtbx.Text != oldPass)
                {
                    Program.MessageWarn("Change Password!", "You should enter valid old password");
                    return;
                }
                if (newPassTxtbx.Text.Length == 0)
                {
                    Program.MessageWarn("Change Password!", "You should enter new password");
                    return;
                }
                if (confPassTxtbx.Text.Length == 0 || newPassTxtbx.Text != confPassTxtbx.Text)
                {
                    Program.MessageWarn("Change Password!", "You should enter valid confirmation");
                    return;
                }
                Doctor.UpdateDoctor(cust.Username, cust.Fname, cust.Lname, newPassTxtbx.Text);
                Program.MessageSuccess("Change Password!", "Password changed successful");
                this.Close();
            }
        }
    }
}
