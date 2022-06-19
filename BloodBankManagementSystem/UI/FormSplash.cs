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
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        int move = 0;
        private void timerSplash_Tick(object sender, EventArgs e)
        {
            //write a code to show loading animation 
            timerSplash.Interval = 20; 
            panelMovebale.Width += 5;

            move += 5;
            //if the loading is coplete than display login form close this Form 
            if (move==630)
            {
                //stop the timer and close this form 
                timerSplash.Stop();
                this.Hide();

                //display the login form
                ChoseTheUserType chose = new ChoseTheUserType();
                chose.Show();

            }
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {
            //loasd the timer 
            timerSplash.Start();

        }

        private void panelMovebale_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDev_Click(object sender, EventArgs e)
        {

        }
    }
}
