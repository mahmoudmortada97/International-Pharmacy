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
    public partial class Add_research : MetroFramework.Forms.MetroForm
    {

        string ordb = "Data source=Project; User id = scott; Password=tiger;";
        OracleConnection con;
        public Add_research()
        {
            InitializeComponent();
        }

        private void Add_research_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();

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
            cmd.CommandText = "RESEARCH_PROC_INSERT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("res_id", radTextBox1.Text);
            cmd.Parameters.Add("res_title", radTextBox2.Text);
            cmd.Parameters.Add("bran_id", radTextBox3.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Research added succefully");

        }

    }
}

