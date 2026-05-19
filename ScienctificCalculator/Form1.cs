using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienctificCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double output;
        double firstnumber;
        string choice;
        bool calcptr = false;

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || calcptr)
            {
                textBox.Clear();
            }
            calcptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else
            {
                textBox.Text += button.Text;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            firstnumber = double.Parse(textBox.Text);
            Button Optr = (Button)sender;
            choice = Optr.Text;
            calcptr = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int ind = textBox.Text.Length;
            ind--;
            textBox.Text = textBox.Text.Remove(ind);
            if (textBox.Text == "")
            {
                textBox.Text = "0";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            output = double.Parse(textBox.Text);
            output = output * -1;
            textBox.Text = output.ToString();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            switch (choice)
            {
                case "+":
                    textBox.Text = (firstnumber + double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (firstnumber - double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (firstnumber * double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    textBox.Text = (firstnumber / double.Parse(textBox.Text)).ToString();
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox.Text =Math.PI.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            output = double.Parse(textBox.Text);
            output = Math.Log10(output);
            textBox.Text = output.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            output = double.Parse(textBox.Text);
            output = Math.Sqrt(output);
            textBox.Text = output.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            output = double.Parse(textBox.Text);
            output = Math.Pow(output, 2);
            textBox.Text = output.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            output = double.Parse(textBox.Text);
            output = Math.Pow(output, 3);
            textBox.Text = output.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            output = double.Parse(textBox.Text);
            output = 1 / output;
            textBox.Text = output.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            output = double.Parse(textBox.Text);
            output = Math.Log(output);
            textBox.Text = output.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            output = double.Parse(textBox.Text);
            output = output / 100;
            textBox.Text = output.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            output = double.Parse(textBox.Text);
            output = Math.Sin(output);
            textBox.Text = output.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            output = double.Parse(textBox.Text);
            output = Math.Sinh(output);
            textBox.Text = output.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            output = double.Parse(textBox.Text);
            output = Math.Cos(output);
            textBox.Text = output.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            output = double.Parse(textBox.Text);
            output = Math.Cosh(output);
            textBox.Text = output.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            output = double.Parse(textBox.Text);
            output = Math.Tan(output);
            textBox.Text = output.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            output = double.Parse(textBox.Text);
            output = Math.Tanh(output);
            textBox.Text = output.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            output = double.Parse(textBox.Text);
            output = Math.Ceiling(output);
            textBox.Text = output.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            output = double.Parse(textBox.Text);
            output = Math.Floor(output);
            textBox.Text = output.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            output = double.Parse(textBox.Text);
            output = Math.Exp(output);
            textBox.Text = output.ToString();
        }
    }
}
