<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="HackArena.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Homepage</title>
    <link rel="stylesheet" type="text/css" href="~/Styles/styles.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class ="">
            <asp:Menu ID="NavBar" runat="server" OnMenuItemClick="Menu1_MenuItemClick" CssClass="NavBar">
                <Items>
                    <asp:MenuItem Text="Explore" Value="Explore"></asp:MenuItem>
                    <asp:MenuItem Text="Problems" Value="Problems"></asp:MenuItem>
                    <asp:MenuItem Text="Discuss" Value="Discuss"></asp:MenuItem>
                    <asp:MenuItem Text="Settings" Value="Settings"></asp:MenuItem>
                </Items>
            </asp:Menu>
        </div>

        <h2> Problem List </h2>

        <div>
            <asp:GridView ID="GridView1" runat="server">
                <Columns>
                    <!-- Column for Problem Title-->
                </Columns>
            </asp:GridView>
        </div>

    </form>
</body>
</html>
