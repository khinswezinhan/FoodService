using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace foodservice
{
    public partial class update : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        //    SqlCommand cmd = new SqlCommand("select * from LoginTable where Id=@e1", conn);
        //    try
        //    {
        //        conn.Open();
        //        cmd.ExecuteNonQuery();
        //        show();
        //        TextBox2.Text = "";
        //        TextBox3.Text = "";
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
        //void show()
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    SqlDataAdapter da = new SqlDataAdapter("select * from LoginTable", conn);
        //    DataSet ds = new DataSet();
        //    ds.Clear();
        //    da.Fill(ds,"student");
        //    GridView1.DataSource = ds.Tables["student"];
        //    GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("select * from LoginTable where Id=@e1", conn);
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    TextBox2.Text=dr[].ToString();
            //    TextBox2.Text=dr[].ToString();
            //}
            //else{
            //    TextBox2.Text="";
            //    TextBox3.Text="";
            //}
            //conn.Close();
        }
    }
}