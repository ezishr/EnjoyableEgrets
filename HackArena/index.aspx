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
            <asp:GridView ID="ProblemGridView" runat="server" AutoGenerateColumns="false" CssClass="gridview" OnRowCommand="ProblemGridView_RowCommand">
            <Columns>

                <%--Column for Problem Title--%>
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />

                <%--Column for Problem Title--%>
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />

                <%--Column for Problem Title--%>
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <asp:Button ID="DetailsButton" runat="server" Text="View Details" CommandName="ViewDetails" CommandArgument='<%# Eval("ID") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>
        </asp:GridView>
        </div>

    </form>
</body>
</html>
