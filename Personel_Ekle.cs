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
    public partial class Personel_Ekle : Form
    {
        public Personel_Ekle()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void Personel_Ekle_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_PERSONEL(AD,SOYAD,TELEFON,GÖREV,MAAS,ADRES) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", mtxttelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtgorev.Text);
            komut.Parameters.AddWithValue("@p5", txtmaas.Text);
            komut.Parameters.AddWithValue("@p6", txtadres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
