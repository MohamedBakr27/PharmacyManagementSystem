using Pharmacy.Admin;
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

namespace Pharmacy.EmployeeAuth
{
    public partial class AuthEmployee : Form
    {
        public AuthEmployee()
        {
            InitializeComponent();
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
            bool isCashier = new SqlCommand($"select * from cashier where cashier_username='{usrnameTxtbx.Text}' and password='{passTxtbx.Text}'", db.con).ExecuteReader().HasRows;
            db.con.Close();

            db.con.Open();
            bool isDoctor = new SqlCommand($"select * from doctor where doc_username='{usrnameTxtbx.Text}' and password='{passTxtbx.Text}'", db.con).ExecuteReader().HasRows;
            db.con.Close();
            if (isCashier)
            {
                db.con.Open();

                var sdr = new SqlCommand($"select * from cashier where cashier_username = '{usrnameTxtbx.Text}'", db.con).ExecuteReader();
                sdr.Read();


                CashierDashboard nw = new CashierDashboard();
                nw.user = new Cashier(sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), sdr[4].ToString()); ;
                db.con.Close();

                this.Hide();
                nw.ini();
                nw.ShowDialog();

                this.Close();
                return;
            }
            else if (isDoctor)
            {
                db.con.Open();

                var sdr = new SqlCommand($"select * from doctor where doc_username = '{usrnameTxtbx.Text}'", db.con).ExecuteReader();
                sdr.Read();


                DoctorDashboard nw = new DoctorDashboard();
                nw.user = new Doctor(sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString()); ;
                db.con.Close();

                this.Hide();
                nw.ini();
                nw.ShowDialog();

                this.Close();
                return;
            }
            else
            {
                Program.MessageWarn("Login Failed!", "Invalid login data!");
            }
        }
    }
}
