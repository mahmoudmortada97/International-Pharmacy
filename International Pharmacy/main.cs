using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using MetroFramework;
namespace International_Pharmacy
{
    public partial class main : Telerik.WinControls.UI.RadForm
    {
        public main()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            RadForm1 r = new RadForm1();
            r.Show();
            this.Visible = false;
        }

        private void radButtonElement6_Click(object sender, EventArgs e)
        {
            employee em = new employee();
            em.Show();
            this.Visible = false;
        }

        private void radButtonElement7_Click(object sender, EventArgs e)
        {
            Partner p = new Partner();
            p.Show();
            this.Visible = false;
        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            s.Show();
            this.Visible = false;
        }

        private void radButtonElement2_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Show();
            this.Visible = false;
        }

        private void radButtonElement3_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.Show();
            this.Visible = false;
        }

        private void radButtonElement4_Click(object sender, EventArgs e)
        {
            Branch b = new Branch();
            b.Show();
            this.Visible = false;
        }

        private void radButtonElement5_Click(object sender, EventArgs e)
        {
            Research r = new Research();
            r.Show();
            this.Visible = false;
        }

        private void radButtonElement8_Click(object sender, EventArgs e)
        {
            Author a = new Author();
            a.Show();
            this.Visible = false;
        }

        private void radCarousel1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
