using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    internal class Supplier
    {
        public string SupID, Email, Company, Address;
        public Supplier(string supID, string email, string company, string address)
        {
            SupID = supID;
            Email = email;
            Company = company;
            Address = address;
        }
        public static bool AddSupplier(string supID,string email, string company,string address)
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            bool ch = true;
            SqlCommand com = new SqlCommand($"insert into supplier values('{supID}','{email}','{company}','{address}')",db.con);
            try { com.ExecuteNonQuery(); }
            catch
            {
                ch = false;
            }
            db.con.Close();
            if (!ch)
            {
                Program.MessageWarn("Add Failed!", "Invalid data!");
            }
            return ch;
        }
        public static bool UpdateSupplier(string supID,string email="",string company="",string address="")
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            bool ch = true;
            int cnt = 0;
            SqlCommand com = new SqlCommand($"update supplier set sup_id='{supID}',sup_email='{email}',company='{company}',address='{address}' where sup_id='{supID}'", db.con);
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
        public static bool RemoveSupplier(string supID)
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            bool ch = true;
            SqlCommand com = new SqlCommand($"delete supplier where sup_id='{supID}'", db.con);
            try { com.ExecuteNonQuery(); }
            catch (Exception ex) 
            {
                ch = false;
            }
            db.con.Close();
            if (!ch)
            {
                Program.MessageWarn("Remove Failed", "Cannot Remove Supplier!");
            }
            return ch;
        }
        public override string ToString()
        {
            return $"{Company} Supplier Email : {Email}.";
        }
    }
}
