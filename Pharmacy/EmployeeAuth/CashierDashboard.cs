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
using Pharmacy.CustomerAuth;

namespace Pharmacy.EmployeeAuth
{
    public partial class CashierDashboard : Form
    {
        public CashierDashboard()
        {
            InitializeComponent();
        }
        public object user;
        public void ini()
        {
            Cashier cust = (Cashier)user;
            userNameLbl.Text = cust.Fname + " " + cust.Lname;

            DBCon db = DBCon.GetCon();
            db.con.Open();
            outcomeLbl.Text = "-" + new SqlCommand("select sum(amount*Medicine.price) from OrderSupplier,Medicine where Medicine.med_id=OrderSupplier.med_id", db.con).ExecuteScalar().ToString() + "$";
            db.con.Close();

            reloadStockTable();
            reloadReportTable();
            reloadSaleTable();
            double total = 0;
            for (int i = 0; i < saleTable.Rows.Count; i++)
                total += double.Parse(saleTable.Rows[i].Cells[2].Value.ToString());
            incomeLbl.Text = "+" + total + "$";
            reloadOrderTable();
            reloadBtns();
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
            if (int.Parse(row[8].Value.ToString()) == 0) removeMedBtn.Enabled = true;
            else removeMedBtn.Enabled = false;
        }

        private void removeMedBtn_Click(object sender, EventArgs e)
        {
            string medID = stockTable.SelectedRows[0].Cells[0].Value.ToString();
            if (MessageBox.Show("Are you sure to remove?", "Remove Medicine", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Medicine.RemoveMedicine(medID))
                {
                    Program.MessageSuccess("Remove Medicine", "Medicine Removed successful");
                    reloadStockTable();
                    reloadBtns();
                }
            }
        }
        public void reloadStockTable()
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
        void reloadReportTable()
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            var sdr = new SqlCommand($"select r.rpt_id, c.fname+' '+c.lname [fullName],r.rpt_content,r.rpt_date from report r join doctor c on r.doc_username = c.doc_username\r\n and r.cashier_username = '{((Cashier)user).Username}'", db.con).ExecuteReader();
            for (int i = reportTable.Rows.Count - 1; i >= 0; i--)
                reportTable.Rows.RemoveAt(i); 
            while (sdr.Read())
            {
                string[] row = new string[] { sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), ((DateTime)sdr[3]).ToShortDateString() };
                reportTable.Rows.Add(row);
            }
            db.con.Close();
        }
        void reloadSaleTable()
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            var sdr = new SqlCommand("select OrderReceipt.rcpt_id, OrderReceipt.rcpt_date, OrderReceipt.payment, cashier.fname+' '+Cashier.lname[cashierName], Customer.fname+' '+Customer.lname[customerName] from OrderReceipt, Cashier, Customer where OrderReceipt.cashier_username = Cashier.cashier_username and OrderReceipt.customer_username=customer.customer_username", db.con).ExecuteReader();
            for (int i = saleTable.Rows.Count - 1; i >= 0; i--)
                saleTable.Rows.RemoveAt(i); 
            while (sdr.Read())
            {
                string[] row = new string[] { sdr[0].ToString(), ((DateTime)sdr[1]).ToShortDateString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString() };
                saleTable.Rows.Add(row);
            }
            db.con.Close();
        }
        void reloadOrderTable()
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            HashSet<string> vis = new HashSet<string>();
            var sdr = new SqlCommand($"select o.rcpt_id,o.payment,c.fname+' '+c.lname[fullName],o.rcpt_date from OrderReceipt o, tempReq t, Customer c where t.rcpt_id = o.rcpt_id and c.customer_username=o.customer_username", db.con).ExecuteReader();
            for (int i = ordersTable.Rows.Count - 1; i >= 0; i--)
                ordersTable.Rows.RemoveAt(i);
            while (sdr.Read())
            {
                string[] row = new string[] { sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString() };
                vis.Add(row[0]);
                ordersTable.Rows.Add(row);
            }
            db.con.Close();
        }
        void reloadBtns()
        {
            acceptBtn.Enabled = rejectBtn.Enabled = ordersTable.Rows.Count != 0;
            viewMedBtn.Enabled = removeMedBtn.Enabled = updateMedBtn.Enabled = stockTable.Rows.Count != 0;
            viewRcptBtn.Enabled = saleTable.Rows.Count != 0;
            viewRprtBtn.Enabled = reportTable.Rows.Count != 0;
        }
        private void addMedBtn_Click(object sender, EventArgs e)
        {
            AddMedicine nw = new AddMedicine();
            nw.ini();
            nw.ShowDialog();
            reloadStockTable();
            reloadBtns();
        }

        private void updateMedBtn_Click(object sender, EventArgs e)
        {
            UpdateMedicine nw = new UpdateMedicine();
            var row = stockTable.SelectedRows[0].Cells;
            string[] tm = row[5].Value.ToString().Split('/');
            nw.medicine = new Medicine(row[0].Value.ToString(), row[1].Value.ToString(), row[2].Value.ToString(), row[3].Value.ToString(), row[4].Value.ToString(), new DateTime(int.Parse(tm[2]), int.Parse(tm[0]), int.Parse(tm[1])), row[6].Value.ToString(), double.Parse(row[7].Value.ToString()), int.Parse(row[8].Value.ToString()));
            nw.ini();
            nw.ShowDialog();
            reloadStockTable();
            reloadBtns();
        }

        private void viewRcptBtn_Click(object sender, EventArgs e)
        {
            ViewReceipt nw = new ViewReceipt();
            var row = saleTable.SelectedRows[0].Cells;
            nw.rcptID = row[0].Value.ToString();
            nw.date = row[1].Value.ToString();
            nw.total = row[2].Value.ToString();
            nw.cashierName = row[3].Value.ToString();
            nw.customerName = row[4].Value.ToString();
            nw.ini();
            nw.ShowDialog();
        }

        private void viewRprtBtn_Click(object sender, EventArgs e)
        {
            ViewReport nw = new ViewReport();
            var row = reportTable.SelectedRows[0].Cells;
            string[] tm = row[3].Value.ToString().Split('/');
            nw.report = new Report(row[0].Value.ToString(), row[2].Value.ToString(), new DateTime(int.Parse(tm[2]), int.Parse(tm[0]), int.Parse(tm[1])));
            nw.ini();
            nw.ShowDialog();
        }

        private void sendRprtBtn_Click(object sender, EventArgs e)
        {
            SendReport nw = new SendReport();
            nw.user = this.user;
            nw.ShowDialog();
            reloadReportTable();
            reloadBtns();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            if (!this.Focused) return;
            if (tabs.SelectedIndex !=1 ) reloadStockTable();
            if (tabs.SelectedIndex != 2) reloadReportTable();
            if (tabs.SelectedIndex != 3) reloadSaleTable();
            if (tabs.SelectedIndex != 4) reloadOrderTable();
            reloadBtns();
            DBCon db = DBCon.GetCon();
            db.con.Open();
            outcomeLbl.Text = "-" + new SqlCommand("select sum(amount*Medicine.price) from OrderSupplier,Medicine where Medicine.med_id=OrderSupplier.med_id", db.con).ExecuteScalar().ToString() + "$";
            db.con.Close();
        }

        private void ordersTable_SelectionChanged(object sender, EventArgs e)
        {
            if (ordersTable.SelectedRows.Count == 0) return;
            var row = ordersTable.SelectedRows[0].Cells;
            if (row[3].Value.ToString() == "Accepted") viewRcptBtn.Enabled = true;
            else viewRcptBtn.Enabled = false;
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            DBCon db = DBCon.GetCon();
            var row = ordersTable.SelectedRows[0].Cells;
            db.con.Open();
            new SqlCommand($"update OrderReceipt set cashier_username = '{((Cashier)user).Username}' where rcpt_id = '{row[0].Value.ToString()}'",db.con).ExecuteNonQuery();
            
            new SqlCommand($"delete tempReq where rcpt_id = '{row[0].Value.ToString()}'", db.con).ExecuteNonQuery();
            db.con.Close();
            reloadOrderTable();
            reloadSaleTable();
            reloadBtns();
            double total = 0;
            for (int i = 0; i < saleTable.Rows.Count; i++)
                total += double.Parse(saleTable.Rows[i].Cells[2].Value.ToString());
            incomeLbl.Text = "+" + total + "$";
        }

        private void rejectBtn_Click(object sender, EventArgs e)
        {
            DBCon db = DBCon.GetCon();
            var row = ordersTable.SelectedRows[0].Cells;
            db.con.Open();
            var sdr = new SqlCommand($"select med_id,quantity from medRcpt where rcpt_id = '{row[0].Value.ToString()}'", db.con).ExecuteReader();
            List<List<string>> quer = new List<List<string>>();
            while (sdr.Read())
                quer.Add(new List<string>() { sdr[0].ToString(), sdr[1].ToString() });
            db.con.Close();
            foreach(var q in quer)
            {
                db.con.Open();
                new SqlCommand($"update medicine set quantity = quantity + {q[1]} where med_id = '{q[0]}'", db.con).ExecuteNonQuery();
                db.con.Close();
            }
            db.con.Open();
            new SqlCommand($"delete medrcpt where rcpt_id = '{row[0].Value.ToString()}'", db.con).ExecuteNonQuery();
            new SqlCommand($"delete tempReq where rcpt_id = '{row[0].Value.ToString()}'", db.con).ExecuteNonQuery();
            new SqlCommand($"delete OrderReceipt where rcpt_id = '{row[0].Value.ToString()}'", db.con).ExecuteNonQuery();
            db.con.Close();
            reloadOrderTable();
            reloadSaleTable();
            reloadStockTable();
            reloadBtns();
            double total = 0;
            for (int i = 0; i < saleTable.Rows.Count; i++)
                total += double.Parse(saleTable.Rows[i].Cells[2].Value.ToString());
            incomeLbl.Text = "+" + total + "$";
        }

        private void changeNameBtn_Click(object sender, EventArgs e)
        {
            ChangeName nw = new ChangeName();
            nw.cur = 1;
            nw.user = this.user;
            nw.ShowDialog();
            Cashier c = (Cashier)user;
            userNameLbl.Text = c.Fname + " " + c.Lname;
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            ChangePassword nw = new ChangePassword();
            nw.cur = 1;
            nw.user = this.user;
            nw.ShowDialog();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            AuthEmployee nw = new AuthEmployee();
            this.Hide();
            nw.ShowDialog();
        }
    }
}
