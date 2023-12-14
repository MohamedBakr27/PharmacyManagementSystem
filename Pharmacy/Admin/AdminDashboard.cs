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

namespace Pharmacy.Admin
{
    public partial class AdminDashboard : Form
    {
        enum tabState
        {
            Doctor,Customer,Cashier
        }
        static tabState curTab = tabState.Customer;
        public AdminDashboard()
        {
            InitializeComponent();
            tabCh();
        }
        private void tabCh()
        {
            updateBtn.Enabled = removeBtn.Enabled = false;
            if (curTab==tabState.Customer)
            {
                customerBtn.FillColor = Color.DarkCyan;
                cashierBtn.FillColor = Color.SlateGray;
                doctorBtn.FillColor = Color.SlateGray;
                shiftLbl.Visible = false;
                shiftTxtbx.Visible = false;
            }
            else if(curTab==tabState.Cashier)
            {
                customerBtn.FillColor = Color.SlateGray;
                cashierBtn.FillColor = Color.DarkCyan;
                doctorBtn.FillColor = Color.SlateGray;
                shiftLbl.Visible = true;
                shiftTxtbx.Visible = true;
            }
            else
            {
                customerBtn.FillColor = Color.SlateGray;
                cashierBtn.FillColor = Color.SlateGray;
                doctorBtn.FillColor = Color.DarkCyan;
                shiftLbl.Visible = false;
                shiftTxtbx.Visible = false;
            }
            fnameTxtbx.Clear();
            lnameTxtbx.Clear();
            usrnameTxtbx.Clear();
            passTxtbx.Clear();
            shiftTxtbx.Clear();
            viewTxtbx.Clear();
        }

        private void cashierBtn_Click(object sender, EventArgs e)
        {
            curTab = tabState.Cashier;
            tabCh();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            curTab = tabState.Customer;
            tabCh();
        }

        private void doctorBtn_Click(object sender, EventArgs e)
        {
            curTab = tabState.Doctor;
            tabCh();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (curTab == tabState.Customer)
            {
                string warnMessage = "";
                if (fnameTxtbx.Text.Length == 0) warnMessage += "You should enter first name.\n";
                if (lnameTxtbx.Text.Length == 0) warnMessage += "You should enter last name.\n";
                if (usrnameTxtbx.Text.Length == 0) warnMessage += "You should enter username.\n";
                if (passTxtbx.Text.Length == 0) warnMessage += "You should enter password.\n";
                if (warnMessage.Length > 0)
                {
                    Program.MessageWarn("Faild to Add!", warnMessage);
                    return;
                }
                if (Customer.AddCustomer(usrnameTxtbx.Text, fnameTxtbx.Text, lnameTxtbx.Text, passTxtbx.Text))
                {
                    updateBtn.Enabled = removeBtn.Enabled = true;
                    Program.MessageSuccess("Added Successful", $"Customer {fnameTxtbx.Text} {lnameTxtbx.Text} : was added to system.");
                }
            }
            else if (curTab == tabState.Cashier)
            {
                string warnMessage = "";
                if (fnameTxtbx.Text.Length == 0) warnMessage += "You should enter first name.\n";
                if (lnameTxtbx.Text.Length == 0) warnMessage += "You should enter last name.\n";
                if (usrnameTxtbx.Text.Length == 0) warnMessage += "You should enter username.\n";
                if (passTxtbx.Text.Length == 0) warnMessage += "You should enter password.\n";
                if (shiftTxtbx.Text.Length == 0) warnMessage += "You should enter shift.\n";
                if (warnMessage.Length > 0)
                {
                    Program.MessageWarn("Faild to Add!", warnMessage);
                    return;
                }
                if (Cashier.AddCashier(usrnameTxtbx.Text, fnameTxtbx.Text, lnameTxtbx.Text, passTxtbx.Text,shiftTxtbx.Text))
                {
                    updateBtn.Enabled = removeBtn.Enabled = true;
                    Program.MessageSuccess("Added Successful", $"Cashier {fnameTxtbx.Text} {lnameTxtbx.Text} : was added to system.");
                }
            }
            else
            {
                string warnMessage = "";
                if (fnameTxtbx.Text.Length == 0) warnMessage += "You should enter first name.\n";
                if (lnameTxtbx.Text.Length == 0) warnMessage += "You should enter last name.\n";
                if (usrnameTxtbx.Text.Length == 0) warnMessage += "You should enter username.\n";
                if (passTxtbx.Text.Length == 0) warnMessage += "You should enter password.\n";
                if (warnMessage.Length > 0)
                {
                    Program.MessageWarn("Faild to Add!", warnMessage);
                    return;
                }
                if (Doctor.AddDoctor(usrnameTxtbx.Text, fnameTxtbx.Text, lnameTxtbx.Text, passTxtbx.Text))
                {
                    updateBtn.Enabled = removeBtn.Enabled = true;
                    Program.MessageSuccess("Added Successful", $"Doctor {fnameTxtbx.Text} {lnameTxtbx.Text} : was added to system.");
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (curTab == tabState.Customer)
            {
                string warnMessage = "";
                if (fnameTxtbx.Text.Length == 0) warnMessage += "You should enter first name.\n";
                if (lnameTxtbx.Text.Length == 0) warnMessage += "You should enter last name.\n";
                if (usrnameTxtbx.Text.Length == 0) warnMessage += "You should enter username.\n";
                if (passTxtbx.Text.Length == 0) warnMessage += "You should enter password.\n";
                if (warnMessage.Length > 0)
                {
                    Program.MessageWarn("Faild to Update!", warnMessage);
                    return;
                }
                if (Customer.UpdateCustomer(usrnameTxtbx.Text, fnameTxtbx.Text, lnameTxtbx.Text, passTxtbx.Text))
                {
                    updateBtn.Enabled = removeBtn.Enabled = true;
                    Program.MessageSuccess("Updated Successful", $"Customer {fnameTxtbx.Text} {lnameTxtbx.Text} : was Updated in system.");
                }
            }
            else if (curTab == tabState.Cashier)
            {
                string warnMessage = "";
                if (fnameTxtbx.Text.Length == 0) warnMessage += "You should enter first name.\n";
                if (lnameTxtbx.Text.Length == 0) warnMessage += "You should enter last name.\n";
                if (usrnameTxtbx.Text.Length == 0) warnMessage += "You should enter username.\n";
                if (passTxtbx.Text.Length == 0) warnMessage += "You should enter password.\n";
                if (passTxtbx.Text.Length == 0) warnMessage += "You should enter shift.\n";
                if (warnMessage.Length > 0)
                {
                    Program.MessageWarn("Faild to Update!", warnMessage);
                    return;
                }
                if (Cashier.UpdateCashier(usrnameTxtbx.Text, fnameTxtbx.Text, lnameTxtbx.Text, passTxtbx.Text,shiftTxtbx.Text))
                {
                    updateBtn.Enabled = removeBtn.Enabled = true;
                    Program.MessageSuccess("Updated Successful", $"Cashier {fnameTxtbx.Text} {lnameTxtbx.Text} : was Updated in system.");
                }
            }
            else
            {
                string warnMessage = "";
                if (fnameTxtbx.Text.Length == 0) warnMessage += "You should enter first name.\n";
                if (lnameTxtbx.Text.Length == 0) warnMessage += "You should enter last name.\n";
                if (usrnameTxtbx.Text.Length == 0) warnMessage += "You should enter username.\n";
                if (passTxtbx.Text.Length == 0) warnMessage += "You should enter password.\n";
                if (warnMessage.Length > 0)
                {
                    Program.MessageWarn("Faild to Update!", warnMessage);
                    return;
                }
                if (Doctor.UpdateDoctor(usrnameTxtbx.Text, fnameTxtbx.Text, lnameTxtbx.Text, passTxtbx.Text))
                {
                    updateBtn.Enabled = removeBtn.Enabled = true;
                    Program.MessageSuccess("Updated Successful", $"Doctor {fnameTxtbx.Text} {lnameTxtbx.Text} : was Updated in system.");
                }
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (curTab == tabState.Customer)
            {
                string warnMessage = "";
                if (usrnameTxtbx.Text.Length == 0) warnMessage += "You should enter username.\n";
                if (warnMessage.Length > 0)
                {
                    Program.MessageWarn("Faild to remove!", warnMessage);
                    return;
                }
                if (!Customer.RemoveCustomer(usrnameTxtbx.Text)) return;
                Program.MessageSuccess("Removed Successful", $"Customer {usrnameTxtbx.Text} : was removed from system.");
                tabCh();
            }
            else if (curTab == tabState.Cashier)
            {
                string warnMessage = "";
                if (usrnameTxtbx.Text.Length == 0) warnMessage += "You should enter username.\n";
                if (warnMessage.Length > 0)
                {
                    Program.MessageWarn("Faild to remove!", warnMessage);
                    return;
                }
                if (!Cashier.RemoveCashier(usrnameTxtbx.Text)) return;
                Program.MessageSuccess("Removed Successful", $"Cashier {usrnameTxtbx.Text} : was removed from system.");
                tabCh();
            }
            else
            {
                string warnMessage = "";
                if (usrnameTxtbx.Text.Length == 0) warnMessage += "You should enter username.\n";
                if (warnMessage.Length > 0)
                {
                    Program.MessageWarn("Faild to remove!", warnMessage);
                    return;
                }
                if (!Doctor.RemoveDoctor(usrnameTxtbx.Text)) return;
                Program.MessageSuccess("Removed Successful", $"Doctor {usrnameTxtbx.Text} : was removed from system.");
                tabCh();
            }
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (viewTxtbx.Text.Length == 0)
            {
                Program.MessageWarn("Display Failed!", "You should enter username!");
                return;
            }
            DBCon db = DBCon.GetCon();
            db.con.Open();
            if(curTab==tabState.Customer)
            {
                var com = new SqlCommand($"select * from customer where customer_username = '{viewTxtbx.Text}'", db.con);
                var sdr = com.ExecuteReader();
                if (sdr.HasRows == false)
                    Program.MessageWarn("Display Failed!", "You should valid username!");
                else
                {
                    sdr.Read();
                    updateBtn.Enabled = removeBtn.Enabled = true;
                    usrnameTxtbx.Text = sdr[0].ToString();
                    fnameTxtbx.Text = sdr[1].ToString();
                    lnameTxtbx.Text = sdr[2].ToString();
                    passTxtbx.Text = sdr[3].ToString();
                }
            }
            else if (curTab == tabState.Cashier)
            {
                var com = new SqlCommand($"select * from cashier where cashier_username = '{viewTxtbx.Text}'", db.con);
                var sdr = com.ExecuteReader();
                if (sdr.HasRows == false)
                    Program.MessageWarn("Display Failed!", "You should valid username!");
                else
                {
                    sdr.Read();
                    updateBtn.Enabled = removeBtn.Enabled = true;
                    usrnameTxtbx.Text = sdr[0].ToString();
                    fnameTxtbx.Text = sdr[1].ToString();
                    lnameTxtbx.Text = sdr[2].ToString();
                    passTxtbx.Text = sdr[3].ToString();
                    shiftTxtbx.Text = sdr[4].ToString();
                }
            }
            else
            {
                var com = new SqlCommand($"select * from doctor where doc_username = '{viewTxtbx.Text}'", db.con);
                var sdr = com.ExecuteReader();
                if (sdr.HasRows == false)
                    Program.MessageWarn("Display Failed!", "You should valid username!");
                else
                {
                    sdr.Read();
                    updateBtn.Enabled = removeBtn.Enabled = true;
                    usrnameTxtbx.Text = sdr[0].ToString();
                    fnameTxtbx.Text = sdr[1].ToString();
                    lnameTxtbx.Text = sdr[2].ToString();
                    passTxtbx.Text = sdr[3].ToString();
                }
            }
            db.con.Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            new SqlCommand("delete tempReq\r\ndelete MedRcpt\r\ndelete OrderReceipt\r\ndelete Feedback\r\ndelete Report\r\ndelete Customer\r\ndelete Cashier\r\ndelete OrderSupplier\r\ndelete Medicine\r\ndelete Supplier\r\ndelete Doctor", db.con).ExecuteNonQuery();
            db.con.Close();
        }
    }
}
