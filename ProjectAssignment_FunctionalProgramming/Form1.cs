using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//Create windows form application for University Student Registration Process. 

//Add different control to accept student information such as FirstName, LastName,
//Age, subjects or courses interested in, gender, etc. 

//Validate the information. 

//Use functional programming concept like LAMBDA expression , multithreading in the application. 

//Create class with respective properties to store student information in object collection
//of class. 

//Use lambda expression to query the data through the collection. 

//Add different processes like approving the admission to the course depending upon score
//or grades respectively. 

namespace ProjectAssignment_FunctionalProgramming
{
    public partial class Form1 : Form
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        Gender Gender { get; set; }
        double GPA { get; set; }

        List<Applicant> applicants = new List<Applicant>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateData();
                Thread valueThread = new Thread(GetValues);
                valueThread.Start();
                valueThread.Join();

                applicants.Add(new Applicant(FirstName, LastName, Age, Gender, GPA));

                reInit();

                button2.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Applicant> accepted;
            List<Applicant> rejected;
            accepted = applicants.FindAll(x => x.GPA >= 3.0);
            rejected = applicants.FindAll(x => x.GPA < 3.0);

            lbl_accepted.Text = "Accepted: ";
            lbl_rejected.Text = "Rejected: ";

            accepted.ForEach(x => lbl_accepted.Text += ("\n" + x.ToString()) + "\n");
            rejected.ForEach(x => lbl_rejected.Text += ("\n" + x.ToString()) + "\n");

            button2.Enabled = false;

        }
        private void GetValues()
        {
            try
            {
                FirstName = tb_first_name.Text;
                LastName = tb_last_name.Text;
                Age = int.Parse(tb_age.Text);
                GPA = double.Parse(tb_gpa.Text);

                if (rb_f.Checked)
                {
                    Gender = Gender.Female;
                }
                else if (rb_m.Checked)
                {
                    Gender = Gender.Male;
                }
                else
                {
                    Gender = Gender.No_Response;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ValidateData()
        {
            Regex names = new Regex(@"[a-zA-Z]+");
            Regex age = new Regex(@"[0-9]+");
            Regex GPA = new Regex(@"[0-9].[0-9]{1,2}");
            if (!names.IsMatch(tb_first_name.Text))
            {
                throw new ArgumentException("First name should be all letters and not blank");
            }
            else if (!names.IsMatch(tb_last_name.Text))
            {
                throw new ArgumentException("Last name should be all letters and not blank");
            }
            else if (!age.IsMatch(tb_age.Text)
                     || int.Parse(tb_age.Text) < 16
                     || int.Parse(tb_age.Text) > 100)
            {
                throw new ArgumentException("Please enter a valid age");
            }
            else if (!GPA.IsMatch(tb_gpa.Text))
            {
                throw new ArgumentException("Please enter a valid GPA");
            }
            else if (!(rb_f.Checked || rb_m.Checked || rb_n.Checked))
            {
                throw new ArgumentException("Plese select a gender option");
            }
            else
            {
                return;
            }
        }
        private void reInit()
        {
            tb_first_name.Text = string.Empty;
            tb_last_name.Text = string.Empty;
            tb_age.Text = string.Empty;
            tb_gpa.Text = string.Empty;
            rb_f.Checked = false;
            rb_m.Checked = false;
            rb_n.Checked = false;
        }
    }
}
