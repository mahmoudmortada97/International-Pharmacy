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
    public partial class Branch : MetroFramework.Forms.MetroForm
    {
        public Branch()
        {
            InitializeComponent();
        }

        private void Branch_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
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
            Add_Branch a = new Add_Branch();
            a.Show();
            this.Visible = false;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {

            Edit_Branch a = new Edit_Branch();
            a.Show();
            this.Visible = false;
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            view_branch a = new view_branch();
            a.Show();
            this.Visible = false;
        }

        private void radButton4_Click(object sender, EventArgs e)
        {

            delete_branch a = new delete_branch();
            a.Show();
            this.Visible = false;
        }
    }
}
