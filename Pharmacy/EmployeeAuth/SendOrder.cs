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
    public partial class SendOrder : Form
    {
        public SendOrder()
        {
            InitializeComponent();
        }
        public object supplier;
        public object user;
        static Dictionary<string, double> medNameToPrice = new Dictionary<string, double>();
        static Dictionary<string, string> medNameToID = new Dictionary<string, string>();
        public void ini()
        {
            Supplier sup = (Supplier)supplier;
            supNameLbl.Text = "Supplier : " + sup.Company;
            DBCon db = DBCon.GetCon();
            db.con.Open();
            var sdr = new SqlCommand($"select brand_name,price,med_id from medicine where sup_id = '{sup.SupID}'", db.con).ExecuteReader();
            while (sdr.Read())
            {
                medNameToPrice[sdr[0].ToString()] = double.Parse(sdr[1].ToString());
                medCb.Items.Add(sdr[0].ToString());
                medNameToID[sdr[0].ToString()] = sdr[2].ToString();
            }
            medCb.SelectedIndex = 0;
            db.con.Close();
        }

        private void medCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalLbl.Text = $"Total = {(medNameToPrice[medCb.SelectedItem.ToString()] * (double)quantityNum.Value).ToString()}$";
        }

        private void quantityNum_ValueChanged(object sender, EventArgs e)
        {
            totalLbl.Text = $"Total = {(medNameToPrice[medCb.SelectedItem.ToString()] * (double)quantityNum.Value).ToString()}$";
        }

        private void sendOrderBtn_Click(object sender, EventArgs e)
        {
            if (quantityNum.Value == 0)
            {
                Program.MessageWarn("Send Order!", "You should choose quantity.");
                return;
            }
            DBCon db = DBCon.GetCon();
            db.con.Open();
            SqlCommand com = new SqlCommand("select count(*) from OrderSupplier", db.con);
            int sz = (int)com.ExecuteScalar();
            string orderID = "1";
            if (sz != 0)
            {
                com = new SqlCommand("select order_id from OrderSupplier order by order_id desc", db.con);
                orderID = (1 + (int)com.ExecuteScalar()).ToString();
            }
            com = new SqlCommand($"insert into OrderSupplier values('{orderID}','{((Supplier)supplier).SupID}','{((Doctor)user).Username}','{medNameToID[medCb.SelectedItem.ToString()]}','{quantityNum.Value.ToString()}','{DateTime.Now.ToShortDateString()}')", db.con);
            com.ExecuteNonQuery();
            db.con.Close();
            Program.MessageSuccess("Send Order!", "Order Sent Successful!");
            db.con.Open();
            com = new SqlCommand("update medicine set quantity = quantity + '"+(int)quantityNum.Value+"' where med_id = '"+ medNameToID[medCb.SelectedItem.ToString()] + "'", db.con);
            com.ExecuteNonQuery();
            db.con.Close();
            this.Close();
        }
    }
}
