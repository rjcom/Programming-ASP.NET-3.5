<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Repeater.aspx.cs" Inherits="Repeater" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Repeater Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
         ConnectionString="<%$ ConnectionStrings:AWLTConnection %>" 
         SelectCommand="select top 10 CustomerID, FirstName, LastName from [SalesLT].Customer order by CustomerID">
       </asp:SqlDataSource>
      <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
         <HeaderTemplate>
            <ul>
         </HeaderTemplate>
         <ItemTemplate>
            <li>
               <%# Eval("CustomerID") %>: <%# Eval("FirstName") %> <%# Eval("LastName") %>
            </li>
         </ItemTemplate>
         <FooterTemplate>
            </ul>
         </FooterTemplate>
      </asp:Repeater>
   </div>
   </form>
</body>
</html>
