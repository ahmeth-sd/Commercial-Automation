using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Ticari_Otomasyonn
{
    class Sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-P8MLHOA\SQLEXPRESS;Initial Catalog=DboTicariOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
