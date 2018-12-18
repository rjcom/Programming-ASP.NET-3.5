<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LinqDS.aspx.cs" Inherits="LinqDS" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LinqDataSource Demo Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
       ContextTypeName="AwltCustomersDataContext" OrderBy="LastName" 
       Select="new (FirstName, LastName, CompanyName, EmailAddress)" 
       TableName="Customers">
    </asp:LinqDataSource>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
       AllowSorting="True" AutoGenerateColumns="False" DataSourceID="LinqDataSource1">
       <Columns>
          <asp:BoundField DataField="FirstName" HeaderText="FirstName" ReadOnly="True" 
             SortExpression="FirstName" />
          <asp:BoundField DataField="LastName" HeaderText="LastName" ReadOnly="True" 
             SortExpression="LastName" />
          <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" 
             ReadOnly="True" SortExpression="CompanyName" />
          <asp:BoundField DataField="EmailAddress" HeaderText="EmailAddress" 
             ReadOnly="True" SortExpression="EmailAddress" />
       </Columns>
    </asp:GridView>
    </form>
</body>
</html>
