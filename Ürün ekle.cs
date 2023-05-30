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
    public partial class Ürün_ekle : Form
    {
        public Ürün_ekle()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Ürün_ekle_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER(URUNAD,MARKA,MODEL,ALISFİYAT,SATISFİYAT,STOK) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtuad.Text);
            komut.Parameters.AddWithValue("@p2", txtmarka.Text);
            komut.Parameters.AddWithValue("@p3", txtmodel.Text);
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtuafiyat.Text.ToString()));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(txtusfiyat.Text.ToString()));
            komut.Parameters.AddWithValue("@p6", int.Parse(numericUpDown1.Text.ToString()));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
