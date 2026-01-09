<%@ Page Title="" Language="C#" MasterPageFile="~/Shopkeeper.Master" AutoEventWireup="true" CodeBehind="Shopkeeperupdate.aspx.cs" Inherits="foodservice.Shopkeeperupdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <div class="container" style="margin-top:180px">
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
    <table class="w-100">

        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Foodname"></asp:Label></td>
    <td><asp:TextBox ID="txtfoodname1" runat="server" OnTextChanged="txtfoodname1_TextChanged" AutoPostBack="True"></asp:TextBox></td>
             <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter your Foodname" ControlToValidate="txtfoodname1" CssClass="text-danger"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="Label2" runat="server" Text="Email"></asp:Label></td>
            <td> <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter your Email" ControlToValidate="TextBox1" CssClass="text-danger"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td> <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label></td>
            <td> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
              <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Enter your Price" ControlToValidate="TextBox2" CssClass="text-danger"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>  <asp:Label ID="Label4" runat="server" Text="TypeOfFood"></asp:Label></td>
            <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Choose your Food Type " ControlToValidate="TextBox3" CssClass="text-danger"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td><asp:Label ID="Label5" runat="server" Text="Image"></asp:Label></td>
            <td> <asp:FileUpload ID="FileUpload1" runat="server" /></td>
              <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Insert your Image" ControlToValidate="FileUpload1" CssClass="text-danger"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td> <asp:Label ID="Label6" runat="server" Text="Description"></asp:Label></td>
            <td> <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
             <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Enter your Description" ControlToValidate="TextBox5" CssClass="text-danger"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td><asp:Label ID="Label7" runat="server" Text="Shopname"></asp:Label></td>
            <td> <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
              <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Enter your Shopname" ControlToValidate="TextBox6" CssClass="text-danger"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" CausesValidation="False" EnableViewState="False" CssClass="btn btn-danger" /></td>
            <td><asp:Button ID="update" runat="server" Text="Update" CausesValidation="False" ClientIDMode="Inherit" EnableViewState="False" OnClick="update_Click" CssClass="btn btn-success" /></td>
        </tr>
    </table>
         </div></div>
            <div class="col-3"></div>
            </div></div>
</asp:Content>
