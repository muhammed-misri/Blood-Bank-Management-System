using BloodBankManagementSystem.BLL;
using BloodBankManagementSystem.Business_Logic_Layer_BLL;
using BloodBankManagementSystem.DataAccessLayer_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.UI
{
    public partial class FormDonorsSginUp : Form
    {
        public FormDonorsSginUp()
        {
            InitializeComponent();
        }

        // create objects of donorDAL and  donorDLL
        donorBLL d = new donorBLL();
        donorDAL dal = new donorDAL();
        UserDAL udal = new UserDAL();

        // global variable for image 
        string image_name = "no-image.jpg";


        private void FormDonorsSginUp_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //we will write the code to add new donor 
            //step 1. get the data from manage Donors Form
            d.first_name = txtFirstName.Text;
            d.email = txtEmail.Text;
            d.last_name = txtLastName.Text;
            d.address = txtAddress.Text;
            d.gender = cmbGender.Text;
            d.blood_group = cmbBloodGroup.Text;
            d.contact = txtContact.Text;
            d.added_date = DateTime.Now;
            d.image_name = image_name;

            //get the ID of logged in user 
            string loggedInUser = FormLogin.loggedInUser;
            UserBLL user = udal.GetIDFromUsername(loggedInUser);
            d.added_by = user.user_id; //to do get the id of logged in user 


            //step 2.inserting data into Database 
            //create a boolean variable to insert Data into Database and check whether the data inserted successfully or not
            bool isSuccess = dal.Insert(d);

            //if the data is inserted successfully than the values of isSuccess will be true 
            //else it'll be false 

            if (isSuccess == true)
            {
                //data inserted successfully
                MessageBox.Show("New Donor added Successfully.");

                // refresh Data Grid View 
                DataTable dt = dal.Select();
               // dgvDonors.DataSource = dt;

                // clear all the textBoxes
                Clear();

                FormTheLast last = new FormTheLast();
                last.Show();
                this.Hide();

            }
            else
            {
                //Failed to insert Data  
                MessageBox.Show("Failed to Add New Donor.");
            }
        }


        public void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtContact.Text = "";
            txtDonorID.Text = "";
            cmbBloodGroup.Text = "";
            cmbGender.Text = "";

            //clear the picture Box
            //first we need to  get the image path
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            string imagepath = paths + "\\images\\no-image.jpg";

            //Display in picture Box


        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            // write the code to uplode the image of user
            // open dialog Box to select  image 
            OpenFileDialog open = new OpenFileDialog();


            //filter the file type, only allow image file type
            open.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.PNG; *.gif;)|*.jpg; *.jpeg; *.png; *.PNG; *.gif;";


            // check if the file is selected or not 
            if (open.ShowDialog() == DialogResult.OK)
            {
                //check it the file existes or not 
                if (open.CheckFileExists)
                {
                    // Display the selected file on picture Box 
                    pictureBoxProfilePicture.Image = new Bitmap(open.FileName);

                    //rename the image we selected 
                    //1. get the extension of image 
                    string ext = Path.GetExtension(open.FileName);

                    string name = Path.GetFileNameWithoutExtension(open.FileName);

                    // generate random but glonally unique identifier
                    Guid g = new Guid();
                    g = Guid.NewGuid();

                    //3.rename our image 
                    image_name = "Blood_bank_MS" + name + g + ext;

                    //4. get the path of selected image 
                    string sourcePath = open.FileName;
                    //5. get the path of Destination
                    string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);

                    //6.paths to Destination folder 
                    string destinationPath = paths + "\\images\\ " + image_name;

                    //7.copy the image to Destination folder
                    File.Copy(sourcePath, destinationPath);

                    //8. Display message 
                    MessageBox.Show("Image Successfully Uploaded. ");


                }
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear the textBoxes
            Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // add func to close this form
            Application.Exit();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            FormHomeDonor homeDonor = new FormHomeDonor();
            homeDonor.Show();
            this.Hide();
        }
    }
}
