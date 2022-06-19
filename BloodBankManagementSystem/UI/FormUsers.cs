using BloodBankManagementSystem.BLL;
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

namespace BloodBankManagementSystem
{
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        // create objects of userDAL and  userDLL
        UserBLL u = new UserBLL();
        UserDAL dal = new UserDAL();

        // global variable for image 
        string imageName = "no-image.jpg";

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

                    //2. generate ranmod integer 
                    Random random = new Random();
                    int RandInt = random.Next(0,1000);

                    //3.rename the image 
                    imageName = "Blood_bank_MS" + RandInt + ext;

                    //4. get the path of selected image 
                    string sourcePath = open.FileName;
                    //5. get the path of Destination
                    string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);

                    //6.paths to Destination folder 
                    string destinationPath = paths + "\\images\\ " + imageName;

                    //7.copy the image to Destination folder
                    File.Copy(sourcePath,destinationPath);

                    //8. Display message 
                    MessageBox.Show("Image Successfully Uploaded. ");


                }
            }
        }
    
        private void Form2_Load(object sender, EventArgs e)
        {
            // Display the users in Datagrid view when the form is loaded
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            // add func to close this form
            this.Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // step 1: Get the values from UI
            u.full_name = txtFullName.Text;
            u.email = txtEmail.Text;
            u.user_name = txtUserName.Text;
            u.address = txtAddress.Text;
            u.password = txtPassword.Text;
            u.Contact = txtContact.Text;
            u.added_date = DateTime.Now;
            u.image_name = imageName;

            //step2 : adding the value from  UI to Database 
            //creayte a boolean variable to check wether the data is inserted successfully or not 
            bool success = dal.Insert(u);

            //step3 : check wether the data is  inserted seccessfully or not 
            if (success == true)
            {
                //data or User Added successfully

                MessageBox.Show("New User added Successfully. ");
                // Display the data in DataGridView 
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;

                // clear textBoxes
                Clear();

            }
            else
            {
                //Failed to Add User 
                MessageBox.Show("Failed to Add New User. ");
            }

        }
        // method or function to clear textboes 
        public void Clear()
        {
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtUserName.Text = "";
            txtUserID.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";

            //path to Destination folder
            //get the image path 
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            string imagePath = paths + "\\images\\no-image.jpg";

           
        }

        private void dgvUsers_CellContenClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // find the Row index of the Row clicked on users Data frid view 
            int RowIndex = e.RowIndex;
            txtUserID.Text = dgvUsers.Rows[RowIndex].Cells[0].Value.ToString();
            txtUserName.Text = dgvUsers.Rows[RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[RowIndex].Cells[2].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[RowIndex].Cells[3].Value.ToString();
            txtFullName.Text = dgvUsers.Rows[RowIndex].Cells[4].Value.ToString();
            txtContact.Text = dgvUsers.Rows[RowIndex].Cells[5].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[RowIndex].Cells[6].Value.ToString();
            imageName = dgvUsers.Rows[RowIndex].Cells[8].Value.ToString();


            //Display the image of selected user 
            //get the image path 
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            if (imageName!="no-image.jpg")
            {
                //path to Destination folder
                string imagePath = paths + "\\images\\ " + imageName;

                //Display in picture Box
                pictureBoxProfilePicture.Image = new Bitmap(imagePath);
            }
            else
            {
                //path to Destination folder
                string imagePath = paths + "\\images\\no-image.jpg";

                //Display in picture Box
                pictureBoxProfilePicture.Image = new Bitmap(imagePath);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //setp1: get the values from UI
            u.user_id = int.Parse(txtUserID.Text);
            u.full_name = txtFullName.Text;
            u.email = txtEmail.Text;
            u.user_name = txtUserName.Text;
            u.address = txtAddress.Text;
            u.Contact = txtContact.Text;
            u.added_date = DateTime.Now;
            u.image_name=imageName;
            u.password = txtPassword.Text;

            // step2: create a boolean variable to check wether the data is inserted successfully or not 
            bool success = dal.Update(u);

            //let's check wether the data is update successfully or not
            if (success==true)
            {
                // Data Updated successfully 
                MessageBox.Show("User Updated Successfully.");

                // refresh data grid view 
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;

                // clean the textBoxes 
                Clear();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // step 1: get the UserID from textBox to Delete the Uesr
            u.user_id = int.Parse(txtUserID.Text);

            //step2: create a boolean value to check wether the user deleted or not 
            bool success = dal.Delete(u);

            //let's check wether the user is Deleted or not

            if(success==true)
            {
                //user Deleted successfully
                MessageBox.Show("User Deleted successfully");

                //Refresh Data Grid View
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;

                //clear the textBoxes 
                Clear();


            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // write the code to get the users based on keywords
            //1.get the keywords from the textBox
            string keywords = txtSearch.Text;
            //2.check whether the textBox is empty or not 
            if (keywords!=null)
            {
                //txetBox is not empty, display users on data grid view  based on the keywords 
                DataTable dt = dal.Search(keywords);
                dgvUsers.DataSource = dt;
            }
            else
            {
                //textBox is empty , display all the users on data grid view
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;
            }
        }

        private void pictureBoxProfilePicture_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            FormHome home = new FormHome();
            home.Show();
            this.Hide();
        }
    }
}
