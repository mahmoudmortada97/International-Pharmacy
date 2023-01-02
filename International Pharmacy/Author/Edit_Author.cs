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
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
namespace International_Pharmacy
{
    public partial class Edit_Author : MetroFramework.Forms.MetroForm
    {
        string ordb = "Data source=Project; User id = scott; Password=tiger;";
        OracleConnection con;
        public Edit_Author()
        {
            InitializeComponent();
        }

        private void Edit_Author_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select  AUTHOR_ID from AUTHOR";
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "update AUTHOR set AUTHOR_NAME=:name, AFFILIATION=:aff where AUTHOR_ID=:id";

            c.Parameters.Add("name", radTextBox2.Text);
            c.Parameters.Add("aff", radTextBox3.Text);
            c.Parameters.Add("id",comboBox1.SelectedItem.ToString());
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Author modified");
            }

        }

        private void radMultiColumnComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                   }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
