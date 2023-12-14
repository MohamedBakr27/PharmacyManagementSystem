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
using System.Xml;
using Pharmacy.EmployeeAuth;

namespace Pharmacy.CustomerAuth
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }
        public object user;
        public void ini()
        {
            Customer cust = (Customer)user;
            userNameLbl.Text = cust.Fname + " " + cust.Lname;
            reloadStockTable();
            reloadFeedbackTable();
            reloadOrderTable();
            double total = 0;
            for (int i = 0; i < ordersTable.Rows.Count; i++)
                total += double.Parse(ordersTable.Rows[i].Cells[1].Value.ToString());
            ordersNumLbl.Text = ordersTable.Rows.Count.ToString();
            spentLbl.Text = total.ToString() + "$";
            reloadBtns();

        }
        void reloadStockTable()
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            var sdr = new SqlCommand("select med.med_id,med.generic_name,med.brand_name,med.category,med.type,med.exp_date,sup.company,med.price,med.quantity from medicine med join Supplier sup on sup.sup_id = med.sup_id", db.con).ExecuteReader();
            for (int i = stockTable.Rows.Count - 1; i >= 0; i--)
                stockTable.Rows.RemoveAt(i);
            while (sdr.Read())
            {
                string[] row = new string[] { sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString(), ((DateTime)sdr[5]).ToShortDateString(), sdr[6].ToString(), sdr[7].ToString(), sdr[8].ToString() };
                stockTable.Rows.Add(row);
            }
            db.con.Close();
        }
        void reloadFeedbackTable()
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            var sdr = new SqlCommand($"select r.fb_id, c.fname+' '+c.lname [fullName],r.fb_content,r.fb_date from Feedback r join doctor c on r.doc_username = c.doc_username and r.customer_username = '{((Customer)user).Username}'", db.con).ExecuteReader();
            for (int i = feedbackTable.Rows.Count - 1; i >= 0; i--)
                feedbackTable.Rows.RemoveAt(i);
            while (sdr.Read())
            {
                string[] row = new string[] { sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), ((DateTime)sdr[3]).ToShortDateString() };
                feedbackTable.Rows.Add(row);
            }
            db.con.Close();
        }
        void reloadOrderTable()
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            HashSet<string> vis = new HashSet<string>();
            var sdr = new SqlCommand($"select o.rcpt_id,o.payment,o.rcpt_date from OrderReceipt o, tempReq t where o.customer_username='{((Customer)user).Username}' and t.rcpt_id = o.rcpt_id", db.con).ExecuteReader();
            for (int i = ordersTable.Rows.Count - 1; i >= 0; i--)
                ordersTable.Rows.RemoveAt(i);
            while (sdr.Read())
            {
                string[] row = new string[] { sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(),"Pending" };
                vis.Add(row[0]);
                ordersTable.Rows.Add(row);
            }
            db.con.Close();

            db.con.Open();
            sdr = new SqlCommand($"select rcpt_id,payment,rcpt_date from OrderReceipt  where customer_username='{((Customer)user).Username}'", db.con).ExecuteReader();
            while (sdr.Read())
            {
                string[] row = new string[] { sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), "Accepted" };
                if (!vis.Contains(row[0]))
                    ordersTable.Rows.Add(row);
            }
            db.con.Close();
        }
        void reloadBtns()
        {
            viewMedBtn.Enabled = buyMedBtn.Enabled = stockTable.Rows.Count != 0;
            viewFeedbackBtn.Enabled = feedbackTable.Rows.Count != 0;
        }
        private void viewFeedbackBtn_Click(object sender, EventArgs e)
        {
            ViewReport nw = new ViewReport();
            var row = feedbackTable.SelectedRows[0].Cells;
            string[] tm = row[3].Value.ToString().Split('/');
            nw.report = new Feedback(row[0].Value.ToString(), row[2].Value.ToString(), new DateTime(int.Parse(tm[2]), int.Parse(tm[0]), int.Parse(tm[1])));
            nw.Text = "View Feedback";
            nw.ini();
            nw.ShowDialog();
        }

        private void sendFeedbackBtn_Click(object sender, EventArgs e)
        {
            SendReport nw = new SendReport();
            nw.user = this.user;
            nw.Text = "Send Feedback";
            nw.ShowDialog();
            reloadFeedbackTable();
            reloadBtns();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            if (!this.Focused) return;
            if (tabs.SelectedIndex != 1) reloadStockTable();
            if (tabs.SelectedIndex != 2) reloadFeedbackTable();
            if (tabs.SelectedIndex != 3) reloadOrderTable();
            reloadBtns();
        }
        private bool prefix(string s,string t)
        {
            int l = 0, r = 0;
            while (l < s.Length && r < t.Length)
            {
                if (s[l] != t[r]) return false;
                l++;
                r++;
            }
            return l == s.Length;
        }
        private void searchTxtbx_TextChanged(object sender, EventArgs e)
        {
            if (searchTxtbx.Text.Length == 0)
            {
                reloadStockTable();
                return;
            }
            List<List<string>> res = new List<List<string>>();
            DBCon db = DBCon.GetCon();
            db.con.Open();
            for (int i = stockTable.Rows.Count - 1; i >= 0; i--)
                stockTable.Rows.RemoveAt(i);
            var sdr = new SqlCommand("select med.med_id,med.generic_name,med.brand_name,med.category,med.type,med.exp_date,sup.company,med.price,med.quantity from medicine med join Supplier sup on sup.sup_id = med.sup_id", db.con).ExecuteReader();
            while (sdr.Read())
            {
                string[] row = new string[] { sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString(), ((DateTime)sdr[5]).ToShortDateString(), sdr[6].ToString(), sdr[7].ToString(), sdr[8].ToString() };
                for(int i = 0; i < 3; i++)
                {
                    if (prefix(searchTxtbx.Text, row[i]))
                    {
                        stockTable.Rows.Add(row);
                        break;
                    }
                }
            }
            db.con.Close();
        }

        private void viewMedBtn_Click(object sender, EventArgs e)
        {
            ViewMedicine nw = new ViewMedicine();
            var row = stockTable.SelectedRows[0].Cells;
            string[] tm = row[5].Value.ToString().Split('/');
            nw.medicine = new Medicine(row[0].Value.ToString(), row[1].Value.ToString(), row[2].Value.ToString(), row[3].Value.ToString(), row[4].Value.ToString(), new DateTime(int.Parse(tm[2]), int.Parse(tm[0]), int.Parse(tm[1])), row[6].Value.ToString(), double.Parse(row[7].Value.ToString()), int.Parse(row[8].Value.ToString()));
            nw.ini();
            nw.ShowDialog();
        }

        private void stockTable_SelectionChanged(object sender, EventArgs e)
        {
            if (stockTable.SelectedRows.Count == 0) return;
            var row = stockTable.SelectedRows[0].Cells;
            if (int.Parse(row[8].Value.ToString()) > 0) buyMedBtn.Enabled = true;
            else buyMedBtn.Enabled = false;
        }

        private void buyMedBtn_Click(object sender, EventArgs e)
        {
            BuyMedicine nw = new BuyMedicine();
            nw.stockTable = this.stockTable;
            nw.user = this.user;
            nw.ini();
            nw.ShowDialog();
            reloadStockTable();
            reloadOrderTable();
            reloadBtns();
            double total = 0;
            for (int i = 0; i < ordersTable.Rows.Count; i++)
                total += double.Parse(ordersTable.Rows[i].Cells[1].Value.ToString());
            ordersNumLbl.Text = ordersTable.Rows.Count.ToString();
            spentLbl.Text = total.ToString() + "$";
        }

        private void ordersTable_SelectionChanged(object sender, EventArgs e)
        {
            if (ordersTable.SelectedRows.Count == 0) return;
            var row = ordersTable.SelectedRows[0].Cells;
            if (row[3].Value.ToString() == "Accepted") viewRcptBtn.Enabled = true;
            else viewRcptBtn.Enabled = false;
        }

        private void viewRcptBtn_Click(object sender, EventArgs e)
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            ViewReceipt nw = new ViewReceipt();
            var row = ordersTable.SelectedRows[0].Cells;
            nw.rcptID = row[0].Value.ToString();
            nw.date = row[1].Value.ToString();
            nw.total = row[2].Value.ToString();
            nw.cashierName = (string)new SqlCommand($"select c.fname+' '+c.lname[fullName] from cashier c,OrderReceipt o where o.rcpt_id='{nw.rcptID}' and c.cashier_username = o.cashier_username", db.con).ExecuteScalar();
            nw.customerName = ((Customer)user).Username;
            db.con.Close();
            nw.ini();
            nw.ShowDialog();
        }

        private void changeNameBtn_Click(object sender, EventArgs e)
        {
            ChangeName nw = new ChangeName();
            nw.cur = 0;
            nw.user = this.user;
            nw.ShowDialog();
            Customer c = (Customer)user;
            userNameLbl.Text = c.Fname + " " + c.Lname;
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            ChangePassword nw = new ChangePassword();
            nw.cur = 0;
            nw.user = this.user;
            nw.ShowDialog();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            AuthCustomer nw = new AuthCustomer();
            this.Hide();
            nw.ShowDialog();
        }
    }
}
