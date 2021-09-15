using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Text_Document
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dosyaAdi, dosyaYolu;
        StreamWriter sw;
        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                dosyaYolu = folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = dosyaYolu;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dosyaAdi = textBox2.Text;
            sw = File.CreateText(dosyaYolu+"\\"+dosyaAdi+".txt");
            sw.Close();
        }

        
    }
}
