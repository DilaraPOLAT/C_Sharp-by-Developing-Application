using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String NameSurname, job, city;
            NameSurname = "Dilara Sevim POLAT";
            job = "Computer Engineering";
            city = textBox1.Text;
            label1.Text = NameSurname;
            label2.Text = job;
            label3.Text = city;
        }
    }
}
