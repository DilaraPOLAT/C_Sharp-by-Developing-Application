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
    public partial class frmCaddeSokak : Form
    {
        public frmCaddeSokak()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://parselsorgu.tkgm.gov.tr/");
        }
    }
}
