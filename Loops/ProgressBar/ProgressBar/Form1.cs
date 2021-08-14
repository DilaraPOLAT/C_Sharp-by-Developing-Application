using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 75;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            progressBar1.Value += 10;
            if(progressBar1.Value>=100)
            {
                button1.Enabled = false;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            progressBar1.Value -= 10;
            if (progressBar1.Value <= 0)
            {
                button2.Enabled = false;
            }
            
        }
    }
}
