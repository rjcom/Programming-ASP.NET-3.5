﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="GridView.aspx.vb" Inherits="GridView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>GridView Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:SqlDataSource ID="dsCustomers" runat="server" ConnectionString="<%$ ConnectionStrings:AWLTConnection %>"
         SelectCommand="SELECT [CustomerId], [FirstName], [LastName], [EmailAddress], [RowGuid] FROM [SalesLT].[Customer]"></asp:SqlDataSource>
      <asp:GridView ID="gvwCustomers" runat="server" DataSourceID="dsCustomers"
         AllowPaging="True" PageSize="5"
         AutoGenerateSelectButton="true" DataKeyNames="CustomerID, RowGuid" 
         onselectedindexchanged="gvwCustomers_SelectedIndexChanged">
      </asp:GridView>
      <asp:Label runat="server" ID="lblInfo" />
   </div>
   </form>
</body>
</html>
