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
    public partial class frmLessons : Form
    {
        public frmLessons()
        {
            InitializeComponent();
        }
        Connection bgl = new Connection();
        DataSet1TableAdapters.Tbl_DerslerTableAdapter ds = new DataSet1TableAdapters.Tbl_DerslerTableAdapter();
        private void btnPost_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.LessonList();
        }

        private void btnPut_Click(object sender, EventArgs e)
        {
           ds.LessonAdd(txtAd.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ds.LessonUpdate(txtAd.Text,byte.Parse(txtId.Text));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ds.LesssonDelete(byte.Parse(txtId.Text));
        }

        private void frmLessons_Load(object sender, EventArgs e)
        {   
            dataGridView1.DataSource = ds.LessonList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
