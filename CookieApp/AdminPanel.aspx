<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPanel.aspx.cs" Inherits="CookieApp.AdminPanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Panel administracyjny</title>
</head>
<body>
    <div>
        <asp:HyperLink ID="logoutLink" runat="server" NavigateUrl="~/Logout.aspx">Wyloguj</asp:HyperLink>
    </div>
    <div>
        <asp:HyperLink ID="loginLink" runat="server" NavigateUrl="~/Login.aspx">Zaloguj</asp:HyperLink>
    </div>
    <div>
        <asp:HyperLink ID="adminLink" runat="server" NavigateUrl="~/AdminPanel.aspx">Panel Administracyjny</asp:HyperLink>
    </div>
    <div>
        <asp:HyperLink ID="toDoLink" runat="server" NavigateUrl="~/ToDo.aspx">Lista zadań</asp:HyperLink>
    </div>
    <hr />
        <div>
            <div>
            <table>
                <tr>
                    <th>Użytkownik</th>
                    <th>Zadania</th>
                </tr>
                <% foreach(var userStat in UserStats) { %>
                <tr>
                    <td><%=userStat.User %></td>
                    <td><%=userStat.ItemsCount %></td>
                </tr>
                 <% } %>
            </table>
        </div>
        </div>
</body>
</html>
