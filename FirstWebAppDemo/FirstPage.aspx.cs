using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebAppDemo
{
    public partial class FirstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Request type is: " + Request.RequestType);

            if(!IsPostBack)
            {
                DropDownList1.Items.Add("Red");
                DropDownList1.Items.Add("Yellow");
                DropDownList1.Items.Add("Black");
                DropDownList1.Items.Add("Green");
            }
        }
    }
}