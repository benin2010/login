using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    public class data
    {
        public static string conn = "SERVER=208.109.13.30;DATABASE=rjssoftw_school_Management;UID=rjssoftw_rjssoft_school;PASSWORD=School@1234;";
        public void setconnection(string con)
        {
            conn = con;
        }
        public string getconnection()
        {
            return conn;
        }
    }
}
