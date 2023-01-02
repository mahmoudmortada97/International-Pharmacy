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
    public partial class Add_employee : MetroFramework.Forms.MetroForm
    {
        string ordb = "Data source=Project; User id = scott; Password=tiger;";
        OracleConnection con;
        public Add_employee()
        {
            InitializeComponent();
        }

        private void Add_employee_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
        }

        private void radTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            employee m = new employee();
            m.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into employee values (:id1,:fname,:lname,:sal,:addd,:pos,:phon,:sup,:bran)";
            cmd.Parameters.Add("id", radTextBox1.Text);
            cmd.Parameters.Add("fname", radTextBox2.Text);
            cmd.Parameters.Add("lname", radTextBox3.Text);
            cmd.Parameters.Add("sal", radTextBox5.Text);
            cmd.Parameters.Add("addd", radTextBox4.Text);
            cmd.Parameters.Add("pos", radTextBox9.Text);
            cmd.Parameters.Add("phon", radTextBox6.Text);
            cmd.Parameters.Add("sup", radTextBox7.Text);
            cmd.Parameters.Add("bran", radTextBox8.Text);
         
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
               
                MessageBox.Show("New Empolyee is added");
            }
            //textBox1.Text = "";
            //textBox2.Text = "";
            //textBox4.Text = "";
            //textBox3.Text = "";
            //textBox8.Text = "";
            //textBox5.Text = "";
            //textBox6.Text = "";
            //textBox7.Text = "";
            //textBox9.Text = "";

        }
    }
}
