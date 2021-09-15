using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMigrationBetweenForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       public string message;
        public string from_who;
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = message;
            label2.Text = from_who;
        }
    }
}
