using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    internal class User
    {
        public string Username, Fname, Lname;
        public User(string username, string fname, string lname)
        {
            Username = username;
            Fname = fname;
            Lname = lname;
        }

        public override string ToString()
        {
            return $"{Fname} {Lname}.";
        }
    }
}
