using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Return_Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       int sum(int number1,int number2)
        {
            int result = number1 + number2;
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text=sum(12, 45).ToString();
            label2.Text = sum(40, 52).ToString();

        }
    }
}
