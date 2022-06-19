using BloodBankManagementSystem.BLL;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.DataAccessLayer_DAL
{
    class UserDAL
    {
        // create a static string to connect database
        static string myconString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;


        #region SELECT data form Database 
        public DataTable Select()
        {
            // create an object to connection database 
            SqlConnection con = new SqlConnection(myconString);

            // create a DataTable to Hold the  Data from Database
            DataTable dt = new DataTable();

            try
            {
                // write sql Qeury to get Data from Database
                String sql = "SELECT * FROM tbl_users";

                // create sql command to execute Query
                SqlCommand cmd = new SqlCommand(sql, con);

                // sql Data Adepter to hold the data from Database temporarily
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                // open Database connection 
                con.Open();

                // transfer data from sqldata adepter to dataTable
                dataAdapter.Fill(dt);

            }
            catch (Exception ex)
            {
                // Display error Message if  there's any exceptional errors
                MessageBox.Show(ex.Message);
            }

            finally
            {
                // close Database Connection
                con.Close();
            }
            return dt;
        }
        #endregion

        ///////////////

        #region Insert Data into Database for User Module
        public bool Insert(UserBLL u)
        {
            // create a boolean variable and set its defult value to false
            bool isSuccess = false;
            // create an object of sqlconnection to connect Database 
            SqlConnection con = new SqlConnection(myconString);
            try
            {
                // create a string variable to store th INSERT QUERY
                string sql = "INSERT INTO tbl_users(user_name, email, password, full_name, contact, address, added_date, image_name)VALUES (@user_name, @email, @password, @full_name, @contact, @address, @added_date, @image_name)";
                // create a SQL command to pass the value in our Query
                SqlCommand cmd = new SqlCommand(sql, con);

                //create the parameter to pass get the value from UI and pass it on SQL Query above
                cmd.Parameters.AddWithValue("@user_name", u.user_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.Contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);

                // open Database connection
                con.Open();

                // create an integer variable to hold the value after the query is executed
                int rows = cmd.ExecuteNonQuery();

                // the value of rows will be greater than 0 if the query is executed successfully 
                //else it'll be 0

                if (rows > 0)
                {
                    //Query executed successfully
                    isSuccess = true;
                }

                else
                {
                    // failed to execute Query
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

        #endregion
        //////////////////////////


        #region UPDATE data in Database (User Module)
        public bool Update(UserBLL u)
        {
            //create a boolean variable  and set its defult value to false
            bool isSuccess = false;

            //create an object to Database connection 
            SqlConnection con = new SqlConnection(myconString);

            try
            {
                // create an string variable to  hold the sql Query
                string sql = "UPDATE tbl_users SET user_name=@user_name,email=@email,password=@password,full_name=@full_name,contact=@contact,address=@address,added_date=@added_date,image_name=@image_name WHERE user_id =@user_id";

                // create sql command ro execute query and also pass the value to sql Query
                SqlCommand cmd = new SqlCommand(sql, con);

                //new pass the value to SQL Query 
                cmd.Parameters.AddWithValue("@user_name", u.user_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.Contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);
                cmd.Parameters.AddWithValue("@user_id", u.user_id);

                //open Daatbase connection 
                con.Open();


                // create an integer variable to hold the value after the Query is executed
                int rows = cmd.ExecuteNonQuery();

                // if the query is executed successfully than the value of rows will be greater than 0 
                // else it'll be 0 

                if (rows > 0)
                {
                    //Query  executed successfully
                    isSuccess = true;
                }
                else
                {
                    //failed to executed Query 
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                // Display error message if there's any exception error
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // close Database connection 
                con.Close();
            }
            return isSuccess;

        }

        #endregion

        ///////////////////////


        #region Delete Data from Database (User Module)
        public bool Delete(UserBLL u)
        {
            //create a boolean variable  and set its defult value to false
            bool isSuccess = false;

            //create an object for connection 
            SqlConnection con = new SqlConnection(myconString);

            try
            {
                // create an string variable to  hold the sql Query to delete data 
                string sql = "DELETE FROM tbl_users WHERE user_id=@user_id";

                // create sql command to execute the query
                SqlCommand cmd = new SqlCommand(sql, con);

                //pass the value thorugt parameters     
                cmd.Parameters.AddWithValue("@user_id", u.user_id);

                //open the Database connection 
                con.Open();


                // create an integer variable to hold the value after the Query is executed
                int rows = cmd.ExecuteNonQuery();

                // if the query is executed successfully than the value of rows will be greater than 0 
                // else it'll be 0  

                if (rows > 0)
                {
                    //Query  executed successfully
                    isSuccess = true;
                }
                else
                {
                    //failed to executed Query 
                    isSuccess = false;
                }

            }

            catch (Exception ex)
            {
                // Display error Message if  there's any exceptional errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // close Database connection 
                con.Close();
            }
            return isSuccess;
        }


        #endregion


        #region Search
        public DataTable Search(string keywords)
        {
            //1. create an SQL connection to connect database
            SqlConnection con = new SqlConnection(myconString);

            //2. create data table to hold the data from Database
            DataTable dt = new DataTable();

            //3.write the code to search the users 
            try
            {
                //write the SQL Query to search the user form Database 
                string sql = "SELECT * FROM tbl_users WHERE user_id LIKE '%" + keywords + "%' OR full_name LIKE '%" + keywords + "%' OR address LIKE '%" + keywords + "%'";

                //Ccreate SQL command to execute the Query 
                SqlCommand cmd = new SqlCommand(sql, con);

                //create SQL Data Adabter to get  the Data from Database 
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                //open Database connection 
                con.Open();

                //pass the data from adapter to datatable 
                dataAdapter.Fill(dt);


            }
            catch (Exception ex)
            {
                //Display error message if there 's any exceptional errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //close the database connection
                con.Close();

            }
            return dt;
        }


        #endregion

        #region Any User is Login
        public UserBLL GetIDFromUsername(string user_name)
        {
            UserBLL u = new UserBLL();

            //1. create an SQL connection to connect database
            SqlConnection con = new SqlConnection(myconString);

            //2. create data table to hold the data from Database
            DataTable dt = new DataTable();

            try
            {
                //write the SQL Query to get the ID from username
                string sql = "SELECT user_id FROM tbl_users WHERE user_name = '" + user_name + "'";

                //create SQL Data Adabter to get  the Data from Database 
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, con);

                //open Database connection 
                con.Open();

                //pass the data from adapter to datatable 
                dataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    u.user_id = int.Parse(dt.Rows[0]["user_id"].ToString());
                }


            }
            catch (Exception ex)
            {

                //Display error message if there 's any exceptional errors
                MessageBox.Show(ex.Message);

            }
            finally
            {
                //close the database connection
                con.Close();
   
            } 
            return u;
            #endregion

        }
    }
}
