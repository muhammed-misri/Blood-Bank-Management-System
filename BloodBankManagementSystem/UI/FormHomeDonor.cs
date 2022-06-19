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
    public partial class FormHomeDonor : Form
    {
        public FormHomeDonor()
        {
            InitializeComponent();
        }


        //craete the object of donor DAL
        donorDAL dal = new donorDAL();
        private void donToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOposiCount_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            //CLOSE
            Application.Exit();
        }

        private void btnSginUP_Click(object sender, EventArgs e)
        {
            FormDonorsSginUp donors = new FormDonorsSginUp();
            donors.Show();
            this.Hide();
        }

        private void FormHomeDonor_Load(object sender, EventArgs e)
        {
            // load all of the blood donors count when Form is loaded
            //call all donor count method 
            allDonorCount();

            //display all the donors 
            DataTable dt = dal.Select();
            //  dgvDonors.DataSource = dt;

            //display the username of  Logged In user
            // lblUser.Text = FormLogin.loggedInUser;

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

        private void FormHomeDonor_Activated(object sender, EventArgs e)
        {
            // call allDonorCount method 
            allDonorCount();
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
        }
    }
}
