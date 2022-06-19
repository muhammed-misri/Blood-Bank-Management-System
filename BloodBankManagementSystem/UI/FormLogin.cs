using BloodBankManagementSystem.Business_Logic_Layer_BLL;
using BloodBankManagementSystem.DataAccessLayer_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.UI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        //create the object of BLL and DAL
        LoginBLL l = new LoginBLL();
        LoginDAL dal=new LoginDAL();

        //create the statıc method to save  the username
        public static string loggedInUser;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //close 
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //write the code to login our app
            //1.get the username and pass from login form
            l.user_name = txtUsername.Text;
            l.password = txtPassword.Text;

            //2.check the login credentials
            bool isSuccess = dal.LoginCheck(l);


            // check if login successfully or not >> isSuccess >> true 
            //else it'll be false 

            if (isSuccess == true)
            {
                //display message 
                MessageBox.Show("Login  Successfully.");

                //save the username in loggedInUser static method
                loggedInUser = l.user_name;


                //display Home Form
                FormHome home = new FormHome();
                home.Show();
                this.Hide(); // to close this 

            }
            else
            {
                //login Faild      
                MessageBox.Show("Login Failed. Try Again.");
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            ChoseTheUserType chose = new ChoseTheUserType();
            chose.Show();
            this.Hide();
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            timerDate.Start();
        }
    }
}
