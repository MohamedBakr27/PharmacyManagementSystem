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
    public partial class ViewReceipt : Form
    {
        public ViewReceipt()
        {
            InitializeComponent();
        }
        public string rcptID, cashierName, customerName, date, total;
        public void ini()
        {
            cashierNameTitle.Text = cashierName;
            customerNameTitle.Text = customerName;
            totalTitle.Text = total;
            dateTitle.Text = date;
            DBCon db = DBCon.GetCon();
            db.con.Open();
            var sdr = new SqlCommand($"select Medicine.brand_name,Medicine.price,MedRcpt.quantity from Medicine, MedRcpt where Medicine.med_id = MedRcpt.med_id and MedRcpt.rcpt_id = '{rcptID}'", db.con).ExecuteReader();
            while (sdr.Read())
            {
                string[] row = new string[] { sdr[0].ToString(),sdr[1].ToString(),sdr[2].ToString(), (double.Parse(sdr[1].ToString()) * int.Parse(sdr[2].ToString())).ToString()};
                medRcptTable.Rows.Add(row);
            }
            db.con.Close();
        }
    }
}
