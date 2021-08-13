using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExamSystemApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name, surname;
            int s1, s2, project;
            double medium;
            name = textBox1.Text;
            surname = textBox2.Text;
            s1 = Convert.ToInt32(textBox3.Text);
            s2 = Convert.ToInt32(textBox4.Text);
            project = Convert.ToInt32(textBox5.Text);
            medium = (s1 + s2 + project) / 3;
            listBox1.Items.Add("Name:"+name+" "+"Surname:"+surname+" "+"Medium:"+medium);
        }
    }
}
