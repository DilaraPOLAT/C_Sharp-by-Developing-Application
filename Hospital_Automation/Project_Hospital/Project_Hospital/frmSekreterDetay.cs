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
    public partial class frmSekreterDetay : Form
    {
        public frmSekreterDetay()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        public string TC;
        private void frmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TC;

            //AdSoyad
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad from Tbl_Sekreter where SekreterTC=@p1" , bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TC);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                lblAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları DataGride Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar",bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları Listeye Aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd+' '+DoktorSoyad) as 'Doktorlar',DoktorBrans From Tbl_Doktorlar",bgl.baglanti());

            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşı ComboBoxa Atama
            SqlCommand komutbrans = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader drBrans = komutbrans.ExecuteReader();
            while(drBrans.Read())
            {
                cmbBrans.Items.Add(drBrans[0]);
            }
            bgl.baglanti().Close();

           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values(@r1,@r2,@r3,@r4)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Doktor ComboBoxa Atama
            cmbDoktor.Items.Clear();
            SqlCommand komutdoktor = new SqlCommand("Select DoktorAd, DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@d1", bgl.baglanti());
            komutdoktor.Parameters.AddWithValue("@d1", cmbBrans.Text);
            SqlDataReader drDoktor = komutdoktor.ExecuteReader();
            while (drDoktor.Read())
            {
                cmbDoktor.Items.Add(drDoktor[0]+" "+drDoktor[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", richTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            frmDoktorPaneli drp = new frmDoktorPaneli();
            drp.Show();
        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            frmBrans fb = new frmBrans();
            fb.Show();
        }

        private void btnRandevuListele_Click(object sender, EventArgs e)
        {
            frmRandevuListesi frl = new frmRandevuListesi();
            frl.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
          /*  SqlCommand komut = new SqlCommand("update from Tbl_Randevular RandevuTarih=@r1,RandevuSaat=@r2,RandevuBrans=@r3,RandevuDoktor=@r4,RandevuDurum=@r5 where Randevuid=@r6",bgl.baglanti());
            komut.Parameters.AddWithValue("@r1",mskTarih.Text);
            komut.Parameters.AddWithValue("@r2", mskSaat.Text);
            komut.Parameters.AddWithValue("@r3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@r4", cmbDoktor.Text);
            komut.Parameters.AddWithValue("@r5", chcBxDurum.Text);
            komut.Parameters.AddWithValue("@r6", mskTarih.Text);*/
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            frmDuyurular fd = new frmDuyurular();
            fd.Show();
        }
    }
}
