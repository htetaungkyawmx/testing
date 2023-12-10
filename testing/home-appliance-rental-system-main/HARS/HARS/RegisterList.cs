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
    public partial class RegisterList : Form
    {
        private DataAccess da { get; set; }

        public RegisterList()
        {
            InitializeComponent();
            this.da = new DataAccess();
        }

        private void RegisterList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hARSDBDataSet.register' table. You can move, or remove it, as needed.
            loadUserList();

        }

        public void loadUserList()
        {
            this.registerTableAdapter.Fill(this.hARSDBDataSet.register);
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "Update";
            editButton.Text = "Update";
            editButton.UseColumnTextForButtonValue = true;
            editButton.Width = 80;
            dgvUserList.Columns.Add(editButton);
            for (int i = 0; i < dgvUserList.Rows.Count; i++)
            {
                dgvUserList.Rows[i].Cells[0].ReadOnly = true;
            }
        }

        private void dgvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());
            int currentColumnIndex = int.Parse(e.ColumnIndex.ToString());
            if (currentColumnIndex == 9)
            {
                string id = dgvUserList.Rows[currentRow].Cells[0].Value.ToString();
                string username = dgvUserList.Rows[currentRow].Cells[1].Value.ToString();
                string password = dgvUserList.Rows[currentRow].Cells[2].Value.ToString();
                string nrcno = dgvUserList.Rows[currentRow].Cells[3].Value.ToString();
                string phone_no = dgvUserList.Rows[currentRow].Cells[4].Value.ToString();
                string address = dgvUserList.Rows[currentRow].Cells[5].Value.ToString();
                string role = dgvUserList.Rows[currentRow].Cells[6].Value.ToString();
                string active_rent_term = dgvUserList.Rows[currentRow].Cells[7].Value.ToString();
                string max_rent_term = dgvUserList.Rows[currentRow].Cells[8].Value.ToString();
                
                String sql = "Update register set username = @username, password = @password, nrcno = @nrcno, phone = @phone, address = @address, role = @role, active_rent_term = @active_rent_term, max_rent_term = @max_rent_term Where id = @id";
                SqlCommand cmd = this.da.QueryText(sql);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@nrcno", nrcno);
                cmd.Parameters.AddWithValue("@phone", phone_no);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@active_rent_term", active_rent_term);
                cmd.Parameters.AddWithValue("@max_rent_term", max_rent_term);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                this.da.Sqlcon.Close();
                MessageBox.Show("User Successfully Updated. ");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgvUserList.SelectedCells)
            {
                if (oneCell.Selected && dgvUserList.Rows.Count > 1)
                {
                    String id = oneCell.FormattedValue.ToString();
                    dgvUserList.Rows.RemoveAt(oneCell.RowIndex);

                    String sql = "delete register where id = @id";
                    SqlCommand cmd = this.da.QueryText(sql);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    this.da.Sqlcon.Close();
                    MessageBox.Show("User Successfully Deleted. ");
                }

            }
        }
    }
}
