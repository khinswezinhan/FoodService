<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="foodservice.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="homemastercss.css" rel="stylesheet" />
    <link href="all.min.css" rel="stylesheet" />
    <link href="fontawesome.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.1/css/all.min.css"  />
     <link href="Mycss.css" rel="stylesheet" />

   
    <link href="bootstrap.min.css" rel="stylesheet" />
    <%--<link href="homemastercss.css" rel="stylesheet" />--%>
    <script src="bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Button"  />
        <asp:Button ID="Button4" runat="server" Text="Button"  />
        <asp:Button ID="Button3" runat="server" Text="Button" CssClass="cssbtn"  style="border:none;" />
        <h1>hi</h1>
     <i class="fa-solid fa-burger" ></i>
        <i class="fa-brands fa-facebook"></i>
        <h3>huhu</h3>
        OnClientClick="return false;"
        border:4px solid black;
         height: 32px; width: 32px
        
    </div>
        <div class="container">
        <div class="row p-2">
           
            <div class="col-2">
        <div class="allshow text-center">
            <span style="font-size:20px;">&#129367;</span>
            <h3>All</h3>
            </div>
                </div></div></div>
        <asp:Label ID="Label1" runat="server" Text="
            &lt;div style=&quot;color:red&quot;&gt;
                &lt;h4&gt;Hi&lt;/h4&gt;
            &lt;/div&gt;
        " Visible="False"></asp:Label>
        <h1>This is here</h1>

         <span class=" translate-middle badge rounded-pill bg-danger" style="position:absolute;margin-left:20px;z-index:4; top: 314px; left: 25px; ">
    <asp:label id="label2" runat="server" text="label" visible="true"></asp:label>
  </span>

        <asp:Button ID="Button2" type="button" runat="server" Text="Button" class="navbar-brand btn btn-primary position-relative" style="width:50px;height:50px;z-index:1; top: 1px; left: 0px;"  data-bs-toggle="offcanvas" data-bs-target="#offcanvasright" aria-controls="offcanvasright"  OnClientClick="return false;" />
      



         <button type="button" id="cart" class="navbar-brand btn btn-primary position-relative" style="width:50px;height:50px; top: 2px; left: 184px;" data-bs-toggle="offcanvas" data-bs-target="#offcanvasright" aria-controls="offcanvasright" >
<span class="position-absolute top-0 start-100 translate-middle badge rounded-pill bg-danger">
    <asp:label id="label4" runat="server" text="label" visible="true"></asp:label>

    </span>
          </button>
     
            

        <div class="offcanvas offcanvas-end" tabindex="-1" id="offcanvasright" aria-labelledby="offcanvasrightlabel">
  <div class="offcanvas-header">
    <h5 class="offcanvas-title" id="offcanvasrightlabel"><asp:Button ID="btncart" runat="server" Text="Are you sure to look this cart!" style="border:none;"  EnableViewState="False" CausesValidation="False" UseSubmitBehavior="False"  data-bs-toggle="offcanvas" data-bs-target="#offcanvasright" aria-controls="offcanvasright"/></h5>
    <button type="button" class="btn-close" data-bs-dismiss="offcanvas" aria-label="close"></button>
  </div>
  <div class="offcanvas-body">
      <asp:Label ID="lblcartbody" runat="server" Text="Cart body" Visible="False"></asp:Label>
  </div>
</div>
        <br />
        <br />


        <asp:Menu ID="Menu1" runat="server">
                <Items><asp:MenuItem Text="Complete" Value="complete" NavigateUrl="homemaster.aspx"></asp:MenuItem></Items>
            <Items><asp:MenuItem Text="UnComplete" Value="uncomplete" NavigateUrl="homemaster.aspx"></asp:MenuItem></Items>
        </asp:Menu>

        

       
        <asp:Button ID="Button5" runat="server" Text="Date" OnClick="Button5_Click" />
        <asp:Label ID="Label3" runat="server" Visible="false"></asp:Label>
        <asp:Label ID="Label5" runat="server" Visible="false"></asp:Label>

        <div class="dropdown">
  <button class="btn btn-secondary dropdown-toggle" type="button" data-bs-toggle="dropdown" aria-expanded="false">
    Dropdown button
  </button>
  <ul class="dropdown-menu">
    <li><a class="dropdown-item" href="#">Action</a></li>
    <li><a class="dropdown-item" href="#">Another action</a></li>
    <li><a class="dropdown-item" href="#">Something else here</a></li>
  </ul>


             <asp:DropDownList ID="DropDownList1" runat="server">
          
            Height="249px" Width="968px"
          
        </asp:DropDownList>
             <i class="fa-regular fa-bell  position-relative navbar-brand" style="width:30px;height:30px;font-size:35px;color:black;" onload="count()">
             <span class="position-absolute top-0 start-100 translate-middle badge rounded-pill bg-danger" style="margin-right:25px;width:20px;">
    <asp:Label ID="label6" runat="server" ></asp:Label>
   </span></i>
</div>
    </form>
</body>
</html>
