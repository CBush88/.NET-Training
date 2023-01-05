using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrameworkWebApplication1
{
    public partial class SubmitData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //1st Using Querystring
            //Response.Redirect("ShowData.aspx?Data=" + TextBox1.Text);

            //2nd Using Cookies
            //HttpCookie cookie = new HttpCookie("DataInCookie");
            //cookie.Value = TextBox1.Text;
            //cookie.Expires = DateTime.Now.AddHours(1);
            //Response.Cookies.Add(cookie);
            //Response.Redirect("ShowData.aspx");

            //3rd Using Application Object accessible by all users, global
            //Application["Data"] = TextBox1.Text;
            //Response.Redirect("ShowData.aspx");

            //4th Using Session Object
            Session["Data"] = TextBox1.Text;
            Response.Redirect("ShowData.aspx");
        }
    }
}