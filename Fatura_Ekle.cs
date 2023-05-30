using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyonn
{
    public partial class Fatura_Ekle : Form
    {
        public Fatura_Ekle()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nuduadet_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtusfiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuafiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void Fatura_Ekle_Load(object sender, EventArgs e)
        {
           
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_FATURA(SERINO,TARIH,SAAT,VERGIDAIRESI,ALICI,TESLIMEDEN,TESLIMALAN,TUTAR) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@P8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tb_sno.Text);
            komut.Parameters.AddWithValue("@p2", mtb_tarıh.Text);
            komut.Parameters.AddWithValue("@p3", mtb_saat.Text);
            komut.Parameters.AddWithValue("@p4", tb_vdaıresı.Text);
            komut.Parameters.AddWithValue("@p5", tb_alıcı.Text);
            komut.Parameters.AddWithValue("@p6", tb_teden.Text);
            komut.Parameters.AddWithValue("@p7", tb_talan.Text);
            komut.Parameters.AddWithValue("@p8", decimal.Parse(tb_tutar.Text.ToString()));
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
