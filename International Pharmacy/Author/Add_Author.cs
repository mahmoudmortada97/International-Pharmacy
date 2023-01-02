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
    public partial class Add_Author :MetroFramework.Forms.MetroForm
    {
        string ordb = "Data source=Project; User id = scott; Password=tiger;";
        OracleConnection con;
        public Add_Author()
        {
            InitializeComponent();
        }

        private void Add_Author_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Author m = new Author();
            m.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into author values (:id,:name,:aff)";
            cmd.Parameters.Add("id", radTextBox1.Text);
            cmd.Parameters.Add("name", radTextBox2.Text);
            cmd.Parameters.Add("aff", radTextBox3.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("New Author is added");
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
