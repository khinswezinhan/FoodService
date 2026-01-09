using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;


namespace foodservice
{
    public partial class Shopkeeperupdate : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void update_Click(object sender, EventArgs e)
        {
            string imagename = FileUpload1.FileName;
            conn.Open();
            Label8.Visible = true;
            SqlCommand cmd = new SqlCommand("update allTable set Foodname=@b1,Price=@b2,Typeoffood=@b3,image=@i2,Description=@b4,Shopname=@b5 where Foodname= '" + txtfoodname1.Text + "'", conn);
            cmd.Parameters.AddWithValue("@b1", txtfoodname1.Text);
            cmd.Parameters.AddWithValue("@b2",TextBox2.Text);
            cmd.Parameters.AddWithValue("@i2", imagename);

             cmd.Parameters.AddWithValue("@b3",TextBox3.Text);
             //cmd.Parameters.AddWithValue("@b8", );
            cmd.Parameters.AddWithValue("@b4",TextBox5.Text);
            cmd.Parameters.AddWithValue("@b5", TextBox6.Text);
           
            cmd.ExecuteNonQuery();
           
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            txtfoodname1.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }

        protected void txtfoodname1_TextChanged(object sender, EventArgs e)
        {

            conn.Open();
            //string imagename = FileUpload1.FileName;
            //string contenttype = FileUpload1.PostedFile.ContentType;
            //byte[] imageData;

            //using (var binaryReader = new BinaryReader(FileUpload1.PostedFile.InputStream))
            //{
            //    imageData = binaryReader.ReadBytes(FileUpload1.PostedFile.ContentLength);

            //}
            SqlCommand cmd = new SqlCommand("select * from allTable where Foodname=@e1 and Email='" + Session["email"] + "'", conn);
            cmd.Parameters.AddWithValue("@e1", txtfoodname1.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string contentType = dr["image"].ToString();
                TextBox1.Text = dr["Email"].ToString();
                TextBox2.Text = dr["Price"].ToString();
                TextBox3.Text = dr["Typeoffood"].ToString();
                //imagename=dr["image"].ToString();
                TextBox5.Text = dr["Description"].ToString();
                TextBox6.Text = dr["Shopname"].ToString();
                
            }
            
            conn.Close();
        }
    }
}