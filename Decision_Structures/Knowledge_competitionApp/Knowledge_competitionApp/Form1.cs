using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knowledge_competitionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int question_no = 0, correct = 0,wrong=0;

       

        private void btnNext_Click(object sender, EventArgs e)
        {

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnNext.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            question_no++;
            lblQN.Text = question_no.ToString();
            if(question_no==1)
            {
                richTextBox1.Text = "In what year was the republic declared?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label4.Text = "1923";
               
            }
             if (question_no == 2)
            {
                richTextBox1.Text = "Which city is not found in the Aegean region?";
                btnA.Text = "İzmir";
                btnB.Text = "Balıkesir";
                btnC.Text = "Aydın";
                btnD.Text = "Manisa";
                label4.Text = "Balıkesir";
           
            }
            if (question_no == 3)
            {
                richTextBox1.Text = "The last birds belong to which author?";
                btnA.Text = "Sait Faik";
                btnB.Text = "Cemal Süreya";
                btnC.Text = "Attila İlhan";
                btnD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                btnNext.Text = "Results";
    
            }
            if(question_no==4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnNext.Enabled = false;
                MessageBox.Show("Correct: "+correct+" Wrong: "+wrong);
            }
           

        }

      

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;
            label5.Text = btnA.Text;
            if(label5.Text==label4.Text)
            {
                correct++;
                lblCorrect.Text = correct.ToString();
                pictureBox1.Visible=true;
            }
            else
            {
                wrong++;
                lblWrong.Text = wrong.ToString();
                pictureBox2.Visible = true;
;
            }
        }

       

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;
            label5.Text = btnB.Text;
            if (label5.Text == label4.Text)
            {
                correct++;
                lblCorrect.Text = correct.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wrong++;
                lblWrong.Text = wrong.ToString();
                pictureBox2.Visible = true;
                ;
            }
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;
            label5.Text = btnC.Text;
            if (label5.Text == label4.Text)
            {
                correct++;
                lblCorrect.Text = correct.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wrong++;
                lblWrong.Text = wrong.ToString();
                pictureBox2.Visible = true;
                ;
            }
        }
        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnNext.Enabled = true;
            label5.Text = btnD.Text;
            if (label5.Text == label4.Text)
            {
                correct++;
                lblCorrect.Text = correct.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                wrong++;
                lblWrong.Text = wrong.ToString();
                pictureBox2.Visible = true;
                ;
            }
        }
    }
}
