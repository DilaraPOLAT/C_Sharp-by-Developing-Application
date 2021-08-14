using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_clock_withTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int clock = 0, minute = 0,second=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            minute++;
            label1.Text = minute.ToString();
            if(minute==60)
            {
                second++;
                label2.Text = second.ToString();
                minute = 0;
                if(second==3)
                {
                    clock++;
                    label3.Text = clock.ToString();
                    second = 0;
                }
            }

        }
    }
}
