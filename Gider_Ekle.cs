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
    public partial class Gider_Ekle : Form
    {
        public Gider_Ekle()
        {
            InitializeComponent();
        }

        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_GIDERLER(TARİH,GİDER,TUTAR,GİDERNOT) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mtb_tarıh.Text);
            komut.Parameters.AddWithValue("@p2", tb_gider.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(tb_tutar.Text.ToString()));
            komut.Parameters.AddWithValue("@p4", tb_not.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
