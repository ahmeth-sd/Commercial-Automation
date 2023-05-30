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
    public partial class Müşteriler : Form
    {
        public Müşteriler()
        {
            InitializeComponent();
        }
        

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        DataSet daset=new DataSet();
        public void Temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            maskedTextBox1.Text = "";
            txtmail.Text = "";
            txtadres.Text = "";
            txttur.Text = "";
            txtmarka.Text = "";
            txtmodel.Text = "";
            txtfiyat.Text = "";
        }
        private void Müşteriler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select *from TBL_MUSTERİ", bgl.baglanti());
            adtr.Fill(daset, "TBL_MUSTERİ");
            dataGridView1.DataSource = daset.Tables["TBL_MUSTERİ"];
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand komut = new SqlCommand("update TBL_MUSTERİ set AD=@p1,SOYAD=@p2,TELEFON=@p3,MAİL=@p4,ADRES=@p5,TUR=@p6,MARKA=@p7,MODEL=@p8,FİYAT=@p9 where ID=@p0 ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p0", txtid.Text);
                komut.Parameters.AddWithValue("@p1", txtad.Text);
                komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
                komut.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
                komut.Parameters.AddWithValue("@p4", txtmail.Text);
                komut.Parameters.AddWithValue("@p5", txtadres.Text);
                komut.Parameters.AddWithValue("@p6", txttur.Text);
                komut.Parameters.AddWithValue("@p7", txtmarka.Text);
                komut.Parameters.AddWithValue("@p8", txtmodel.Text);
                komut.Parameters.AddWithValue("@p9", decimal.Parse(txtfiyat.Text.ToString()));
                komut.ExecuteNonQuery();
                daset.Tables["TBL_MUSTERİ"].Clear();
                listele();
                MessageBox.Show("Güncelleme İşlemi Başarılı");
                Temizle();
            }
                

            catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("Delete from TBL_MUSTERİ where ID=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", txtid.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                daset.Tables["TBL_MUSTERİ"].Clear();
                listele();
                MessageBox.Show("Müşteri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Temizle();
            }

            catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void txttur_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtid_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells["AD"].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells["SOYAD"].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells["TELEFON"].Value.ToString();
            txtmail.Text = dataGridView1.CurrentRow.Cells["MAİL"].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells["ADRES"].Value.ToString();
            txttur.Text = dataGridView1.CurrentRow.Cells["TUR"].Value.ToString();
            txtmarka.Text = dataGridView1.CurrentRow.Cells["MARKA"].Value.ToString();
            txtmodel.Text = dataGridView1.CurrentRow.Cells["MODEL"].Value.ToString();
            txtfiyat.Text = dataGridView1.CurrentRow.Cells["FİYAT"].Value.ToString();
        }
    }
}
