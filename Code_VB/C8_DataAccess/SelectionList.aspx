<%@ Page Language="VB" AutoEventWireup="false" CodeFile="SelectionList.aspx.vb" Inherits="SelectionList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Selection List Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:SqlDataSource ID="dsCustomers" runat="server" 
         ConnectionString="<%$ ConnectionStrings:AWLTConnection %>"
         SelectCommand="SELECT [CustomerID], [FirstName] + ' ' + [LastName] as FullName FROM [SalesLT].[Customer] ORDER BY FullName" />
      <asp:DropDownList ID="DropDownList1" runat="server" 
         DataSourceID="dsCustomers" DataTextField="FullName" 
         DataValueField="CustomerID" 
         AutoPostBack="true"
         onselectedindexchanged="DropDownList1_SelectedIndexChanged"
         AppendDataBoundItems="true">
         <asp:ListItem Selected="True" Text="Select a customer" Value="" />
      </asp:DropDownList>
      <asp:Label ID="lblSelection" runat="server" />
   </div>
   </form>
</body>
</html>
