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
    public partial class DoctorDashboard : Form
    {
        public DoctorDashboard()
        {
            InitializeComponent();
        }
        public object user;
        public void ini()
        {
            Doctor cust = (Doctor)user;
            userNameLbl.Text = cust.Fname + " " + cust.Lname;

            DBCon db = DBCon.GetCon();
            db.con.Open();
            outcomeLbl.Text = "-"+new SqlCommand("select sum(amount*Medicine.price) from OrderSupplier,Medicine where Medicine.med_id=OrderSupplier.med_id", db.con).ExecuteScalar().ToString()+"$";
            db.con.Close();

            reloadStockTable();
            reloadReportTable();
            reloadSaleTable();
            double total = 0;
            for (int i = 0; i < saleTable.Rows.Count; i++)
                total += double.Parse(saleTable.Rows[i].Cells[2].Value.ToString());
            incomeLbl.Text = "+" +total+ "$";
            reloadFeedbackTable();
            reloadSupplierTable();
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
        void reloadReportTable()
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            var sdr = new SqlCommand("select r.rpt_id, c.fname+' '+c.lname [fullName],r.rpt_content,r.rpt_date from report r join cashier c on r.cashier_username = c.cashier_username", db.con).ExecuteReader();
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
        void reloadFeedbackTable()
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            var sdr = new SqlCommand("select f.fb_id, c.fname+' '+c.lname [fullName],f.fb_content,f.fb_date from feedback f join Customer c on f.customer_username = c.customer_username", db.con).ExecuteReader();
            for (int i = feedbackTable.Rows.Count - 1; i >= 0; i--)
                feedbackTable.Rows.RemoveAt(i);
            while (sdr.Read())
            {
                string[] row = new string[] { sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), ((DateTime)sdr[3]).ToShortDateString() };
                feedbackTable.Rows.Add(row);
            }
            db.con.Close();
        }
        void reloadSupplierTable()
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            var sdr = new SqlCommand("select * from supplier", db.con).ExecuteReader();
            for (int i = supplierTable.Rows.Count - 1; i >= 0; i--)
                supplierTable.Rows.RemoveAt(i);
            while (sdr.Read())
            {
                string[] row = new string[] { sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString() };
                supplierTable.Rows.Add(row);
            }
            db.con.Close();
        }
        void reloadBtns()
        {
            removeSupplierBtn.Enabled = updateSupplierBtn.Enabled = sendOrderBtn.Enabled = viewOrdersBtn.Enabled = supplierTable.Rows.Count != 0;
            viewFeedbackBtn.Enabled = feedbackTable.Rows.Count != 0;
            viewRprtBtn.Enabled = reportTable.Rows.Count != 0;
            viewRcptBtn.Enabled = saleTable.Rows.Count != 0;
            removeMedBtn.Enabled = updateMedBtn.Enabled = viewMedBtn.Enabled = stockTable.Rows.Count != 0;
            if (supplierTable.Rows.Count > 0)
            {
                DBCon db = DBCon.GetCon();
                var row = supplierTable.SelectedRows[0].Cells;
                db.con.Open();
                sendOrderBtn.Enabled = new SqlCommand($"select count(*) from medicine where sup_id = '{row[0].Value.ToString()}'", db.con).ExecuteScalar().ToString() != "0";
                db.con.Close();
            }
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

        private void removeSupplierBtn_Click(object sender, EventArgs e)
        {
            string supID = supplierTable.SelectedRows[0].Cells[0].Value.ToString();
            if (MessageBox.Show("Are you sure to remove?","Remove Supplier", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Supplier.RemoveSupplier(supID))
                {
                    Program.MessageSuccess("Remove Supplier", "Supplier Removed successful");
                    reloadSupplierTable();
                    reloadBtns();
                }
            }
        }

        private void addSupplierBtn_Click(object sender, EventArgs e)
        {
            AddSupplier nw = new AddSupplier();
            nw.ShowDialog();
            reloadSupplierTable();
            reloadBtns();
        }

        private void updateSupplierBtn_Click(object sender, EventArgs e)
        {
            UpdateSupplier nw = new UpdateSupplier();
            var row = supplierTable.SelectedRows[0].Cells;
            nw.supplier = new Supplier(row[0].Value.ToString(), row[1].Value.ToString(), row[2].Value.ToString(), row[3].Value.ToString());
            nw.ini();
            nw.ShowDialog();
            reloadSupplierTable();
            reloadStockTable();
            reloadBtns();
        }

        private void viewOrdersBtn_Click(object sender, EventArgs e)
        {
            ViewOrders nw = new ViewOrders();
            var row = supplierTable.SelectedRows[0].Cells;
            nw.supplier = new Supplier(row[0].Value.ToString(), row[1].Value.ToString(), row[2].Value.ToString(), row[3].Value.ToString());
            nw.ini();
            nw.ShowDialog();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            if (tabs.SelectedIndex != 1) reloadStockTable();
            if (tabs.SelectedIndex != 2) reloadReportTable();
            if (tabs.SelectedIndex != 4) reloadSaleTable();
            if (tabs.SelectedIndex != 3) reloadFeedbackTable();
            if (tabs.SelectedIndex != 5) reloadSupplierTable();
            reloadBtns();
            DBCon db = DBCon.GetCon();
            db.con.Open();
            outcomeLbl.Text = "-" + new SqlCommand("select sum(amount*Medicine.price) from OrderSupplier,Medicine where Medicine.med_id=OrderSupplier.med_id", db.con).ExecuteScalar().ToString() + "$";
            db.con.Close();
        }

        private void sendOrderBtn_Click(object sender, EventArgs e)
        {
            DBCon db = DBCon.GetCon();
            var row = supplierTable.SelectedRows[0].Cells;
            db.con.Open();
            sendOrderBtn.Enabled = new SqlCommand($"select count(*) from medicine where sup_id = '{row[0].Value.ToString()}'", db.con).ExecuteScalar().ToString() != "0";
            db.con.Close();
            if (!sendOrderBtn.Enabled) return;
            SendOrder nw = new SendOrder();
            nw.supplier = new Supplier(row[0].Value.ToString(), row[1].Value.ToString(), row[2].Value.ToString(), row[3].Value.ToString());
            nw.user = this.user;
            nw.ini();
            nw.ShowDialog();
            reloadStockTable();
            reloadBtns();
        }

        private void changeNameBtn_Click(object sender, EventArgs e)
        {
            ChangeName nw = new ChangeName();
            nw.cur = 2;
            nw.user = this.user;
            nw.ShowDialog();
            Doctor c = (Doctor)user;
            userNameLbl.Text = c.Fname + " " + c.Lname;
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            ChangePassword nw = new ChangePassword();
            nw.cur = 2;
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
