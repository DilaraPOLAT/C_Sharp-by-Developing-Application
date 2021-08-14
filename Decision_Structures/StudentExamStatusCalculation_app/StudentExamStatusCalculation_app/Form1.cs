using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExamStatusCalculation_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double midterm, final, result;
            midterm = Convert.ToDouble(textBox4.Text);
            final = Convert.ToDouble(textBox5.Text);
            result = midterm * 0.4 + final * 0.6;
            if(result<50)
            {
                textBox6.Text= result+" Left :( ";
            }
            else 
            {
                textBox6.Text=result+" Passed :) ";
            }
            listBox1.Items.Add("Your information:"+  " Name: "+textBox1.Text+ " Surname: " +textBox2.Text+ " Name Lesson: " +textBox3.Text+ " Midterm: "+textBox4.Text + " Final: "+textBox5.Text+" Result: "+result);
           

        }
    }
}
