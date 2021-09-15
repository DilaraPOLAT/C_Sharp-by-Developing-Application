using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            /* string[] citys = { "Ankara", "Elazığ", "Malatya", "Konya", "Bursa", "İstanbul" };
            
             for(i=0;i<citys.Length;i++)
             {
                 listBox1.Items.Add(citys[i]);
             }*/
            int[] numbers = { 10, 8, 5, 6, 7, 74, 25, 33, 91 };
            for(i=0;i<numbers.Length;i++)
            {
                if(numbers[i]%2==0)
                {
                    listBox1.Items.Add(numbers[i]);
                }
            }
        }
    }
}
