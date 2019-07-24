using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data source=DESKTOP-8TO73FG\\SQLEXPRESS;Initial Catalog=emlakkayıt;Integrated security=true; ");
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="admin" && textBox2.Text=="siteadmin")

            {

                Form2 emlak = new Form2();
                emlak.Show();
                
            }
            else
            {
                MessageBox.Show("hatalı kullanıcı adı veya şifre girdiniz");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
