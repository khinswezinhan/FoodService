<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="foodservice.update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container " style="margin-top:180px">
        <div class="row">
            <div class="col-3"></div>
            <div class="col-6">
                 <div style="width:100%;box-shadow: 0px 0px 10px grey;padding:55px;">
                     <asp:Label ID="Label8" runat="server" Text="Label" Visible="False">
                  <div class="alert alert-success alert-dismissible fade show" role="alert">
  <strong>Successful!</strong> သင့်ထည့်သွင်းမှူအောင်မြင်ပါသည်..
  <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
</div>
               </asp:Label>
   
    <table class="w-100" >
       <tr >
           <td><asp:Label ID="Label4" runat="server" Text="Email"></asp:Label></td>
            <td> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /></td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="သင့်အီးမေးထည့်ပါ" ControlToValidate="TextBox1" ForeColor="#CC0000"></asp:RequiredFieldValidator></td>
          
     </tr>
       <tr>
           <td><asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></td>
           <td> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="သင့်ပတ်စဝှက်ထည့်ပါ" ControlToValidate="TextBox2" ForeColor="#CC0000"></asp:RequiredFieldValidator></td>
       </tr>
   <tr>
       <td><asp:Label ID="Label3" runat="server" Text="phone"></asp:Label></td>
       <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="သင့်ဖုန်းနံပါတ်ထည့်ပါ" ControlToValidate="TextBox3" ForeColor="#CC0000"></asp:RequiredFieldValidator></td>
   </tr>
 
    <tr>
        <td><asp:Button ID="Button2"  runat="server" Text="Show" OnClick="Button2_Click" CssClass="sbutton" /></td>
        <td><asp:Button ID="Button1" CssClass="sbutton" runat="server" Text="update" OnClick="Button1_Click" /></td>
    </tr>
        </table></div></div>
       <div class="col-3"></div>
        </div></div>
       <asp:GridView ID="GridView1" runat="server" Visible="False"></asp:GridView>
    

</asp:Content>
