using BloodBankManagementSystem.DataAccessLayer_DAL;
using BloodBankManagementSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        //craete the object of donor DAL
        donorDAL dal = new donorDAL();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //CLOSE
            Application.Exit();
        }

        private void uToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open  Form User
            FormUsers users = new FormUsers();
            users.Show();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            // load all of the blood donors count when Form is loaded
            //call all donor count method 
            allDonorCount();

            //display all the donors 
            DataTable dt = dal.Select();
            dgvDonors.DataSource = dt;

            //display the username of  Logged In user
            lblUser.Text = FormLogin.loggedInUser;

            timerDate.Start();

        }

        public void allDonorCount()
        {
            //get the donor count from Database and set in respective label
            lblOposiCount.Text = dal.countDonors("O+");
            lblOnegaCount.Text = dal.countDonors("O-");
            lblAposiCount.Text = dal.countDonors("A+");
            lblAnegaCount.Text = dal.countDonors("A-");
            lblBposiCount.Text = dal.countDonors("B+");
            lblBnegaCount.Text = dal.countDonors("B-");
            lblABposiCount.Text = dal.countDonors("AB+");
            lblABnegaCount.Text = dal.countDonors("AB-");


        }
        private void dvgDonors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dvgUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void donToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open Manager Donors Form
            FormDonors donors = new FormDonors();
            donors.Show();
        }

        private void FormHome_Activated(object sender, EventArgs e)
        {
            // call allDonorCount method 
            allDonorCount();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //1.get the keywords from the textBox
            string keywords = txtSearch.Text;
            //2.check whether the textBox is empty or not 
            if (keywords != null)
            {
                //txetBox is not empty, display users on data grid view  based on the keywords 
                DataTable dt = dal.Search(keywords);
                dgvDonors.DataSource = dt;
            }
            else
            {
                //textBox is empty , display all the users on data grid view
                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;
            }
        }

        private void lblOnegaCount_Click(object sender, EventArgs e)
        {

        }

        private void lblUserTitle_Click(object sender, EventArgs e)
        {

        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            
        }
    }
}
