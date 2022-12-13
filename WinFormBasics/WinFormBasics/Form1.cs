using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBasics
{
    public partial class Form1 : Form
    {
        Color previousColor;
        bool directionLeft;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(int.Parse(textBox1.Text) + int.Parse(textBox2.Text));
        }

        private void gotFocus(object sender, EventArgs e)
        {
            previousColor = Addition.BackColor;
            Addition.BackColor = Color.Aqua;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Addition.BackColor = previousColor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(int.Parse(textBox1.Text) + 1);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "";
            pictureBox1.Image = null;
            //pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Thank you for using the Application.");
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Left = 0;
            label2.Text = DateTime.Now.ToString();
            label2.AutoSize= true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (directionLeft)
            {
            label2.Left += 5;
                if(label2.Left >= this.Width - label2.Width)
                {
                    directionLeft = false;
                }
            }else
            {
                label2.Left -= 5;
                if(label2.Left <= 0)
                {
                    directionLeft = true;
                }
            }
        }
    }
}
