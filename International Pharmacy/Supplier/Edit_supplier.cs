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
    public partial class Edit_supplier : MetroFramework.Forms.MetroForm
    {
        string ordb = "Data source=Project; User id = scott; Password=tiger;";
        OracleConnection con;
        public Edit_supplier()
        {
            InitializeComponent();
        }

        private void Edit_supplier_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select SUPPLIER_ID from SUPPLIER";
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
            Supplier m = new Supplier();
            m.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "supplier_proc_update";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("f_name", radTextBox2.Text);
            cmd.Parameters.Add("l_name", radTextBox3.Text);
            cmd.Parameters.Add("addr", radTextBox4.Text);
            cmd.Parameters.Add("supp_no", radTextBox9.Text);
            cmd.Parameters.Add("supp_id", comboBox1.SelectedItem.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Supplier updated succefully");
        }
    }
}
