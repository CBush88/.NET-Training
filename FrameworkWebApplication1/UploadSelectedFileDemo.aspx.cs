using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrameworkWebApplication1
{
    public partial class UploadSelectedFileDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Upload " + Session["FileToUploadName"] + "?";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists((string)Session["UploadDirectory"]))
            {
                Directory.CreateDirectory((string)Session["UploadDirectory"]);
            }
            File.WriteAllBytes((string)Session["UploadDirectory"] + (string)Session["FileToUploadName"], (byte[])Session["FileContent"]);
            Response.Redirect("FileSelectionDemo.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("FileSelectionDemo.aspx");
        }
    }
}