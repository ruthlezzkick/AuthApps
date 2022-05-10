<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CookieApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Logowanie</title>
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
    <form id="form1" runat="server">
        <label>Użytkownik:</label>
        <div><asp:TextBox runat="server" ID="userTxt" Text=""></asp:TextBox></div>
        <label>Hasło:</label>
        <div><asp:TextBox runat="server" ID="passwordTxt" TextMode="Password"></asp:TextBox></div>
        <br/>
        <div><asp:Button runat="server" ID="loginBtn" Text="Wyślij" OnClick="loginBtn_Click"></asp:Button></div>
        <div><asp:Label runat="server" ID="loginMessage" Text="" Visible="false"></asp:Label></div>
    </form>
</body>
</html>
