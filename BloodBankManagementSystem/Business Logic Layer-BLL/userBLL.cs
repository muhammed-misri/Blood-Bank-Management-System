using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BloodBankManagementSystem.BLL;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace BloodBankManagementSystem.BLL
{
    class UserBLL
    {
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string full_name { get; set; }
        public string Contact { get; set; }
        public  string address { get; set; }
        public DateTime added_date { get; set; }
        public string image_name { get; set; }

    }
}
