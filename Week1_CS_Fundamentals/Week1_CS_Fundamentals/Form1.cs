using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1_CS_Fundamentals
{
    public partial class Form1 : Form
    {
        bool answer;
        char firstChar;
        string[] fortunes = new string[15]
        {
            "You will be very sleepy today.",
            "If you play the lottery, you will lose.",
            "Today will be a sunny day.",
            "Rain will follow you wherever you go.",
            "A new love will present itself to you.",
            "Old passions will be rekindled.",
            "You will make a new friend.",
            "Today will be very similar to yesterday.",
            "Tomorrow will come two days after yesterday.",
            "If at first you don't succeed, re-evaluate your goals.",
            "Coming up with 15 options is surprisingly hard to do.",
            "Today, you will come up with a new idea.",
            "Yesterday will only have happened once.",
            "I've got to be close to done by now.",
            "Not all fortunes can be winners."
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                button1.Enabled = false;
            }
            else
            {
                Form2 form2 = new Form2(textBox1.Text, this);
                form2.Visible = true;
            }
        }
        public void verify(bool response)
        {
            answer = response;
            if (answer)
            {
                firstChar = textBox1.Text[0];
                label2.Text = $"Your fortune is: {fortunes[firstChar % 15]}";
                label2.Visible = true;
            }
            else
            {
                textBox1.Text = "";
                label2.Text = "";
                label2.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
