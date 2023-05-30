using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyonn
{
    class KullancıGirişi
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-P8MLHOA\SQLEXPRESS;Initial Catalog=DboTicariOtomasyon;Integrated Security=True");

        SqlCommand command;
        SqlDataReader read;

        public SqlDataReader user(TextBox kullanıcıadı, TextBox sifre)
        {
            baglanti.Open();
            command = new SqlCommand();
            command.Connection = baglanti;
            command.CommandText = "Select *from TBL_GIRIS where KULLANICIADI='" + kullanıcıadı.Text + "'";
            read = command.ExecuteReader();
            if (read.Read() == true)
            {
                if (sifre.Text == read["SIFRE"].ToString())
                {
                    Form1 fr = new Form1();
                    fr.Show();
                }
                else
                {
                    MessageBox.Show("Şifrenizi kontrol edinizi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol edinizi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            baglanti.Close();
            return read;

        }

    }
}
