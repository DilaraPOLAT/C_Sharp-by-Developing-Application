using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightTicketReservationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota:" + comboBox1.Text + "-" + comboBox2.Text+" "+"Date:"+dateTimePicker1.Text+" "+"Clock:"+maskedTextBox1.Text+" "+"Passenger Information ~ Name_Surname:"+textBox1.Text+" "+"TC:"+maskedTextBox2.Text+" "+"Telephone:"+maskedTextBox3.Text);
            MessageBox.Show("Passenger Registered");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String value = comboBox1.Text;
            comboBox1.Text=comboBox2.Text;
            comboBox2.Text=value;
        }
    }
}
