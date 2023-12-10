using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HARS
{
    public partial class Register : Form
    {
        private DataAccess da { get; set; }
        private String role;
        public Register()
        {
            InitializeComponent();
            this.da = new DataAccess();
        }

        private void btnRegister_Click(object sender, EventArgs e)  //" + this.txtUserName.Text + "
                                                                    //" + this.txtPassword.Text + "
                                                                    //" + this.txtNrcNumber.Text + "
                                                                    //" + this.txtPhoneNumber.Text + "
                                                                    //" + this.txtAddress.Text + "
        {
            
            if(!loadUserByUsername(this.txtUserName.Text))
            {
                int defaultMaxRentTerm = 5;
                string sql = "insert into register (username, password, nrcno, phone, address, role, max_rent_term) values('" + this.txtUserName.Text + "', '" + this.txtPassword.Text + "', '" + this.txtNrcNumber.Text + "', " + this.txtPhoneNumber.Text + " , '" + this.txtAddress.Text + "', '" + role + "', " + defaultMaxRentTerm + " )";

                try
                {
                    if (this.txtPassword.Text == this.txtConfirmPassword.Text)
                    {
                        int count = this.da.ExecuteDML(sql);

                        if (count == 1)
                        {

                            MessageBox.Show("Registered successfully");

                            Login login = new Login();
                            login.Visible = true;
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Register Failed.");
                            this.txtUserName.Text = "";
                            this.txtPassword.Text = "";
                            this.txtConfirmPassword.Text = "";
                            this.txtNrcNumber.Text = "";
                            this.txtPhoneNumber.Text = "";
                            this.txtAddress.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter same password.");
                    }
                    this.da.Sqlcon.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Error: " + exc.Message);
                }
            }
            else
            {
                MessageBox.Show("Can Not Use this username.Username already exist.");
            }

            

        }

        private bool loadUserByUsername(String username)
        {
            string sql = $@"select * from register where username = '{@username}' ";
            try
            {

                DataTable dt = this.da.ExecuteQueryTable(sql);
                if (dt.Rows.Count == 1)
                {
                    return true;
                }
                this.da.Sqlcon.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
            return false;
        }




        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            this.Visible = false;
        }

        private void cbRole_CheckedChanged(object sender, EventArgs e)
        {
            checkAdmin();
        }
        private void checkAdmin()
        {
            bool isAdmin = cbRole.Checked;
            if (isAdmin)
            {
                role = "admin";
            }
            else
            {
                role = "user";
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 10;
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.MaxLength = 10;
            checkAdmin();
        }

        private void menuClick_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHowtouse frmhowtouse = new frmHowtouse();
            frmhowtouse.Visible = true;
            this.Visible = false;
        }
    }
}