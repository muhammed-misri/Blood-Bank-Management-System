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
    public partial class ChoseTheUserType : Form
    {
        public ChoseTheUserType()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void btnDonor_Click(object sender, EventArgs e)
        {
            FormHomeDonor homedonor = new FormHomeDonor();
            homedonor.Show();
            this.Hide();
        }
    

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTitle.Text =  lblTitle.Text.Substring(1, lblTitle.Text.Length - 1) + lblTitle.Text.Substring(0, 1); 
           
        }

        private void ChoseTheUserType_Load(object sender, EventArgs e)
        {
            timerText.Start();
            timerText.Interval = 100;

            timerDate.Start();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");


        }
    }
}
