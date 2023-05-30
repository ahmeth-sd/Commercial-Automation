using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ticari_Otomasyonn
{
    public partial class Musteri_Ekle : Form
    {
        public Musteri_Ekle()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                SqlCommand komut = new SqlCommand("insert into TBL_MUSTERİ(AD,SOYAD,TELEFON,MAİL,ADRES,TUR,MARKA,MODEL,FİYAT) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtad.Text);
                komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
                komut.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
                komut.Parameters.AddWithValue("@p4", txtmail.Text);
                komut.Parameters.AddWithValue("@p5", txtadres.Text);
                komut.Parameters.AddWithValue("@p6", textBox1.Text);
                komut.Parameters.AddWithValue("@p7", txtmarka.Text);
                komut.Parameters.AddWithValue("@p8", txtmodel.Text);
                komut.Parameters.AddWithValue("@p9", decimal.Parse(txtfiyat.Text.ToString()));
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            MessageBox.Show("Müşteri sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
            
          
        }

        private void Musteri_Ekle_Load(object sender, EventArgs e)
        {

        }

        private void txtmarka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
