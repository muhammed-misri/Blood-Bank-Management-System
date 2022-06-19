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
    class donorDAL
    {
        // create a static string to connect database
        static string myconString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

         #region select to display data in data grid view from Database 
        public DataTable Select()
        {
            //create object to datatable to hold the data from database and return it 
            DataTable dt = new DataTable();

            // create an object to connection database 
            SqlConnection con = new SqlConnection(myconString);

            try
            {
                // write sql Qeury to select Data from Database
                String sql = "SELECT * FROM tbl_donors";

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

         #region Insert Data to Database 
        public bool Insert(donorBLL d)
        {
            // create a boolean variable and set its defult value to false
            bool isSuccess = false;
          
            // create an object of sqlconnection to connect Database 
            SqlConnection con = new SqlConnection(myconString);
            try
            {
                // write the QUERY to insert data into database 
                string sql = "INSERT INTO tbl_donors(first_name, email, added_by, last_name, contact, address, added_date, image_name,gender,blood_group)VALUES (@first_name, @email, @added_by, @last_name, @contact, @address, @added_date, @image_name,@gender,@blood_group)";
               
                // create a SQL command to pass the value in our Query
                SqlCommand cmd = new SqlCommand(sql, con);

                //create the parameter to pass get the value from UI and pass it on SQL Query above
                cmd.Parameters.AddWithValue("@first_name", d.first_name);
                cmd.Parameters.AddWithValue("@email", d.email);
                cmd.Parameters.AddWithValue("@last_name", d.last_name);
                cmd.Parameters.AddWithValue("@added_by", d.added_by);
                cmd.Parameters.AddWithValue("@contact", d.contact);
                cmd.Parameters.AddWithValue("@address", d.address);
                cmd.Parameters.AddWithValue("@added_date", d.added_date);
                cmd.Parameters.AddWithValue("@image_name", d.image_name);
                cmd.Parameters.AddWithValue("@gender", d.gender);
                cmd.Parameters.AddWithValue("@blood_group", d.blood_group);
               
                // open Database connection
                con.Open();

                // create an integer variable to check whether the query was exected successfully or not    
                int rows = cmd.ExecuteNonQuery();

                // if the query is executed successfully the value of rows will be greater than 0
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

       
        #region UPDATE data in Database (User Module)
        public bool Update(donorBLL d)
        {
            //create a boolean variable  and set its defult value to false
            bool isSuccess = false;

            //create an object to Database connection 
            SqlConnection con = new SqlConnection(myconString);

            try
            {
                // create a sql Query  to  update donors
                string sql = "UPDATE tbl_donors SET first_name=@first_name,email=@email,added_by=@added_by,last_name=@last_name,contact=@contact,address=@address,image_name=@image_name,gender=@gender,blood_group=@blood_group WHERE donor_id =@donor_id";

                // create sql command ro execute query and also pass the value to sql Query
                SqlCommand cmd = new SqlCommand(sql, con);

                // pass the value to SQL Query 
                cmd.Parameters.AddWithValue("@first_name", d.first_name);
                cmd.Parameters.AddWithValue("@email", d.email);
                cmd.Parameters.AddWithValue("@last_name", d.last_name);
                cmd.Parameters.AddWithValue("@added_by", d.added_by);
                cmd.Parameters.AddWithValue("@contact", d.contact);
                cmd.Parameters.AddWithValue("@address", d.address);
                cmd.Parameters.AddWithValue("@blood_group",d.blood_group);
                cmd.Parameters.AddWithValue("@donor_id", d.donor_id);
                cmd.Parameters.AddWithValue("@gender", d.gender);
                cmd.Parameters.AddWithValue("@image_name", d.image_name);
                //open Daatbase connection 
                con.Open();


                // create an integer variable to check whether the Query executed or not 
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


        #region Delete donor from Database 
        public bool Delete(donorBLL d)
        {
            //create a boolean variable  and set its defult value to false
            bool isSuccess = false;

            //create an object for connection 
            SqlConnection con = new SqlConnection(myconString);

            try
            {
                // create the Query to delete donor from database 
                string sql = "DELETE FROM tbl_donors WHERE donor_id=@donor_id";

                // create sql command to execute the query
                SqlCommand cmd = new SqlCommand(sql, con);

                //pass the value to sql Query using parameters     
                cmd.Parameters.AddWithValue("@donor_id", d.donor_id);

                //open the Database connection 
                con.Open();


                // create an integer variable to check whether the Query executed successfully or not 
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
                string sql = "SELECT * FROM tbl_donors WHERE donor_id LIKE '%" + keywords + "%' OR first_name LIKE '%" + keywords + "%' OR address LIKE '%" + keywords + "%'OR last_name LIKE '%" + keywords + "%'OR email LIKE '%" + keywords + "%'OR blood_group LIKE '%" + keywords + "%'";

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
   

        #region Count Donors for specific Blood Group
        public string countDonors (string blood_group)
        {
            // create sql connection for database connection 
            SqlConnection con = new SqlConnection(myconString);

            //set a string variable for donor  count  and set it defult value to 0 
            string donors = "0";

            try
            {
                //sql Query to count donors for specific blood group 
                string sql = "SELECT * FROM tbl_donors WHERE blood_group ='"+ blood_group + "'";

                // create sql command to execute Query
                SqlCommand cmd = new SqlCommand(sql, con);

                // sql Data Adepter to get the data from Database 
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                //datatable to hold the data temporarily
                DataTable dt = new DataTable();

                // open Database connection 
                con.Open();

                // transfer data from sqldata adepter to dataTable
                dataAdapter.Fill(dt);

                //get the total number of Donors based on biood group
                donors = dt.Rows.Count.ToString();



            }
            catch (Exception ex)
            {

                // Display error Message if  there's any
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //close database connection
                con.Close();
            }
            return donors; 

        }


        #endregion
    }
}
