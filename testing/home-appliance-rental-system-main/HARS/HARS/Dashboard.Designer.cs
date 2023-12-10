
namespace HARS
{
    partial class Dashboard
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuAppliance = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApplianceList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApplianceListForUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApplianceType = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBrand = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRentList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuUserList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUserRentList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(691, 7);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(53, 13);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "username";
            // 
            // btnLogout
            // 
            this.btnLogout.AutoSize = true;
            this.btnLogout.Location = new System.Drawing.Point(760, 7);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(40, 13);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.TabStop = true;
            this.btnLogout.Text = "Logout";
            this.btnLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLogout_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // menuAppliance
            // 
            this.menuAppliance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuAppliance.Name = "menuAppliance";
            this.menuAppliance.Size = new System.Drawing.Size(77, 20);
            this.menuAppliance.Text = "Appliances";
            this.menuAppliance.Click += new System.EventHandler(this.menuAppliance_Click);
            // 
            // menuApplianceList
            // 
            this.menuApplianceList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuApplianceList.Name = "menuApplianceList";
            this.menuApplianceList.Size = new System.Drawing.Size(93, 20);
            this.menuApplianceList.Text = "Appliance List";
            this.menuApplianceList.Click += new System.EventHandler(this.menuApplianceList_Click);
            // 
            // menuApplianceListForUser
            // 
            this.menuApplianceListForUser.ForeColor = System.Drawing.Color.White;
            this.menuApplianceListForUser.Name = "menuApplianceListForUser";
            this.menuApplianceListForUser.Size = new System.Drawing.Size(93, 20);
            this.menuApplianceListForUser.Text = "Appliance List";
            this.menuApplianceListForUser.Click += new System.EventHandler(this.menuApplianceListForUser_Click);
            // 
            // menuApplianceType
            // 
            this.menuApplianceType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuApplianceType.Name = "menuApplianceType";
            this.menuApplianceType.Size = new System.Drawing.Size(99, 20);
            this.menuApplianceType.Text = "Appliance Type";
            this.menuApplianceType.Click += new System.EventHandler(this.menuApplianceType_Click);
            // 
            // menuBrand
            // 
            this.menuBrand.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuBrand.Name = "menuBrand";
            this.menuBrand.Size = new System.Drawing.Size(50, 20);
            this.menuBrand.Text = "Brand";
            this.menuBrand.Click += new System.EventHandler(this.menuBrand_Click);
            // 
            // menuRent
            // 
            this.menuRent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuRent.Name = "menuRent";
            this.menuRent.Size = new System.Drawing.Size(43, 20);
            this.menuRent.Text = "Rent";
            this.menuRent.Click += new System.EventHandler(this.menuRent_Click);
            // 
            // menuRentList
            // 
            this.menuRentList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuRentList.Name = "menuRentList";
            this.menuRentList.Size = new System.Drawing.Size(64, 20);
            this.menuRentList.Text = "Rent List";
            this.menuRentList.Click += new System.EventHandler(this.menuRentList_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAppliance,
            this.menuApplianceList,
            this.menuApplianceListForUser,
            this.menuApplianceType,
            this.menuBrand,
            this.menuRent,
            this.menuRentList,
            this.menuUserList,
            this.menuUserRentList});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuUserList
            // 
            this.menuUserList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuUserList.Name = "menuUserList";
            this.menuUserList.Size = new System.Drawing.Size(63, 20);
            this.menuUserList.Text = "User List";
            this.menuUserList.Click += new System.EventHandler(this.menuUserList_Click);
            // 
            // menuUserRentList
            // 
            this.menuUserRentList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuUserRentList.Name = "menuUserRentList";
            this.menuUserRentList.Size = new System.Drawing.Size(80, 20);
            this.menuUserRentList.Text = "UseRentList";
            this.menuUserRentList.Click += new System.EventHandler(this.menuUserRentList_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(847, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.LinkLabel btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuAppliance;
        private System.Windows.Forms.ToolStripMenuItem menuApplianceList;
        private System.Windows.Forms.ToolStripMenuItem menuApplianceListForUser;
        private System.Windows.Forms.ToolStripMenuItem menuApplianceType;
        private System.Windows.Forms.ToolStripMenuItem menuBrand;
        private System.Windows.Forms.ToolStripMenuItem menuRent;
        private System.Windows.Forms.ToolStripMenuItem menuRentList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuUserList;
        private System.Windows.Forms.ToolStripMenuItem menuUserRentList;
    }
}