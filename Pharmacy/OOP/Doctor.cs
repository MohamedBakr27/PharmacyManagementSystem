using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    internal class Doctor : User
    {
        public Doctor(string username,string fname,string lname) 
            : base(username, fname, lname) { }
        public static bool AddDoctor(string username, string fname, string lname,string password)
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            bool ch = true;
            SqlCommand com = new SqlCommand($"insert into doctor values('{username}','{fname}','{lname}','{password}')", db.con);
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
        public static bool UpdateDoctor(string username, string fname = "", string lname = "", string password = "")
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            bool ch = true;
            SqlCommand com = new SqlCommand($"update doctor set fname='{fname}',lname='{lname}'"+(password!=""?$",password='{password}'":"") +$" where doc_username='{username}'", db.con);
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
        public static bool RemoveDoctor(string username)
        {
            DBCon db = DBCon.GetCon();
            bool ch = true;
            db.con.Open();
            SqlCommand com = new SqlCommand($"delete doctor where doc_username='{username}'", db.con);
            try { com.ExecuteNonQuery(); }
            catch (Exception ex)
            {
                ch = false;
            }
            db.con.Close();
            if (!ch)
            {
                Program.MessageWarn("Remove Failed!", "Cannot remove this doctor!");
            }
            return ch;
        }
        public override string ToString()
        {
            return $"Doctor Name : "+base.ToString();
        }
    }
}
