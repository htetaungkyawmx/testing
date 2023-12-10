
using System;
using System.Data;
using System.Windows.Forms;

namespace HARS
{
    public partial class Login : Form
    {
        private DataAccess da { get; set; }

        public Login()
        {
            InitializeComponent();
            this.da = new DataAccess();
            this.errorMessage.Visible = false;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from register where username = '" + this.txtUserName.Text + "' and password = '" + this.txtPassword.Text + "';";
            try
            {
                
                DataTable dt = this.da.ExecuteQueryTable(sql);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Valid");
                    String username = this.txtUserName.Text;
                    String role = dt.Rows[0]["role"].ToString();
                    Dashboard dashboard = new Dashboard(username, role);
                    dashboard.Visible = true;
                    this.Visible = false;
                    this.da.Sqlcon.Close();

                }
                else
                {
                    MessageBox.Show("Login Invalid");
                    this.errorMessage.Visible = true;
                    this.txtUserName.Text = "";
                    this.txtPassword.Text = "";
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
           
        }

       

        private void Login_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 10;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Visible = true;
            this.Visible = false;
        }
    }
}
