<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ProfileInfo.aspx.vb" Inherits="ProfileInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="pnlNonAnonymousInfo" runat="server">
            <table>
                <tr>
                    <td>
                        First Name:
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Last Name:
                    </td>
                    <td>
                        <asp:TextBox ID="txtLastName" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Phone Number:
                    </td>
                    <td>
                        <asp:TextBox ID="txtPhone" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Birth Date:
                    </td>
                    <td>
                        <asp:TextBox ID="txtBirthDate" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="ThemeBlue" Text="DarkBlue" runat="server" OnClick="Set_Theme" />
                    </td>
                    <td>
                        <asp:Button ID="ThemePsych" Text="Psychedelic" runat="server" OnClick="Set_Theme" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <table>
            <tr>
                <td>
                    Books
                </td>
                <td>
                    <asp:CheckBoxList ID="cblFavoriteBooks" runat="server">
                        <asp:ListItem>Programming C# 3.5</asp:ListItem>
                        <asp:ListItem>Programming ASP.NET</asp:ListItem>
                        <asp:ListItem>Programming .NET Apps</asp:ListItem>
                        <asp:ListItem>Programming Silverlight</asp:ListItem>
                        <asp:ListItem>Object Oriented Design Heuristics</asp:ListItem>
                        <asp:ListItem>Design Patterns</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSave" Text="Save" runat="server" OnClick="btnSave_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
