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
    public partial class view_author : MetroFramework.Forms.MetroForm
    {
        string ordb = "Data source=Project; User id = scott; Password=tiger;";
        OracleConnection con;
        OracleDataAdapter ad;   
        public view_author()
        {
            InitializeComponent();
        }

        private void view_author_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select author_id from author";
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
            Author m = new Author();
            m.Show();
            this.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
          /*  string str = "";
            DataSet ds = new DataSet();
           str = @"select * from  AUTHOR where AUTHOR_ID='" + comboBox1.SelectedItem + "'";
          
            ad = new OracleDataAdapter(str, ordb);
            ds = new DataSet();
            ad.Fill(ds);
            radGridView1.DataSource = ds.Tables[0];
            radGridView1.Columns[0].Width = 140;
            radGridView1.Columns[1].Width = 140;  // or whatever width works well for abbrev
            radGridView1.Columns[2].Width = 140;
            */
        }

        private void label2_Click(object sender, EventArgs e)
        {
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "";
            DataSet ds = new DataSet();
            str = @"select * from  AUTHOR where AUTHOR_ID='" + comboBox1.SelectedItem + "'";

            ad = new OracleDataAdapter(str, ordb);
            ds = new DataSet();
            ad.Fill(ds);
            radGridView1.DataSource = ds.Tables[0];
            radGridView1.Columns[0].Width = 140;
            radGridView1.Columns[1].Width = 140;  // or whatever width works well for abbrev
            radGridView1.Columns[2].Width = 140;
          
          //  DataSet ds = new DataSet();
            str = @"select r.researche_title 
from author a , researches r , author_research ar
where ar.res_id= r.researche_id and ar.author_id =  a.author_id
 and a.author_id='" + comboBox1.SelectedItem + "'";

            ad = new OracleDataAdapter(str, ordb);
            ds = new DataSet();
            ad.Fill(ds);
            radGridView2.DataSource = ds.Tables[0];
            radGridView2.Columns[0].Width = 140;

        }
    }
}
