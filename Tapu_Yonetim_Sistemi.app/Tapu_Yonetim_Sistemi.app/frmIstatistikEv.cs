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
namespace Tapu_Yonetim_Sistemi.app
{
    public partial class frmIstatistikEv : Form
    {
        public frmIstatistikEv()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N553KTL\\SQL2019;Initial Catalog=TapuVeriTabani;Integrated Security=True");
        private void frmIstatistikEv_Load(object sender, EventArgs e)
        {
            //Satılan ev sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*)from Ev", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())
            {
                lblEvSay.Text = dr1[0].ToString();
            }
            baglanti.Close();

            //Toplam ev ucreti

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(ucret)from Ev", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            { 
                lblEvUcret.Text = dr2[0].ToString();
            }
            baglanti.Close();

            //Balkonlu ev sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count(*)from Ev where  Balkon=1", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
               lblBalkonlu.Text = dr3[0].ToString();
            }
            baglanti.Close();


            //Balkonsuz ev  sayısı
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count(*)from Ev where  Balkon=0", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();

            while (dr4.Read())
            {
               lblBalkonsuz.Text = dr4[0].ToString();
            }
            baglanti.Close();
        }
    }
}
