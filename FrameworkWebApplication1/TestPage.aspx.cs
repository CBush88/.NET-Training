using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrameworkWebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static ArrayList list = new ArrayList();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string description = TextBox2.Text;

            list.Add(new Person(name, description));

            Output.Text = "";
            foreach(Person item in list)
            {
                Output.Text += item.Name + " " + item.Description + "<br/>";
            }
        }
    }
}