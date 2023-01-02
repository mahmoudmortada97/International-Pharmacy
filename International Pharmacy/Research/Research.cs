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
    public partial class Research : MetroFramework.Forms.MetroForm
    {
        public Research()
        {
            InitializeComponent();
        }

        private void Research_Load(object sender, EventArgs e)
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
            Add_research a = new Add_research();
            a.Show();
            this.Visible = false;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            Edit_research a = new Edit_research();
            a.Show();
            this.Visible = false;
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            view_research a = new view_research();
            a.Show();
            this.Visible = false;
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            delete_research a = new delete_research();
            a.Show();
            this.Visible = false;
        }
    }
}
