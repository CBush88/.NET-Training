using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsForms2
{
    public partial class Form3 : Form
    {
        Form2 f2;
        public Form3(Form2 f2, string text)
        {
            InitializeComponent();
            textBox1.Text = text;
            this.f2 = f2;
            if(f2.option == Options.HashSet)
            {
                btn_all.Visible= false;
                btn_cancel.Location = btn_all.Location;
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            f2.ChangeFirst(textBox1.Text, textBox2.Text);
            this.Close();
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            f2.ChangeAll(textBox1.Text, textBox2.Text);
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
