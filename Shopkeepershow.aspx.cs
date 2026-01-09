using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;


namespace foodservice
{
    public partial class Shopkeepershow : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);
        string a;
        static int c = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            int i = 1;
            conn.Open();


            SqlCommand cmd = new SqlCommand("select * from allTable where Id='" + 1 + "' and Email='" + Session["email"] + "'", conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                image1.ImageUrl = rdr["image"].ToString();
                lblfoodname1.Text = rdr["Foodname"].ToString();
                lblprice1.Text = rdr["Price"].ToString();
               
                lbldescription1.Text = rdr["Description"].ToString();
                rdr.Close();
            }
            else
            {
                lblFirst.Visible = false;
                rdr.Close();
            }

            SqlCommand amd = new SqlCommand("select * from allTable where Id='" + 2 + "' and Email='" + Session["email"] + "'", conn);
            SqlDataReader rd = amd.ExecuteReader();
            if (rd.Read())
            {
                image2.ImageUrl = rd["image"].ToString();
                lblfoodname2.Text = rd["Foodname"].ToString();
                lblprice2.Text = rd["Price"].ToString();
                
                lbldescription2.Text = rd["Description"].ToString();
                rd.Close();
            }
            else
            {
                lblSecond.Visible = false;
                rd.Close();
            }


            SqlCommand bmd = new SqlCommand("select * from allTable where Id='" + 3 + "' and Email='" + Session["email"] + "'", conn);
            SqlDataReader bd = bmd.ExecuteReader();
            if (bd.Read())
            {
                image5.ImageUrl = bd["image"].ToString();
                lblfoodname3.Text = bd["Foodname"].ToString();
                lblprice3.Text = bd["Price"].ToString();
               
                lbldescription3.Text = bd["Description"].ToString();
                bd.Close();
            }
            else
            {
                lblThird.Visible = false;
                bd.Close();
            }

            SqlCommand dmd = new SqlCommand("select * from allTable where Id='" + 4 + "' and Email='" + Session["email"] + "'", conn);
            SqlDataReader dd = dmd.ExecuteReader();
            if (dd.Read())
            {
                image7.ImageUrl = dd["image"].ToString();
                lblfoodname4.Text = dd["Foodname"].ToString();
                lblprice4.Text = dd["Price"].ToString();
                
                lbldescription4.Text = dd["Description"].ToString();
                dd.Close();
            }
            else
            {
                lblFourth.Visible = false;
                dd.Close();
            }


            SqlCommand fifth = new SqlCommand("select * from allTable where Id='" + 5 + "' and Email='" + Session["email"] + "'", conn);
            SqlDataReader fifthrdr = fifth.ExecuteReader();
            if (fifthrdr.Read())
            {
                lblSecondFirstImage.ImageUrl = fifthrdr["image"].ToString();
                lblSecondFirstFoodname.Text = fifthrdr["Foodname"].ToString();
                lblSecondFirstPrice.Text = fifthrdr["Price"].ToString();
               
                lblSecondFirstDescription.Text = fifthrdr["Description"].ToString();
                fifthrdr.Close();
            }
            else
            {
                lblSecondFirst.Visible = false;
                fifthrdr.Close();
            }


            SqlCommand sixth = new SqlCommand("select * from allTable where Id='" + 6 + "' and Email='" + Session["email"] + "'", conn);
            SqlDataReader sixthrdr = sixth.ExecuteReader();
            if (sixthrdr.Read())
            {
                lblSecondSecondImage.ImageUrl = sixthrdr["image"].ToString();
                lblSecondSecondFoodname.Text = sixthrdr["Foodname"].ToString();
                lblSecondSecondPrice.Text = sixthrdr["Price"].ToString();
              
                lblSecondSecondDescription.Text = sixthrdr["Description"].ToString();
                sixthrdr.Close();
            }
            else
            {
                lblSecondSecond.Visible = false;
                sixthrdr.Close();
            }



            SqlCommand seventh = new SqlCommand("select * from allTable where Id='" + 7 + "' and Email='" + Session["email"] + "'", conn);
            SqlDataReader seventhrdr = seventh.ExecuteReader();
            if (seventhrdr.Read())
            {
                lblSecondThirdImage.ImageUrl = seventhrdr["image"].ToString();
                lblSecondThirdFoodname.Text = seventhrdr["Foodname"].ToString();
                lblSecondThirdPrice.Text = seventhrdr["Price"].ToString();
                
                lblSecondThirdDescription.Text = seventhrdr["Description"].ToString();
                seventhrdr.Close();
            }
            else
            {
                lblSecondThird.Visible = false;
                seventhrdr.Close();
            }

            conn.Close();


            //string h = Session["email"].ToString();
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("select * from AllDataTable where Email='" + Session["email"] + "'", conn);
            //SqlDataReader rdr = cmd.ExecuteReader();

            //while (rdr.Read())
            //{
                //string contentType = rdr["image"].ToString();
                //GridView1.Visible = true;
                //String aa="Select * from ShTable where Email='"+ Session["email"] +"'";
                //SqlDataAdapter dt = new SqlDataAdapter(aa, conn);

                //DataSet ds = new DataSet();
                //dt.Fill(ds, "s");
                //conn.Close();
                //DataTable da = new DataTable();
                //dt.Fill(da);
                //dt.Update(ds, "s");
                //GridView1.DataSource = da;
                //GridView1.DataBind();
            //    Label1.Visible = true;
            //    Label2.Visible = true;
            //    a = "<div class='col-4><div class='card' style='width: 18rem;box-shadow:0px 0px 10px grey'><img src='"+ contentType +"'><div class='card-body'><h5 class='card-title'><asp:Label ID='lblfoodname2' runat='server' CssClass='card-text' Text='"+ rdr["Foodname"].ToString() +"'></asp:Label></h5><asp:Label ID='lblprice2' runat='server' CssClass='card-text' Text='"+rdr["Price"].ToString()+"'></asp:Label><br /> <asp:Label ID='lbldescription2' runat='server' CssClass='card-text' Text='"+rdr["Description"].ToString()+"'></asp:Label><br /><br /> </div></div></div>";

            //    c += 1;
            //    if (c <= 3)
            //    {

            //        Label1.Text += a;
            //    }

            //    else
            //    {

            //        Label2.Text += a;
            //    }
            //}
            //rdr.Close();
        }
    }
}