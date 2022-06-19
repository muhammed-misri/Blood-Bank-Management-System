namespace BloodBankManagementSystem.UI
{
    partial class FormSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSplash));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblAppSubName = new System.Windows.Forms.Label();
            this.lnlAppName = new System.Windows.Forms.Label();
            this.panelBG = new System.Windows.Forms.Panel();
            this.panelMovebale = new System.Windows.Forms.Panel();
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(136, 87);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(96, 98);
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblAppSubName
            // 
            this.lblAppSubName.AutoSize = true;
            this.lblAppSubName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppSubName.ForeColor = System.Drawing.Color.White;
            this.lblAppSubName.Location = new System.Drawing.Point(363, 155);
            this.lblAppSubName.Name = "lblAppSubName";
            this.lblAppSubName.Size = new System.Drawing.Size(214, 30);
            this.lblAppSubName.TabIndex = 11;
            this.lblAppSubName.Text = "Management System";
            // 
            // lnlAppName
            // 
            this.lnlAppName.AutoSize = true;
            this.lnlAppName.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlAppName.ForeColor = System.Drawing.Color.Black;
            this.lnlAppName.Location = new System.Drawing.Point(359, 93);
            this.lnlAppName.Name = "lnlAppName";
            this.lnlAppName.Size = new System.Drawing.Size(223, 50);
            this.lnlAppName.TabIndex = 10;
            this.lnlAppName.Text = "Blood Bank";
            // 
            // panelBG
            // 
            this.panelBG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBG.Controls.Add(this.panelMovebale);
            this.panelBG.Location = new System.Drawing.Point(0, 293);
            this.panelBG.Name = "panelBG";
            this.panelBG.Size = new System.Drawing.Size(655, 28);
            this.panelBG.TabIndex = 12;
            // 
            // panelMovebale
            // 
            this.panelMovebale.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelMovebale.Location = new System.Drawing.Point(0, 0);
            this.panelMovebale.Name = "panelMovebale";
            this.panelMovebale.Size = new System.Drawing.Size(35, 28);
            this.panelMovebale.TabIndex = 0;
            this.panelMovebale.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMovebale_Paint);
            // 
            // timerSplash
            // 
            this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
            // 
            // FormSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(655, 382);
            this.Controls.Add(this.panelBG);
            this.Controls.Add(this.lblAppSubName);
            this.Controls.Add(this.lnlAppName);
            this.Controls.Add(this.pictureBoxLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSplash";
            this.Load += new System.EventHandler(this.FormSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelBG.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblAppSubName;
        private System.Windows.Forms.Label lnlAppName;
        private System.Windows.Forms.Panel panelBG;
        private System.Windows.Forms.Panel panelMovebale;
        private System.Windows.Forms.Timer timerSplash;
    }
}