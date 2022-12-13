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
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(string text, Form1 form1)
        {
            InitializeComponent();
            label1.Text = $"Is the name {text} correct?";
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.verify(true);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.verify(false);
            Close();
        }
    }
}
