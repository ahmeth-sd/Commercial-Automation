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
    public partial class İletişim : Form
    {
        public İletişim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text="0 312 582 30 00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text="Eti, Yükseliş Sk. No. 5, 06570 Çankaya/Ankara";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text="http://mf.gazi.edu.tr/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
