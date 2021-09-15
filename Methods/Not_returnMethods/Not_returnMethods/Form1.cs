using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_returnMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }

        void colorize()
        {
            textBox1.BackColor = Color.Green;
            textBox2.BackColor = Color.Blue;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
            colorize();

        }
    }
}
