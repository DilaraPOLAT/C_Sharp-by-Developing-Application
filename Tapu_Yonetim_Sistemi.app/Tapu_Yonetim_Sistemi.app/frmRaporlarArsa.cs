using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tapu_Yonetim_Sistemi.app
{
    public partial class frmRaporlarArsa : Form
    {
        public frmRaporlarArsa()
        {
            InitializeComponent();
        }

        private void frmRaporlarArsa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TapuVeriTabaniDataSet9.Arsa' table. You can move, or remove it, as needed.
            this.ArsaTableAdapter.Fill(this.TapuVeriTabaniDataSet9.Arsa);

            this.reportViewer1.RefreshReport();
        }
    }
}
