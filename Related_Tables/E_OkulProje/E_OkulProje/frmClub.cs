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
    public partial class frmClub : Form
    {
        public frmClub()
        {
            InitializeComponent();
        }
        Connection bgl = new Connection();
        
        private void frmClub_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *From Tbl_Kulupler",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *From Tbl_Kulupler", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnPut_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Kulupler(KulupAd) values(@k1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txtAd.Text);
            komut.ExecuteNonQuery();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Kulupler set KulupAd=@k1 where KulupId=@k2", bgl.baglanti());
            komut.Parameters.AddWithValue("@k2", txtId.Text);
            komut.Parameters.AddWithValue("@k1", txtAd.Text);
            komut.ExecuteNonQuery();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE from Tbl_Kulupler where KulupId=@k1", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txtId.Text);
            komut.ExecuteNonQuery();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
