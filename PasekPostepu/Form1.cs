using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasekPostepu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                progressBar1.PerformStep();
                string napis = $"{i} ";
                richTextBox1.Text += napis;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            progressBar1.Value = 0;
        }
    }
}
