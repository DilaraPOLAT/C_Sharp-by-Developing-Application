using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] persons = { "Ayşe", "Demet", "Hakan", "Fatma", "Ahmet", "Dilara" };
            //label1.Text = persons[1];

            int[] numbers = { 1, 2, 3, 4, 5 };
            label1.Text = numbers[2].ToString();
        }

    }
}
