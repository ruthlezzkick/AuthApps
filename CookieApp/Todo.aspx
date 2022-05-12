<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Todo.aspx.cs" Inherits="CookieApp.Todo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lista zadań</title>
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
            <table>
                <tr>
                    <th>Id</th>
                    <th>Nazwa</th>
                    <th>Użytkownik</th>
                </tr>
                <% foreach(var toDoItem in UserToDoItems) { %>
                <tr>
                    <td><%=toDoItem.Id %></td>
                    <td><%=toDoItem.Name %></td>
                    <td><%=toDoItem.UserName %></td>
                </tr>
                 <% } %>
            </table>
        </div>
</body>
</html>
