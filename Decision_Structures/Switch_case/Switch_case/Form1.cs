using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int moon = Convert.ToInt16(textBox1.Text);
            switch (moon)
            {
                case 1:label2.Text = "January"; break;
                case 2: label2.Text = "February"; break;
                case 3: label2.Text = "March"; break;
                case 4: label2.Text = "April"; break;
                case 5: label2.Text = "May"; break;
                case 6: label2.Text = "June"; break;
                case 7: label2.Text = "July"; break;
                case 8: label2.Text = "August"; break;
                case 9: label2.Text = "September"; break;
                case 10: label2.Text = "October"; break;
                case 11: label2.Text = "November"; break;
                case 12: label2.Text = "December"; break;
                default: label2.Text = "Incorrect moon!";break;
            }
            */
            string season = textBox1.Text;
            switch(season)
            {
                case "summer":label2.Text = "June, july, august ";break;
                case "spring":label2.Text = "March, april, may";break;
                case "writer":label2.Text = "December, january, february";break;
                case "autumn":label2.Text = "September, octomber, novamber";break;
                default:label2.Text = "Incorrect season";break;

            }

            
        }
    }
}
