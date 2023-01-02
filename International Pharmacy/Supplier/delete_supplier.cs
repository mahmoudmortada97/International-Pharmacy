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
    public partial class delete_supplier : MetroFramework.Forms.MetroForm
    {
        string ordb = "Data source=Project; User id = scott; Password=tiger;";
        OracleConnection con;
        public delete_supplier()
        {
            InitializeComponent();
        }

        private void delete_supplier_Load(object sender, EventArgs e)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "supplier_proc_delete";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("res_id", comboBox1.SelectedItem.ToString());

            cmd.ExecuteNonQuery();
            MessageBox.Show("Supplier deleted succefully");
        }
    }
}
