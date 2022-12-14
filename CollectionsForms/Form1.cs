using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsForms
{
    public partial class Form1 : Form
    {
        public enum Options
        {
            ArrayList, Stack, Queue
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_arraylist_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(Options.ArrayList);
            f.Show();
        }

        private void btn_stack_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(Options.Stack);
            f.Show();
        }

        private void btn_queue_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(Options.Queue);
            f.Show();
        }
    }
}
