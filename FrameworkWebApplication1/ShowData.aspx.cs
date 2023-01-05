using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrameworkWebApplication1
{
    public partial class ShowData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //1st Using QueryString
            //string info = Request.QueryString["Data"];
            //Label1.Text = info;
            //Response.Write(info);

            //2nd Using Cookies
            //if (Request.Cookies["DataInCookie"] != null)
            //{
            //    string info1 = Request.Cookies["DataInCookie"].Value;
            //    Response.Write(info1);
            //    Label1.Text = info1;
            //}

            //3rd Using Application Object
            //if (Application["Data"] != null)
            //{
            //    string info2 = Application["Data"].ToString();
            //    Response.Write("<h1>" + info2 + "</h1>");
            //    Label1.Text = info2;
            //}

            if (Session["Data"] != null)
            {
                string info3 = Session["Data"].ToString();
                Response.Write("<h1>" + info3 + "</h1");
                Label1.Text = info3;
            }
        }
    }
}