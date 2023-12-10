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
    public partial class Appliances : Form
    {
        private DataAccess da { get; set; }
 
        public Appliances()
        {
            InitializeComponent();
            this.da = new DataAccess();
        }

        private void Appliances_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hARSDBDataSet.brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.hARSDBDataSet.brand);
            // TODO: This line of code loads data into the 'hARSDBDataSet.appliance_type' table. You can move, or remove it, as needed.
            this.appliance_typeTableAdapter.Fill(this.hARSDBDataSet.appliance_type);
            
        }

        public SqlConnection Sqlcon;
        public SqlCommand Sqlcom;
        public SqlDataAdapter Sda;
        public DataTable Dt;



        private void btnSave_Click(object sender, EventArgs e)
        {

            
            try
            {
                if (!string.IsNullOrEmpty(this.txtName.Text) && !string.IsNullOrEmpty(this.cboApplianceType.Text)
                    && !string.IsNullOrEmpty(this.cboBrands.Text) && !string.IsNullOrEmpty(this.txtModels.Text)
                    && !string.IsNullOrEmpty(this.txtPrice.Text) && !string.IsNullOrEmpty(this.txtColour.Text)
                    && !string.IsNullOrEmpty(this.txtDimentions.Text) && !string.IsNullOrEmpty(this.txtEnergy.Text)
                    && !string.IsNullOrEmpty(this.txtMonthDuration.Text))
                {
                    int applianceTypeId=GetApplianceTypeId(this.cboApplianceType.Text);

                    string sql = "insert into appliances (name, brands, price, models, dimensions ,colour, energy_consumption, appliance_type_id, month_duration) values('" + this.txtName.Text + "', '" + this.cboBrands.Text + "', " + this.txtPrice.Text + ", '" + this.txtModels.Text + "', '" + this.txtDimentions.Text + "', '" + this.txtColour.Text + "', '" + this.txtEnergy.Text + "', " + applianceTypeId + ", " + this.txtMonthDuration.Text  + ")";

                    int count = this.da.ExecuteDML(sql);
                    

                    if (count == 1)
                    {
                        MessageBox.Show("Appliance Successfully Saved.");
                        this.Visible = false;
                    }else
                    {
                        MessageBox.Show("Could not save appliance.");
                        this.txtName.Text = "";
                        this.txtModels.Text = "";
                        this.txtPrice.Text = ""; 
                        this.txtColour.Text = "";
                        this.txtDimentions.Text = "";
                        this.txtEnergy.Text = "";
                        this.txtMonthDuration.Text = "";
                    }
                    this.da.Sqlcon.Close();
                }
                else if (string.IsNullOrEmpty(this.txtName.Text))
                {
                    MessageBox.Show("Name must not be empty.");
                }
                else if (string.IsNullOrEmpty(this.txtModels.Text))
                {
                    MessageBox.Show("Models must not be empty.");
                }
                else if (string.IsNullOrEmpty(this.txtPrice.Text))
                {
                    MessageBox.Show("Price must not be empty.");
                }
                else if (string.IsNullOrEmpty(this.txtColour.Text))
                {
                    MessageBox.Show("Colour must not be empty.");
                }
                else if (string.IsNullOrEmpty(this.txtDimentions.Text))
                {
                    MessageBox.Show("Dimensions must not be empty.");
                }
                else if (string.IsNullOrEmpty(this.txtEnergy.Text))
                {
                    MessageBox.Show("Energy consumption must not be empty.");
                }
                else if (string.IsNullOrEmpty(this.txtMonthDuration.Text))
                {
                    MessageBox.Show("Month Duration must not be empty.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
            
        
        }

        public int GetApplianceTypeId(String name)
        {
            string sql = $@"select * from appliance_type where name = '{@name}' ";
            int intId = 0;
            try
            {

                DataTable dt = this.da.ExecuteQueryTable(sql);
                if (dt.Rows.Count == 1)
                {
                    String id = dt.Rows[0]["id"].ToString();
                    intId = Convert.ToInt32(id);

                }
                this.da.Sqlcon.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
            return intId;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
