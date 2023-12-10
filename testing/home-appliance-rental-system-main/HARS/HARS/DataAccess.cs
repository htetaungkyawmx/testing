using System.Data;
using System.Data.SqlClient;

namespace HARS
{
    public class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        private DataTable dt;
        public DataTable Dt
        {
            get { return this.dt; }
            set { this.dt = value; }
        }

        public DataAccess()
        {
            this.Sqlcon = new SqlConnection(@"Data Source=DESKTOP-S6HMOJ7;Initial Catalog=HARSDB;User ID=sa;Password=12345");
        }

        public SqlCommand QueryText(string query)
        {
            if(this.sqlcon.State.ToString() == "Closed")
            {
                this.Sqlcon.Open();
            }
                  
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
            return this.Sqlcom;
        }

        public DataSet ExecuteQuery(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds;
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Dt = new DataTable();
            this.Sda.Fill(this.Dt);
            return Dt;
        }

        public int ExecuteDML(string sql)
        {
            this.QueryText(sql);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }


    }
}
