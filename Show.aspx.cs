using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class Show : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand amd = new SqlCommand("select count(Id) from ShTable", conn);
            int count = (int)amd.ExecuteScalar();

            for (int j = 1; j <= count; j++)
            {
                SqlCommand cmd = new SqlCommand("select * from allTable where Id=@e1", conn);
                cmd.Parameters.AddWithValue("@e1", j);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (j == 1)
                    {
                        lblName1.Text = rdr["Foodname"].ToString();
                        lblName1.Visible = true;
                        lblprice1.Visible = true;
                        lblDe1.Visible = true;
                    }
                    if (j == 2)
                    {
                        lblName2.Text = rdr["Foodname"].ToString();
                        lblName2.Visible = true;
                        lblprice2.Visible = true;
                        lblDe2.Visible = true;
                    }

                }

                rdr.Close();
            }

            conn.Close();
            
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("select * from ShopTable",conn);
            //SqlDataReader rdr = cmd.ExecuteReader();
            //rdr.Close();
            //SqlCommand amd = new SqlCommand("select count(Id) from ShopTable",conn);
            //int count=(int)amd.ExecuteScalar();

            //for (int i = 0; i < count;i++ )
            //string[] Name=new string[count];
            //int i=0;
            //while(rdr.Read())
            //{
            //    Name[i]=rdr["FoodName"].ToString();
            //    lblName.Text=Name[i];
            //    //lblName.[i].Text = rdr["FoodName"].ToString();
            //    //lblprice.Text = rdr["Price"].ToString();
            //    //lblDe.Text = rdr["Description"].ToString();
            //    lblName.Visible = true;
            //    lblprice.Visible = true;
            //    lblDe.Visible = true;
            //}
           
            //conn.Close();

            //conn.Open();
            //SqlCommand amd = new SqlCommand("select count(Id) from ShopTable", conn);
            //int count = (int)amd.ExecuteScalar();
            //Session["Count"] = count;
            //String[] aa = new String[count];
            //for (int i = 0; i <= count; i++)
            //{
                
            //    SqlCommand cmd = new SqlCommand("select * from ShopTable where Id=@e1",conn);
            //    cmd.Parameters.AddWithValue("@e1",i);
            //    SqlDataReader rdr = cmd.ExecuteReader();
            //    if (rdr.Read())
            //    {
            //        aa[i]=rdr["Price"].ToString();
            //        lblprice.Text = aa[i];
            //        lblName.Visible = true;
            //        lblprice.Visible = true;
            //        lblDe.Visible = true;

            //    }
            //    rdr.Close();
            //}
           
            //conn.Close();
           
        }
    }
}