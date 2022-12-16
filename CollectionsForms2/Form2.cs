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
    public partial class Form2 : Form
    {
        List<string> list;
        Dictionary<int, string> dict;
        HashSet<string> set;
        int dictIndex = 0;
        public Options option;

        public Form2(Options option)
        {
            InitializeComponent();
            this.option = option;
            switch (option)
            {
                case (Options.List):
                    list = new List<string>();
                    break;
                case (Options.Dictionary):
                    dict = new Dictionary<int, string>();
                    break;
                case Options.HashSet:
                    set = new HashSet<string>();
                    break;
                default:
                    break;
            }
        }

        public void ChangeFirst(string text1, string text2)
        {
            switch(option)
            {
                case Options.List:
                    for(int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == text1)
                        {
                            list[i] = text2;
                            break;
                        }
                    }
                    break;
                case Options.Dictionary:
                    foreach(int key in dict.Keys)
                    {
                        if (dict[key].Equals(text1))
                        {
                            dict[key] = text2;
                            break;
                        }
                    }
                    break;
                case Options.HashSet:
                    if (set.Contains(text1))
                    {
                        set.Remove(text1);
                        set.Add(text2);
                    }
                    break;
            }
        }

        public void ChangeAll(string text1, string text2)
        {
            switch (option)
            {
                case Options.List:
                    for(int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == text1)
                        {
                            list[i] = text2;
                        }
                    }
                    break;
                case Options.Dictionary:
                    List<int> keysToChange = new List<int>();
                    foreach(int key in dict.Keys)
                    {
                        if (dict[key].Equals(text1))
                        {
                            keysToChange.Add(key);
                        }
                    }
                    foreach (int key in keysToChange)
                    {
                        dict[key] = text2;
                    }
                    break;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            switch(option)
            {
                case Options.List:
                    list.Add(text);
                    break;
                case Options.Dictionary:
                    dict.Add(dictIndex++, text);
                    break;
                case Options.HashSet:
                    set.Add(text);
                    break;
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            switch (option)
            {
                case(Options.List): 
                    list.Remove(text);
                    break;
                case (Options.Dictionary):
                    foreach(KeyValuePair<int, string> item in dict)
                    {
                        if (item.Value == text)
                        {
                            dict.Remove(item.Key);
                            break;
                        }
                    }
                    break;
                case (Options.HashSet):
                    set.Remove(text);
                    break;
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this, textBox1.Text);
            f3.Show();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            switch (option)
            {
                case Options.List:
                    foreach(string item in list)
                    {
                        label1.Text += item + "\n";
                    }
                    break;
                case Options.Dictionary:
                    foreach(KeyValuePair<int, string> item in dict)
                    {
                        label1.Text += $"{item.Key}: {item.Value}\n";
                    }
                    break;
                case Options.HashSet:
                    foreach(string item in set)
                    {
                        label1.Text += item + "\n";
                    }
                    break;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            switch (option)
            {
                case Options.List:
                    list.Clear();
                    break;
                case Options.Dictionary:
                    dict.Clear();
                    break;
                case Options.HashSet:
                    set.Clear();
                    break;
            }
        }
    }
}
