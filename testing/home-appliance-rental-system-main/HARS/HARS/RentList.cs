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
    public partial class RentList : Form
    {
        String userName;
        String role;
        String active_rent_term;

        private DataAccess da { get; set; }
        public RentList()
        {
            InitializeComponent();
        }

        public RentList(String userName, String role, String active_rent_term)
        {
            InitializeComponent();
            this.da = new DataAccess();
            this.userName = userName;
            this.role = role;
            this.active_rent_term = active_rent_term;
        }

        public void loadRentlist(String userName)
        {
            String sql;
            if (role.Equals("admin"))
            {
                 sql = $@"select * from rent";
            }
            else
            {
                 sql = $@"select * from rent where rentee = '{@userName}' ";
            }
            
            DataTable dt = this.da.ExecuteQueryTable(sql);
            this.da.Sqlcon.Close();

            this.rentListView.DataSource = dt;
        }

        private void RentList_Load(object sender, EventArgs e)
        {
            loadRentlist(userName);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewCell idCell = rentListView.SelectedCells[0];
            DataGridViewCell renteeCell = rentListView.SelectedCells[9];

            String id = idCell.FormattedValue.ToString();
            String renteeName = renteeCell.FormattedValue.ToString();
            int art = Convert.ToInt32(active_rent_term);


            if (idCell.Selected && rentListView.Rows.Count > 1)
                {
                  
                    rentListView.Rows.RemoveAt(idCell.RowIndex);

                    String sql = "delete rent where id = @id";
                    SqlCommand cmd = this.da.QueryText(sql);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    this.da.Sqlcon.Close();

                   
                    String activeRentTermSql = "Update register set active_rent_term = @active_rent_term Where username = @username";
                    SqlCommand activeRentTermCmd = this.da.QueryText(activeRentTermSql);
                    activeRentTermCmd.Parameters.AddWithValue("@username", renteeName);
                    activeRentTermCmd.Parameters.AddWithValue("@active_rent_term", art - 1);
                    activeRentTermCmd.ExecuteNonQuery();
                    this.da.Sqlcon.Close();

                MessageBox.Show("Rent Successfully Deleted. ");
                }
            
            


        }
    }
    }

