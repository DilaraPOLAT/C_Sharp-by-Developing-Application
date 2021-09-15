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
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }

        private void btnClup_Click(object sender, EventArgs e)
        {
            frmClub fr = new frmClub();
            fr.Show();
        }

        private void btnLesson_Click(object sender, EventArgs e)
        {
            frmLessons fr = new frmLessons();
            fr.Show();
        }
    }
}
