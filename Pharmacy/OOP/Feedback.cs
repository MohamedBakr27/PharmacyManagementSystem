using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    internal class Feedback
    {
        public string FdID, FdContent;
        public DateTime FdDate;
        public Feedback(string fdID, string fdContent, DateTime fdDate)
        {
            FdID = fdID;
            FdContent = fdContent;
            FdDate = fdDate;
        }
        public static bool AddFeedback(string fdContent, DateTime fdDate, string from)
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            bool ch = true;
            SqlCommand com = new SqlCommand("select count(*) from feedback", db.con);
            int sz = (int)com.ExecuteScalar();
            string fdID = "1";
            if (sz != 0)
            {
                com = new SqlCommand("select fb_id from feedback order by fb_id desc", db.con);
                fdID= (1 + (int)com.ExecuteScalar()).ToString();
            }
            com = new SqlCommand("select doc_username from doctor",db.con);
            string targetDocUsername = (string)com.ExecuteScalar();
            com = new SqlCommand($"insert into feedback values('{fdID}','{fdDate.ToShortDateString()}','{fdContent}','{from}','{targetDocUsername}')", db.con);
            try { com.ExecuteNonQuery(); }
            catch (Exception ex) { ch = false; }
            db.con.Close();
            return ch;
        }
        public static void RemoveFeedback(string fdID)
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            SqlCommand com = new SqlCommand($"delete feedback where fb_id = '{fdID}'", db.con);
            com.ExecuteNonQuery();
            db.con.Close();
        }

        public override string ToString()
        {
            return $"FeedbackID : {FdID}\nDate : {FdDate.ToShortDateString()}\nReport Content :\n{FdContent}";
        }
    }
}
