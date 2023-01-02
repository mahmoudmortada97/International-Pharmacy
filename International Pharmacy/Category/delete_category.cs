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
    public partial class delete_category : MetroFramework.Forms.MetroForm
    {
        string ordb = "Data source=Project; User id = scott; Password=tiger;";
        OracleConnection con;
        public delete_category()
        {
            InitializeComponent();
        }

        private void delete_category_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select CATEGORYID from CATEGORY";
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
            Category m = new Category();
            m.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "Delete from CATEGORY where CATEGORYID=:id";
            c.Parameters.Add("id", comboBox1.Text);
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Category deleted");
                comboBox1.Items.Remove(comboBox1.Text);

            }
        }
    }
}
