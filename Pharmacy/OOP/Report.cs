using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    internal class Report
    {
        public string RptID, RptContent;
        public DateTime RptDate;
        public Report(string rptID, string rptContent, DateTime rptDate)
        {
            RptID = rptID;
            RptContent = rptContent;
            RptDate = rptDate;
        }
        public static bool AddReport(string rptContent, DateTime rptDate, string from)
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            bool ch = true;
            SqlCommand com = new SqlCommand("select count(*) from report", db.con);
            int sz = (int)com.ExecuteScalar();
            string rptID = "1";
            if (sz != 0)
            {
                com = new SqlCommand("select rpt_id from report order by rpt_id desc", db.con);
                rptID = (1 + (int)com.ExecuteScalar()).ToString();
            }
            com = new SqlCommand("select doc_username from doctor", db.con);
            string targetDocUsername = (string)com.ExecuteScalar();
            com = new SqlCommand($"insert into report values('{rptID}','{rptDate.ToShortDateString()}','{rptContent}','{from}','{targetDocUsername}')", db.con);
            try { com.ExecuteNonQuery(); }
            catch (Exception ex) { ch = false; }
            db.con.Close();
            return ch;
        }
        public static void RemoveReport(string rptID)
        {
            DBCon db = DBCon.GetCon();
            db.con.Open();
            SqlCommand com = new SqlCommand($"delete report where rpt_id = '{rptID}'", db.con);
            com.ExecuteNonQuery();
            db.con.Close();
        }
        public override string ToString()
        {
            return $"ReportID : {RptID}\nDate : {RptDate.ToShortDateString()}\nReport Content :\n{RptContent}";
        }
    }
}
