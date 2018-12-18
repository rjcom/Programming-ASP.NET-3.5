<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Welcome.aspx.vb" Inherits="Welcome" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
        <br />
        <asp:LoginView ID="LoginView1" runat="server">
            <LoggedInTemplate>
                Welcome to this fab new site
                <asp:LoginName ID="LoginName1" runat="server" />
                <br />
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/ChangePW.aspx">
                    Change your password</asp:HyperLink><br />
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/ManageRoles.aspx">
                    Manage Roles</asp:HyperLink>
            </LoggedInTemplate>
            <AnonymousTemplate>
                You aren&#8217;t logged in yet.<br />
                You&#8217;ll need to log in to access the system.
            </AnonymousTemplate>
        </asp:LoginView>
        <br />
    </div>
    </form>
</body>
</html>
