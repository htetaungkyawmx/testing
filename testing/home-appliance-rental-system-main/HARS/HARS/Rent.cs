using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HARS
{
    public partial class Rent : Form
    {
        private DataAccess da { get; set; }
        String loginUserName = "";
        String activeRentTerm = "";

        public Rent(String loginUserName, String activeRentTerm)
        {
            InitializeComponent();
            this.loginUserName = loginUserName;
            this.activeRentTerm = activeRentTerm;
            this.da = new DataAccess();
            initAppliance();
            
        }



        public void refreshState(String applianceTypeId, String brandName)
        {
            string sql;
            if (!string.IsNullOrEmpty(applianceTypeId) && string.IsNullOrEmpty(brandName))
            {
                sql = $@"select * from appliances where appliance_type_id = '{@applianceTypeId}'   ";
            }else if(string.IsNullOrEmpty(applianceTypeId) && !string.IsNullOrEmpty(brandName))
            {
                sql = $@"select * from appliances where brands = '{@brandName}'  ";
            }else
            {
                sql = $@"select * from appliances where appliance_type_id = '{@applianceTypeId}' and brands = '{@brandName}'  ";
            }

            

            DataTable dt = this.da.ExecuteQueryTable(sql);

             DataRow dr = dt.NewRow();
             dr.ItemArray = new object[] { 0, "Select Appliance" };
             dt.Rows.InsertAt(dr, 0);
            
            cboAppliance.DisplayMember = "name";
            cboAppliance.ValueMember = "id";
            cboAppliance.DataSource = dt;
            this.da.Sqlcon.Close();
        }

     
        public void initAppliance()
        {
            string sql = $@"select * from appliances ";

            DataTable dt = this.da.ExecuteQueryTable(sql);

            DataRow dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "Select Appliance" };
            dt.Rows.InsertAt(dr, 0);

            cboAppliance.DisplayMember = "name";
            cboAppliance.ValueMember = "id";
            cboAppliance.DataSource = dt;
            this.da.Sqlcon.Close();
        }
        public void initApplianceType()
        {
            string sql = $@"select * from appliance_type";

            DataTable dt = this.da.ExecuteQueryTable(sql);

            DataRow dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "Select Appliance Type" };
            dt.Rows.InsertAt(dr, 0);

            cboApplianceType.DisplayMember = "name";
            cboApplianceType.ValueMember = "id";
            cboApplianceType.DataSource = dt;
            this.da.Sqlcon.Close();
        }
        public void initBrand()
        {
            string sql = $@"select * from brand";

            DataTable dt = this.da.ExecuteQueryTable(sql);

            DataRow dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "Select Brand" };
            dt.Rows.InsertAt(dr, 0);

            cboBrand.DisplayMember = "name";
            cboBrand.ValueMember = "id";
            cboBrand.DataSource = dt;
            this.da.Sqlcon.Close();
        }

        private void Rent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hARSDBDataSet.brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.hARSDBDataSet.brand);
            // TODO: This line of code loads data into the 'hARSDBDataSet.appliances' table. You can move, or remove it, as needed.
            this.appliancesTableAdapter.Fill(this.hARSDBDataSet.appliances);
            // TODO: This line of code loads data into the 'hARSDBDataSet.appliance_type' table. You can move, or remove it, as needed.
            this.appliance_typeTableAdapter.Fill(this.hARSDBDataSet.appliance_type);
        }

        private void cboApplianceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            String brandName = "";

            DataRowView brandNameDrv = (DataRowView)cboBrand.SelectedValue;
            if (brandNameDrv != null)
            {
                brandName = brandNameDrv.Row[1].ToString();
            }



            ComboBox comboBox = (ComboBox)sender;
            DataRowView drv = (DataRowView)comboBox.SelectedValue;
            if (drv != null)
            {
                String id = drv.Row[0].ToString();
                refreshState(id, brandName);
            }
        }

        private void cboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            String id = "";
            DataRowView applianceTypeDRV = (DataRowView)this.cboApplianceType.SelectedValue;

            if (applianceTypeDRV != null)
            {
                
                id = applianceTypeDRV.Row[0].ToString();
            }


            ComboBox comboBox = (ComboBox)sender;
            DataRowView drv = (DataRowView)comboBox.SelectedValue;
            if ( drv != null )
            {   
                String brandName = drv.Row[1].ToString();
                refreshState(id, brandName);
            }

        }

        private void cboAppliance_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (!this.cboAppliance.SelectedValue.Equals(0))
            {
                loadData(this.cboAppliance.SelectedValue.ToString());
            }

        }

        public void loadData(String id)
        {
            String sql = $@"select * from appliances where id = '{@id}'   ";
            
            DataTable dt = this.da.ExecuteQueryTable(sql);
            this.da.Sqlcon.Close();
            if (dt.Rows.Count == 1)
            {
                
                DateTime startDate = this.dtpStartDate.Value;
                DateTime endDate = this.dtpEndDate.Value;
                int month = (endDate.Year - startDate.Year) * 12 + endDate.Month - startDate.Month;

                String monthDurationSTR=dt.Rows[0]["month_duration"].ToString();
                int monthDuration=0;
                if (!string.IsNullOrEmpty(monthDurationSTR))
                {
                    monthDuration = Convert.ToInt32(monthDurationSTR);
                }

                String priceSTR = dt.Rows[0]["price"].ToString();
                int price = Convert.ToInt32(priceSTR);
           

                if(month <= monthDuration)
                {
                    int resultPrice = month == 0 ? Convert.ToInt32(price) : price * month;
                    txtPrice.Text = resultPrice.ToString();
                }
                else
                {
                    MessageBox.Show("Rental Term Overflow the appliance's maximum term.");
                }

                
            }
            

        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (!this.cboAppliance.SelectedValue.Equals(0))
            {
                loadData(this.cboAppliance.SelectedValue.ToString());
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                DataRowView appliceTypeDRV = (DataRowView)this.cboApplianceType.SelectedValue;
                String applianceType = appliceTypeDRV.Row[1].ToString();

                DataRowView brandDRV = (DataRowView)this.cboBrand.SelectedValue;
                String brand = brandDRV.Row[1].ToString();

                String applianceId = this.cboAppliance.SelectedValue.ToString();
                DataTable dt =loadAppliance(applianceId);
                String applianceName = dt.Rows[0]["name"].ToString();
                String price = this.txtPrice.Text;

                String models = dt.Rows[0]["models"].ToString();
                
                String startDate=this.dtpStartDate.Value.ToString("dd_MM_yyyy", CultureInfo.InvariantCulture);
                String endDate = this.dtpEndDate.Value.ToString("dd_MM_yyyy", CultureInfo.InvariantCulture);
                
                String submittedDate = DateTime.Now.ToString("dd_MM_yyyy", CultureInfo.InvariantCulture);

                String rentee = loginUserName;


                string sql = "insert into rent (appliance, appliance_type, brand, price, models , start_date, end_date, submitted_date, rentee) values('" + applianceName + "', '" + applianceType + "', '" + brand + "', '" + price + "', '" + models + "', '" + startDate + "', '" + endDate + "', '" + submittedDate + "', '" + rentee + "')";

                int count = this.da.ExecuteDML(sql);
                this.da.Sqlcon.Close();

                String updateRegisterSql = "Update register set active_rent_term = @active_rent_term Where username = @username";
                SqlCommand cmd = this.da.QueryText(updateRegisterSql);

                cmd.Parameters.AddWithValue("@username", loginUserName);
                cmd.Parameters.AddWithValue("@active_rent_term", Convert.ToInt32(activeRentTerm)+1);
                cmd.ExecuteNonQuery();
                this.da.Sqlcon.Close();

                if (count == 1)
                {
                    MessageBox.Show("Successfully Rented "+ applianceName +" by " + rentee );
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Could not rented appliance " + applianceName);
                    this.Visible = false;
                }
                


            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        public DataTable loadAppliance(String id)
        {
            String sql = $@"select * from appliances where id = '{@id}'   ";
            DataTable dt = this.da.ExecuteQueryTable(sql);
            this.da.Sqlcon.Close();
            return dt;
        }

        private void Appliance_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
