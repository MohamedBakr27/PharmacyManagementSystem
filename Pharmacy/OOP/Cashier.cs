using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    internal class Cashier : User
    {
        public string Shift;
        public Cashier(string username,string fname,string lname,string shift)
            : base(username, fname, lname) { Shift = shift;  }
        public static bool AddCashier(string username, string fname, string lname, string password, string shift)
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            bool ch = true;
            SqlCommand com = new SqlCommand($"insert into cashier values('{username}','{fname}','{lname}','{password}','{shift}')", db.con);
            try { com.ExecuteNonQuery(); }
            catch (Exception ex)
            {
                ch = false;
            }
            db.con.Close();
            if (!ch)
            {
                Program.MessageWarn("Register Failed!", "Username is already taken!");
            }
            return ch;
        }
        public static bool UpdateCashier(string username, string fname = "", string lname = "", string password = "",string shift = "")
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            bool ch = true;
            int cnt = 0;
            SqlCommand com = new SqlCommand($"update cashier set fname='{fname}',lname='{lname}'" + (password != "" ? $",password='{password}'" : "") + $", shift='{shift}' where cashier_username='{username}'", db.con);
            try { cnt = com.ExecuteNonQuery(); }
            catch (Exception ex)
            {
                ch = false;
            }
            db.con.Close();
            if (cnt == 0 || !ch)
            {
                ch = false;
                Program.MessageWarn("Update Failed!", "Invalid data!");
            }
            return ch;
        }
        public static bool RemoveCashier(string username)
        {
            DBCon db = DBCon.GetCon();
            bool ch = true;
            db.con.Open();
            SqlCommand com = new SqlCommand($"delete cashier where cashier_username='{username}'", db.con);
            try { com.ExecuteNonQuery(); }
            catch (Exception ex) 
            {
                ch = false;
            }
            db.con.Close();
            if (!ch)
            {
                Program.MessageWarn("Remove Failed!", "Cannot remove this cashier!");
            }
            return ch;
        }
        public override string ToString()
        {
            return $"Cashier Name : "+base.ToString();
        }
    }
}
