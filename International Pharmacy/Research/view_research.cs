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
    public partial class view_research : MetroFramework.Forms.MetroForm
    {
        public view_research()
        {
            InitializeComponent();
        }

        private void view_research_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Research m = new Research();
            m.Show();
            this.Visible = false;
        }

        private void radMultiColumnComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
