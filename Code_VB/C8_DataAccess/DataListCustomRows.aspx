<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DataListCustomRows.aspx.vb" Inherits="DataListCustomRows" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>DataList Edit and Delete Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:SqlDataSource ID="dsCustomers" runat="server" ConnectionString="<%$ ConnectionStrings:AWLTConnection %>"
         DeleteCommand="DELETE FROM [SalesLT].[Customer] WHERE [CustomerID] = @CustomerID"
         SelectCommand="
            SELECT TOP 9 [CustomerID], [NameStyle],
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
      <asp:DataList ID="DataList1" runat="server" DataKeyField="CustomerID" DataSourceID="dsCustomers"
         GridLines="Vertical" RepeatColumns="3" 
         OnEditCommand="DataList1_EditCommand" OnCancelCommand="DataList1_CancelCommand"
         OnDeleteCommand="DataList1_DeleteCommand" 
         OnUpdateCommand="DataList1_UpdateCommand" 
         BackColor="White" 
         BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
         ForeColor="Black" onselectedindexchanged="DataList1_SelectedIndexChanged">
         <ItemTemplate>
            FullName:
            <asp:Label ID="FullNameLabel" runat="server" Text='<%# Eval("FullName") %>' />
            <br />
            CompanyName:
            <asp:Label ID="CompanyNameLabel" runat="server" Text='<%# Eval("CompanyName") %>' />
            <br />
            SalesPerson:
            <asp:Label ID="SalesPersonLabel" runat="server" Text='<%# Eval("SalesPerson") %>' />
            <br />
            ModifiedDate:
            <asp:Label ID="ModifiedDateLabel" runat="server" Text='<%# Eval("ModifiedDate", "{0:dd/MM/yyyy}") %>' />
            <br />
            EmailAddress:
            <asp:HyperLink ID="hypEmailReadOnly" runat="server" NavigateUrl='<%# Eval("EmailAddress", "mailto:{0}") %>'
               Text='<%# Eval("EmailAddress") %>' />
            <br />
            Phone:
            <asp:Label ID="PhoneLabel" runat="server" Text='<%# Eval("Phone") %>' />
            <br />
            PasswordHash:
            <asp:Label ID="PasswordHashLabel" runat="server" Text='<%# Eval("PasswordHash") %>' />
            <br />
            PasswordSalt:
            <asp:Label ID="PasswordSaltLabel" runat="server" Text='<%# Eval("PasswordSalt") %>' />
            <br />
            <asp:Button runat="server" ID="btnSelect" Text="Select" CommandName="Select" />
            <asp:Button runat="server" ID="btnEdit" Text="Edit" CommandName="Edit" />
            <asp:Button runat="server" ID="btnDelete" Text="Delete" CommandName="Delete" />
         </ItemTemplate>
         <FooterStyle BackColor="#CCCCCC" />
         <AlternatingItemStyle BackColor="#CCCCCC" />
         <EditItemTemplate>
            NameStyle:
            <asp:CheckBox ID="NameStyleCheckBox" runat="server" Checked='<%# Bind("NameStyle") %>' />
            <br />
            Title:
            <asp:TextBox ID="TitleTextBox" runat="server" Text='<%# Bind("Title") %>' />
            <br />
            FirstName:
            <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstName") %>' />
            <br />
            MiddleName:
            <asp:TextBox ID="MiddleNameTextBox" runat="server" Text='<%# Bind("MiddleName") %>' />
            <br />
            LastName:
            <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>' />
            <br />
            Suffix:
            <asp:TextBox ID="SuffixTextBox" runat="server" Text='<%# Bind("Suffix") %>' />
            <br />
            CompanyName:
            <asp:TextBox ID="CompanyNameTextBox" runat="server" Text='<%# Bind("CompanyName") %>' />
            <br />
            SalesPerson:
            <asp:TextBox ID="SalesPersonTextBox" runat="server" Text='<%# Bind("SalesPerson") %>' />
            <br />
            EmailAddress:
            <asp:TextBox ID="EmailAddressTextBox" runat="server" Text='<%# Bind("EmailAddress") %>' />
            <br />
            Phone:
            <asp:TextBox ID="PhoneTextBox" runat="server" Text='<%# Bind("Phone") %>' />
            <br />
            <asp:Button runat="server" ID="btnUpdate" Text="Update" CommandName="Update" />
            <asp:Button runat="server" ID="btnCancel" Text="Cancel" CommandName="Cancel" />
         </EditItemTemplate>
         <SelectedItemStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
         <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
         <SelectedItemTemplate>
            FullName:
            <asp:Label ID="FullNameLabel" runat="server" Text='<%# Eval("FullName") %>' />
            <br />
            CompanyName:
            <asp:Label ID="CompanyNameLabel" runat="server" Text='<%# Eval("CompanyName") %>' />
            <br />
            SalesPerson:
            <asp:Label ID="SalesPersonLabel" runat="server" Text='<%# Eval("SalesPerson") %>' />
            <br />
            ModifiedDate:
            <asp:Label ID="ModifiedDateLabel" runat="server" Text='<%# Eval("ModifiedDate", "{0:dd/MM/yyyy}") %>' />
            <br />
            EmailAddress:
            <asp:HyperLink ID="hypEmailReadOnly" runat="server" NavigateUrl='<%# Eval("EmailAddress", "mailto:{0}") %>'
               Text='<%# Eval("EmailAddress") %>' />
            <br />
            Phone:
            <asp:Label ID="PhoneLabel" runat="server" Text='<%# Eval("Phone") %>' />
            <br />
            PasswordHash:
            <asp:Label ID="PasswordHashLabel" runat="server" Text='<%# Eval("PasswordHash") %>' />
            <br />
            PasswordSalt:
            <asp:Label ID="PasswordSaltLabel" runat="server" Text='<%# Eval("PasswordSalt") %>' />
            <br />
            <asp:Button runat="server" ID="btnCancelSelect" Text="Deselect" CommandName="Cancel" />
         </SelectedItemTemplate>
      </asp:DataList>
   </div>
   <asp:Label ID="lblInfo" runat="server" />
   </form>
</body>
</html>
