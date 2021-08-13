using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables_int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int number1, number2,sum;
            number1 = 5;
            number2 = 10;
            sum = number1 + number2;
            label1.Text = sum.ToString();*/
            int edge, area, perimeter;
            edge = 10;
            area = 10 * 10;
            perimeter = 10 * 4;
            label1.Text = "Area:" + area + " " + "Perimeter:" + perimeter;
        }
    }
}
