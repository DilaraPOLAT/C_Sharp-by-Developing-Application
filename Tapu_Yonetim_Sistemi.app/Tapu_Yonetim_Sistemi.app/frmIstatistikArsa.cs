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
    public partial class frmIstatistikArsa : Form
    {
        public frmIstatistikArsa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N553KTL\\SQL2019;Initial Catalog=TapuVeriTabani;Integrated Security=True");
        private void frmIstatistikArsa_Load(object sender, EventArgs e)
        {
            //Satılan arsa sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*)from Arsa",baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();

            while(dr1.Read())
            {
                lbl_ArsaSay.Text = dr1[0].ToString();
            }
            baglanti.Close();
            //Toplam arsa ucreti
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(ucret)from Arsa", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
             lbl_ArsaUcreti.Text = dr2[0].ToString();
            }
            baglanti.Close();
            //sulu arsa sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count(*)from Arsa where  cinsi=1", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                lbl_Sulu.Text = dr3[0].ToString();
            }
            baglanti.Close();


            //susuz arsa sayısı
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count(*)from Arsa where  cinsi=0", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();

            while (dr4.Read())
            {
                lbl_Susuz.Text = dr4[0].ToString();
            }
            baglanti.Close();

        }
    }
}
