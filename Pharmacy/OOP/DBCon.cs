using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    internal class DBCon
    {
        public static DBCon instance;
        public SqlConnection con;
        private DBCon()
        {
            con = new SqlConnection("Data Source=.;Initial Catalog=Pharmacy;Integrated Security=TrueData Source=.;Initial Catalog=Pharmacy;Integrated Security=True");
        }
        public static DBCon GetCon()
        {
            if (instance == null) instance = new DBCon();
            return instance;
        }
    }
}
