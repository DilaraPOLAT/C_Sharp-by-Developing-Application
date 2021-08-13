using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBuffetSaleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int safeTotal=0;
        private void button1_Click(object sender, EventArgs e)
        {
            int corn, tea, water, sale, sum;
            corn = Convert.ToInt16(TxtCorn.Text);
            water = Convert.ToInt16(TxtWater.Text);
            tea = Convert.ToInt16(TxtTea.Text);
            sale = Convert.ToInt16(TxtSale.Text);

            sum = corn * 4 + tea *3 +water *2 +sale *10;
            lblTotal.Text = "Total: "+sum+"£";
            safeTotal = safeTotal + sum;
            lblSafe.Text = "Safe: "+safeTotal+"£";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtCorn.Text = "";
            TxtSale.Text = "";
            TxtTea.Text = "";
            TxtWater.Text = "";
            TxtCorn.Focus();
        }
    }
}
