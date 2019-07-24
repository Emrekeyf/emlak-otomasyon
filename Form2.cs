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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data source=DESKTOP-8TO73FG\\SQLEXPRESS;Initial Catalog=emlakkayıt;Integrated security=true;");
        private void verilerigöster() {
            listView1.Items.Clear();
            bag.Open();
            SqlCommand komut = new SqlCommand("Select * from sitebilgi",bag);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())

            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["site"].ToString());
                ekle.SubItems.Add(oku["odasayısı"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                ekle.SubItems.Add(oku["blok"].ToString());
                ekle.SubItems.Add(oku["no"].ToString());
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["notlar"].ToString());
                ekle.SubItems.Add(oku["satkıra"].ToString());
                ekle.SubItems.Add(oku["metrekare"].ToString());
                listView1.Items.Add(ekle);

            }
            bag.Close();
            
        
        
        
        
        
        
        
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="GÜL")

            {
                butongül.BackColor = Color.Yellow;
                butonberk.BackColor = Color.Gray;
                butonmenkse.BackColor= Color.Gray;
                butonkardeln.BackColor = Color.Gray;
                
                
                
                
            }
            if (comboBox1.Text == "MENEKŞE")
            {
                butonmenkse.BackColor = Color.Yellow;
                butonberk.BackColor = Color.Gray;
                butongül.BackColor = Color.Gray;
                butonkardeln.BackColor = Color.Gray;
                


            }
            if (comboBox1.Text == "KARDELEN")
            {
                butonkardeln.BackColor = Color.Yellow;
                butonberk.BackColor = Color.Gray;
                butonmenkse.BackColor = Color.Gray;
                butongül.BackColor = Color.Gray;
                


            }
            if (comboBox1.Text == "BERK")
            {
                butonberk.BackColor = Color.Yellow;
                butongül.BackColor= Color.Gray;
                butonmenkse.BackColor = Color.Gray;
                butonkardeln.BackColor = Color.Gray;
                


            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btngoruntule_Click(object sender, EventArgs e)
        {
            verilerigöster();
        }

        private void butonkaydet_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand komut = new SqlCommand("insert into sitebilgi(id,site,odasayısı,fiyat,blok,no,adsoyad,telefon,notlar,satkıra,metrekare) values('"+textBox6.Text.ToString()+"', '"+ comboBox1.Text.ToString()+"','"+comboBox3.Text.ToString()+"','"+textBox2.Text.ToString()+"','"+comboBox5.Text.ToString()+"','"+textBox3.Text.ToString()+"','"+textBox4.Text.ToString()+"','"+textBox5.Text.ToString()+"','"+richTextBox1.Text.ToString()+"','"+comboBox2.Text.ToString()+"','"+textBox1.Text.ToString()+"')",bag);


            komut.ExecuteNonQuery();
            bag.Close();
            verilerigöster();

        }
        int id=0;

        private void butonsil_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand komut = new SqlCommand(" Delete From sitebilgi where id=(" + id + ")", bag);
            komut.ExecuteNonQuery();
            bag.Close();
            verilerigöster();



        }


        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id=int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox6.Text=listView1.SelectedItems[0].SubItems[0].Text;

           

            comboBox1.Text= listView1.SelectedItems[0].SubItems[1].Text;

            comboBox2.Text = listView1.SelectedItems[0].SubItems[9].Text;

            comboBox3.Text= listView1.SelectedItems[0].SubItems[2].Text;

            textBox1.Text = listView1.SelectedItems[0].SubItems[10].Text;

            textBox2.Text = listView1.SelectedItems[0].SubItems[3].Text;
          comboBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;



          textBox3.Text = listView1.SelectedItems[0].SubItems[5].Text;

          textBox4.Text = listView1.SelectedItems[0].SubItems[6].Text;




          textBox5.Text = listView1.SelectedItems[0].SubItems[7].Text;
          richTextBox1.Text = listView1.SelectedItems[0].SubItems[8].Text;

           


        }

        private void butondüzelt_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand komut = new SqlCommand(" update sitebilgi set  id='" + textBox6.Text.ToString() + "',site='" + comboBox1.Text.ToString()
                + "',satkıra='" + comboBox2.Text.ToString() + "',odasayısı='" + comboBox3.Text.ToString() + "',metrekare='" + textBox1.Text.ToString() + "',fiyat='" + textBox2.Text.ToString() + "',blok='" + comboBox5.Text.ToString() + "',no='" + textBox3.Text.ToString() +    "',adsoyad='" + textBox4.Text.ToString()+ "',telefon='" + textBox5.Text.ToString()+ "',notlar='" + richTextBox1.Text.ToString()  + "' where id=" + id + "", bag);
            komut.ExecuteNonQuery();
            bag.Close();
            verilerigöster();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
