using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    internal class Medicine
    {
        public string MedID, GenericName, BrandName, Category, Type, SupName;
        public double Price;
        public DateTime ExpiryDate;
        public int Quantity = 0;
        public Medicine(string medID, string genericName, string brandName, string category, string type, DateTime expiryDate, string supName, double price,int quantity)
        {
            MedID = medID;
            GenericName = genericName;
            BrandName = brandName;
            Category = category;
            Type = type;
            Price = price;
            ExpiryDate = expiryDate;
            SupName = supName;
            Quantity = quantity;
        }

        public static bool AddMedicine(string medID, string genericName, string brandName, string category, string type, DateTime expiryDate, string supName, double price)
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            bool ch = true;
            SqlCommand com = new SqlCommand($"insert into Medicine values('{medID}','{genericName}','{brandName}','{category}','{type}','{expiryDate}','{supName}','{price}','0')", db.con);
            try { com.ExecuteNonQuery(); }
            catch (Exception ex)
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
        public static bool UpdateMedicine(string medId, string genericName = "", string brandName = "", string category = "", string type = "", string supName = "", double price = default, int quantity = default)
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            bool ch = true;
            int cnt = 0;
            SqlCommand com = new SqlCommand($"update medicine set generic_name = '{genericName}', brand_name = '{brandName}', category = '{category}', type='{type}',sup_id='{supName}', quantity = '{quantity}', price='{price}' where med_id = '{medId}'", db.con);
            try { cnt=com.ExecuteNonQuery(); }
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
        public static bool RemoveMedicine(string medID)
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            bool ch = true;
            SqlCommand com = new SqlCommand($"delete medicine where med_id = '{medID}'", db.con);
            try { com.ExecuteNonQuery(); }
            catch (Exception ex)
            {
                ch = false;
            }
            db.con.Close();
            if (!ch)
            {
                ch = false;
                Program.MessageWarn("Remove Failed!", "Cannot remove this medicine!");
            }
            return ch;
        }

        public override string ToString()
        {
            return $"Medicine GenericName : {GenericName}, BrandName {BrandName}, Type : {Type}, Category : {Category}, Price : {Price}, ExpDate : {ExpiryDate.ToShortDateString()}";
        }
    }
}
