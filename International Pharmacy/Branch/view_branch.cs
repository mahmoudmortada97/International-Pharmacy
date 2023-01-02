using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace International_Pharmacy
{
    public partial class view_branch : MetroFramework.Forms.MetroForm
    {
        string ordb = "Data source=Project; User id = scott; Password=tiger;";
        OracleConnection con;
        OracleDataAdapter ad;
        DataSet ds;
        public view_branch()
        {
            InitializeComponent();
        }

        private void view_branch_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select emp_id from employee";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);

            }
            dr.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Branch m = new Branch();
            m.Show();
            this.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            con = new OracleConnection(ordb);
            con.Open();
            string str = "select * from BRANCH where BRANCH_ID='" + comboBox1.SelectedItem + "'";
           
            ad = new OracleDataAdapter(str, ordb);
            ds = new DataSet();
            ad.Fill(ds);
            radGridView1.DataSource = ds.Tables[0];
            radGridView1.Columns[0].Width = 140;
            radGridView1.Columns[1].Width = 140;  // or whatever width works well for abbrev
            radGridView1.Columns[2].Width = 140;
            radGridView1.Columns[3].Width = 140;

        }
    }
}
