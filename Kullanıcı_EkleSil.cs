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
    public partial class Kullanıcı_EkleSil : Form
    {
        public Kullanıcı_EkleSil()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_GIRIS(KULLANICIADI,SIFRE) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kullanıcı sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        KullanıcıSil kullanıcısil=new KullanıcıSil();
        private void button2_Click(object sender, EventArgs e)
        {
            kullanıcısil.userdelete(textBox1,textBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
