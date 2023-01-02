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
    public partial class Author : MetroFramework.Forms.MetroForm
    {
        public Author()
        {
            InitializeComponent();
        }

        private void Author_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            main m = new main();
            m.Show();
            this.Visible = false;
        }

        private void radButton3_Click(object sender, EventArgs e)
        {

           view_author a = new view_author();
            a.Show();
            this.Visible = false;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {

            Edit_Author a = new Edit_Author();
            a.Show();
            this.Visible = false;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Add_Author a = new Add_Author();
            a.Show();
            this.Visible = false;
        }

        private void radButton4_Click(object sender, EventArgs e)
        {

           delete_author a = new delete_author();
            a.Show();
            this.Visible = false;
        }
    }
}
