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
namespace International_Pharmacy
{
    public partial class view_product : MetroFramework.Forms.MetroForm
    {
        public view_product()
        {
            InitializeComponent();
        }

        private void view_product_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Product m = new Product();
            m.Show();
            this.Visible = false;
        }
    }
}
