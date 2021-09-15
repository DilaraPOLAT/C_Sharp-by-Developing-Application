using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tapu_Yonetim_Sistemi.app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmEv fre = new frmEv();
            fre.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmArsa fra = new frmArsa();
            fra.Show();
        }

        private void btnKayitliEmlak_Click(object sender, EventArgs e)
        {
            frmKayitliEmlak frmKE = new frmKayitliEmlak();
            frmKE.Show();
        }

        private void btnTapuArsa_Click(object sender, EventArgs e)
        {
            frmArsa fra = new frmArsa();
            fra.Show();
        }

        private void btnTapuEv_Click(object sender, EventArgs e)
        {
            frmEv fre = new frmEv();
            fre.Show();
        }

        private void mAVİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void pembeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DeepPink;
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.YellowGreen;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkRed;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
        }


        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaglan frmb = new frmBaglan();
            frmb.webBrowser1.Navigate("https://www.google.com/");
            frmb.label1.Text = "GOOGLE";
            frmb.ShowDialog();
        }

        private void yandexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaglan frmb = new frmBaglan();
            frmb.webBrowser1.Navigate("https://yandex.com.tr/");
            frmb.label1.Text = "YANDEX";
            frmb.ShowDialog();
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaglan frmb = new frmBaglan();
            frmb.webBrowser1.Navigate("https://www.youtube.com/");
            frmb.label1.Text = "YOUTUBE";
            frmb.ShowDialog();
        }

        private void gmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaglan frmb = new frmBaglan();
            frmb.webBrowser1.Navigate("https://mail.google.com/mail/u/0/#inbox");
            frmb.label1.Text = "E-POSTA";
            frmb.ShowDialog();
        }

        private void kARAKOÇANBELEDİYESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaglan frmb = new frmBaglan();
            frmb.webBrowser1.Navigate("http://www.karakocan.bel.tr/");
            frmb.label1.Text = "KARAKOÇAN BELEDİYESİ";
            frmb.ShowDialog();
        }

        private void eBELEDİYEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaglan frmb = new frmBaglan();
            frmb.webBrowser1.Navigate("https://www.belediye.gov.tr/");
            frmb.label1.Text = "E-BELEDİYE";
            frmb.ShowDialog();
        }

        private void eDEVLETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaglan frmb = new frmBaglan();
            frmb.webBrowser1.Navigate("https://www.turkiye.gov.tr/");
            frmb.label1.Text = "E-DEVLET";
            frmb.ShowDialog();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
