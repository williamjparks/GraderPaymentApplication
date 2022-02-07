<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormMain.aspx.cs" Inherits="WebClientDemo.WebFormMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Client Information</h1>
        </div>
        <asp:GridView ID="gvClients" runat="server">
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
