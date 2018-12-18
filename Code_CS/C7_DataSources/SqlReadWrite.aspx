<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SqlReadWrite.aspx.cs" Inherits="SqlReadWrite" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>SQL Read Write Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorksLTConnectionString %>"
   SelectCommand="SELECT [CustomerID], [FirstName], [LastName], [CompanyName], [EmailAddress] FROM [SalesLT].[Customer]"
   DeleteCommand="DELETE FROM [SalesLT].[Customer] WHERE [CustomerID] = @original_CustomerID AND [FirstName] = @original_FirstName AND [LastName] = @original_LastName AND [CompanyName] = @original_CompanyName AND [EmailAddress] = @original_EmailAddress"
   InsertCommand="INSERT INTO [SalesLT].[Customer] ([FirstName], [LastName], [CompanyName], [EmailAddress]) VALUES (@FirstName, @LastName, @CompanyName, @EmailAddress)"
   UpdateCommand="UPDATE [SalesLT].[Customer] SET [FirstName] = @FirstName, [LastName] = @LastName, [CompanyName] = @CompanyName, [EmailAddress] = @EmailAddress WHERE [CustomerID] = @original_CustomerID AND [FirstName] = @original_FirstName AND [LastName] = @original_LastName AND [CompanyName] = @original_CompanyName AND [EmailAddress] = @original_EmailAddress"
   ConflictDetection="CompareAllValues" OldValuesParameterFormatString="original_{0}">
   <DeleteParameters>
      <asp:Parameter Name="original_CustomerID" Type="Int32" />
      <asp:Parameter Name="original_FirstName" Type="String" />
      <asp:Parameter Name="original_LastName" Type="String" />
      <asp:Parameter Name="original_CompanyName" Type="String" />
      <asp:Parameter Name="original_EmailAddress" Type="String" />
   </DeleteParameters>
   <UpdateParameters>
      <asp:Parameter Name="FirstName" Type="String" />
      <asp:Parameter Name="LastName" Type="String" />
      <asp:Parameter Name="CompanyName" Type="String" />
      <asp:Parameter Name="EmailAddress" Type="String" />
      <asp:Parameter Name="original_CustomerID" Type="Int32" />
      <asp:Parameter Name="original_FirstName" Type="String" />
      <asp:Parameter Name="original_LastName" Type="String" />
      <asp:Parameter Name="original_CompanyName" Type="String" />
      <asp:Parameter Name="original_EmailAddress" Type="String" />
   </UpdateParameters>
   <InsertParameters>
      <asp:Parameter Name="FirstName" Type="String" />
      <asp:Parameter Name="LastName" Type="String" />
      <asp:Parameter Name="CompanyName" Type="String" />
      <asp:Parameter Name="EmailAddress" Type="String" />
   </InsertParameters>
</asp:SqlDataSource>
   </div>
   <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CustomerID"
      DataSourceID="SqlDataSource1" BackColor="#CCCCCC" BorderColor="#999999" 
       BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" 
       ForeColor="Black">
       <FooterStyle BackColor="#CCCCCC" />
       <RowStyle BackColor="White" />
      <Columns>
         <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
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
