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
    public partial class view_employee : MetroFramework.Forms.MetroForm
    {
        string ordb = "Data source=Project; User id = scott; Password=tiger;";
        OracleConnection con;
        OracleDataAdapter ad;
      
        DataSet ds;
            public view_employee()
        {
            InitializeComponent();
        }

        private void view_employee_Load(object sender, EventArgs e)
        {
            
        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

         



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            con = new OracleConnection(ordb);
            con.Open();
            string str = "";
            if (comboBox1.Text == "Employee ID")
            {
                str = @"select * from employee where emp_id='" + comboBox2.SelectedItem + "'";
            }
            if (comboBox1.Text == "Super ID")
            {
                 str = @"select * from employee where super_id='" + comboBox2.SelectedItem + "'";
            }
            if (comboBox1.Text == "Name")
            {
                 str = @"select * from employee where  f_name|| ' ' ||' '|| l_name='" + comboBox2.SelectedItem + "'";
            }
            ad = new OracleDataAdapter(str, ordb);
                ds = new DataSet();
                ad.Fill(ds);
                radGridView1.DataSource = ds.Tables[0];
                radGridView1.Columns[0].Width = 140;
                radGridView1.Columns[1].Width = 140;  // or whatever width works well for abbrev
                radGridView1.Columns[2].Width = 140;
                radGridView1.Columns[3].Width = 140;
                radGridView1.Columns[4].Width = 140;  // or whatever width works well for abbrev
                radGridView1.Columns[5].Width = 140;
                radGridView1.Columns[6].Width = 140;
                radGridView1.Columns[7].Width = 140;  // or whatever width works well for abbrev
                radGridView1.Columns[8].Width = 140;
                
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            if (comboBox1.SelectedItem.ToString() == "Employee ID")
                cmd.CommandText = "select  emp_id from employee";
            else if (comboBox1.SelectedItem.ToString() == "Name")
                cmd.CommandText = "select f_name|| ' ' ||' '|| l_name from employee ";
            else if (comboBox1.SelectedItem.ToString()=="Super ID")
                cmd.CommandText = "select DISTINCT super_id from employee";
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
            employee m = new employee();
            m.Show();
            this.Visible = false;
        }
    }
}
