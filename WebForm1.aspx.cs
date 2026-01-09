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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand amd = new SqlCommand("select count(Id) from DeliveryloginTable", conn);
            int count = (int)amd.ExecuteScalar();

            string[] mama = new string[count];
            int i = 0;
            SqlCommand cmd = new SqlCommand("select * from DeliveryloginTable ", conn);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                mama[i] = r["Dname"].ToString();
                DropDownList1.Items.Add(mama[i]);
                i++;
            }
            r.Close();
            conn.Close();
            //DropDownList1.Items.Add("MaMa");
            //DropDownList1.Items.Add("MaMa");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Label3.Visible = true;
            Label5.Visible = true;

            DateTime dd = new DateTime();


            Label3.Text = DateTime.Now.ToShortDateString()+"//";
            Label5.Text = DateTime.Now.ToLongTimeString();
        }
    }
}