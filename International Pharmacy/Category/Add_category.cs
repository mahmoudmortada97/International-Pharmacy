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
    public partial class Add_category : MetroFramework.Forms.MetroForm
    {
        string ordb = "Data source=Project; User id = scott; Password=tiger;";
        OracleConnection con;
        public Add_category()
        {
            InitializeComponent();
        }

        private void Add_category_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Category m = new Category();
            m.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into CATEGORY values (:catid,:catname)";
            cmd.Parameters.Add("catid", radTextBox1.Text);
            cmd.Parameters.Add("catname", radTextBox2.Text);

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {

                MessageBox.Show("New Category is added");
            }
        }
    }
}
