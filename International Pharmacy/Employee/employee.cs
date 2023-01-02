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
    public partial class employee : MetroFramework.Forms.MetroForm
    {
        public employee()
        {
            InitializeComponent();
        }

        private void employee_Load(object sender, EventArgs e)
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
            Add_employee a = new Add_employee();
            a.Show();
            this.Visible = false;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {

            Edit_employee a = new Edit_employee();
            a.Show();
            this.Visible = false;
        }

        private void radButton3_Click(object sender, EventArgs e)
        {

            view_employee a = new view_employee();
            a.Show();
            this.Visible = false;
        }

        private void radButton4_Click(object sender, EventArgs e)
        {

            Delete_employee a = new Delete_employee();
            a.Show();
            this.Visible = false;
        }
    }
}
