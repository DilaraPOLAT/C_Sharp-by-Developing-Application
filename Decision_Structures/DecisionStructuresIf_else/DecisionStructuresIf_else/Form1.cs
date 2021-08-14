using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionStructuresIf_else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt16(textBox1.Text);
            if(number%2==0 && number>=10)
            {
                label1.Text = "Even Number greater than 10";
            }
            else if(number % 2 == 0)
            {
                label1.Text = "Even Number";
            }
            else if(number >=10)
            {
                label1.Text = "Number greater than 10";
            }
            else
            {
                label1.Text = "Not greater than 10 and not even number.";
            }
        }
    }
}
