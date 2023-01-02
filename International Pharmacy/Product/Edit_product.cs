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
using System.IO;
namespace International_Pharmacy
{
    public partial class Edit_product : MetroFramework.Forms.MetroForm
    {
        string ordb = "Data source=Project; User id = scott; Password=tiger;";
        OracleConnection con;
        public Edit_product()
        {
            InitializeComponent();
        }

        private void Edit_product_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select product_id from product";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0]);

            }
            dr.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Product m = new Product();
            m.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            FileInfo fi = new FileInfo(textBox1.Text);
            byte[] imagedata = br.ReadBytes((int)fi.Length);
            br.Close();
            fs.Close();
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "update product set PRODUCT_NAME=:gender ,CAT_ID=:name3,SUP_PROD_ID=:gender3, IMAGE=:name2 where PRODUCT_ID =:id ";

          
            cmd.Parameters.Add("gender", radTextBox2.Text);
            cmd.Parameters.Add("name3", radTextBox3.Text);
            cmd.Parameters.Add("gender3", radTextBox4.Text);
            cmd.Parameters.Add("name2", (object)imagedata);
            cmd.Parameters.Add("name", radMultiColumnComboBox1.SelectedItem.ToString());
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("modified");
            }
        }

        private void radMultiColumnComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

         
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "select * from product where  product_id=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", comboBox2.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                radTextBox2.Text = dr[1].ToString();
                radTextBox4.Text = dr[2].ToString();
                radTextBox3.Text = dr[3].ToString();
                textBox1.Text = dr[4].ToString();

            }
            dr.Close();
        }
    }
}
