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
    public partial class ApplianceList : Form
    {

        private DataAccess da { get; set; }

        public ApplianceList()
        {
            InitializeComponent();
            this.da = new DataAccess();
        }


        private void ApplianceList_Load(object sender, EventArgs e)
        {
            
            loadApplianceList();
        }

        private void loadApplianceList()
        {
            this.appliancesTableAdapter.Fill(this.hARSDBDataSet.appliances);
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "Update";
            editButton.Text = "Update";
            editButton.UseColumnTextForButtonValue = true;
            editButton.Width = 80;
            gvApplianceList.Columns.Add(editButton);
            for (int i = 0; i < gvApplianceList.Rows.Count; i++)
            {
                gvApplianceList.Rows[i].Cells[0].ReadOnly = true;
            }
            
        }


        private void gvApplianceList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());
            int currentColumnIndex = int.Parse(e.ColumnIndex.ToString());
            if (currentColumnIndex == 9)
            {
                string id = gvApplianceList.Rows[currentRow].Cells[0].Value.ToString();
                string name = gvApplianceList.Rows[currentRow].Cells[1].Value.ToString();
                string brands = gvApplianceList.Rows[currentRow].Cells[2].Value.ToString();
                string price = gvApplianceList.Rows[currentRow].Cells[3].Value.ToString();
                string models = gvApplianceList.Rows[currentRow].Cells[4].Value.ToString();
                string dimensions = gvApplianceList.Rows[currentRow].Cells[5].Value.ToString();
                string colour = gvApplianceList.Rows[currentRow].Cells[6].Value.ToString();
                string energy_consumption = gvApplianceList.Rows[currentRow].Cells[7].Value.ToString();
                string month_duration = gvApplianceList.Rows[currentRow].Cells[8].Value.ToString();

                String sql = "Update appliances set name = @name, brands = @brands, price = @price, models = @models, dimensions = @dimensions, colour = @colour, energy_consumption = @energy_consumption, month_duration = @month_duration Where id = @id";
                SqlCommand cmd = this.da.QueryText(sql);
                
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@brands", brands);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@models", models);
                cmd.Parameters.AddWithValue("@dimensions", dimensions);
                cmd.Parameters.AddWithValue("@colour", colour);
                cmd.Parameters.AddWithValue("@energy_consumption", energy_consumption);
                cmd.Parameters.AddWithValue("@month_duration", month_duration);
                cmd.ExecuteNonQuery();
                this.da.Sqlcon.Close();
                MessageBox.Show("Appliance Successfully Updated. ");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in gvApplianceList.SelectedCells)
            {
                if (oneCell.Selected && gvApplianceList.Rows.Count > 1)
                {
                    String id = oneCell.FormattedValue.ToString();
                    gvApplianceList.Rows.RemoveAt(oneCell.RowIndex);
                    
                    String sql = "delete appliances where id = @id";
                    SqlCommand cmd = this.da.QueryText(sql);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    this.da.Sqlcon.Close();
                    MessageBox.Show("Appliance Successfully Deleted. ");
                }
                    
            }
        }

       
    }
}
