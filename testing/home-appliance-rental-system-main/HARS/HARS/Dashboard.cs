using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HARS
{
    public partial class Dashboard : Form
    {
        String role;
        String active_rent_term = "";
        String max_rent_term = "";

        private DataAccess da { get; set; }

       
        public Dashboard(String name, String role)
        {
            InitializeComponent();
            this.lblUsername.Text = name;
            this.role = role;
            this.da = new DataAccess();
        }


        private void menuApplianceType_Click(object sender, EventArgs e)
        {
            AppliancesTypes appliancesTypes = new AppliancesTypes();
            appliancesTypes.Visible = true;
        
        }

        private void menuAppliance_Click(object sender, EventArgs e)
        {
            Appliances appliances = new Appliances();
            appliances.Visible = true;

        }

        private void menuBrand_Click(object sender, EventArgs e)
        {
            Brand brand = new Brand();
            brand.Visible = true;
        }

        private void menuApplianceList_Click(object sender, EventArgs e)
        {
            ApplianceList applianceList = new ApplianceList();
            applianceList.Visible = true;
        }

        private void menuRent_Click(object sender, EventArgs e)
        {
           if (checkRentable(this.lblUsername.Text))
           {
                Rent rent = new Rent(this.lblUsername.Text, active_rent_term);
              rent.Visible = true;
            }
            else
            {
                MessageBox.Show(lblUsername.Text +" exceed the maximum term.");
            }
           
        }

        private bool checkRentable(String username)
        {

            string sql = $@"select * from register where username = '{@username}' ";
            try
            {

                DataTable dt = this.da.ExecuteQueryTable(sql);
                if (dt.Rows.Count == 1)
                {
                    active_rent_term = dt.Rows[0]["active_rent_term"].ToString();
                    max_rent_term = dt.Rows[0]["max_rent_term"].ToString();

                    if (Convert.ToInt32(active_rent_term) >= Convert.ToInt32(max_rent_term))
                    {
                        return false;

                    }
                    return true;
                }
                this.da.Sqlcon.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
            return true;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (this.role.Equals("user"))
            {
                menuAppliance.Visible = false;
                menuApplianceType.Visible = false;
                menuBrand.Visible = false;
                menuApplianceList.Visible = false;
                menuUserList.Visible = false;
                menuRentList.Visible = false;
            }
            else {
                menuApplianceListForUser.Visible = false;
                menuUserRentList.Visible = false;
            }
        }

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Visible = true;
            this.Visible = false;
        }

        private void menuRentList_Click(object sender, EventArgs e)
        {
            checkRentable(this.lblUsername.Text);  //assume method invoking to initialize active_rent_term
            RentList rentList = new RentList(this.lblUsername.Text, role, active_rent_term);
            rentList.Visible = true;
        }

        private void menuApplianceListForUser_Click(object sender, EventArgs e)
        {
            ApplianceListForUser applianceListForUser = new ApplianceListForUser();
            applianceListForUser.Visible = true;
        }

        private void menuUserList_Click(object sender, EventArgs e)
        {
            RegisterList registerList = new RegisterList();
            registerList.Visible = true;
            
        }

        private void menuUserRentList_Click(object sender, EventArgs e)
        {
            UserRentList userRentList = new UserRentList(this.lblUsername.Text, role);
            userRentList.Visible = true;
        }
    }
}
