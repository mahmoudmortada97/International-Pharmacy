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
    public partial class Add_Branch : MetroFramework.Forms.MetroForm
    {
        string ordb = "Data source=Project; User id = scott; Password=tiger;";
        OracleConnection con;

        public Add_Branch()
        {
            InitializeComponent();
        }

        private void Add_Branch_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Branch m = new Branch();
            m.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into branch values (:BID,:ADSTREET,:ADCITY,:ADCOUNTRY)";
            cmd.Parameters.Add("BID", radTextBox1.Text);
            cmd.Parameters.Add("ADSTREET", radTextBox2.Text);
            cmd.Parameters.Add("ADCITY", radTextBox3.Text);
            cmd.Parameters.Add("ADCOUNTRY", radTextBox4.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("New Branch is added");
            }
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
