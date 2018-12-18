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
                    Manage Roles</asp:HyperLink><br />
            </LoggedInTemplate>
            <AnonymousTemplate>
                You aren&#8217;t logged in yet.<br />
                You&#8217;ll need to log in to access the system.
            </AnonymousTemplate>
        </asp:LoginView>
        <br />
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/ProfileInfo.aspx">
           Edit Profile Information</asp:HyperLink>
        <br />
        <asp:ListBox ID="lbBooks" runat="server" />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/CreateAccount.aspx">Create a new account</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/WebParts.aspx">Web Parts</asp:HyperLink>
        <asp:Panel ID="pnlInfo" runat="server" Visible="False">
            <table width="100%">
                <tr>
                    <td>
                        <asp:Label ID="lblFullName" runat="server" Text="Full name unknown">
                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPhone" runat="server" Text="Phone number unknown">
                        </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblBirthDate" runat="server" Text="Birthdate unknown">
                        </asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblListBox" runat="server" Text="ListBox" />
                </td>
                <td>
                    <asp:ListBox ID="lbItems" runat="server">
                        <asp:ListItem>First Item</asp:ListItem>
                        <asp:ListItem>Second Item</asp:ListItem>
                        <asp:ListItem>Third Item</asp:ListItem>
                        <asp:ListItem>Fourth Item</asp:ListItem>
                    </asp:ListBox>
                </td>
                <td>
                    <asp:Label ID="lblRadioButtonList" runat="server" 
                        Text="Radio Button List" SkinID="Red" />
                </td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem>Radio Button 1</asp:ListItem>
                        <asp:ListItem>Radio Button 2</asp:ListItem>
                        <asp:ListItem>Radio Button 3</asp:ListItem>
                        <asp:ListItem>Radio Button 4</asp:ListItem>
                        <asp:ListItem>Radio Button 5</asp:ListItem>
                        <asp:ListItem>Radio Button 6</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCalendar" runat="server" Text="Calendar" />
                </td>
                <td>
                    <asp:Calendar ID="Calendar1" runat="server" />
                </td>
                <td>
                    <asp:Label ID="lblTextBox" runat="server" Text="TextBox" />
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
