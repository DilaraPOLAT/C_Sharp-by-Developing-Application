using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables_Double
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* double s1, s2, s3,result;
             s1 = 60.1;
             s2 = 70.3;
             s3 = 85.8;
             result = s1 + s2 + s3;
             label1.Text = result.ToString("0.00");
            */
            double number;
            number = Convert.ToDouble(textBox1.Text);
            label1.Text = number.ToString("0.00");
        }
    }
}
