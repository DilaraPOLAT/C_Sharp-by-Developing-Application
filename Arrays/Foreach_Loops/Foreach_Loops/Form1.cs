using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach_Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string[] persons = { "Ayşe", "Ada", "Melike", "Ahmet", "Yusuf", "Ömer", "Fatma", "Mehmet" };
            foreach(string value in persons)
            {
                listBox1.Items.Add(value);
            }*/

            int[] exams = { 20, 45, 87, 62, 95, 43, 12, 90 };
            int sum = 0,medium;
            foreach(int i in exams)
            {
                sum += i;
                listBox1.Items.Add(i);
            }
            medium = sum / exams.Length;
            label1.Text = sum.ToString();
            label2.Text = medium.ToString();

        }
    }
}
