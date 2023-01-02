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
    public partial class Delete_employee : MetroFramework.Forms.MetroForm
    {


        string ordb = "Data source=Project; User id = scott; Password=tiger;";
        OracleConnection con;
        public Delete_employee()
        {
            InitializeComponent();
        }

        private void Delete_employee_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select BRANCH_ID from BRANCH";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "Delete from EMPLOYEE where EMP_ID=:id";
            c.Parameters.Add("id", comboBox1.Text);
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Empolyee deleted");
                comboBox1.Items.Remove(comboBox1.Text);

            }
        }
    }
}