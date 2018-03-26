using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "6,251";
            textBox2.Text = "0,827";
            textBox3.Text = "25,001";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);
            double a,c,d,f,g,h,j,k,l,m,n,b;
          //-----------------------------------------
            a = Math.Round(Math.Pow(Math.Sin(x), 2),4);
            c = Math.Round(Math.Sqrt(x + y),4);
            d = Math.Round(1 + a/c,4);
            f = Math.Round(Math.Abs(x - y),4);
            g = Math.Round(f * d,4);
          //-----------------------------------------
            h = Math.Round((Math.Pow(Math.E,(x-y))) + x/2,4);
          //-----------------------------------------
            j = Math.Round(g / h,4);
          //-----------------------------------------
            k = Math.Round(Math.Pow(Math.Cos(y), 2),4);
          //-----------------------------------------
            l = Math.Round(j * k,4);
          //-----------------------------------------
            m = Math.Round(Math.Pow(Math.Abs(x), 1 / 3),4);
          //-----------------------------------------
            n =Math.Round( Math.Pow(y, m),4);
          //-----------------------------------------
            b = Math.Round(l + n,4);

            textBox4.Text = Convert.ToString(b);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
