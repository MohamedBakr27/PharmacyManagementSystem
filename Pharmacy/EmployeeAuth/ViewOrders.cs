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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }
        public object supplier;
        public void ini()
        {
            Supplier sup = (Supplier)supplier;
            supNameTitle.Text = sup.Company;
            DBCon db = DBCon.GetCon();
            db.con.Open();
            var sdr = new SqlCommand("select OrderSupplier.order_id, Medicine.brand_name,OrderSupplier.amount, OrderSupplier.order_date from OrderSupplier,Medicine where OrderSupplier.med_id=Medicine.med_id and OrderSupplier.sup_id='"+sup.SupID+"'", db.con).ExecuteReader();
            while (sdr.Read())
            {
                string[] row = new string[] { sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString() };
                orderSupplierTable.Rows.Add(row);
            }
            db.con.Close();
        }
    }
}
