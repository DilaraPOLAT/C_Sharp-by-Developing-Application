using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumStructure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum country { X,Adana, Adıyaman, Afyon, Ağrı, Amasya, Ankara, Anatalya, Artvin, Aydın };
        private void button1_Click(object sender, EventArgs e)
        {
            int plaque = Convert.ToInt16(textBox1.Text);
            country c;
            c = (country)plaque;
            label1.Text = c.ToString();
        }
    }
}
