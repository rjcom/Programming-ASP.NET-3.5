<%@ Page Language="VB" AutoEventWireup="false" CodeFile="GridViewCustomRows.aspx.vb" Inherits="GridViewCustomRows" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>GridView Custom Rows Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:SqlDataSource ID="dsCustomers" runat="server" 
         ConnectionString="<%$ ConnectionStrings:AWLTConnection %>"
         SelectCommand="
            SELECT [CustomerID], [NameStyle],
	            CASE WHEN [Title] IS NULL THEN '' ELSE [Title] + ' ' END +
               [FirstName] + ' ' +
	            CASE WHEN [MiddleName] IS NULL THEN '' ELSE [MiddleName] + ' ' END +
	            [LastName] + 
	            CASE WHEN [Suffix] IS NULL THEN '' ELSE ' ' + [Suffix] END as 'FullName',
	            [Title], [FirstName], [MiddleName], [LastName], [Suffix],
	            [CompanyName], [SalesPerson], [ModifiedDate], [EmailAddress], [Phone], 
	            [PasswordHash], [PasswordSalt]
               FROM [SalesLT].[Customer]" 
         UpdateCommand="
            UPDATE [SalesLT].[Customer] SET 
               [NameStyle] = @NameStyle, [Title] = @Title, [FirstName] = @FirstName, 
               [MiddleName] = @MiddleName, [LastName] = @LastName, [Suffix] = @Suffix, 
               [CompanyName] = @CompanyName, [SalesPerson] = @SalesPerson, 
               [EmailAddress] = @EmailAddress, [Phone] = @Phone, 
               [ModifiedDate] = GetDate() WHERE [CustomerID] = @CustomerID">
      <DeleteParameters>
         <asp:Parameter Name="CustomerID" Type="Int32" />
      </DeleteParameters>
      <UpdateParameters>
            <asp:Parameter Name="NameStyle" Type="Boolean" />
            <asp:Parameter Name="Title" Type="String" />
            <asp:Parameter Name="FirstName" Type="String" />
            <asp:Parameter Name="MiddleName" Type="String" />
            <asp:Parameter Name="LastName" Type="String" />
            <asp:Parameter Name="Suffix" Type="String" />
            <asp:Parameter Name="CompanyName" Type="String" />
            <asp:Parameter Name="SalesPerson" Type="String" />
            <asp:Parameter Name="EmailAddress" Type="String" />
            <asp:Parameter Name="Phone" Type="String" />
            <asp:Parameter Name="CustomerID" Type="Int32" />
         </UpdateParameters>
      </asp:SqlDataSource>
      <asp:GridView ID="gvwCustomers" runat="server" AllowPaging="True" AutoGenerateColumns="False"
         DataSourceID="dsCustomers" DataKeyNames="CustomerID" 
         onrowediting="gvwCustomers_RowEditing" 
         onrowcancelingedit="gvwCustomers_RowCancelingEdit" 
         onrowupdated="gvwCustomers_RowUpdated">
         <PagerSettings FirstPageText="First" LastPageText="Last" PageButtonCount="5" />
         <EmptyDataTemplate>
            No customers found I&#39;m afraid
         </EmptyDataTemplate>
         <Columns>
            <asp:BoundField DataField="CustomerID" ReadOnly="True" Visible="False" />
            <asp:BoundField DataField="FullName" HeaderText="Name" ReadOnly="true" />
            <asp:CheckBoxField HeaderText="Non-western name?" DataField="NameStyle" Visible="false" />
            <asp:BoundField DataField="Title" HeaderText="Title" Visible="false" />
            <asp:BoundField DataField="FirstName" HeaderText="First Name" Visible="false" />
            <asp:BoundField DataField="MiddleName" HeaderText="Middle Name" Visible="false" />
            <asp:BoundField DataField="LastName" HeaderText="Surname" Visible="false" />
            <asp:BoundField DataField="Suffix" HeaderText="Suffix" Visible="false" />
            <asp:BoundField DataField="CompanyName" HeaderText="Company" />
            <asp:TemplateField HeaderText="Email Address">
               <ItemTemplate>
                  <asp:HyperLink ID="hypEmailReadOnly" runat="server" NavigateUrl='<%# Eval("EmailAddress", "mailto:{0}") %>'
                     Text='<%# Eval("EmailAddress") %>'></asp:HyperLink>
               </ItemTemplate>
               <EditItemTemplate>
                  <asp:TextBox ID="txtEmailEdit" runat="server" Text='<%# Bind("EmailAddress") %>' />
               </EditItemTemplate>
               <InsertItemTemplate>
                  <asp:TextBox ID="txtEmailInsert" runat="server" Text='<%# Bind("EmailAddress") %>' />
               </InsertItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
            <asp:BoundField DataField="SalesPerson" HeaderText="SalesPerson" />
            <asp:BoundField DataField="ModifiedDate" DataFormatString="{0:hh:mm, dd MMM yyyy}"
               HeaderText="Last Modified" ReadOnly="true" />
            <asp:BoundField DataField="PasswordHash" HeaderText="Password Hash" ReadOnly="True"
               SortExpression="PasswordHash" />
            <asp:BoundField DataField="PasswordSalt" HeaderText="Password Salt" ReadOnly="True"
               SortExpression="PasswordSalt" />
            <asp:CommandField ButtonType="Button" ShowEditButton="True" />
         </Columns>
      </asp:GridView>
   </div>
   </form>
</body>
</html>