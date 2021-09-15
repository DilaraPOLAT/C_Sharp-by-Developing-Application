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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car cr = new Car();
            cr.colour = "Blue";
            cr.speed = 160;
            cr.engine = 1245.56;
            cr.price = 50000;
            cr.status = 's';
            cr.YEAR = -2021;
            cr.BRAND = "Golf";
            cr.peak = 2017;
            cr.plaque = "34 Aİ 1881";
            cr.owner = "Dilara Hanım";

            label1.Text = cr.colour;
            label2.Text = cr.speed.ToString();
            label3.Text = cr.engine.ToString();
            label4.Text = cr.price.ToString();
            label5.Text = cr.status.ToString();
            label6.Text = cr.YEAR.ToString();
            label7.Text = cr.BRAND;
            label8.Text = cr.peak.ToString();
            label9.Text = cr.plaque;
            label10.Text = cr.owner;

            pictureBox1.BackColor = Color.CadetBlue;


        }
    }
}
