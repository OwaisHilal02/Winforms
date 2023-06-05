using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BMIcalculator
{
    public partial class Form2 : Form
    {
        public double BMI;
        public  string name;
        public int X;
        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1()
            { MdiParent = MdiParent };
            this.Hide();
            Form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BMI = Form1.BMI;
            this.name = Form1.name;
            this.X = Form1.X;
            if (X == 0)
            {
                if (BMI < 18.5) { listBox1.Items.Add("Dear "+name +"Your BMI is " + BMI + "\nYour're Underweight"); }
                else if (BMI >= 18.5 && BMI <= 24.9) { listBox1.Items.Add("Dear " + name + "Your BMI is " + BMI + "\nYour're Normal weight"); }
                else if (BMI >= 25 && BMI <= 29.5) { listBox1.Items.Add("Dear " + name + "Your BMI is " + BMI + "\nYour're Overweight"); }
                else { listBox1.Items.Add("Dear " + name + "Your BMI is " + BMI + "\nYour're Obese"); }
            }
            if (X == 1)
            {
                if (BMI < 16.5) { listBox1.Items.Add("Dear " + name + "Your BMI is " + BMI + "\nYour're Underweight"); }
                else if (BMI >= 16.5 && BMI <= 22.9) { listBox1.Items.Add("Dear " + name + "Your BMI is " + BMI + "\nYour're Normal weight"); }
                else if (BMI >= 23 && BMI <= 27.9) { listBox1.Items.Add("Dear " + name + "Your BMI is " + BMI + "\nYour're Overweight"); }
                else { listBox1.Items.Add("Dear " + name + "Your BMI is " + BMI + "\nYour're Obese"); }
            }
        }
    }
}
