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
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cart = new SqlCommand("select count(Id) from CartTable where Email='" + Session["email"] + "'", conn);
            int count = (int)cart.ExecuteScalar();
            Label8.Text = count.ToString();
            Label8.Visible = true;
            //Label8.Text = Session["cartcount"].ToString();
            conn.Close();
        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);



        protected void btnlogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            if(txtemail.Text=="l@gmail.com" && txtpassword.Text=="l123")
            {
                Response.Redirect("userupdatedelete.aspx");
            }
            Session["email"] = txtemail.Text;
            //Label6.Text = Session["email"].ToString();
            //Response.Write("<script>alert(Session['email']);<script>");
            SqlCommand bmd = new SqlCommand("select * from ShopkeeperTable where Email=@en1 and Password=@pn1", conn);
            bmd.Parameters.AddWithValue("@en1", txtemail.Text);
            bmd.Parameters.AddWithValue("@pn1", txtpassword.Text);
            Session["email"] = txtemail.Text;
            SqlDataReader drr = bmd.ExecuteReader();
            if (drr.Read())
            {
                Session["shopKeeperShopname"] = drr["Shopname"];
                Response.Redirect("Shopkeeper2.aspx");
                
            }
            drr.Close();

            //Delivery login insert
            SqlCommand dmd = new SqlCommand("select * from DeliveryloginTable where Demail=@ed1 and Dpassword=@pd1", conn);
            dmd.Parameters.AddWithValue("@ed1", txtemail.Text);
            dmd.Parameters.AddWithValue("@pd1", txtpassword.Text);
            Session["email"] = txtemail.Text;
            SqlDataReader ddr = dmd.ExecuteReader();
            if (ddr.Read())
            {
                Session["dname"] = ddr["Dname"].ToString();
                //Session["shopKeeperShopname"] = drr["Shopname"];
                Response.Redirect("Delivary.aspx");

            }
            ddr.Close();
            //Delivery login insert

            SqlCommand amd = new SqlCommand("select * from LoginTable where Email=@em1 and Password=@p1", conn);
            amd.Parameters.AddWithValue("@em1", txtemail.Text);
            amd.Parameters.AddWithValue("@p1", txtpassword.Text);
            
            SqlDataReader dr = amd.ExecuteReader();
            if (dr.Read())

            {
                dr.Close();
            }    
                
              else
            {
                dr.Close();
                   
                    SqlCommand cmd = new SqlCommand("insert into LoginTable (Email,Password) values(@e1,@e2)", conn);
                    

                    cmd.Parameters.AddWithValue("@e1", txtemail.Text);
                    cmd.Parameters.AddWithValue("@e2", txtpassword.Text);
                    cmd.ExecuteNonQuery();

                    Response.Write("Successful");


                   
                   
                   
                }
           
            
            
            conn.Close();
            }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("marketform.aspx");
           
        }

        //protected void btnsearch_Click(object sender, EventArgs e)
        //{
        //    lblhome.Visible = false;
        //    lblallsearch.Visible = true;
        //    conn.Open();
        //    string find = "select * from AllDataTable where(Foodname like '%'+@foodname+'%') and Id=4";
        //    SqlCommand cmd = new SqlCommand(find, conn);
        //    cmd.Parameters.AddWithValue("@foodname", txtfoodsearch.Text);
            
           
        //    SqlDataReader rdr = cmd.ExecuteReader();
        //    if (rdr.Read())
        //    {
        //        searchimage1.ImageUrl = rdr["image"].ToString();
        //        searchfoodname1.Text = rdr["Foodname"].ToString();
        //        searchprice1.Text = rdr["Price"].ToString();
        //        searchdescription1.Text = rdr["Description"].ToString();
        //        searchshopname1.Text = rdr["Shopname"].ToString();
        //        rdr.Close();

        //    }
        //    else
        //    {
        //        lblbtnview1.Visible = false;
        //        rdr.Close();
        //    }


        //    string findsecond = "select * from AllDataTable where(Foodname like '%'+@foodname+'%') and Id=7";
        //    SqlCommand cmdsecond = new SqlCommand(findsecond, conn);
        //    cmdsecond.Parameters.AddWithValue("@foodname", txtfoodsearch.Text);


        //    SqlDataReader rdrsecond = cmdsecond.ExecuteReader();
        //    if (rdrsecond.Read())
        //    {
        //        searchimage2.ImageUrl = rdrsecond["image"].ToString();
        //        searchfoodname2.Text = rdrsecond["Foodname"].ToString();
        //        searchprice2.Text = rdrsecond["Price"].ToString();
        //        searchdescription2.Text = rdrsecond["Description"].ToString();
        //        searchshopname2.Text = rdrsecond["Shopname"].ToString();
        //        rdrsecond.Close();

        //    }
        //    else
        //    {
        //        lblbtnview2.Visible = false;
        //        rdrsecond.Close();
        //    }
            
        //    //while(rdr){

        //    //}

        //}

        protected void btnhome_Click(object sender, EventArgs e)
        {
            Response.Redirect("homemaster.aspx");
            //lblhome.Visible = true;
            //lblallsearch.Visible = false;
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {

            Session.Clear();
            Response.Redirect("homemaster.aspx");
            //lblhome.Visible = true;
            //lblallsearch.Visible = false;
        }

        protected void btnkorea_Click(object sender, EventArgs e)
        {

           
            Response.Redirect("update.aspx");
            //lblhome.Visible = true;
            //lblallsearch.Visible = false;
        }


        protected void btncancel_Click(object sender, EventArgs e)
        {
            txtemail.Text = "";
            txtpassword.Text = "";
        }








        

       
    }

        
       
    }
