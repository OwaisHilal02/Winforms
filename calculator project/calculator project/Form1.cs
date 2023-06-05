using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_project
{
    public partial class Form1 : Form
    {
        string opr = " ";
        double res;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            textBox1.Text += btn0.Text;
        }

        private void btmDot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            if (btmDot.Text == ".") { 
            if (!textBox1.Text.Contains(".")) { textBox1.Text += btmDot.Text; }
            }
            else { textBox1.Text += btmDot.Text; }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            textBox1.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            textBox1.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            textBox1.Text += btn9.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            textBox1.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            textBox1.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            textBox1.Text += btn6.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            textBox1.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            textBox1.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            textBox1.Text += btn3.Text; 
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label2.Text = "";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            opr = btndiv.Text;
            res = Convert.ToDouble(textBox1.Text);
            label2.Text = textBox1.Text + " " + opr;
            textBox1.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            opr = btnMul.Text;
            res = Convert.ToDouble(textBox1.Text);
            label2.Text = textBox1.Text + " " + opr;
              textBox1.Clear();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            opr = btnSub.Text;
            res = Convert.ToDouble(textBox1.Text);
            label2.Text = textBox1.Text + " " + opr;
            textBox1.Clear();
        }

        private void brnSum_Click(object sender, EventArgs e)
        {
            opr = brnSum.Text;
            res = Convert.ToDouble(textBox1.Text);
            label2.Text = textBox1.Text + " " + opr;
            textBox1.Clear();
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            switch(opr)
            {
                case "+":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (res + y).ToString();
                        label2.Text = "";
                    }break;

                case "-":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (res - y).ToString();
                        label2.Text = "";
                    }break;
                   
                case "*":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (res * y).ToString();
                        label2.Text = "";
                    } break;

                case "/":
                    {
                        double y = Convert.ToDouble(textBox1.Text);
                        textBox1.Text = (res / y).ToString();
                        label2.Text = "";
                    }break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
