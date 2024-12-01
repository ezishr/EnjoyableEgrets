<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="HackArena.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Homepage</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-F3w7mX95PdgyTmZZMECAngseQB83DfGTowi0iMjiWaeVhAn4FJkqJByhZMI3AhiU" crossorigin="anonymous"/>
    <link rel="stylesheet" type="text/css" href="~/Styles\index.css">
</head>
<body>
    <form id="form1" runat="server" class="form-container">
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

        <div class="main-body">
            <div class="column-left">
                <h2> Problem List </h2>

                <div class="problem-container">
                    <asp:GridView 
                        runat="server" 
                        ID="gvProblems" 
                        AutoGenerateColumns="False" 
                        DataKeyNames="ID" 
                        CssClass="problem-grid">
                        <Columns>

                            <asp:BoundField DataField ="ID" HeaderText="ID">
                                <ItemStyle CssClass="id-column" />
                                <HeaderStyle CssClass="id-column" />
                            </asp:BoundField>

                            <asp:HyperLinkField
                                DataNavigateUrlFields="ID"
                                DataNavigateUrlFormatString="ProblemDetails.aspx?ID={0}"
                                DataTextField="Title"
                                HeaderText="Title" >
                                <ItemStyle CssClass="title-column" />
                                <HeaderStyle CssClass="title-column" />
                            </asp:HyperLinkField>

                            <asp:BoundField DataField="Difficulty" HeaderText="Difficulty">
                                <ItemStyle CssClass="difficulty-column" />
                                <HeaderStyle CssClass="difficulty-column" />
                            </asp:BoundField>

                        </Columns>
                    </asp:GridView>
                </div>
            </div>

            <div class="column-right">
                <div class="calendar-container">
                    <h3>Calendar Track</h3>
                    <asp:Calendar 
                        ID="CalendarControl" 
                        runat="server" 
                        CssClass="calendar-control" 
                        BorderStyle="None">

                        <TitleStyle CssClass="calendar-title" />
                        <NextPrevStyle CssClass="calendar-hover" />
                        <TodayDayStyle ForeColor="Green" />
                        <WeekendDayStyle ForeColor="Red" />
                        <DayStyle CssClass="calendar-hover" />

                        <SelectedDayStyle
                            BorderStyle="None" 
                            ForeColor="#CC3399" />

                    </asp:Calendar>
                </div>

                <div class="trending-container">
                    <h3>Trending Companies</h3>
                    
                    <input 
                        type="text" 
                        id="search-bar" 
                        placeholder="Search Companies..."
                        class="search-bar"
                    />

                    <asp:Repeater ID="TrendingCompaniesRepeater" runat="server">
                        <ItemTemplate>
                            <div class="company-item">
                                <%# Container.DataItem %>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>

        </div>

    </form>
</body>
</html>
