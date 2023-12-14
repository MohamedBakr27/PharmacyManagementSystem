using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    internal class Customer : User
    {
        public Customer(string username, string fname, string lname)
            : base(username, fname, lname) { }
        public static bool AddCustomer(string username, string fname, string lname, string password)
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            bool ch = true;
            SqlCommand com = new SqlCommand($"insert into customer values('{username}','{fname}','{lname}','{password}')", db.con);
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
        public static bool UpdateCustomer(string username, string fname = "", string lname = "", string password = "")
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            bool ch = true;
            SqlCommand com = new SqlCommand($"update customer set fname='{fname}',lname='{lname}'" + (password != "" ? $",password='{password}'" : "") + $" where customer_username='{username}'", db.con);
            int cnt = 0;
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
        public static bool RemoveCustomer(string username)
        {
            DBCon db = DBCon.GetCon();
            bool ch = true;
            db.con.Open();
            SqlCommand com = new SqlCommand($"delete customer where customer_username='{username}'", db.con);
            try { com.ExecuteNonQuery(); }
            catch (Exception ex)
            {
                ch = false;
            }
            db.con.Close();
            if (!ch)
            {
                Program.MessageWarn("Remove Failed!", "Cannot remove this customer!");
            }
            return ch;
        }
        public override string ToString()
        {
            return $"Customer Name : " + base.ToString();
        }
    }
}
