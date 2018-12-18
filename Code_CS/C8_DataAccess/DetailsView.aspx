﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DetailsView.aspx.cs" Inherits="DetailsView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>DetailsView Page</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:SqlDataSource ID="dsCustomers" runat="server" ConnectionString="<%$ ConnectionStrings:AWLTConnection %>"
         SelectCommand="SELECT * FROM [SalesLT].[Customer]" />
      <asp:DetailsView ID="CustomerDetails" runat="server" DataSourceID="dsCustomers" AllowPaging="true"
         EmptyDataText="No data was found" DataKeyNames="CustomerID, RowGuid">
      </asp:DetailsView>
      <p>
         <asp:Label runat="server" ID="lblInfo" />
      </p>
   </div>
   </form>
</body>
</html>
