using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Obje_Create
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Car cr2 = new Car();
            cr2.colour = "Pink";
            cr2.speed = 50;
            cr2.engine = 145.75;
            cr2.price = 45000;
            cr2.status = 's';

            label1.Text = cr2.colour;
            label2.Text = cr2.speed.ToString();
            label3.Text = cr2.engine.ToString();
            label4.Text = cr2.price.ToString();
            label5.Text = cr2.status.ToString();

            pictureBox1.BackColor = Color.DeepPink;

        }
    }
}
