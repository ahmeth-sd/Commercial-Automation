using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ticari_Otomasyonn
{
    class KullanıcıSil
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-P8MLHOA\SQLEXPRESS;Initial Catalog=DboTicariOtomasyon;Integrated Security=True");
        SqlCommand command;
        SqlDataReader read;
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public void  userdelete(TextBox kullanıcıadı, TextBox sifre)
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
                    try
                    {
                        SqlCommand komutsil = new SqlCommand("Delete from TBL_GIRIS where KULLANICIADI=@p1",
                            bgl.baglanti());
                        komutsil.Parameters.AddWithValue("@p1", kullanıcıadı.Text);
                        komutsil.ExecuteNonQuery();
                        MessageBox.Show("Kullanıcı silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Kullanıcı silinemedi lütfen bilgileri kontrol ediniz!", "Hata",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı silinemedi lütfen bilgileri kontrol ediniz!", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                baglanti.Close();

            }
        }  
    }
}
