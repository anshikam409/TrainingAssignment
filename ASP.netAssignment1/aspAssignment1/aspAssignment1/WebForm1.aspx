<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="aspAssignment1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to my Mc Store</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlItems" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlItems_SelectedIndexChanged">
                <asp:ListItem Text=" Mc Menu Card" Value="" />
                <asp:ListItem Text="Diet Coke" Value="coke" />
                <asp:ListItem Text="Pizza" Value="pizza" />
                <asp:ListItem Text="Oreo" Value="oreo" />
                <asp:ListItem Text="McFlurry" Value="mcflurry" />
                <asp:ListItem Text="Burger" Value="burger" />
            </asp:DropDownList>
            <br />
            <asp:Image ID="imgItem" runat="server" Width="200px" Height="200px" ImageUrl="~/Images/placeholder.jpg" />
            <br />
            <asp:Button ID="btnShowCost" runat="server" Text="Show Cost" OnClick="btnShowCost_Click" />
            <br />
            <asp:Label ID="lblCost" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
