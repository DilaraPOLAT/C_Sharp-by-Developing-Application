using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            int number1, number2,result;
            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);

            if (radioButton1.Checked)
            {
                result = number1 + number2;
                listBox1.Items.Add("Sum:" + result);

            }

            else if (radioButton2.Checked)
            {
                result = number1 - number2;
                listBox1.Items.Add("Subtraction:"+result);

            }

            else if (radioButton3.Checked)
            {
                result = number1 * number2;
                listBox1.Items.Add("Multiplication:" + result);
            }

            else if (radioButton4.Checked)
            {
                result = number1 / number2;
                listBox1.Items.Add("Divide:" + result);
            }
            else
            {
                MessageBox.Show("Please Process Choose!");
            }
        }

      
    }
}
