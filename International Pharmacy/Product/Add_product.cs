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
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.IO;
namespace International_Pharmacy
{
    public partial class Add_product : MetroFramework.Forms.MetroForm
    {
        string ordb = "Data source=Project; User id = scott; Password=tiger;";
        OracleConnection con;
        public Add_product()
        {
            InitializeComponent();
        }

        private void Add_product_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = opf.FileName;
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
          
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Product m = new Product();
            m.Show();
            this.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(textBox1.Text,FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            FileInfo fi = new FileInfo(textBox1.Text);
            byte[] imagedata = br.ReadBytes((int)fi.Length);
            br.Close();
            fs.Close();
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into product values (:id1,:name,:id,:cat,:img)";
            cmd.Parameters.Add("id1", radTextBox1.Text);
            cmd.Parameters.Add("name", radTextBox2.Text);
            cmd.Parameters.Add("id", radTextBox3.Text);
            cmd.Parameters.Add("cat", radTextBox4.Text);
            cmd.Parameters.Add("img", (object)imagedata);
            
           int r= cmd.ExecuteNonQuery();
            if(r!=-1)
            {
                MessageBox.Show("Inserted");
            }
           
        }
    }
}
