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
    public partial class Faturalar : Form
    {
        public Faturalar()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        DataSet daset=new DataSet();

        public void listele()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select *from TBL_FATURA", bgl.baglanti());
            adtr.Fill(daset, "TBL_FATURA");
            dataGridView1.DataSource = daset.Tables["TBL_FATURA"];
        }
        public void Temizle()
        {
            txtid.Text = "";
            txtserıno.Text = "";
            mtxttarıh.Text = "";
            mtxtsaat.Text = "";
            txtvdaıresı.Text = "";
            txtalıcı.Text = "";
            txtteden.Text = "";
            txttalan.Text = "";
            txttutar.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Faturalar_Load(object sender, EventArgs e)
        {
            listele();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            txtserıno.Text = dataGridView1.CurrentRow.Cells["SERINO"].Value.ToString();
            mtxttarıh.Text = dataGridView1.CurrentRow.Cells["TARIH"].Value.ToString();
            mtxtsaat.Text = dataGridView1.CurrentRow.Cells["SAAT"].Value.ToString();
            txtvdaıresı.Text = dataGridView1.CurrentRow.Cells["VERGIDAIRESI"].Value.ToString();
            txtalıcı.Text = dataGridView1.CurrentRow.Cells["ALICI"].Value.ToString();
            txtteden.Text = dataGridView1.CurrentRow.Cells["TESLIMEDEN"].Value.ToString();
            txttalan.Text = dataGridView1.CurrentRow.Cells["TESLIMALAN"].Value.ToString();
            txttutar.Text = dataGridView1.CurrentRow.Cells["TUTAR"].Value.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update TBL_FATURA set SERINO=@p1,TARIH=@p2,SAAT=@p3,VERGIDAIRESI=@p4,ALICI=@p5,TESLIMEDEN=@p6,TESLIMALAN=@p7,TUTAR=@P8 where ID=@p0 ", bgl.baglanti());
                komut.Parameters.AddWithValue("@p0", txtid.Text);
                komut.Parameters.AddWithValue("@p1", txtserıno.Text);
                komut.Parameters.AddWithValue("@p2", mtxttarıh.Text);
                komut.Parameters.AddWithValue("@p3", mtxtsaat.Text);
                komut.Parameters.AddWithValue("@p4", txtvdaıresı.Text);
                komut.Parameters.AddWithValue("@p5", txtalıcı.Text);
                komut.Parameters.AddWithValue("@p6", txtteden.Text);
                komut.Parameters.AddWithValue("@p7", txttalan.Text);
                komut.Parameters.AddWithValue("@p8", decimal.Parse(txttutar.Text));
                komut.ExecuteNonQuery();
                daset.Tables["TBL_FATURA"].Clear();
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
                SqlCommand komutsil = new SqlCommand("Delete from TBL_FATURA where ID=@p1", bgl.baglanti());
                komutsil.Parameters.AddWithValue("@p1", txtid.Text);
                komutsil.ExecuteNonQuery();
                bgl.baglanti().Close();
                daset.Tables["TBL_FATURA"].Clear();
                listele();
                MessageBox.Show("Fatura silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Temizle();
            }

            catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
    }
}
