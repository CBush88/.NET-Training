using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Create a Windows Application to get an application form filled for a Job

//The common fields would be
//Name of the candidate
//ID
//Address
//Phone Number
//Qualification
//Major Subjects
//Percentage
//Grade
//Blood Group
//Date of Birth
//Decide the data types for the Candidate's fields (Create Model)
//Create user defined exceptions for at least two fields
//Raise exception through the model where the values are set
//Must give pop up message to the user on click of the submit button about the invalid data

namespace Project_AdvancedCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            //Candidate candidate = new Candidate();
            try
            {
                Candidate candidate = new Candidate(tb_name.Text, int.Parse(tb_id.Text),
                    tb_address.Text, tb_phone.Text, tb_qualification.Text, tb_major.Text,
                    float.Parse(tb_gpa.Text), tb_blood_group.Text, tb_dob.Text);
                label1.Text = candidate.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
