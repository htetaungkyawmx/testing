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
    public partial class UserRentList : Form
    {
        String userName;
        String role;

        private DataAccess da { get; set; }

        public UserRentList(String userName, String role)
        {
            InitializeComponent();
            this.da = new DataAccess();
            this.userName = userName;
            this.role = role;
        }

        private void UserRentList_Load(object sender, EventArgs e)
        {
            loadUserRentlist(userName);
        }

        public void loadUserRentlist(String userName)
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

            this.dgvUserRentList.DataSource = dt;
        }
    }
}
