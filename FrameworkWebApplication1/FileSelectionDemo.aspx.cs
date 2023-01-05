using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrameworkWebApplication1
{
    public partial class FileSelectionDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string dirPath = Server.MapPath("~/Uploads/");
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            Session["UploadDirectory"] = dirPath;
            Session["FileToUploadName"] = Path.GetFileName(FileUpload1.FileName);
            byte[] bytes = new byte[FileUpload1.FileContent.Length];
            for (int i = 0; i < FileUpload1.FileContent.Length; i++)
            {
                bytes[i] = (byte)FileUpload1.FileContent.ReadByte();
            }
            Session["FileContent"] = bytes;
            Response.Redirect("UploadSelectedFileDemo.aspx");
        }
    }
}