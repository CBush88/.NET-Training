using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        char operation = ' ';
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double current = double.Parse(label1.Text);
            current *= 10;
            current += 1;
            label1.Text = current.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double current = double.Parse(label1.Text);
            current *= 10;
            current += 2;
            label1.Text = current.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double current = double.Parse(label1.Text);
            current *= 10;
            current += 3;
            label1.Text = current.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double current = double.Parse(label1.Text);
            current *= 10;
            current += 4;
            label1.Text = current.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double current = double.Parse(label1.Text);
            current *= 10;
            current += 5;
            label1.Text = current.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double current = double.Parse(label1.Text);
            current *= 10;
            current += 6;
            label1.Text = current.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double current = double.Parse(label1.Text);
            current *= 10;
            current += 7;
            label1.Text = current.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double current = double.Parse(label1.Text);
            current *= 10;
            current += 8;
            label1.Text = current.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double current = double.Parse(label1.Text);
            current *= 10;
            current += 9;
            label1.Text = current.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double current = double.Parse(label1.Text);
            current *= 10;
            current += 0;
            label1.Text = current.ToString();
        }

        private void addition_Click(object sender, EventArgs e)
        {
            operation = '+';
            label2.Text = label1.Text;
            label3.Text = operation.ToString();
            label1.Text = "0";
        }

        private void subraction_Click(object sender, EventArgs e)
        {
            operation = '-';
            label2.Text = label1.Text;
            label3.Text = operation.ToString();
            label1.Text = "0";
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            operation = '*';
            label2.Text = label1.Text;
            label3.Text = operation.ToString();
            label1.Text = "0";
        }

        private void division_Click(object sender, EventArgs e)
        {
            operation = '/';
            label2.Text = label1.Text;
            label3.Text = operation.ToString();
            label1.Text = "0";
        }

        private void enter_Click(object sender, EventArgs e)
        {
            double label1double = double.Parse(label1.Text);
            double label2double = double.Parse(label2.Text);

            switch (operation)
            {
                case ('+'):
                    label1.Text = (label1double + label2double).ToString();
                    label2.Text = "";
                    label3.Text = "";
                    break;
                case ('-'):
                    label1.Text = (label1double - label2double).ToString();
                    label2.Text = "";
                    label3.Text = "";
                    break;
                case ('*'):
                    label1.Text = (label1double * label2double).ToString();
                    label2.Text = "";
                    label3.Text = "";
                    break;
                case('/'):
                    label1.Text = (label2double / label1double).ToString();
                    label2.Text = "";
                    label3.Text = "";
                    break;
                default:
                    break;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
