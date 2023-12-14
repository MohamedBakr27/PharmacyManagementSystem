using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy.EmployeeAuth
{
    public partial class UpdateMedicine : Form
    {
        public UpdateMedicine()
        {
            InitializeComponent();
        }
        public object medicine;
        public void ini()
        {
            Medicine med = (Medicine)medicine;
            medIDTxtbx.Text = med.MedID;
            brandNameTxtbx.Text = med.BrandName;
            expiryDateCal.Value = med.ExpiryDate;
            priceNum.Value = (int)med.Price;
            genericNameTxtbx.Text = med.GenericName;
            supplierCb.Items.Add(med.SupName);
            supplierCb.SelectedIndex = 0;
            categoryCb.Items.Add(med.Category);
            categoryCb.SelectedIndex = 0;
            typeCb.Items.Add(med.Type);
            typeCb.SelectedIndex = 0;
        }

        private void updateMedBtn_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (genericNameTxtbx.Text.Length == 0) msg += "You should enter generic name\n";
            if (brandNameTxtbx.Text.Length == 0) msg += "You should enter brand name\n";
            if (msg.Length > 0)
            {
                Program.MessageWarn("Update Medicine!", msg);
                return;
            }
            DBCon db = DBCon.GetCon();
            db.con.Open();
            string supID = new SqlCommand("select sup_id from supplier where company = '"+supplierCb.SelectedItem.ToString()+"'", db.con).ExecuteScalar().ToString();
            db.con.Close();
            if (Medicine.UpdateMedicine(medIDTxtbx.Text, genericNameTxtbx.Text, brandNameTxtbx.Text, categoryCb.SelectedItem.ToString(), typeCb.SelectedItem.ToString(), supID, (double)priceNum.Value, ((Medicine)medicine).Quantity))
            {
                Program.MessageSuccess("Update Medicine!", "Medicine Updated Successful!");
                this.Close();
            }
        }
    }
}
