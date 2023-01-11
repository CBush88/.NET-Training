using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_DB_Management
{
    public partial class Students : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-4R12Q4C8;Initial Catalog=TestDB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select * from Student", con);
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource= dr;
            GridView1.DataBind();
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource= ds;
            GridView1.DataBind();
            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into Student values(@stdId, @stdName, @stdCourse)", con);
            cmd.CommandType= CommandType.Text;
            cmd.Parameters.AddWithValue("@stdId", int.Parse(TextBox1.Text));
            cmd.Parameters.AddWithValue("@stdName", TextBox2.Text);
            cmd.Parameters.AddWithValue("@stdCourse", TextBox3.Text);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("Select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Student");
            SqlCommandBuilder cmdr = new SqlCommandBuilder(da);
            DataRow dr = ds.Tables["Student"].NewRow();
            dr[0] = int.Parse(TextBox1.Text);
            dr[1] = TextBox2.Text;
            dr[2] = TextBox3.Text;
            ds.Tables["Student"].Rows.Add(dr);
            da.Update(ds, "Student");
            con.Close();
        }
    }
}