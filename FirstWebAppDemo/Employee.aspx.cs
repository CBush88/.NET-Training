using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebAppDemo
{
    public partial class Employee : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-4R12Q4C8;Initial Catalog=TestDB;Integrated Security=True");
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //using connected architecture
            con.Open();
            cmd = new SqlCommand("select * from Employee", con);
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource= dr;
            GridView1.DataBind();
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into employee values(@empId, @empName, @empDesignation, @empSalary, @empLocation)", con);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.AddWithValue("@empId", int.Parse(TextBox1.Text));
            cmd.Parameters.AddWithValue("@empName", TextBox2.Text);
            cmd.Parameters.AddWithValue("@empDesignation", TextBox3.Text);
            cmd.Parameters.AddWithValue("@empSalary", double.Parse(TextBox4.Text));
            cmd.Parameters.AddWithValue("@empLocation", TextBox5.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            Label6.Text = "New Employee Added";
        }
    }
}