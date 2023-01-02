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
    public partial class Add_supplier : MetroFramework.Forms.MetroForm
    {
        string ordb = "Data source=Project; User id = scott; Password=tiger;";
        OracleConnection con;
        public Add_supplier()
        {
            InitializeComponent();
        }

        private void Add_supplier_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
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
            cmd.CommandText = "supplier_proc_insert";
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("supp_id", radTextBox1.Text);
            cmd.Parameters.Add("f_name", radTextBox2.Text);
            cmd.Parameters.Add("l_name", radTextBox3.Text);
            cmd.Parameters.Add("addr", radTextBox4.Text);
            cmd.Parameters.Add("supp_no", radTextBox9.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Supplier added succefully");
        }
    }
}
