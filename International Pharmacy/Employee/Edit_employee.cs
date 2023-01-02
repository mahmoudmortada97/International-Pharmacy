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
    public partial class Edit_employee : MetroFramework.Forms.MetroForm
    {
        string ordb = "Data source=Project; User id = scott; Password=tiger;";
        OracleConnection con;
        public Edit_employee()
        {
            InitializeComponent();
        }

        private void Edit_employee_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select emp_id from employee";
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
            employee m = new employee();
            m.Show();
            this.Visible = false;
        }

        private void radTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "select * from employee where  emp_id=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", comboBox1.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                radTextBox2.Text = dr[1].ToString();
                radTextBox3.Text = dr[2].ToString();
                radTextBox5.Text = dr[3].ToString();
                radTextBox4.Text = dr[4].ToString();
                radTextBox9.Text = dr[5].ToString();
                radTextBox6.Text = dr[6].ToString();
                radTextBox1.Text = dr[7].ToString();
                radTextBox8.Text = dr[8].ToString();
            }
            dr.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = @"update EMPLOYEE set F_NAME=:fname, 
                  L_NAME=:lname ,SALARY=:sal, ADDRESS=:addd, 
                  PHONE_NUMBER =:phon, POSITION =:pos,SUPER_ID =:sup, 
                  BRANCH_EMP_ID =:bran where EMP_ID =:id ";

            cmd.Parameters.Add("fname", radTextBox2.Text);
            cmd.Parameters.Add("lname", radTextBox3.Text);
            cmd.Parameters.Add("sal", radTextBox5.Text);
            cmd.Parameters.Add("addd", radTextBox4.Text);
            cmd.Parameters.Add("phon", radTextBox9.Text);
            cmd.Parameters.Add("pos", radTextBox6.Text);
            cmd.Parameters.Add("sup", radTextBox1.Text);
            cmd.Parameters.Add("bran", radTextBox8.Text);
            cmd.Parameters.Add("id", comboBox1.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Empolyee modified");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
