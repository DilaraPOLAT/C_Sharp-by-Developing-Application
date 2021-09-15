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
    public partial class frmReportKayitliEmlakEv : Form
    {
        public frmReportKayitliEmlakEv()
        {
            InitializeComponent();
        }

        private void frmReportKayitliEmlakEv_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
