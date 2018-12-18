<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ManageRoles.aspx.vb" Inherits="ManageRoles" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage Roles</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Role Membership</h3>
        <asp:HyperLink ID="linkHome" runat="server" NavigateUrl="Welcome.aspx">Home page</asp:HyperLink><br />
        <asp:Label ID="Msg" ForeColor="maroon" runat="server" /><br />
        <table cellpadding="3" border="1" style="border: solid 1px black">
            <tr>
                <td valign="top">
                    Roles:
                </td>
                <td valign="top">
                    <asp:ListBox ID="RolesListBox" runat="server" Rows="8" AutoPostBack="True"></asp:ListBox>
                </td>
                <td valign="top">
                    Users:
                </td>
                <td valign="top">
                    <asp:ListBox ID="UsersListBox" DataTextField="Username" Rows="8" SelectionMode="Multiple" runat="server" />
                </td>
            </tr>
            <tr>
                <td valign="top">
                    Users In Role:
                </td>
                <td valign="top">
                    <asp:GridView runat="server" CellPadding="4" ID="UsersInRoleGrid" AutoGenerateColumns="false"
                        GridLines="None" CellSpacing="0" AllowSorting="False" OnRowCommand="UsersInRoleGrid_RemoveFromRole">
                        <HeaderStyle BackColor="navy" ForeColor="white" />
                        <Columns>
                            <asp:TemplateField HeaderText="User Name">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblUserName" Text=" <%# Container.DataItem.ToString() %>" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:ButtonField Text="Remove From Role" ButtonType="Link" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td valign="top" visible="false" colspan="2">
                    <asp:Button Text="Add User(s) to Role" ID="btnAddUsersToRole" runat="server" OnClick="btnAddUsersToRole_Click" /><br />
                    <asp:Button Text="Create new Role" ID="btnCreateRole" runat="server" OnClick="btnCreateRole_Click" />
                    <asp:Panel ID="pnlCreateRole" runat="server" Visible="False" BackColor="#E0E0E0">
                        &nbsp;New Role:&nbsp;<asp:TextBox ID="txtNewRole" runat="server" /><br />
                        <br />
                        &nbsp;<asp:Button ID="btnAddRole" runat="server" Text="Add" OnClick="btnAddRole_Click" /><br />
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
