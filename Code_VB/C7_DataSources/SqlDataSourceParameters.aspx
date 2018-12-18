<%@ Page Language="VB" AutoEventWireup="false" CodeFile="SqlDataSourceParameters.aspx.vb" Inherits="SqlDataSourceParameters" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Data Source Parameters Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:SqlDataSource ID="StaffDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorksLTConnectionString %>"
         SelectCommand="SELECT DISTINCT [SalesPerson] FROM [SalesLT].[Customer]"></asp:SqlDataSource>
      <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="StaffDataSource"
         DataTextField="SalesPerson" DataValueField="SalesPerson" AutoPostBack="true">
      </asp:DropDownList>
      <asp:SqlDataSource ID="CustomersDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorksLTConnectionString %>"
         SelectCommand="SELECT [CustomerID], [FirstName], [LastName], [CompanyName], [EmailAddress] 
       FROM [SalesLT].[Customer] WHERE ([SalesPerson] = @SalesPerson) ORDER BY [LastName]">
         <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="SalesPerson" PropertyName="SelectedValue"
               Type="String" />
         </SelectParameters>
      </asp:SqlDataSource>
   </div>
   <asp:GridView ID="CustomerGridView" runat="server" AutoGenerateColumns="False" DataKeyNames="CustomerID"
      DataSourceID="CustomersDataSource" BackColor="#CCCCCC" 
       BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" 
       CellSpacing="2" ForeColor="Black">
       <FooterStyle BackColor="#CCCCCC" />
       <RowStyle BackColor="White" />
      <Columns>
         <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" InsertVisible="False"
            ReadOnly="True" SortExpression="CustomerID" />
         <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
         <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
         <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
         <asp:BoundField DataField="EmailAddress" HeaderText="EmailAddress" SortExpression="EmailAddress" />
      </Columns>
       <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
       <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
       <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
   </asp:GridView>
   </form>
</body>
</html>
