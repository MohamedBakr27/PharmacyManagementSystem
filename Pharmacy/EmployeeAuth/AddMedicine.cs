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
    public partial class AddMedicine : Form
    {
        public AddMedicine()
        {
            InitializeComponent();
        }
        static Dictionary<string,string> nameToID = new Dictionary<string,string>();
        public void ini()
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            var sdr = new SqlCommand("select sup_id, company from supplier", db.con).ExecuteReader();
            while(sdr.Read())
            {
                nameToID[sdr[1].ToString()] = sdr[0].ToString();
                supplierCb.Items.Add(sdr[1].ToString());
            }
            db.con.Close();
        }

        private void addMedBtn_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (medIDTxtbx.Text.Length == 0) msg += "You should enter medicine ID\n";
            if (genericNameTxtbx.Text.Length == 0) msg += "You should enter generic name\n";
            if (brandNameTxtbx.Text.Length == 0) msg += "You should enter brand name\n";
            if (supplierCb.SelectedIndex == -1) msg += "You should choose supplier\n";
            if (categoryCb.SelectedIndex == -1) msg += "You should choose category\n";
            if (typeCb.SelectedIndex == -1) msg += "You should choose type\n";
            if(msg.Length > 0)
            {
                Program.MessageWarn("Add Medicine!", msg);
                return;
            }
            if (Medicine.AddMedicine(medIDTxtbx.Text, genericNameTxtbx.Text, brandNameTxtbx.Text, categoryCb.SelectedItem.ToString(), typeCb.SelectedItem.ToString(), expiryDateCal.Value, nameToID[supplierCb.SelectedItem.ToString()], (double)priceNum.Value))
            {
                Program.MessageSuccess("Add Medicine!", "Medicine Added Successful!");
                this.Close();
            }
        }
    }
}
