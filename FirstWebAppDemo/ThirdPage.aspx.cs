using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebAppDemo
{
    public partial class ThirdPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> qualifications = new List<string>();
            if(CheckBox1.Checked)
            {
                qualifications.Add("Prior Technical Experience");
            }
            if(CheckBox2.Checked)
            {
                qualifications.Add("Prior Managerial Experience");
            }
            if(CheckBox3.Checked)
            {
                qualifications.Add("An undergraduate degree");
            }
            if(CheckBox4.Checked)
            {
                qualifications.Add("A graduate degree");
            }
            Label5.Text = "Hello " + TextBox1.Text + ". You have " + TextBox2.Text + " years of experience. " + ((qualifications.Count > 0) ? "Your qualifications include: " + string.Join(", ", qualifications) + "." : "");
        }
    }
}