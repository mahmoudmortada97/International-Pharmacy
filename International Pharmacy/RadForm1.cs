using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace International_Pharmacy
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            radGroupBox1.Visible=true;
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
       
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
            
           

        }

        private void radLabel2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Password is FCIS");
        }
    }
}
