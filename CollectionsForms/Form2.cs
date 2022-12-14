using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsForms
{
    public partial class Form2 : Form
    {
        ArrayList list;
        Stack stack;
        Queue queue;

        Form1.Options type;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1.Options option)
        {
            InitializeComponent();
            this.type = option;
            switch(this.type)
            {
                case Form1.Options.ArrayList:
                    list = new ArrayList();
                    break;
                case Form1.Options.Stack:
                    stack = new Stack();
                    break;
                case Form1.Options.Queue:
                    queue = new Queue();
                    break;
                default: 
                    break;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            switch(this.type)
            {
                case Form1.Options.ArrayList:
                    this.list.Add(text);
                    break;
                case Form1.Options.Stack:
                    this.stack.Push(text);
                    break;
                case Form1.Options.Queue:
                    this.queue.Enqueue(text);
                    break;
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            switch(this.type)
            {
                case Form1.Options.ArrayList:
                    this.list.Remove(textBox1.Text);
                    break;
                case Form1.Options.Stack:
                    this.stack.Pop();
                    break;
                case Form1.Options.Queue:
                    this.queue.Dequeue();
                    break;
            }
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            switch (this.type)
            {
                case Form1.Options.ArrayList:
                    foreach(var item in this.list)
                    {
                        label1.Text += item + "\n";
                    }
                    break;
                case Form1.Options.Stack:
                    foreach(var item in this.stack)
                    {
                        label1.Text += item + "\n";
                    }
                    break;
                case Form1.Options.Queue:
                    foreach(var item in this.queue)
                    {
                        label1.Text += item + "\n";
                    }
                    break;
            }
        }
    }
}
