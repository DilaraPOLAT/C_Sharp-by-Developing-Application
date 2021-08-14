using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratice_SumOfConsecutiveNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i,sum=0;
            for (i = 0; i <=10; i+=2)
            {
                sum = sum+i;
            }
            label1.Text = sum.ToString();
        }
    }
}
