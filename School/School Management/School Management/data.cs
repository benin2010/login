using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    public class data
    {
        public static string conn = "SERVER=208.109.14.40;DATABASE=school;UID=School1989;PASSWORD=dob30111989;";
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
