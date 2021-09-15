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
using Microsoft.Reporting.WinForms;

namespace Tapu_Yonetim_Sistemi.app
{
    public partial class frmKayitliEmlak : Form
    {
        public frmKayitliEmlak()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-N553KTL\\SQL2019;Initial Catalog=TapuVeriTabani;Integrated Security=True");

        DataTable tablo = new DataTable();
        DataTable tablo1 = new DataTable();

        private void frmKayitliEmlak_Load(object sender, EventArgs e)
        {
            
            tablo.Columns.Add("id", typeof(int));
            tablo.Columns.Add("il", typeof(string));
            tablo.Columns.Add("ilce", typeof(string));
            tablo.Columns.Add("MAHALLE", typeof(string));
            tablo.Columns.Add("CADDE_SOKAK", typeof(string));
            tablo.Columns.Add("ADA", typeof(int));
            tablo.Columns.Add("PARSEL", typeof(int));
            tablo.Columns.Add("Cinsi", typeof(bool));
            tablo.Columns.Add("Yuz_Olcumu", typeof(int));
            tablo.Columns.Add("Maliki_AdSOYAD", typeof(string));
            tablo.Columns.Add("Maliki_TelNO", typeof(string));
            tablo.Columns.Add("UCRET", typeof(float));
            dataGridView1.DataSource = tablo;

            tablo1.Columns.Add("id", typeof(int));
            tablo1.Columns.Add("il", typeof(string));
            tablo1.Columns.Add("ilce", typeof(string));
            tablo1.Columns.Add("MAHALLE", typeof(string));
            tablo1.Columns.Add("CADDE_SOKAK", typeof(string));
            tablo1.Columns.Add("Cinsi", typeof(string));
            tablo1.Columns.Add("KAT_Sayisi", typeof(int));
            tablo1.Columns.Add("BLOK_KAT_NO", typeof(string));
            tablo1.Columns.Add("BALKON", typeof(bool));
            tablo1.Columns.Add("YUZ_OLCUMU", typeof(int));
            tablo1.Columns.Add("Maliki_AdSOYAD", typeof(string));
            tablo1.Columns.Add("Maliki_TelNO", typeof(string));
            tablo1.Columns.Add("UCRET", typeof(float));
            dataGridView2.DataSource = tablo1;



        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            tablo.Rows.Clear();
            tablo1.Rows.Clear();
            baglanti.Open();

            SqlCommand kmt = new SqlCommand("select * From Arsa where Alici_AdSoyad=@p1", baglanti);
            kmt.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            SqlDataReader dr = kmt.ExecuteReader();

            while (dr.Read())
            {
                tablo.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[11].ToString(), dr[12].ToString(), dr[13].ToString());
            }
            baglanti.Close();


            baglanti.Open();

            SqlCommand kmt1 = new SqlCommand("select * From Ev where Alici_AdSoyad=@p1", baglanti);
            kmt1.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            SqlDataReader dr1 = kmt1.ExecuteReader();

            while (dr1.Read())
            {
                tablo1.Rows.Add(dr1[0].ToString(), dr1[1].ToString(), dr1[2].ToString(), dr1[3].ToString(), dr1[4].ToString(), dr1[5].ToString(), dr1[6].ToString(), dr1[7].ToString(), dr1[8].ToString(), dr1[9].ToString(), dr1[12].ToString(), dr1[13].ToString(), dr1[14].ToString());
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komutE = new SqlCommand("select count(*)from Ev  where Alici_AdSoyad=@p1", baglanti);
            komutE.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            SqlDataReader drE = komutE.ExecuteReader();
            while (drE.Read())
            {
                lblEvSay.Text = drE[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komutA = new SqlCommand("select count(*)from Arsa where Alici_AdSoyad=@p1", baglanti);
            komutA.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            SqlDataReader drA = komutA.ExecuteReader();
            while (drA.Read())
            {
                lblArsaSay.Text = drA[0].ToString();
            }
            baglanti.Close();

        }
        ReportDataSource rsA = new ReportDataSource();
        private void btnRaporArsa_Click(object sender, EventArgs e)
        {
            List<Arsa> LstA = new List<Arsa>();
            LstA.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Arsa arsa = new Arsa
                {
                    id = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()),
                    il = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    ilce = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    MAHALLE = dataGridView1.Rows[i].Cells[3].Value.ToString(),
                    CADDE_SOKAK = dataGridView1.Rows[i].Cells[4].Value.ToString(),
                    ADA = int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()),
                    PARSEL = int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()),
                    Cinsi = bool.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString()),
                    Yuz_Olcumu = int.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString()),
                    Maliki_AdSOYAD = dataGridView1.Rows[i].Cells[9].Value.ToString(),
                    Maliki_TelNO = dataGridView1.Rows[i].Cells[10].Value.ToString(),
                    UCRET = int.Parse(dataGridView1.Rows[i].Cells[11].Value.ToString())
                };
                LstA.Add(arsa);
            }

                rsA.Name = "DataSet1";
                rsA.Value = LstA;

                frmReportKayitliEmlak frmKE = new frmReportKayitliEmlak();
                frmKE.reportViewer1.LocalReport.DataSources.Clear();
                frmKE.reportViewer1.LocalReport.DataSources.Add(rsA);
                frmKE.reportViewer1.LocalReport.ReportEmbeddedResource = "Tapu_Yonetim_Sistemi.app.ReportKayitliEmlakArsa.rdlc";

                frmKE.ShowDialog();
            

        }
        ReportDataSource rsE = new ReportDataSource();
        private void btnRaporEv_Click(object sender, EventArgs e)
        {
            List<Ev> LstE = new List<Ev>();
            LstE.Clear();
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                Ev ev = new Ev
                {
                    id = int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString()),
                    il = dataGridView2.Rows[i].Cells[1].Value.ToString(),
                    ilce = dataGridView2.Rows[i].Cells[2].Value.ToString(),
                    MAHALLE = dataGridView2.Rows[i].Cells[3].Value.ToString(),
                    CADDE_SOKAK = dataGridView2.Rows[i].Cells[4].Value.ToString(),
                    Cinsi = dataGridView2.Rows[i].Cells[5].Value.ToString(),
                    KAT_Sayisi = int.Parse(dataGridView2.Rows[i].Cells[6].Value.ToString()),
                    BLOK_KAT_NO = dataGridView2.Rows[i].Cells[7].Value.ToString(),
                    BALKON = bool.Parse(dataGridView2.Rows[i].Cells[8].Value.ToString()),
                    YUZ_OLCUMU = int.Parse(dataGridView2.Rows[i].Cells[9].Value.ToString()),
                    Maliki_AdSOYAD = dataGridView2.Rows[i].Cells[10].Value.ToString(),
                    Maliki_TelNO = dataGridView2.Rows[i].Cells[11].Value.ToString(),
                    UCRET = int.Parse(dataGridView2.Rows[i].Cells[12].Value.ToString())
                };
                LstE.Add(ev);
            }

                rsE.Name = "DataSet2";
                rsE.Value = LstE;

                frmReportKayitliEmlakEv frmKEE = new frmReportKayitliEmlakEv();
                frmKEE.reportViewer1.LocalReport.DataSources.Clear();
                frmKEE.reportViewer1.LocalReport.DataSources.Add(rsE);
                frmKEE.reportViewer1.LocalReport.ReportEmbeddedResource = "Tapu_Yonetim_Sistemi.app.ReportKayitliEmlakEv.rdlc";

                frmKEE.ShowDialog();
            
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkSeaGreen;
        }

        private void kırmızıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkRed;
        }

        private void pembeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DeepPink;
        }

        private void sarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.YellowGreen;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkGray;
        }

        private void tAPUARSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArsa arsa = new frmArsa();
            arsa.Show();
        }

        private void tAPUEVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEv ev = new frmEv();
            ev.Show();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {
            txtAdSoyad.Text = txtAdSoyad.Text.ToUpper();
            txtAdSoyad.SelectionStart = txtAdSoyad.Text.Length;
        }
    }
    public class Arsa
    {
        public int id { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string MAHALLE { get; set; }
        public string CADDE_SOKAK { get; set; }
        public int ADA { get; set; }
        public int PARSEL { get; set; }
        public bool Cinsi { get; set; }
        public int Yuz_Olcumu { get; set; }
        public string Maliki_AdSOYAD { get; set; }
        public string Maliki_TelNO { get; set; }
        public int UCRET { get; set; }
    }

    public class Ev
    {
        public int id { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string MAHALLE { get; set; }
        public string CADDE_SOKAK { get; set; }
        public string Cinsi { get; set; }
        public int KAT_Sayisi { get; set; }
        public string BLOK_KAT_NO { get; set; }
        public bool BALKON { get; set; }
        public int YUZ_OLCUMU { get; set; }
        public string Maliki_AdSOYAD { get; set; }
        public string Maliki_TelNO { get; set; }
        public int UCRET { get; set; }
    }
}
