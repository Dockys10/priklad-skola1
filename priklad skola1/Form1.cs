using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace priklad_skola1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int fak = 1;
            for(int i=2;i<=n;i++)
            {
                fak *= i;
            }
            label1.Text = "faktorial je " + fak;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);
            int naN = 1;
            for(int i=0;i<n;i++)
            {
                naN *= a;
            }
            label2.Text = "a na n je " + naN;
        }
    }
}
