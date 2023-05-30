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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();

        private void Giriş_Load(object sender, EventArgs e)
        {

        }
        KullancıGirişi kullanıcıgirişi =new KullancıGirişi();
        private void button1_Click(object sender, EventArgs e)
        {
            kullanıcıgirişi.user(textBox1,textBox2);
            

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aquamarine;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Lavender;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.OrangeRed;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Lavender;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
