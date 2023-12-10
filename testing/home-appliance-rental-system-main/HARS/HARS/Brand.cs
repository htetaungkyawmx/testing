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
    public partial class Brand : Form
    {
        private DataAccess da { get; set; }
        public Brand()
        {
            InitializeComponent();
            this.da = new DataAccess();

        }

        private void Brand_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "insert into brand (name, owner) values('"+ this.txtBrandName.Text +"', '"+ this.txtOwner.Text +"') ";

            try
            {
                if(!string.IsNullOrEmpty(this.txtBrandName.Text) && !string.IsNullOrEmpty(this.txtOwner.Text))
                {
                    int count = this.da.ExecuteDML(sql);
                    if(count == 1)
                    {
                        MessageBox.Show("Registered successfully");
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Register Failed.");
                        this.txtBrandName.Text = "";
                        this.txtOwner.Text = "";
                    }
                    this.da.Sqlcon.Close();
                }
                else if(string.IsNullOrEmpty(this.txtBrandName.Text))
                {
                    MessageBox.Show("Owner Name must not be empty. ");
                }
                else if (string.IsNullOrEmpty(this.txtOwner.Text))
                {
                    MessageBox.Show("Brand Name must not be empty. ");
                }


            }
            catch(Exception exe)
            {
                MessageBox.Show("Error: " + exe.Message);
            
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
