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
    public partial class frmArsa : Form
    {
        public frmArsa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N553KTL\\SQL2019;Initial Catalog=TapuVeriTabani;Integrated Security=True");
       void temizle()
        {
            txtAAdaSoyad.Text = "";
            txtMAdSoyad.Text = "";
            txtMahalle.Text = "";
            txtParsel.Text = "";
            txtAda.Text = "";
            txtCaddeS.Text = "";
            mskUcret.Text = "";
            txtYuzOl.Text = "";
            cmb_il.Text = "";
            cmb_ilce.Text = "";
            mskATelNo.Text = "";
            mskMTelNo.Text = "";
            rdbSulu.Checked = false;
            rdbSusuz.Checked = false;
            txtArsaId.Text = "";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmCaddeSokak frcd = new frmCaddeSokak();
            frcd.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            int deger = cmb_il.SelectedIndex + 1;
            SqlCommand kmt = new SqlCommand("select ilceadi From ilceler where sehirid="+ deger.ToString(), baglanti);
            cmb_ilce.Items.Clear();
            SqlDataReader dr = kmt.ExecuteReader();

            while (dr.Read())
            {
              cmb_ilce.Items.Add(dr[0].ToString());
            }
          
            
            baglanti.Close();
        }

        private void frmArsa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tapuVeriTabaniDataSet9.Arsa' table. You can move, or remove it, as needed.
            this.arsaTableAdapter.Fill(this.tapuVeriTabaniDataSet9.Arsa);


            this.illerTableAdapter.Fill(this.tapuVeriTabaniDataSet1.iller);
        

        }

        private void btnListele_Click(object sender, EventArgs e)
        {

            this.arsaTableAdapter.Fill(this.tapuVeriTabaniDataSet9.Arsa);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kKomut = new SqlCommand("insert into Arsa(il,ilce,Mahalle,Cadde_Sokak,Ada,Parsel,Cinsi,Yuz_Olcumu,Maliki_AdSoyad,Maliki_TelNo,Alici_AdSoyad,Alici_TelNo,Ucret) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13) ", baglanti);
              kKomut.Parameters.AddWithValue("@p1", cmb_il.Text);
              kKomut.Parameters.AddWithValue("@p2", cmb_ilce.Text);
              kKomut.Parameters.AddWithValue("@p3", txtMahalle.Text);
              kKomut.Parameters.AddWithValue("@p4", txtCaddeS.Text);
              kKomut.Parameters.AddWithValue("@p5", txtAda.Text);
              kKomut.Parameters.AddWithValue("@p6", txtParsel.Text);
              kKomut.Parameters.AddWithValue("@p7", label5.Text);
              kKomut.Parameters.AddWithValue("@p8", txtYuzOl.Text);
              kKomut.Parameters.AddWithValue("@p9", txtMAdSoyad.Text);
              kKomut.Parameters.AddWithValue("@p10", mskMTelNo.Text.ToString());
              kKomut.Parameters.AddWithValue("@p11", txtAAdaSoyad.Text); 
            kKomut.Parameters.AddWithValue("@p12", mskATelNo.Text.ToString());
            kKomut.Parameters.AddWithValue("@p13", mskUcret.Text);
            kKomut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void rdbSulu_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "True";
        }

        private void rdbSusuz_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "False";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kKomut = new SqlCommand("Delete from Arsa where id=@k1", baglanti);
            kKomut.Parameters.AddWithValue("@k1", txtArsaId.Text);
            kKomut.ExecuteNonQuery();
            baglanti.Close();
        }

       

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtArsaId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmb_il.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmb_ilce.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtMahalle.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtCaddeS.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtAda.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtParsel.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            label5.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            if(label5.Text=="True")
            {
                rdbSulu.Checked = true;

            }
            else
            {
                rdbSusuz.Checked = true;
            }
            txtYuzOl.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txtMAdSoyad.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            mskMTelNo.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            txtAAdaSoyad.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            mskATelNo.Text = dataGridView1.Rows[secilen].Cells[12].Value.ToString();
            mskUcret.Text = dataGridView1.Rows[secilen].Cells[13].Value.ToString();
        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            frmRaporlarArsa frmRA = new frmRaporlarArsa();
            frmRA.Show();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            frmIstatistikArsa fri = new frmIstatistikArsa();
            fri.Show();
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            frmGrafiklerArsa frga = new frmGrafiklerArsa();
            frga.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand GKomut = new SqlCommand("Update Arsa Set il=@p1,ilce=@p2,Mahalle=@p3,Cadde_Sokak=@p4,Ada=@p5,Parsel=@p6,Cinsi=@p7,Yuz_Olcumu=@p8,Maliki_AdSoyad=@p9,Maliki_TelNo=@p10,Alici_AdSoyad=@p11,Alici_TelNo=@p12,Ucret=@p13 where id=@p14", baglanti);
            GKomut.Parameters.AddWithValue("@p1", cmb_il.Text);
            GKomut.Parameters.AddWithValue("@p2", cmb_ilce.Text);
            GKomut.Parameters.AddWithValue("@p3", txtMahalle.Text);
            GKomut.Parameters.AddWithValue("@p4", txtCaddeS.Text);
            GKomut.Parameters.AddWithValue("@p5", txtAda.Text);
            GKomut.Parameters.AddWithValue("@p6", txtParsel.Text);
            GKomut.Parameters.AddWithValue("@p7", label5.Text);
            GKomut.Parameters.AddWithValue("@p8", txtYuzOl.Text);
            GKomut.Parameters.AddWithValue("@p9", txtMAdSoyad.Text);
            GKomut.Parameters.AddWithValue("@p10", mskMTelNo.Text);
            GKomut.Parameters.AddWithValue("@p11", txtAAdaSoyad.Text);
            GKomut.Parameters.AddWithValue("@p12", mskATelNo.Text);
            GKomut.Parameters.AddWithValue("@p13", mskUcret.Text);
            GKomut.Parameters.AddWithValue("@p14", txtArsaId.Text);
            GKomut.ExecuteNonQuery();

            baglanti.Close();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void sarıToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }


        private void kahverengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Tan;
        }

        private void pembeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.DeepPink;
        }

        private void kırmızıToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkRed;
        }

        private void griToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
        }

        private void yeşilToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }


      

        private void tAPUEVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEv ev = new frmEv();
            ev.Show();
        }

        private void kAYITLIEMLAKToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmKayitliEmlak kayEmlak = new frmKayitliEmlak();
            kayEmlak.Show();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMAdSoyad_TextChanged(object sender, EventArgs e)
        {
            txtMAdSoyad.Text = txtMAdSoyad.Text.ToUpper();
            txtMAdSoyad.SelectionStart = txtMAdSoyad.Text.Length;
        }

        private void txtAAdaSoyad_TextChanged(object sender, EventArgs e)
        {
            txtAAdaSoyad.Text = txtAAdaSoyad.Text.ToUpper();
            txtAAdaSoyad.SelectionStart = txtAAdaSoyad.Text.Length;
        }

        private void txtMahalle_TextChanged(object sender, EventArgs e)
        {
            txtMahalle.Text = txtMahalle.Text.ToUpper();
            txtMahalle.SelectionStart = txtMahalle.Text.Length;
        }

        private void txtCaddeS_TextChanged(object sender, EventArgs e)
        {
            txtCaddeS.Text = txtCaddeS.Text.ToUpper();
            txtCaddeS.SelectionStart = txtCaddeS.Text.Length;
        }
    }
}
