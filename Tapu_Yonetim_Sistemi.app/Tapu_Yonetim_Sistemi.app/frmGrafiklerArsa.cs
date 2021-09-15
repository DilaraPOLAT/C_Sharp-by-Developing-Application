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
    public partial class frmGrafiklerArsa : Form
    {
        public frmGrafiklerArsa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N553KTL\\SQL2019;Initial Catalog=TapuVeriTabani;Integrated Security=True");
        private void frmGrafiklerArsa_Load(object sender, EventArgs e)
        {
            //Sehirler
            baglanti.Open();
            SqlCommand kmt1 = new SqlCommand("select il,count(*) From Arsa Group By il" , baglanti);
            SqlDataReader dr1 = kmt1.ExecuteReader();

            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }

            baglanti.Close();

            //Ucret
            baglanti.Open();
            SqlCommand kmt2 = new SqlCommand("select il,Avg(Ucret ) From Arsa Group By il", baglanti);
            SqlDataReader dr2 = kmt2.ExecuteReader();

            while (dr2.Read())
            {
                chart2.Series["Ucret"].Points.AddXY(dr2[0], dr2[1]);
            }

            baglanti.Close();

        }
    }
}
