<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListViewCustomRows.aspx.cs"
    Inherits="ListViewCustomRows" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ListView Custome Rows</title>
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
        <br />
        <asp:ListView ID="ListView1" runat="server" DataKeyNames="CustomerID" DataSourceID="dsCustomers"
            GroupItemCount="2" OnItemInserting="lvw_ItemInserting" InsertItemPosition="FirstItem">
            <LayoutTemplate>
                <table>
                    <asp:PlaceHolder ID="groupPlaceholder" runat="server" />
                </table>
            </LayoutTemplate>
            <GroupTemplate>
                <tr>
                    <asp:PlaceHolder runat="server" ID="itemPlaceholder" />
                </tr>
            </GroupTemplate>
            <ItemTemplate>
                <td>
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
                    <asp:Button runat="server" ID="btnEdit" Text="Edit" CommandName="Edit" CausesValidation="false" />
                    <asp:Button runat="server" ID="btnDelete" Text="Delete" CommandName="Delete" CausesValidation="false" />
                </td>
            </ItemTemplate>
            <EditItemTemplate>
                <td>
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
                    <asp:Button runat="server" ID="btnUpdate" Text="Update" CommandName="Update" CausesValidation="true" />
                    <asp:Button runat="server" ID="btnCancel" Text="Cancel" CommandName="Cancel" CausesValidation="false" />
                </td>
            </EditItemTemplate>
            <InsertItemTemplate>
                <td>
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
                    <asp:TextBox ID="NewPasswordTextBox" runat="server" />
                    <br />
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" CausesValidation="true" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" CausesValidation="false" />
                </td>
            </InsertItemTemplate>
            <EmptyDataTemplate>
                <td>
                    No data was returned.
                </td>
            </EmptyDataTemplate>
        </asp:ListView>
        <asp:DataPager ID="DataPager1" runat="server" PageSize="3" PagedControlID="ListView1">
            <Fields>
                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
            </Fields>
        </asp:DataPager>
    </div>
    </form>
</body>
</html>
