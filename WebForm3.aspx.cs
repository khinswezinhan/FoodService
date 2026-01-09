using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace foodservice
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["const"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
           

            }
        protected void Button1_Click(object sender, EventArgs e)
        {
        //    string htmlString = "<asp:Label ID='lblName3' runat='server' Text='Hello' Visible='True'></asp:Label>";

        //    // Extract IDs
        //    Regex idRegex = new Regex("ID='(.*?)'", RegexOptions.IgnoreCase);
        //    MatchCollection idMatches = idRegex.Matches(htmlString);
        //    List<string> ids = new List<string>();
        //    foreach (Match match in idMatches)
        //    {
        //        ids.Add(match.Groups[1].Value);
        //        Response.Write(match.Groups[1].Value);
                
        //    }
           
        //    ids.ForEach(Response.Write);
           
        }
    }
}