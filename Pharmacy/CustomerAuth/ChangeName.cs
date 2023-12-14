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
    public partial class ChangeName : Form
    {
        public ChangeName()
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
                string pass = new SqlCommand($"select password from customer where customer_username = '{cust.Username}'", db.con).ExecuteScalar().ToString();
                db.con.Close();
                string msg = "";
                if (fnameTxtbx.Text.Length == 0) msg += "You should enter first name\n";
                if (lnameTxtbx.Text.Length == 0) msg += "You should enter last name\n";
                if(msg.Length > 0)
                {
                    Program.MessageWarn("Change Name!", msg);
                    return;
                }
                if(passTxtbx.Text.Length ==0 || passTxtbx.Text != pass)
                {
                    Program.MessageWarn("Change Name!", "You should enter valid password");
                    return;
                }
                Customer.UpdateCustomer(cust.Username, fnameTxtbx.Text, lnameTxtbx.Text, pass);
                Program.MessageSuccess("Change Name!", "Name changed successful");
                ((Customer)user).Fname = fnameTxtbx.Text;
                ((Customer)user).Lname = lnameTxtbx.Text; 
                this.Close();
            }
            else if (cur == 1)
            {
                Cashier cust = (Cashier)user;
                DBCon db = DBCon.GetCon();
                db.con.Open();
                string pass = new SqlCommand($"select password from cashier where cashier_username = '{cust.Username}'", db.con).ExecuteScalar().ToString();
                db.con.Close();
                string msg = "";
                if (fnameTxtbx.Text.Length == 0) msg += "You should enter first name\n";
                if (lnameTxtbx.Text.Length == 0) msg += "You should enter last name\n";
                if (msg.Length > 0)
                {
                    Program.MessageWarn("Change Name!", msg);
                    return;
                }
                if (passTxtbx.Text.Length == 0 || passTxtbx.Text != pass)
                {
                    Program.MessageWarn("Change Name!", "You should enter valid password");
                    return;
                }
                Cashier.UpdateCashier(cust.Username, fnameTxtbx.Text, lnameTxtbx.Text, pass,cust.Shift);
                Program.MessageSuccess("Change Name!", "Name changed successful");
                ((Cashier)user).Fname = fnameTxtbx.Text;
                ((Cashier)user).Lname = lnameTxtbx.Text;
                this.Close();
            }
            else
            {
                Doctor cust = (Doctor)user;
                DBCon db = DBCon.GetCon();
                db.con.Open();
                string pass = new SqlCommand($"select password from doctor where doc_username = '{cust.Username}'", db.con).ExecuteScalar().ToString();
                db.con.Close();
                string msg = "";
                if (fnameTxtbx.Text.Length == 0) msg += "You should enter first name\n";
                if (lnameTxtbx.Text.Length == 0) msg += "You should enter last name\n";
                if (msg.Length > 0)
                {
                    Program.MessageWarn("Change Name!", msg);
                    return;
                }
                if (passTxtbx.Text.Length == 0 || passTxtbx.Text != pass)
                {
                    Program.MessageWarn("Change Name!", "You should enter valid password");
                    return;
                }
                Doctor.UpdateDoctor(cust.Username, fnameTxtbx.Text, lnameTxtbx.Text, pass);
                Program.MessageSuccess("Change Name!", "Name changed successful");
                ((Doctor)user).Fname = fnameTxtbx.Text;
                ((Doctor)user).Lname = lnameTxtbx.Text;
                this.Close();
            }
        }
    }
}
