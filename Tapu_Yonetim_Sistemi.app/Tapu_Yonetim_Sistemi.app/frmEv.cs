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
    public partial class frmEv : Form
    {
        public frmEv()
        {
            InitializeComponent();
        }

        private void frmEv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tapuVeriTabaniDataSet23.Ev' table. You can move, or remove it, as needed.
            this.evTableAdapter8.Fill(this.tapuVeriTabaniDataSet23.Ev);
        

            

            // TODO: This line of code loads data into the 'tapuVeriTabaniDataSet10.iller' table. You can move, or remove it, as needed.
            this.illerTableAdapter.Fill(this.tapuVeriTabaniDataSet10.iller);
            txtCinsi.Text = "Ev";

        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N553KTL\\SQL2019;Initial Catalog=TapuVeriTabani;Integrated Security=True");
       
        void Temizle()
        {
            txtMAdSoyad.Text = "";
            txtAAdSoyad.Text = "";
            mskATelNo.Text = "";
            mskMTelNo.Text = "";
            cmb_il.Text = "";
            cmb_ilce.Text = "";
            txtBlok.Text = "";
            txtCinsi.Text = "";
            txtCadde.Text = "";
            txtEv_id.Text = "";
            txtMahalle.Text = "";
            rdbBalkonlu.Checked = false;
            rdbBalkonsuz.Checked = false;
            txtYuz_Olcumu.Text = "";
            mskKat.Text = "";
            mskUcret.Text = "";
            

        }
        private void cmb_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            int deger = cmb_il.SelectedIndex + 1;
            SqlCommand kmt = new SqlCommand("select ilceadi From ilceler where sehirid=" + deger.ToString(), baglanti);
            cmb_ilce.Items.Clear();
            SqlDataReader dr = kmt.ExecuteReader();

            while (dr.Read())
            {
                cmb_ilce.Items.Add(dr[0].ToString());
            }


            baglanti.Close();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.evTableAdapter8.Fill(this.tapuVeriTabaniDataSet23.Ev);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kKomut = new SqlCommand("insert into Ev(il,ilce,Mahalle,Cadde_Sokak,Cinsi,Kat_Sayisi,Blok_Kat_No,Balkon,Yuz_Olcumu,Maliki_AdSoyad,Maliki_TelNo,Alici_AdSoyad,Alici_TelNo,Ucret) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14) ", baglanti);
            kKomut.Parameters.AddWithValue("@p1", cmb_il.Text);
            kKomut.Parameters.AddWithValue("@p2", cmb_ilce.Text);
            kKomut.Parameters.AddWithValue("@p3", txtMahalle.Text);
            kKomut.Parameters.AddWithValue("@p4",txtCadde.Text);
            kKomut.Parameters.AddWithValue("@p5", txtCinsi.Text);
            kKomut.Parameters.AddWithValue("@p6", mskKat.Text);
            kKomut.Parameters.AddWithValue("@p7", txtBlok.Text);
            kKomut.Parameters.AddWithValue("@p8", lblBalkon.Text);
            kKomut.Parameters.AddWithValue("@p9", txtYuz_Olcumu.Text);
            kKomut.Parameters.AddWithValue("@p10", txtMAdSoyad.Text);
            kKomut.Parameters.AddWithValue("@p11", mskMTelNo.Text.ToString());
            kKomut.Parameters.AddWithValue("@p12", txtAAdSoyad.Text);
            kKomut.Parameters.AddWithValue("@p13", mskATelNo.Text.ToString());
            kKomut.Parameters.AddWithValue("@p14", mskUcret.Text);
            kKomut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void rdbBalkonlu_CheckedChanged(object sender, EventArgs e)
        {
            lblBalkon.Text = "True";
        }

        private void rdbBalkonsuz_CheckedChanged(object sender, EventArgs e)
        {
            lblBalkon.Text = "False";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

       

       

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kKomut = new SqlCommand("Delete from Ev where id=@k1", baglanti);
            kKomut.Parameters.AddWithValue("@k1", txtEv_id.Text);
            kKomut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            frmIstatistikEv frie = new frmIstatistikEv();
            frie.Show();
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            frmGrafiklerEv frge = new frmGrafiklerEv();
            frge.Show();
        }

    

        private void btnRapor_Click_1(object sender, EventArgs e)
        {
            frmGrafiklerEv frge = new frmGrafiklerEv();
            frge.Show();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            frmReportEv frre = new frmReportEv();
            frre.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand GKomut = new SqlCommand("Update Ev Set il=@p1,ilce=@p2,Mahalle=@p3,Cadde_Sokak=@p4,Cinsi=@p5,Kat_Sayisi=@p6,Blok_Kat_No=@p7,Balkon=@p8,Yuz_Olcumu=@p9,Maliki_AdSoyad=@p10,Maliki_TelNo=@p11,Alici_AdSoyad=@p12,Alici_TelNo=@p13,Ucret=@p14 where id=@p15", baglanti);
            GKomut.Parameters.AddWithValue("@p1",cmb_il.Text);
            GKomut.Parameters.AddWithValue("@p2",cmb_ilce.Text );
            GKomut.Parameters.AddWithValue("@p3",txtMahalle.Text );
            GKomut.Parameters.AddWithValue("@p4",txtCadde.Text );
            GKomut.Parameters.AddWithValue("@p5",txtCinsi.Text );
            GKomut.Parameters.AddWithValue("@p6",mskKat.Text );
            GKomut.Parameters.AddWithValue("@p7",txtBlok.Text );
            GKomut.Parameters.AddWithValue("@p8",lblBalkon.Text );
            GKomut.Parameters.AddWithValue("@p9",txtYuz_Olcumu.Text );
            GKomut.Parameters.AddWithValue("@p10",txtMAdSoyad.Text );
            GKomut.Parameters.AddWithValue("@p11",mskMTelNo.Text );
            GKomut.Parameters.AddWithValue("@p12",txtAAdSoyad.Text );
            GKomut.Parameters.AddWithValue("@p13", mskATelNo.Text);
            GKomut.Parameters.AddWithValue("@p14",mskUcret.Text );
            GKomut.Parameters.AddWithValue("@p15",txtEv_id.Text );
            GKomut.ExecuteNonQuery();

            baglanti.Close();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void pembeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DeepPink;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.IndianRed;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkSeaGreen;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void tAPUARSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArsa arsa = new frmArsa();
            arsa.Show();
        }

        private void kAYITLIEMLAKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKayitliEmlak kayEmlak = new frmKayitliEmlak();
            kayEmlak.Show();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtEv_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmb_il.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmb_ilce.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtMahalle.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtCadde.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtCinsi.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mskKat.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtBlok.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            lblBalkon.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            if (lblBalkon.Text == "True")
            {
                rdbBalkonlu.Checked = true;

            }
            else
            {
                rdbBalkonsuz.Checked = true;
            }
            txtYuz_Olcumu.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            txtMAdSoyad.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            mskMTelNo.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            txtAAdSoyad.Text = dataGridView1.Rows[secilen].Cells[12].Value.ToString();
            mskATelNo.Text = dataGridView1.Rows[secilen].Cells[13].Value.ToString();
           mskUcret.Text = dataGridView1.Rows[secilen].Cells[14].Value.ToString();
        }

        private void txtMAdSoyad_TextChanged(object sender, EventArgs e)
        {
            txtMAdSoyad.Text = txtMAdSoyad.Text.ToUpper();
            txtMAdSoyad.SelectionStart = txtMAdSoyad.Text.Length;
        }

        private void txtAAdSoyad_TextChanged(object sender, EventArgs e)
        {
            txtAAdSoyad.Text = txtAAdSoyad.Text.ToUpper();
            txtAAdSoyad.SelectionStart = txtAAdSoyad.Text.Length;
        }

        private void txtMahalle_TextChanged(object sender, EventArgs e)
        {
            txtMahalle.Text = txtMahalle.Text.ToUpper();
            txtMahalle.SelectionStart = txtMahalle.Text.Length;
        }

        private void txtCadde_TextChanged(object sender, EventArgs e)
        {
            txtCadde.Text = txtCadde.Text.ToUpper();
            txtCadde.SelectionStart = txtCadde.Text.Length;
        }

        private void txtBlok_TextChanged(object sender, EventArgs e)
        {
            txtBlok.Text = txtBlok.Text.ToUpper();
            txtBlok.SelectionStart = txtBlok.Text.Length;
        }
    }
}
