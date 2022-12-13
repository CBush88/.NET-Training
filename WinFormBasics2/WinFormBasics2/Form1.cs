using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormBasics2
{
    public partial class Form1 : Form
    {
        Button[] colorButtons = new Button[10];
        int buttonIndex = 0;
        bool initialized = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            label4.Text = hScrollBar1.Value.ToString();
            label5.Text = hScrollBar2.Value.ToString();
            label6.Text = hScrollBar3.Value.ToString();
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            label4.Text= "";
            label5.Text= "";
            label6.Text= "";
            label7.Text = "";
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            label7.Location = new Point(e.X + 10, e.Y + 10);
            label7.Text = $"{hScrollBar1.Value.ToString()},{hScrollBar2.Value.ToString()},{hScrollBar3.Value.ToString()}";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!initialized)
            {
                colorButtons[buttonIndex] = new Button();
                colorButtons[buttonIndex].Click += new EventHandler(colorButton_Click);
            }

            colorButtons[buttonIndex].Location = button1.Location;
            colorButtons[buttonIndex].Top += (buttonIndex * 20);
            colorButtons[buttonIndex].BackColor = panel1.BackColor;
            colorButtons[buttonIndex].Size = button1.Size;

            this.Controls.Add(colorButtons[buttonIndex]);
            buttonIndex++;

            if(buttonIndex >= 10)
            {
                initialized=true;
                buttonIndex = 0;
            }
            //button1.BackColor = panel1.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void colorButton_Click(object sender, EventArgs e)
        {
            panel1.BackColor = ((Button)sender).BackColor;
        }
    }
}
