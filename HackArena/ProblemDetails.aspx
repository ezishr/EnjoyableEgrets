<%--
    * Name: Enjoyable Egrets
    * Email: vopq@mail.uc.edu, cadetce@mail.uc.edu, yemaneag@mail.uc.edu, hossaizn@mail.uc.edu
    * Assignment Number: Final Project
    * Due Date: Dec 5th, 2024
    * Course #/Section: IS 3050 - 002
    * Semester/Year: Fall 2024
    * Brief Description of the assignment: Build a website that shows a list of LeetCode problems and allows users to invoke the solutions.
    * Citations: ChatGPT; https://learn.microsoft.com/en-us/dotnet/api/system.web.ui.webcontrols?view=netframework-4.8.1 
    *Anything else that's relevant: N/A
--%>


<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProblemDetails.aspx.cs" Inherits="HackArena.ProblemDetails" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Problem Details</title>
    <link rel="stylesheet" type="text/css" href="../Styles/index.css"/>
    <link rel="stylesheet" type="text/css" href="../Styles/styles.css"/>

    <%-- Import fonts: 
        - Roboto Mono: normal text
        - Martian Mono: header 1
        - Chivo Mono: header 2
        - Cutive Mono: solution code --%>
    <style>
        @import url('https://fonts.googleapis.com/css2?family=Chivo+Mono:ital,wght@0,100..900;1,100..900&family=Cutive+Mono&family=Martian+Mono:wght@100..800&family=Roboto+Mono:ital,wght@0,100..700;1,100..700&display=swap');
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Nav Bar -->
        <div class ="navbar">
            <div class="navbar-left">
                <img src="/Images/navbar-logo.png" alt="NavBar Logo" class="navbar-logo"/>
            </div>

            <div class="navbar-center">
                <asp:Menu ID="NavBarCenter" runat="server" CssClass="NavBar" RenderingMode="List">
                    <Items>
                        <asp:MenuItem Text="Explore" Value="Explore" NavigateUrl="~/index.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="Problems" Value="Problems" NavigateUrl="~/index.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="Discuss" Value="Discuss" NavigateUrl="~/index.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="Settings" Value="Settings" NavigateUrl="~/index.aspx"></asp:MenuItem>
                    </Items>
                </asp:Menu>
            </div>

            <div class="navbar-login">
                <a href="index.aspx" class="navbar-link">Log In</a>
                <a href="index.aspx" class="navbar-link">Sign Up</a>
            </div>
        </div>


        <div class="container">
            <!-- Left Column -->
            <div class="left">
                <h2>Problem Details</h2>



                <asp:Label 
                    ID="lblProblemTitle" 
                    runat="server" 
                    Text="Title: " 
                    Font-Bold="True"
                    Font-Names="Chivo Mono"
                    Font-Size="16px">
                </asp:Label>
                <br />
                <br />
                <br />

                <asp:Label 
                    ID="lblProblemDescription" 
                    runat="server" 
                    Text="Description: "
                    Font-Bold="True"
                    Font-Names="Chivo Mono"
                    Font-Size="16px">
                </asp:Label>
                <br />
                <br />
                <br />

                <asp:Label 
                    ID="lblProblemTestCase" 
                    runat="server" 
                    Text="Test Cases: "
                    Font-Bold="True"
                    Font-Names="Chivo Mono" 
                    Font-Size="16px">
                </asp:Label>
            </div>




            <!-- Right Column -->
            <div class="right">
                <h2>Submit Your Solution</h2>



                <asp:TextBox 
                    ID="txtUserSolution" 
                    runat="server" 
                    CssClass="textbox" 
                    TextMode="MultiLine" 
                    Placeholder="Write your solution here..." 
                    Font-Size="16px">
                </asp:TextBox>
                <asp:Button 
                    ID="btnShowSolution" 
                    runat="server" 
                    Text="Show Solution" 
                    OnClick="btnShowSolution_Click" />
                <asp:TextBox 
                    ID="txtActualSolution" 
                    runat="server" 
                    CssClass="textbox" 
                    TextMode="MultiLine" 
                    Visible="False" 
                    ReadOnly="True"
                    Font-Size="16px">
                </asp:TextBox>
            </div>
        </div>
    </form>
</body>
</html>
