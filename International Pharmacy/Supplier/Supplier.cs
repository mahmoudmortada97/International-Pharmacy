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
    public partial class Supplier : MetroFramework.Forms.MetroForm
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            main m = new main();
            m.Show();
            this.Visible = false;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Add_supplier a = new Add_supplier();
            a.Show();
            this.Visible = false;
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
           view_supplier a = new view_supplier();
            a.Show();
            this.Visible = false;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
           Edit_supplier a = new Edit_supplier();
            a.Show();
            this.Visible = false;
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            delete_supplier a = new delete_supplier();
            a.Show();
            this.Visible = false;
        }
    }
}
