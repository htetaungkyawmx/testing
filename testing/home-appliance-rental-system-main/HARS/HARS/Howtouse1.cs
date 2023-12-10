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
    public partial class frmHowtouse : Form
    {
        public frmHowtouse()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Visible = true;
            this.Visible = false;
        }

        private void frmHowtouse_Load(object sender, EventArgs e)
        {

        }
    }
}
