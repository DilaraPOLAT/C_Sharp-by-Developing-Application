using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_OkulProje
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            frmStudentLogin frm = new frmStudentLogin();
            this.Hide();
            frm.Show();

        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            frmTeacher frm = new frmTeacher();
            this.Hide();
            frm.Show();
        }
    }
}
