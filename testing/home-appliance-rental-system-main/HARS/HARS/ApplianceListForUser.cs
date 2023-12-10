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
    public partial class ApplianceListForUser : Form
    {
        public ApplianceListForUser()
        {
            InitializeComponent();
        }

        private void ApplianceListForUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hARSDBDataSet.appliances' table. You can move, or remove it, as needed.
            this.appliancesTableAdapter.Fill(this.hARSDBDataSet.appliances);

        }
    }
}
