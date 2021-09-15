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

namespace Project_Hospital
{
    public partial class frmDoktorGiris : Form
    {
        public frmDoktorGiris()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select *from Tbl_Doktorlar where DoktorTC=@d1 and DoktorSifre=@d2",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", mskTC.Text);
            komut.Parameters.AddWithValue("@d2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                frmDoktorDetay frd = new frmDoktorDetay();
                frd.TC = mskTC.Text;
                frd.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı TC  & Şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
