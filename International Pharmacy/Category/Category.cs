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
    public partial class Category : MetroFramework.Forms.MetroForm
    {
        public Category()
        {
            InitializeComponent();
        }

        private void Category_Load(object sender, EventArgs e)
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
            Add_category a = new Add_category();
            a.Show();
            this.Visible = false;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            Edit_Category a = new Edit_Category();
            a.Show();
            this.Visible = false;
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
           view_category a = new view_category();
            a.Show();
            this.Visible = false;
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            delete_category a = new delete_category();
            a.Show();
            this.Visible = false;
        }
    }
}
