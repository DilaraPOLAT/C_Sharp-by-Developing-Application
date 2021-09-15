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

namespace E_OkulProje
{
    public partial class frmStudentNotes : Form
    {
        public frmStudentNotes()
        {
            InitializeComponent();
        }
        public string numara;
        Connection bgl = new Connection();
      
        private void frmStudentNotes_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select DersAd, Sinav1,Sinav2,Sinav3,Ortalama,Durum from Tbl_Notlar INNER JOIN Tbl_Dersler ON Tbl_Notlar.DersId = Tbl_Dersler.DersId where OgrId = @p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", numara);
            this.Text = numara.ToString();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            SqlCommand komut2 = new SqlCommand("Select OgrAd,OgrSoyad from Tbl_Ogrenciler Where ogrId=@p1",bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr= komut2.ExecuteReader();
            while(dr.Read())
            {
                this.Text = dr[0] + " " + dr[1].ToString();
            }

        }
    }
}
