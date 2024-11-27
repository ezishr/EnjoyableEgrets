<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProblemDetails.aspx.cs" Inherits="HackArena.ProblemDetails" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="~/Styles/styles.css"/>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <!-- Left Column -->
            <div class="left">
                <h2>Problem Details</h2>
                <asp:Label ID="lblProblemTitle" runat="server" Text="Title: " Font-Bold="True"></asp:Label><br /><br />
                <asp:Label ID="lblProblemDescription" runat="server" Text="Description: "></asp:Label><br /><br />
                <asp:Label ID="lblProblemTestCase" runat="server" Text="Test Case: "></asp:Label>
            </div>

            <!-- Right Column -->
            <div class="right">
                <h2>Submit Your Solution</h2>
                <asp:TextBox ID="txtUserSolution" runat="server" CssClass="textbox" TextMode="MultiLine" Placeholder="Write your solution here..."></asp:TextBox>
                <asp:Button ID="btnShowSolution" runat="server" Text="Show Solution" OnClick="btnShowSolution_Click" />
                <asp:TextBox ID="txtActualSolution" runat="server" CssClass="textbox" TextMode="MultiLine" Visible="False" ReadOnly="True"></asp:TextBox>
            </div>
        </div>
    </form>
</body>
</html>
