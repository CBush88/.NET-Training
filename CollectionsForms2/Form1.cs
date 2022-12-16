using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Create a form based windows application 

//Create one form with options with buttons to select List, Dictionary, HashSet 

//Create another button to display, add and remove or change the elements from the selected collection 

//Adding,

namespace CollectionsForms2
{
    public enum Options
    {
        List, Dictionary, HashSet
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(Options.List);
            f.Show();
        }

        private void btn_dictionary_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(Options.Dictionary);
            f.Show();
        }

        private void btn_hashset_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(Options.HashSet);
            f.Show();
        }
    }
}
