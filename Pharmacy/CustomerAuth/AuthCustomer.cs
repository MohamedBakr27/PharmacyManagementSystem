using Pharmacy.EmployeeAuth;
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
    public partial class AuthCustomer : Form
    {
        public AuthCustomer()
        {
            InitializeComponent();
        }
        static bool lgn = true;

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string warnMessage = "";
            if (fnameTxtbx.Text.Length == 0) warnMessage += "You should enter your first name.\n";
            if (lnameTxtbx.Text.Length == 0) warnMessage += "You should enter your last name.\n";
            if (usrnameTxtbx.Text.Length == 0) warnMessage += "You should enter your username.\n";
            if (passTxtbx.Text.Length == 0) warnMessage += "You should enter your password.\n";
            if (passconfrmTxtbx.Text.Length == 0) warnMessage += "You should enter your confirmation password.\n";
            if(warnMessage.Length>0)
            {
                Program.MessageWarn("Register Failed!", warnMessage);
                return;
            }
            if (passTxtbx.Text != passconfrmTxtbx.Text) warnMessage += "You should enter same password in confirmation.";
            if (warnMessage.Length > 0)
            {
                Program.MessageWarn("Register Failed!", warnMessage);
                return;
            }
            if(Customer.AddCustomer(usrnameTxtbx.Text, fnameTxtbx.Text, lnameTxtbx.Text, passTxtbx.Text))
                changeState();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            string warnMessage = "";
            if (usrnameTxtbx.Text.Length == 0) warnMessage += "You should enter your username.\n";
            if (passTxtbx.Text.Length == 0) warnMessage += "You should enter your password.\n";
            if (warnMessage.Length > 0)
            {
                Program.MessageWarn("Login Failed!", warnMessage);
                return;
            }
            DBCon db = DBCon.GetCon();
            db.con.Open();
            bool invalid = new SqlCommand($"select * from customer where customer_username='{usrnameTxtbx.Text}' and password='{passTxtbx.Text}'", db.con).ExecuteReader().HasRows == false;
            db.con.Close();
            if (invalid)
            {
                Program.MessageWarn("Login Failed!", "Invalid login data!");
            }
            else
            {
                db.con.Open();

                var sdr = new SqlCommand($"select * from customer where customer_username = '{usrnameTxtbx.Text}'", db.con).ExecuteReader();
                sdr.Read();


                CustomerDashboard nw = new CustomerDashboard();
                nw.user = new Customer(sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString()); ;
                db.con.Close();

                this.Hide();
                nw.ini();
                nw.ShowDialog();

                this.Close();
            }
            db.con.Close();
        }
        private void changeState()
        {
            lgn = !lgn;
            if (lgn)
            {
                pageTitle.Text = "Login";
                fnameLbl.Visible = false;
                lnameLbl.Visible = false;
                passconfrmLbl.Visible = false;
                pageTitle.Location = new Point(454, 126);

                fnameTxtbx.Visible = false;
                lnameTxtbx.Visible = false;
                passconfrmTxtbx.Visible = false;

                registerBtn.Visible = false;
                loginBtn.Visible = true;
                nthvaccBtn.Text = "Not Have Account";
                this.Text = "Customer - Authentication - Login";
            }
            else
            {
                pageTitle.Text = "Register";
                fnameLbl.Visible = true;
                lnameLbl.Visible = true;
                passconfrmLbl.Visible = true;
                pageTitle.Location = new Point(433, 12);

                fnameTxtbx.Visible = true;
                lnameTxtbx.Visible = true;
                passconfrmTxtbx.Visible = true;

                registerBtn.Visible = true;
                loginBtn.Visible = false;
                nthvaccBtn.Text = "Have Account";
                this.Text = "Customer - Authentication - Register";
            }
        }

        private void nthvaccBtn_Click(object sender, EventArgs e)
        {
            changeState();
        }
    }
}
