using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyonn
{
    public partial class Hakkımızda : Form
    {
        public Hakkımızda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text="BM-102 Proje Ödevi";
            label2.Text="Büşra Arık - 181180006";
            label3.Text="Ahmet Salih Dağ - 181180019";
            label4.Text="Ahmet Kürşat İşken - 181180041";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
