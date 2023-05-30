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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

                Urunler urun = new Urunler();
                urun.MdiParent = this;
                urun.Show();   
            
                              
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mÜŞTERİToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void üRÜNSİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
               
            
        }

        private void mÜŞTERİLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Müşteriler musteriler = new Müşteriler();
                musteriler.MdiParent = this;
                musteriler.Show();
            
        }

        private void pERSONELToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Personeller personeller = new Personeller();
                personeller.MdiParent = this;
                personeller.Show();
            
           
        }

        private void mÜŞTERİEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Musteri_Ekle mekle = new Musteri_Ekle();
                mekle.MdiParent = this;
                mekle.Show();
            
           

        }

         
        private void mÜŞTERİSİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
              
          
        }

         
        private void pERSONELEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {

                Personel_Ekle perekle = new Personel_Ekle();
                perekle.MdiParent = this;
                perekle.Show(); 
            
            
        }

         
        private void pERSONELSİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
              
        }

        private void üRÜNEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
                Ürün_ekle uekle = new Ürün_ekle();
                uekle.MdiParent = this;
                uekle.Show();
            
          
        }

         
        private void mÜŞTERİDÜZENLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fATURAEKLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fatura_Ekle fekle= new Fatura_Ekle();
            fekle.MdiParent = this;
            fekle.Show();
        }

        private void fATURASİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void fATURALARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Faturalar faturalar= new Faturalar();
            faturalar.MdiParent = this;
            faturalar.Show();
        }

        private void aYLIKKAZANÇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gider_Ekle gekle= new Gider_Ekle();
            gekle.MdiParent = this;
            gekle.Show();
        }

        private void gELİRGİDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giderler gider=new Giderler();
            gider.MdiParent = this;
            gider.Show();
        }

        private void gİDERSİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void gİRİŞBİLGİLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kullanıcı_EkleSil kullanıcıeklesil=new Kullanıcı_EkleSil();
            kullanıcıeklesil.MdiParent = this;
            kullanıcıeklesil.Show();
        }

        private void hAKKIMIZDAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hakkımızda hakkımızda=new Hakkımızda();
            hakkımızda.MdiParent=this;
            hakkımızda.Show();
        }

        private void iLETİŞİMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            İletişim iletişim=new İletişim();
            iletişim.MdiParent=this;
            iletişim.Show();
        }
    }
}
