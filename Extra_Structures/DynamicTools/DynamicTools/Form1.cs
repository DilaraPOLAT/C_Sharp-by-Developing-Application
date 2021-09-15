using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnLoc = new Point(20,10);
            btn.Location = btnLoc;
            btn.Name = "Button1";
            btn.Text = "Click";
            btn.BackColor = Color.Green;
            btn.Height = 50;
            btn.Width = 75;
            

            Label lbl = new Label();
            Point lblLoc = new Point(250,25);
            lbl.Location = lblLoc;
            lbl.Name = "Label1";
            lbl.Text = "Hello";
            lbl.BackColor = Color.HotPink;
            lbl.AutoSize = true;
            this.Controls.Add(lbl);
            this.Controls.Add(btn);

            
            for (int i=0; i<= 5;i++)
            {
                TextBox tbx = new TextBox();
                Point tbxLoc = new Point(300,i*20);
                tbx.Location = tbxLoc;
                tbx.Name = "Textbox" + i;
                tbx.BackColor = Color.YellowGreen;
                tbx.Text = i.ToString();
                this.Controls.Add(tbx);

            }





        }
    }
}
