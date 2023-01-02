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
    public partial class Edit_research : MetroFramework.Forms.MetroForm
    {
        string ordb = "Data source=Project; User id = scott; Password=tiger;";
        OracleConnection con;
        public Edit_research()
        {
            InitializeComponent();
        }

        private void Edit_research_Load(object sender, EventArgs e)
        {

            con = new OracleConnection(ordb);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select RESEARCHE_ID from RESEARCHES";
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
            Research m = new Research();
            m.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "research_proc_update";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("branch_id", radTextBox2.Text);
            cmd.Parameters.Add("res_title", radTextBox3.Text);
            cmd.Parameters.Add("res_id", comboBox1.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Research updated succefully");
        }
    }
}
