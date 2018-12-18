<%@ Page Language="VB" AutoEventWireup="false" CodeFile="LinqDsEdit.aspx.vb" Inherits="LinqDsEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Editing Data With the LinqDataSource</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:LinqDataSource ID="LinqDataSource1" runat="server" 
          ContextTypeName="AwltCustomerDataContext" EnableDelete="True" 
          EnableInsert="True" EnableUpdate="True" TableName="Customers">
       </asp:LinqDataSource>
       <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
          AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="CustomerID" 
          DataSourceID="LinqDataSource1">
          <Columns>
             <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                ShowSelectButton="True" />
             <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" 
                InsertVisible="False" ReadOnly="True" SortExpression="CustomerID" />
             <asp:CheckBoxField DataField="NameStyle" HeaderText="NameStyle" 
                SortExpression="NameStyle" />
             <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
             <asp:BoundField DataField="FirstName" HeaderText="FirstName" 
                SortExpression="FirstName" />
             <asp:BoundField DataField="MiddleName" HeaderText="MiddleName" 
                SortExpression="MiddleName" />
             <asp:BoundField DataField="LastName" HeaderText="LastName" 
                SortExpression="LastName" />
             <asp:BoundField DataField="Suffix" HeaderText="Suffix" 
                SortExpression="Suffix" />
             <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" 
                SortExpression="CompanyName" />
             <asp:BoundField DataField="SalesPerson" HeaderText="SalesPerson" 
                SortExpression="SalesPerson" />
             <asp:BoundField DataField="EmailAddress" HeaderText="EmailAddress" 
                SortExpression="EmailAddress" />
             <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
             <asp:BoundField DataField="PasswordHash" HeaderText="PasswordHash" 
                SortExpression="PasswordHash" />
             <asp:BoundField DataField="PasswordSalt" HeaderText="PasswordSalt" 
                SortExpression="PasswordSalt" />
             <asp:BoundField DataField="rowguid" HeaderText="rowguid" 
                SortExpression="rowguid" />
             <asp:BoundField DataField="ModifiedDate" HeaderText="ModifiedDate" 
                SortExpression="ModifiedDate" />
          </Columns>
       </asp:GridView>
    </div>
    </form>
</body>
</html>
