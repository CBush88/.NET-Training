using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebAppDemo
{
    public partial class SecondPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label5.Text = "Hello " + TextBox1.Text + ". Your age is " + TextBox2.Text + ". Your location is " + TextBox3.Text + ". " + "You are a " + ((RadioButton1.Checked)? "Male" : "Female") + " with a " + DropDownList1.Text + " degree.";
        }
    }
}