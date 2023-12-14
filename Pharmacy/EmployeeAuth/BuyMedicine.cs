using ComponentFactory.Krypton.Toolkit;
using Pharmacy.CustomerAuth;
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
    public partial class BuyMedicine : Form
    {
        public BuyMedicine()
        {
            InitializeComponent();
        }
        public DataGridView stockTable;
        public object user;
        public void ini()
        {
            for(int i = 0; i < stockTable.SelectedRows.Count; i++)
            {
                var tmp = stockTable.SelectedRows[i].Cells;
                string[] row = new string[]
                {
                    tmp[0].Value.ToString(),
                    tmp[1].Value.ToString(),
                    tmp[7].Value.ToString(),
                    tmp[8].Value.ToString(),
                    "0",
                    "0"
                };
                orderTable.Rows.Add(row);
            }
        }
        bool changeInSelect = false;
        private void orderTable_SelectionChanged(object sender, EventArgs e)
        {
            if (orderTable.SelectedRows.Count == 0) return;
            changeInSelect = true;
            medQuantity.Maximum = decimal.Parse(orderTable.SelectedRows[0].Cells[3].Value.ToString());
            changeInSelect = true;
            medQuantity.Value = decimal.Parse(orderTable.SelectedRows[0].Cells[4].Value.ToString());
        }

        private void medQuantity_ValueChanged(object sender, EventArgs e)
        {
            if(changeInSelect)
            {
                changeInSelect = false;
                return;
            }
            int tmp = (int)medQuantity.Value;
            orderTable.SelectedRows[0].Cells[4].Value = tmp.ToString();
            double price = double.Parse(orderTable.SelectedRows[0].Cells[2].Value.ToString());
            orderTable.SelectedRows[0].Cells[5].Value = (price * tmp).ToString();
        }

        private void reqBtn_Click(object sender, EventArgs e)
        {
            double total = 0;
            for (int i = 0; i < orderTable.Rows.Count; i++)
                total += double.Parse(orderTable.Rows[i].Cells[5].Value.ToString());
            if(total == 0)
            {
                Program.MessageWarn("Buy Medicine!", "You should choose medicine.");
                return;
            }
            if (MessageBox.Show($"Are you sure you want continue?\nYour Payout is : {total}$","Send Request to Cashier" , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DBCon db = DBCon.GetCon();
                db.con.Open();
                SqlCommand com = new SqlCommand("select count(*) from OrderReceipt", db.con);
                int sz = (int)com.ExecuteScalar();
                string rcptID = "1";
                if (sz != 0)
                {
                    com = new SqlCommand("select rcpt_id from OrderReceipt order by rcpt_id desc", db.con);
                    rcptID = (1 + (int)com.ExecuteScalar()).ToString();
                }
                com = new SqlCommand("select cashier_username from cashier", db.con);
                string targetCashierUsername = (string)com.ExecuteScalar();
                new SqlCommand($"insert into OrderReceipt values('{rcptID}','{DateTime.Now.ToShortDateString()}','{total}','{((Customer)user).Username}','{targetCashierUsername}')", db.con).ExecuteNonQuery();
                for (int i = 0; i < orderTable.Rows.Count; i++)
                {
                    var row = orderTable.Rows[i].Cells;
                    new SqlCommand($"update medicine set quantity = quantity - {row[4].Value.ToString()} where med_id = '{row[0].Value.ToString()}'", db.con).ExecuteNonQuery();
                    new SqlCommand($"insert into medrcpt values('{row[0].Value.ToString()}','{rcptID}','{row[4].Value.ToString()}')", db.con).ExecuteNonQuery();
                }
                new SqlCommand($"insert into tempreq values('{rcptID}')", db.con).ExecuteNonQuery();
                db.con.Close();
                this.Close();
            }
        }
    }
}
