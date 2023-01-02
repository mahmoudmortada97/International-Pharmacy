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
    public partial class Add_Partner : MetroFramework.Forms.MetroForm
    {
        public Add_Partner()
        {
            InitializeComponent();
        }

        private void Add_Partner_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Partner m = new Partner();
            m.Show();
            this.Visible = false;
        }
    }
}
