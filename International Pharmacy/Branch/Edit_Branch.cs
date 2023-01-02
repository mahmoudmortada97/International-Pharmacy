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
    public partial class Edit_Branch : MetroFramework.Forms.MetroForm
    {
        string ordb = "Data source=orcl1; User id = scott; Password=tiger;";
        OracleConnection con;
        public Edit_Branch()
        {
            InitializeComponent();
        }

        private void Edit_Branch_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
         
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select BRANCH_ID from Branch";
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
            Branch  m = new Branch();
            m.Show();
            this.Visible = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "select * from BRANCH where  BRANCH_ID=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", comboBox1.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                radTextBox2.Text = dr[1].ToString();
                radTextBox3.Text = dr[2].ToString();
                radTextBox4.Text = dr[3].ToString();

            }
            dr.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = @"update BRANCH set ADDRESS_STREET=:adstreet, 
                 ADDRESS_CITY=:adcity,ADDRESS_COUNTRY=:adcountry,
                   where BRANCH_ID =:id ";

            cmd.Parameters.Add("adstreet", radTextBox2.Text);
            cmd.Parameters.Add("adcity", radTextBox3.Text);
            cmd.Parameters.Add("adcountry", radTextBox4.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Branch modified");
            }


        }

      
    }
}
