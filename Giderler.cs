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
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        DataSet daset=new DataSet();
        public void listele()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select *from TBL_GIDERLER", bgl.baglanti());
            adtr.Fill(daset, "TBL_GIDERLER");
            dataGridView1.DataSource = daset.Tables["TBL_GIDERLER"];
        }
        public void Temizle()
        {
            txtid.Text = "";
            txttarıh.Text = "";
            txtgıder.Text = "";
            txttutar.Text = "";
            txtnot.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update TBL_GIDERLER set TARİH=@p1,GİDER=@p2,TUTAR=@p3,GİDERNOT=@p4 where ID=@p0 ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p0", txtid.Text);
                komut.Parameters.AddWithValue("@p1", txttarıh.Text);
                komut.Parameters.AddWithValue("@p2", txtgıder.Text);
                komut.Parameters.AddWithValue("@p3", decimal.Parse(txttutar.Text));
                komut.Parameters.AddWithValue("@p4", txtnot.Text);
                komut.ExecuteNonQuery();
                daset.Tables["TBL_GIDERLER"].Clear();
                listele();
                MessageBox.Show("Güncelleme İşlemi Başarılı");
                Temizle();
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutsil = new SqlCommand("Delete from TBL_GIDERLER where ID=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", txtid.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                daset.Tables["TBL_GIDERLER"].Clear();
                listele();
                MessageBox.Show("Gider silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            txttarıh.Text = dataGridView1.CurrentRow.Cells["TARİH"].Value.ToString();
            txtgıder.Text = dataGridView1.CurrentRow.Cells["GİDER"].Value.ToString();
            txttutar.Text = dataGridView1.CurrentRow.Cells["TUTAR"].Value.ToString();
            txtnot.Text = dataGridView1.CurrentRow.Cells["GİDERNOT"].Value.ToString();
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Giderler_Load_1(object sender, EventArgs e)
        {
            listele();
        }
    }
}
