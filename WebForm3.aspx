<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="foodservice.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="bootstrap.min.css" rel="stylesheet" />
    <%--<link href="homemastercss.css" rel="stylesheet" />--%>
    <script src="bootstrap.min.js"></script>
    <link href="Mycss.css" rel="stylesheet" />
     <link href="fontawesome.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.1/css/all.min.css"  />
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <center style="margin-top:200px;">
        <a href="AdminNo.aspx">
              
          <button type="button"  class="navbar-brand btn btn-primary position-relative" style="width:50px;height:50px" onload="count()">
<span class="position-absolute top-0 start-100 translate-middle badge rounded-pill bg-danger">
    <asp:Label ID="unorder" runat="server" Text="" Visible="True"></asp:Label>
   </span>
          </button>
          </a>

           <a href="AdminNo.aspx">      
         <i class="fa-solid fa-cart-shopping  position-relative" style="width:50px;height:50px;font-size:50px;" onload="count()">
             <span class="position-absolute top-0 start-100 translate-middle badge rounded-pill bg-danger" style="margin-right:25px;">
    <asp:Label ID="Label1" runat="server" Text="" Visible="True"></asp:Label>
   </span></i></a>

             </center>
    </div>
    </form>
</body>
</html>
