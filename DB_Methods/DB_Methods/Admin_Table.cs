using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyORM
{
    public class Admin_Table
    {
        public string admin_name { get; set; }
        public string admin_login { get; set; }
        public string admin_password { get; set; }

        public Admin_Table(string name, string login , string password)
        {
            admin_name = name;
            admin_login = login;
            admin_password = password;
        }
        public Admin_Table() { }
    }
}
