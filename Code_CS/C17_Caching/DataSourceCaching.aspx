<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataSourceCaching.aspx.cs"
   Inherits="DataSourceCaching" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>DataSource Caching Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:Label ID="lblTime" runat="server" />
      <asp:SqlDataSource ID="dsCustomers" runat="server" 
         ConnectionString="<%$ ConnectionStrings:AWLTConnectionString %>"
         SelectCommand="SELECT [FirstName], [LastName], [CompanyName], 
            [EmailAddress], [Phone] FROM [SalesLT].[Customer]" 
         EnableCaching="true" CacheDuration="60" />
      <asp:GridView ID="gvwCustomers" runat="server" AllowPaging="True" 
         AllowSorting="True" DataSourceID="dsCustomers" />
   </div>
   </form>
</body>
</html>
