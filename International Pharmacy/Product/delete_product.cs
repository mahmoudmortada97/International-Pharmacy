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
    public partial class delete_product : MetroFramework.Forms.MetroForm
    {
        string ordb = "Data source=Project; User id = scott; Password=tiger;";
        OracleConnection con;
        public delete_product()
        {
            InitializeComponent();
        }

        private void delete_product_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Product m = new Product();
            m.Show();
            this.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            }
        }
}
