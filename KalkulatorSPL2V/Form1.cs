using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorSPL2V
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_hitung_Click(object sender, EventArgs e)
        {
            int a, b, p, q, c, r, det;

            a = Int32.Parse(textBox_A.Text);
            b = Int32.Parse(op1.Text + textBox_B.Text);
            p = Int32.Parse(textBox_P.Text);
            q = Int32.Parse(op2.Text + textBox_Q.Text);
            c = Int32.Parse(textBox_H1.Text);
            r = Int32.Parse(textBox_H2.Text);

            det = a * q - b * p;
            int Dx = c * q - b * r;
            int Dy = a * r - c * p;

            float x =(float) Dx / det;
            float y = (float) Dy / det;
            hx.Text = x. ToString();
            hy.Text = y.ToString();

        }
        private void op1_Click(object sender, EventArgs e)
        {
            if (op1.Text == "+")
            {
                op1.Text = "-";
            }
            else op1.Text = "+";
        }

        private void op2_Click(object sender, EventArgs e)
        {
            if (op2.Text == "+")
            {
                op2.Text = "-";
            }
            else op2.Text = "+";
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_A.Text = textBox_B.Text = textBox_P.Text = textBox_Q.Text = textBox_H1.Text = textBox_H2.Text = hx.Text = hy.Text = textBox_naX.Text = textBox_naY.Text = naX.Text = naY.Text= total.Text="";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, p, q;
            a = Int32.Parse(hx.Text);
            b = Int32.Parse(hy.Text);
            p = Int32.Parse(textBox_naX.Text);
            q = Int32.Parse(textBox_naY.Text);

            int x = a * p;
            int y = b * q;

            naX.Text = x.ToString();
            naY.Text = y.ToString();

            total.Text = (x + y).ToString();
           
        }
    }
}
