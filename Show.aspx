<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="WebApplication1.Show" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 306px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <script type="text/javascript">
            
        </script>
        <table class="auto-style1">
            <tr>
                <td colspan="2">
                    <asp:Image ID="Image1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Enter Picture"></asp:Label>
                </td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblName1" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Price"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblprice1" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Description"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblDe1" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>


        <table class="auto-style1">
            <tr>
                <td colspan="2">
                    <asp:Image ID="Image2" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Name"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblName2" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label6" runat="server" Text="Price"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblprice2" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label8" runat="server" Text="Description"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblDe2" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
        
    </div>
    </form>
</body>
</html>
