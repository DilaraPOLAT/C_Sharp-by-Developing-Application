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
    public partial class frmStudentLogin : Form
    {
       
        public frmStudentLogin()
        {
           
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmStudentNotes frm = new frmStudentNotes();
            frm.numara = textBox1.Text;
            this.Hide();
            frm.Show();
        }
    }
}
