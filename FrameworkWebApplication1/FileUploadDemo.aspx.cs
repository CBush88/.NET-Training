using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrameworkWebApplication1
{
    public partial class FileUploadDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string filePath = Server.MapPath("~/Uploads/");

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            FileUpload1.SaveAs(filePath + Path.GetFileName(FileUpload1.FileName));
            Label1.Text = "File Uploaded Successfully!";
        }
    }
}