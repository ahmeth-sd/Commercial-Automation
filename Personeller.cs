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
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        DataSet daset=new DataSet();

        public void listele()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select *from TBL_PERSONEL", bgl.baglanti());
            adtr.Fill(daset, "TBL_PERSONEL");
            dataGridView1.DataSource = daset.Tables["TBL_PERSONEL"];
        }
        public void Temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            txtgorev.Text = "";
            txtadres.Text = "";
            txtmaas.Text = "";
            mtxttelefon.Text = "";
        }
        private void Personeller_Load(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                SqlCommand komut = new SqlCommand("update TBL_PERSONEL set AD=@p1,SOYAD=@p2,TELEFON=@p3,GÖREV=@p4,MAAS=@p5,ADRES=@p6 where ID=@p0 ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p0", txtid.Text);
                komut.Parameters.AddWithValue("@p1", txtad.Text);
                komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
                komut.Parameters.AddWithValue("@p3", mtxttelefon.Text);
                komut.Parameters.AddWithValue("@p4", txtgorev.Text);
                komut.Parameters.AddWithValue("@p5", txtmaas.Text);
                komut.Parameters.AddWithValue("@p6", txtadres.Text);
                komut.ExecuteNonQuery();
                daset.Tables["TBL_PERSONEL"].Clear();
                listele();
                MessageBox.Show("Güncelleme İşlemi Başarılı");
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("Delete from TBL_PERSONEL where ID=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", txtid.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                daset.Tables["TBL_PERSONEL"].Clear();
                listele();
                MessageBox.Show("Personel silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Temizle();
            }

            catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells["AD"].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells["SOYAD"].Value.ToString();
            mtxttelefon.Text = dataGridView1.CurrentRow.Cells["TELEFON"].Value.ToString();
            txtgorev.Text = dataGridView1.CurrentRow.Cells["GÖREV"].Value.ToString();
            txtmaas.Text = dataGridView1.CurrentRow.Cells["MAAS"].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells["ADRES"].Value.ToString();
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
