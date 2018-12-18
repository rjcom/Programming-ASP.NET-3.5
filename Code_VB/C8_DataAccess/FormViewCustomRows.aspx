<%@ Page Language="VB" AutoEventWireup="false" CodeFile="FormViewCustomRows.aspx.vb" Inherits="FormViewCustomRows" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Details View Custom Rows Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="dsCustomers" runat="server" ConnectionString="<%$ ConnectionStrings:AWLTConnection %>"
            SelectCommand="SELECT	[CustomerID], [NameStyle],
	CASE WHEN [Title] IS NULL THEN '' ELSE [Title] + ' ' END +
    [FirstName] + ' ' +
	CASE WHEN [MiddleName] IS NULL THEN '' ELSE [MiddleName] + ' ' END +
	[LastName] + 
	CASE WHEN [Suffix] IS NULL THEN '' ELSE ' ' + [Suffix] END as 'FullName',
	[Title], [FirstName], [MiddleName], [LastName], [Suffix],
	[CompanyName], [SalesPerson], [ModifiedDate], [EmailAddress], [Phone], 
	[PasswordHash], [PasswordSalt]
FROM [SalesLT].[Customer]" InsertCommand="INSERT INTO [SalesLT].[Customer] ([NameStyle], [Title], [FirstName], [MiddleName], [LastName], [Suffix], [CompanyName], [SalesPerson], [EmailAddress], [Phone], [PasswordHash], [PasswordSalt]) VALUES (@NameStyle, @Title, @FirstName, @MiddleName, @LastName, @Suffix, @CompanyName, @SalesPerson, @EmailAddress, @Phone, @PasswordHash, @PasswordSalt)"
            UpdateCommand="UPDATE [SalesLT].[Customer] SET [NameStyle] = @NameStyle, [Title] = @Title, [FirstName] = @FirstName, [MiddleName] = @MiddleName, [LastName] = @LastName, [Suffix] = @Suffix, [CompanyName] = @CompanyName, [SalesPerson] = @SalesPerson, [EmailAddress] = @EmailAddress, [Phone] = @Phone, [ModifiedDate] = GetDate() WHERE [CustomerID] = @CustomerID"
            DeleteCommand="DELETE FROM [SalesLT].[Customer] WHERE [CustomerID] = @CustomerID">
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
            <InsertParameters>
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
                <asp:Parameter Name="PasswordHash" Type="String" />
                <asp:Parameter Name="PasswordSalt" Type="String" />
            </InsertParameters>
        </asp:SqlDataSource>
        <asp:FormView ID="fvwCustomers" runat="server" AllowPaging="True" DataKeyNames="CustomerID"
            DataSourceID="dsCustomers" OnItemInserting="fvwCustomers_ItemInserting">
            <PagerSettings FirstPageText="First" LastPageText="Last" Mode="NextPreviousFirstLast"
                Visible="true" />
            <EmptyDataTemplate>
                No customers found I&#8217;m afraid
            </EmptyDataTemplate>
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
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update"
                    Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False"
                    CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
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
                Password:
                <asp:TextBox ID="PasswordTextBox" runat="server" />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert"
                    Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False"
                    CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                FullName:
                <asp:Label ID="FullNameLabel" runat="server" Text='<%# Bind("FullName") %>' />
                <br />
                CompanyName:
                <asp:Label ID="CompanyNameLabel" runat="server" Text='<%# Bind("CompanyName") %>' />
                <br />
                SalesPerson:
                <asp:Label ID="SalesPersonLabel" runat="server" Text='<%# Bind("SalesPerson") %>' />
                <br />
                ModifiedDate:
                <asp:Label ID="ModifiedDateLabel" runat="server" Text='<%# Bind("ModifiedDate", "{0:hh:mm, dd MMM yyyy}") %>' />
                <br />
                EmailAddress:
                <asp:HyperLink ID="hypEmailReadOnly" runat="server" NavigateUrl='<%# Eval("EmailAddress", "mailto:{0}") %>'
                    Text='<%# Bind("EmailAddress") %>' />
                <br />
                Phone:
                <asp:Label ID="PhoneLabel" runat="server" Text='<%# Bind("Phone") %>' />
                <br />
                PasswordHash:
                <asp:Label ID="PasswordHashLabel" runat="server" Text='<%# Bind("PasswordHash") %>' />
                <br />
                PasswordSalt:
                <asp:Label ID="PasswordSaltLabel" runat="server" Text='<%# Bind("PasswordSalt") %>' />
                <br />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit"
                    Text="Edit" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New"
                    Text="New" />
                &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete"
                    Text="Delete" />
            </ItemTemplate>
        </asp:FormView>
    </div>
    </form>
</body>
</html>
