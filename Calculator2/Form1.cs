using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        char op = ' ';
        double mem = 0;

        private void numberButton(int num)
        {
            double total = double.Parse(label1.Text);
            total *= 10;
            total += num;
            label1.Text = total.ToString();
        }

        private void operatorButton(char op)
        {
            this.op = op;
            mem = double.Parse(label1.Text);
            label1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numberButton(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numberButton(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numberButton(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numberButton(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numberButton(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            numberButton(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            numberButton(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            numberButton(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numberButton(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            numberButton(0);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operatorButton('-');
        }

        private void plus_Click(object sender, EventArgs e)
        {
            operatorButton('+');
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            operatorButton('*');
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operatorButton('/');
        }

        private void enter_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case ('-'):
                    label1.Text = (mem - double.Parse(label1.Text)).ToString();
                    mem = 0;
                    break;
                case ('+'):
                    label1.Text = (mem + double.Parse(label1.Text)).ToString();
                    mem = 0;
                    break;
                case ('*'):
                    label1.Text = (mem * double.Parse(label1.Text)).ToString();
                    mem = 0;
                    break;
                case ('/'):
                    label1.Text = (mem / double.Parse(label1.Text)).ToString();
                    mem = 0;
                    break;
                default:
                    break;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            mem = 0;
        }
    }
}
