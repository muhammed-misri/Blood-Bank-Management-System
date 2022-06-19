namespace BloodBankManagementSystem.UI
{
    partial class ChoseTheUserType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoseTheUserType));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblAppSubName = new System.Windows.Forms.Label();
            this.lnlAppName = new System.Windows.Forms.Label();
            this.lblChose = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnDonor = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timerText = new System.Windows.Forms.Timer(this.components);
            this.panelAlt = new System.Windows.Forms.Panel();
            this.lblDev = new System.Windows.Forms.Label();
            this.lblDevBy = new System.Windows.Forms.Label();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelAlt.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(170, 108);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(96, 98);
            this.pictureBoxLogo.TabIndex = 11;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblAppSubName
            // 
            this.lblAppSubName.AutoSize = true;
            this.lblAppSubName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppSubName.ForeColor = System.Drawing.Color.Black;
            this.lblAppSubName.Location = new System.Drawing.Point(120, 245);
            this.lblAppSubName.Name = "lblAppSubName";
            this.lblAppSubName.Size = new System.Drawing.Size(187, 25);
            this.lblAppSubName.TabIndex = 10;
            this.lblAppSubName.Text = "Management System";
            // 
            // lnlAppName
            // 
            this.lnlAppName.AutoSize = true;
            this.lnlAppName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlAppName.ForeColor = System.Drawing.Color.Black;
            this.lnlAppName.Location = new System.Drawing.Point(117, 200);
            this.lnlAppName.Name = "lnlAppName";
            this.lnlAppName.Size = new System.Drawing.Size(194, 45);
            this.lnlAppName.TabIndex = 9;
            this.lnlAppName.Text = "Blood Bank";
            // 
            // lblChose
            // 
            this.lblChose.AutoSize = true;
            this.lblChose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChose.Location = new System.Drawing.Point(421, 135);
            this.lblChose.Name = "lblChose";
            this.lblChose.Size = new System.Drawing.Size(196, 30);
            this.lblChose.TabIndex = 13;
            this.lblChose.Text = "Chose for Login as :";
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Green;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUser.Location = new System.Drawing.Point(399, 207);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(118, 42);
            this.btnUser.TabIndex = 14;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnDonor
            // 
            this.btnDonor.BackColor = System.Drawing.Color.Green;
            this.btnDonor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDonor.Location = new System.Drawing.Point(541, 207);
            this.btnDonor.Name = "btnDonor";
            this.btnDonor.Size = new System.Drawing.Size(118, 42);
            this.btnDonor.TabIndex = 15;
            this.btnDonor.Text = "Donor";
            this.btnDonor.UseVisualStyleBackColor = false;
            this.btnDonor.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(-5, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(771, 28);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Hello  and  welcome in    Blood  Bank  Management  System                        " +
    "       ";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // timerText
            // 
            this.timerText.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelAlt
            // 
            this.panelAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.panelAlt.Controls.Add(this.lblDev);
            this.panelAlt.Controls.Add(this.lblDevBy);
            this.panelAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAlt.Location = new System.Drawing.Point(0, 409);
            this.panelAlt.Name = "panelAlt";
            this.panelAlt.Size = new System.Drawing.Size(750, 41);
            this.panelAlt.TabIndex = 17;
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDev.ForeColor = System.Drawing.Color.Black;
            this.lblDev.Location = new System.Drawing.Point(421, 2);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(81, 30);
            this.lblDev.TabIndex = 4;
            this.lblDev.Text = "MU Mİ";
            // 
            // lblDevBy
            // 
            this.lblDevBy.AutoSize = true;
            this.lblDevBy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevBy.ForeColor = System.Drawing.Color.White;
            this.lblDevBy.Location = new System.Drawing.Point(242, 2);
            this.lblDevBy.Name = "lblDevBy";
            this.lblDevBy.Size = new System.Drawing.Size(154, 30);
            this.lblDevBy.TabIndex = 3;
            this.lblDevBy.Text = "Developed By -";
            // 
            // timerDate
            // 
            this.timerDate.Interval = 1000;
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 48);
            this.panel1.TabIndex = 22;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblTime.Location = new System.Drawing.Point(4, 362);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(82, 27);
            this.lblTime.TabIndex = 18;
            this.lblTime.Text = "22 : 22";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("DS-Digital", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.ForeColor = System.Drawing.Color.Black;
            this.lblSecond.Location = new System.Drawing.Point(84, 371);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(24, 16);
            this.lblSecond.TabIndex = 19;
            this.lblSecond.Text = "22";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("DS-Digital", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblDate.Location = new System.Drawing.Point(5, 389);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(103, 19);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = "JUNE 25 2016";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.Black;
            this.lblDay.Location = new System.Drawing.Point(5, 341);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(76, 24);
            this.lblDay.TabIndex = 21;
            this.lblDay.Text = "SUNDAY";
            // 
            // ChoseTheUserType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.panelAlt);
            this.Controls.Add(this.btnDonor);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.lblChose);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.lblAppSubName);
            this.Controls.Add(this.lnlAppName);
            this.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChoseTheUserType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoseTheUserType";
            this.Load += new System.EventHandler(this.ChoseTheUserType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelAlt.ResumeLayout(false);
            this.panelAlt.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblAppSubName;
        private System.Windows.Forms.Label lnlAppName;
        private System.Windows.Forms.Label lblChose;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnDonor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer timerText;
        private System.Windows.Forms.Panel panelAlt;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Label lblDevBy;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDay;
    }
}