namespace BloodBankManagementSystem
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.uToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAlt = new System.Windows.Forms.Panel();
            this.lblDev = new System.Windows.Forms.Label();
            this.lblDevBy = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.panelOpozi = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOposiCount = new System.Windows.Forms.Label();
            this.labelBloodGruop = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOnegaCount = new System.Windows.Forms.Label();
            this.lblOnega = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAnegaCount = new System.Windows.Forms.Label();
            this.lblAnega = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAposiCount = new System.Windows.Forms.Label();
            this.lblAposi = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblABnegaCount = new System.Windows.Forms.Label();
            this.lblABnega = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblABposiCount = new System.Windows.Forms.Label();
            this.lblABposi = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.lblBnegaCount = new System.Windows.Forms.Label();
            this.lblBnega = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.lblBposiCount = new System.Windows.Forms.Label();
            this.lblBposi = new System.Windows.Forms.Label();
            this.dgvDonors = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblUserTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.menuStripTop.SuspendLayout();
            this.panelAlt.SuspendLayout();
            this.panelOpozi.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uToolStripMenuItem,
            this.donToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Padding = new System.Windows.Forms.Padding(6, 10, 0, 10);
            this.menuStripTop.Size = new System.Drawing.Size(1135, 41);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // uToolStripMenuItem
            // 
            this.uToolStripMenuItem.Name = "uToolStripMenuItem";
            this.uToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.uToolStripMenuItem.Text = "User";
            this.uToolStripMenuItem.Click += new System.EventHandler(this.uToolStripMenuItem_Click);
            // 
            // donToolStripMenuItem
            // 
            this.donToolStripMenuItem.Name = "donToolStripMenuItem";
            this.donToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.donToolStripMenuItem.Text = "Donors";
            this.donToolStripMenuItem.Click += new System.EventHandler(this.donToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 21);
            this.toolStripMenuItem1.Text = " ";
            // 
            // panelAlt
            // 
            this.panelAlt.BackColor = System.Drawing.SystemColors.Control;
            this.panelAlt.Controls.Add(this.lblDev);
            this.panelAlt.Controls.Add(this.lblDevBy);
            this.panelAlt.Controls.Add(this.lblAppName);
            this.panelAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAlt.Location = new System.Drawing.Point(0, 659);
            this.panelAlt.Name = "panelAlt";
            this.panelAlt.Size = new System.Drawing.Size(1135, 41);
            this.panelAlt.TabIndex = 1;
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDev.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDev.Location = new System.Drawing.Point(763, 2);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(81, 30);
            this.lblDev.TabIndex = 4;
            this.lblDev.Text = "MU Mİ";
            // 
            // lblDevBy
            // 
            this.lblDevBy.AutoSize = true;
            this.lblDevBy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevBy.ForeColor = System.Drawing.Color.Black;
            this.lblDevBy.Location = new System.Drawing.Point(603, 2);
            this.lblDevBy.Name = "lblDevBy";
            this.lblDevBy.Size = new System.Drawing.Size(154, 30);
            this.lblDevBy.TabIndex = 3;
            this.lblDevBy.Text = "Developed By -";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblAppName.Location = new System.Drawing.Point(270, 2);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(318, 30);
            this.lblAppName.TabIndex = 2;
            this.lblAppName.Text = "Blood Bank Management System";
            // 
            // panelOpozi
            // 
            this.panelOpozi.BackColor = System.Drawing.SystemColors.Control;
            this.panelOpozi.Controls.Add(this.lblName);
            this.panelOpozi.Controls.Add(this.lblOposiCount);
            this.panelOpozi.Controls.Add(this.labelBloodGruop);
            this.panelOpozi.Location = new System.Drawing.Point(20, 125);
            this.panelOpozi.Name = "panelOpozi";
            this.panelOpozi.Size = new System.Drawing.Size(200, 100);
            this.panelOpozi.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(124, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 21);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Donors";
            // 
            // lblOposiCount
            // 
            this.lblOposiCount.AutoSize = true;
            this.lblOposiCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOposiCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblOposiCount.Location = new System.Drawing.Point(120, 9);
            this.lblOposiCount.Name = "lblOposiCount";
            this.lblOposiCount.Size = new System.Drawing.Size(30, 47);
            this.lblOposiCount.TabIndex = 1;
            this.lblOposiCount.Text = " ";
            // 
            // labelBloodGruop
            // 
            this.labelBloodGruop.AutoSize = true;
            this.labelBloodGruop.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloodGruop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.labelBloodGruop.Location = new System.Drawing.Point(3, 19);
            this.labelBloodGruop.Name = "labelBloodGruop";
            this.labelBloodGruop.Size = new System.Drawing.Size(98, 65);
            this.labelBloodGruop.TabIndex = 0;
            this.labelBloodGruop.Text = "O+";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblOnegaCount);
            this.panel1.Controls.Add(this.lblOnega);
            this.panel1.Location = new System.Drawing.Point(240, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Donors";
            // 
            // lblOnegaCount
            // 
            this.lblOnegaCount.AutoSize = true;
            this.lblOnegaCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnegaCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblOnegaCount.Location = new System.Drawing.Point(120, 9);
            this.lblOnegaCount.Name = "lblOnegaCount";
            this.lblOnegaCount.Size = new System.Drawing.Size(77, 47);
            this.lblOnegaCount.TabIndex = 1;
            this.lblOnegaCount.Text = "100";
            this.lblOnegaCount.Click += new System.EventHandler(this.lblOnegaCount_Click);
            // 
            // lblOnega
            // 
            this.lblOnega.AutoSize = true;
            this.lblOnega.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblOnega.Location = new System.Drawing.Point(3, 19);
            this.lblOnega.Name = "lblOnega";
            this.lblOnega.Size = new System.Drawing.Size(83, 65);
            this.lblOnega.TabIndex = 0;
            this.lblOnega.Text = "O-";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblAnegaCount);
            this.panel2.Controls.Add(this.lblAnega);
            this.panel2.Location = new System.Drawing.Point(240, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Donors";
            // 
            // lblAnegaCount
            // 
            this.lblAnegaCount.AutoSize = true;
            this.lblAnegaCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnegaCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblAnegaCount.Location = new System.Drawing.Point(119, 9);
            this.lblAnegaCount.Name = "lblAnegaCount";
            this.lblAnegaCount.Size = new System.Drawing.Size(77, 47);
            this.lblAnegaCount.TabIndex = 1;
            this.lblAnegaCount.Text = "100";
            // 
            // lblAnega
            // 
            this.lblAnega.AutoSize = true;
            this.lblAnega.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblAnega.Location = new System.Drawing.Point(3, 19);
            this.lblAnega.Name = "lblAnega";
            this.lblAnega.Size = new System.Drawing.Size(81, 65);
            this.lblAnega.TabIndex = 0;
            this.lblAnega.Text = "A-";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblAposiCount);
            this.panel3.Controls.Add(this.lblAposi);
            this.panel3.Location = new System.Drawing.Point(20, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(124, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Donors";
            // 
            // lblAposiCount
            // 
            this.lblAposiCount.AutoSize = true;
            this.lblAposiCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAposiCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblAposiCount.Location = new System.Drawing.Point(120, 9);
            this.lblAposiCount.Name = "lblAposiCount";
            this.lblAposiCount.Size = new System.Drawing.Size(77, 47);
            this.lblAposiCount.TabIndex = 1;
            this.lblAposiCount.Text = "100";
            // 
            // lblAposi
            // 
            this.lblAposi.AutoSize = true;
            this.lblAposi.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAposi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblAposi.Location = new System.Drawing.Point(3, 19);
            this.lblAposi.Name = "lblAposi";
            this.lblAposi.Size = new System.Drawing.Size(96, 65);
            this.lblAposi.TabIndex = 0;
            this.lblAposi.Text = "A+";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lblABnegaCount);
            this.panel4.Controls.Add(this.lblABnega);
            this.panel4.Location = new System.Drawing.Point(240, 481);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(124, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "Donors";
            // 
            // lblABnegaCount
            // 
            this.lblABnegaCount.AutoSize = true;
            this.lblABnegaCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABnegaCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblABnegaCount.Location = new System.Drawing.Point(120, 9);
            this.lblABnegaCount.Name = "lblABnegaCount";
            this.lblABnegaCount.Size = new System.Drawing.Size(77, 47);
            this.lblABnegaCount.TabIndex = 1;
            this.lblABnegaCount.Text = "100";
            // 
            // lblABnega
            // 
            this.lblABnega.AutoSize = true;
            this.lblABnega.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABnega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblABnega.Location = new System.Drawing.Point(3, 19);
            this.lblABnega.Name = "lblABnega";
            this.lblABnega.Size = new System.Drawing.Size(112, 65);
            this.lblABnega.TabIndex = 0;
            this.lblABnega.Text = "AB-";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.lblABposiCount);
            this.panel5.Controls.Add(this.lblABposi);
            this.panel5.Location = new System.Drawing.Point(20, 481);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(124, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 21);
            this.label13.TabIndex = 3;
            this.label13.Text = "Donors";
            // 
            // lblABposiCount
            // 
            this.lblABposiCount.AutoSize = true;
            this.lblABposiCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABposiCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblABposiCount.Location = new System.Drawing.Point(120, 9);
            this.lblABposiCount.Name = "lblABposiCount";
            this.lblABposiCount.Size = new System.Drawing.Size(77, 47);
            this.lblABposiCount.TabIndex = 1;
            this.lblABposiCount.Text = "100";
            // 
            // lblABposi
            // 
            this.lblABposi.AutoSize = true;
            this.lblABposi.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABposi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblABposi.Location = new System.Drawing.Point(3, 19);
            this.lblABposi.Name = "lblABposi";
            this.lblABposi.Size = new System.Drawing.Size(127, 65);
            this.lblABposi.TabIndex = 0;
            this.lblABposi.Text = "AB+";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.lblBnegaCount);
            this.panel6.Controls.Add(this.lblBnega);
            this.panel6.Location = new System.Drawing.Point(240, 364);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(124, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 21);
            this.label16.TabIndex = 3;
            this.label16.Text = "Donors";
            // 
            // lblBnegaCount
            // 
            this.lblBnegaCount.AutoSize = true;
            this.lblBnegaCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBnegaCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBnegaCount.Location = new System.Drawing.Point(120, 9);
            this.lblBnegaCount.Name = "lblBnegaCount";
            this.lblBnegaCount.Size = new System.Drawing.Size(77, 47);
            this.lblBnegaCount.TabIndex = 1;
            this.lblBnegaCount.Text = "100";
            // 
            // lblBnega
            // 
            this.lblBnega.AutoSize = true;
            this.lblBnega.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBnega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBnega.Location = new System.Drawing.Point(3, 19);
            this.lblBnega.Name = "lblBnega";
            this.lblBnega.Size = new System.Drawing.Size(78, 65);
            this.lblBnega.TabIndex = 0;
            this.lblBnega.Text = "B-";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.lblBposiCount);
            this.panel7.Controls.Add(this.lblBposi);
            this.panel7.Location = new System.Drawing.Point(20, 364);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(124, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 21);
            this.label19.TabIndex = 3;
            this.label19.Text = "Donors";
            // 
            // lblBposiCount
            // 
            this.lblBposiCount.AutoSize = true;
            this.lblBposiCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBposiCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBposiCount.Location = new System.Drawing.Point(120, 9);
            this.lblBposiCount.Name = "lblBposiCount";
            this.lblBposiCount.Size = new System.Drawing.Size(77, 47);
            this.lblBposiCount.TabIndex = 1;
            this.lblBposiCount.Text = "100";
            // 
            // lblBposi
            // 
            this.lblBposi.AutoSize = true;
            this.lblBposi.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBposi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBposi.Location = new System.Drawing.Point(3, 19);
            this.lblBposi.Name = "lblBposi";
            this.lblBposi.Size = new System.Drawing.Size(93, 65);
            this.lblBposi.TabIndex = 0;
            this.lblBposi.Text = "B+";
            // 
            // dgvDonors
            // 
            this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonors.Location = new System.Drawing.Point(485, 177);
            this.dgvDonors.Name = "dgvDonors";
            this.dgvDonors.Size = new System.Drawing.Size(625, 404);
            this.dgvDonors.TabIndex = 10;
            this.dgvDonors.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgUsers_RowHeaderMouseClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(481, 128);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(109, 21);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search Donor";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(610, 125);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(500, 29);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1092, 9);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(31, 29);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 13;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblUserTitle
            // 
            this.lblUserTitle.AutoSize = true;
            this.lblUserTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblUserTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTitle.Location = new System.Drawing.Point(237, 13);
            this.lblUserTitle.Name = "lblUserTitle";
            this.lblUserTitle.Size = new System.Drawing.Size(97, 17);
            this.lblUserTitle.TabIndex = 14;
            this.lblUserTitle.Text = "Logged In As :";
            this.lblUserTitle.Click += new System.EventHandler(this.lblUserTitle_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.SystemColors.Control;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblUser.Location = new System.Drawing.Point(350, 8);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(21, 30);
            this.lblUser.TabIndex = 15;
            this.lblUser.Text = "-";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("DS-Digital", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblDate.Location = new System.Drawing.Point(101, 637);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(103, 19);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "JUNE 25 2016";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.BackColor = System.Drawing.Color.White;
            this.lblSecond.Font = new System.Drawing.Font("DS-Digital", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.ForeColor = System.Drawing.Color.Black;
            this.lblSecond.Location = new System.Drawing.Point(80, 637);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(27, 19);
            this.lblSecond.TabIndex = 23;
            this.lblSecond.Text = "22";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.White;
            this.lblTime.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblTime.Location = new System.Drawing.Point(3, 629);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(82, 27);
            this.lblTime.TabIndex = 22;
            this.lblTime.Text = "22 : 22";
            // 
            // timerDate
            // 
            this.timerDate.Interval = 1000;
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1135, 700);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserTitle);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvDonors);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOpozi);
            this.Controls.Add(this.panelAlt);
            this.Controls.Add(this.menuStripTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.FormHome_Activated);
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.panelAlt.ResumeLayout(false);
            this.panelAlt.PerformLayout();
            this.panelOpozi.ResumeLayout(false);
            this.panelOpozi.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem uToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donToolStripMenuItem;
        private System.Windows.Forms.Panel panelAlt;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Label lblDevBy;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Panel panelOpozi;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOposiCount;
        private System.Windows.Forms.Label labelBloodGruop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOnegaCount;
        private System.Windows.Forms.Label lblOnega;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAnegaCount;
        private System.Windows.Forms.Label lblAnega;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAposiCount;
        private System.Windows.Forms.Label lblAposi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblABnegaCount;
        private System.Windows.Forms.Label lblABnega;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblABposiCount;
        private System.Windows.Forms.Label lblABposi;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblBnegaCount;
        private System.Windows.Forms.Label lblBnega;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblBposiCount;
        private System.Windows.Forms.Label lblBposi;
        private System.Windows.Forms.DataGridView dgvDonors;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lblUserTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerDate;
    }
}