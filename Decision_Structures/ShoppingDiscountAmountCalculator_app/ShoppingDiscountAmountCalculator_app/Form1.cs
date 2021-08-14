using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingDiscountAmountCalculator_app
{
    public partial class Form1 : Form
    {
        //0-20 ==> %20
        //21-40 ==> %40
        //41++ ==> %50
        //Book price ==> 8tl
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int piece =Convert.ToInt32(textBox1.Text);
            double total=piece*8,result;

            if(piece>=0 && piece<=20)
            {
               result =total-( total * 0.2);
            }
            else if(piece>=21 && piece<=40)
            {
                result = total - (total * 0.4);
            }
            else if(piece>=41)
            {
                result = total - (total * 0.5);
            }
            else
            {
                result = total;
            }
            label3.Text = result.ToString("0.00") + " tl";

        }
    }
}
