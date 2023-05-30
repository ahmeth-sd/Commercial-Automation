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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        DataSet daset=new DataSet();
        public void listele()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select *from TBL_URUNLER", bgl.baglanti());
            adtr.Fill(daset, "TBL_URUNLER");
            dataGridView1.DataSource = daset.Tables["TBL_URUNLER"];
        }
        public void Temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtmarka.Text = "";
            txtafiyat.Text = "";
            txtsfiyat.Text = "";
            nudstok.Text = "";
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtusfiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuafiyat_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update TBL_URUNLER set URUNAD=@p1,MARKA=@p2,MODEL=@p3,ALISFİYAT=@p4,SATISFİYAT=@p5,STOK=@p6 where ID=@p0 ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p0", txtid.Text);
                komut.Parameters.AddWithValue("@p1", txtad.Text);
                komut.Parameters.AddWithValue("@p2", txtmarka.Text);
                komut.Parameters.AddWithValue("@p3", txtmodel.Text);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtafiyat.Text));
                komut.Parameters.AddWithValue("@p5", decimal.Parse(txtsfiyat.Text));
                komut.Parameters.AddWithValue("@p6", nudstok.Text);
                komut.ExecuteNonQuery();
                daset.Tables["TBL_URUNLER"].Clear();
                listele();
                MessageBox.Show("Güncelleme İşlemi Başarılı");
                Temizle();

            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("Delete from TBL_URUNLER where ID=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", txtid.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                daset.Tables["TBL_URUNLER"].Clear();
                listele();
                MessageBox.Show("Ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Temizle();
            }

            catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells["URUNAD"].Value.ToString();
            txtmarka.Text = dataGridView1.CurrentRow.Cells["MARKA"].Value.ToString();
            txtmodel.Text = dataGridView1.CurrentRow.Cells["MODEL"].Value.ToString();
            txtafiyat.Text = dataGridView1.CurrentRow.Cells["ALISFİYAT"].Value.ToString();
            txtsfiyat.Text = dataGridView1.CurrentRow.Cells["SATISFİYAT"].Value.ToString();
            nudstok.Text = dataGridView1.CurrentRow.Cells["STOK"].Value.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
