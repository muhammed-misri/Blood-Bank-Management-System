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
    public partial class FormTheLast : Form
    {
        public FormTheLast()
        {
            InitializeComponent();
        }

        private void FormTheLast_Load(object sender, EventArgs e)
        {
            timerDate.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // close
            Application.Exit();
        }

        private void pictureBoxBackToFirst_Click(object sender, EventArgs e)
        {
            FormSplash splash = new FormSplash();
            splash.Show();
            this.Hide();
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSecond.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            
        }
    }
}
