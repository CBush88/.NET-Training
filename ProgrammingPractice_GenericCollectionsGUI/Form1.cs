using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//As per the code implementation using Shape class and other representations of Shape 

//Try to create a generic list (collection) of objects catering all the types of Shape representations 

//e.g. Use System.Collections.Generic.List class

namespace ProgrammingPractice_GenericCollectionsGUI
{
    public partial class Form1 : Form
    {
        List<Shape> shapes = new List<Shape>();
        string type;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Base: ";
            label3.Text = "Height: ";
            VisibilityOn();
            type = "triangle";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Width: ";
            label3.Text = "Length: ";
            VisibilityOn();
            type = "rectangle";
        }

        private void VisibilityOn()
        {
            label2.Visible = true;
            label3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button3.Visible= true;
        }
        private void VisibilityOff()
        {
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button3.Visible= false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);

            switch (type)
            {
                case ("triangle"):
                    shapes.Add(new Triangle(x, y));
                    break;
                case ("rectangle"):
                    shapes.Add(new Rectangle(x, y));
                    break;
            }
            VisibilityOff();
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = string.Empty;
            foreach(Shape shape in shapes)
            {
                label4.Text += shape.GetType().Name + " " + shape.ToString() + "\n";
            }
        }
    }
}
