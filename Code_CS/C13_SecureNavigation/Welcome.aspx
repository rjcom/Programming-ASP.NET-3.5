<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="Welcome" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Untitled Page</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <table>
         <tr>
            <td>
               <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1">
               </asp:TreeView>
            </td>
            <td>
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
                     You aren&#39;t logged in yet.<br />
                     You&#39;ll need to log in to access the system
                  </AnonymousTemplate>
               </asp:LoginView>
               <br />
               <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/CreateAccount.aspx">Create a new account</asp:HyperLink>
            </td>
         </tr>
      </table>
   </div>
   <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
   </form>
</body>
</html>
