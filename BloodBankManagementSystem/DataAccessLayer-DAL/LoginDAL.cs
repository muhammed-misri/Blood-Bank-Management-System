using BloodBankManagementSystem.Business_Logic_Layer_BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BloodBankManagementSystem.DataAccessLayer_DAL
{
    class LoginDAL
    {
        // create a static string to connect database
        static string myconString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

        public bool LoginCheck(LoginBLL l)
        {

            // create a boolean variable and set its defult value to false
            bool isSuccess = false;

            // create an object of sqlconnection to connect Database 
            SqlConnection con = new SqlConnection(myconString);

            try
            {
                // write the QUERY to check based on username and password
                string sql = "SELECT * FROM tbl_users WHERE user_name=@user_name AND password=@password";

                // create a SQL command to pass the value in our Query
                SqlCommand cmd = new SqlCommand(sql, con);

                //pass the value to sql using parameter
                cmd.Parameters.AddWithValue("@user_name", l.user_name);
                cmd.Parameters.AddWithValue("@password", l.password);

                //sql data adapter to get the data from database 
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                // datatable to hold the data from database  
                DataTable dt = new DataTable();

                // transfer data from sqldata adepter to dataTable
                dataAdapter.Fill(dt);

                //check whether user exists or not  
                if (dt.Rows.Count>0)
                {
                    //user exists and login successful
                    isSuccess = true;
                }
                else
                {
                    //login faild
                    isSuccess = false;

                }
            }
            catch (Exception ex)
            {
                // Display error  message if there's any exceptional errors     
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // close Database connection
                con.Close();

                
            }
                
                
        return isSuccess;
        }
    }
}
