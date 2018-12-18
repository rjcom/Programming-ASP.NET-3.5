<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DetailsViewCustomRows.aspx.cs"
   Inherits="DetailsViewCustomRows" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
FROM [SalesLT].[Customer]"
      InsertCommand="INSERT INTO [SalesLT].[Customer] ([NameStyle], [Title], [FirstName], [MiddleName], [LastName], [Suffix], [CompanyName], [SalesPerson], [EmailAddress], [Phone], [PasswordHash], [PasswordSalt]) VALUES (@NameStyle, @Title, @FirstName, @MiddleName, @LastName, @Suffix, @CompanyName, @SalesPerson, @EmailAddress, @Phone, @PasswordHash, @PasswordSalt)"
      UpdateCommand="UPDATE [SalesLT].[Customer] SET [NameStyle] = @NameStyle, [Title] = @Title, [FirstName] = @FirstName, [MiddleName] = @MiddleName, [LastName] = @LastName, [Suffix] = @Suffix, [CompanyName] = @CompanyName, [SalesPerson] = @SalesPerson, [EmailAddress] = @EmailAddress, [Phone] = @Phone, [ModifiedDate] = GetDate() WHERE [CustomerID] = @CustomerID">
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
      <asp:DetailsView ID="dvwCustomers" runat="server" AllowPaging="True" 
         AutoGenerateRows="False" DataSourceID="dsCustomers" onmodechanged="dvwCustomers_ModeChanged" 
         DataKeyNames="CustomerID" oniteminserting="dvwCustomers_ItemInserting">
         <PagerSettings FirstPageText="First" LastPageText="Last" PageButtonCount="5" />
         <EmptyDataTemplate>
            No customers found I&#39;m afraid
         </EmptyDataTemplate>
         <Fields>
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
                  <asp:HyperLink ID="hypEmailReadOnly" runat="server" 
                     NavigateUrl='<%# Eval("EmailAddress", "mailto:{0}") %>' 
                     Text='<%# Eval("EmailAddress") %>'></asp:HyperLink>
               </ItemTemplate>
               <EditItemTemplate>
                  <asp:TextBox ID="txtEmailEdit" runat="server" 
                     Text='<%# Bind("EmailAddress") %>' />
               </EditItemTemplate>
               <InsertItemTemplate>
                  <asp:TextBox ID="txtEmailInsert" runat="server" 
                     Text='<%# Bind("EmailAddress") %>' />
               </InsertItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
            <asp:BoundField DataField="SalesPerson" HeaderText="SalesPerson" />
            <asp:BoundField DataField="ModifiedDate" DataFormatString="{0:hh:mm, dd MMM yyyy}" HeaderText="Last Modified" ReadOnly="true" />   
            <asp:BoundField DataField="PasswordHash" HeaderText="Password Hash" 
               ReadOnly="True" SortExpression="PasswordHash" />
            <asp:BoundField DataField="PasswordSalt" HeaderText="Password Salt" 
               ReadOnly="True" SortExpression="PasswordSalt" />
            <asp:TemplateField HeaderText="Password" Visible="false">
               <InsertItemTemplate>
                  <asp:TextBox ID="txtPasswordInsert" runat="server" />
               </InsertItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ButtonType="Button" ShowEditButton="True" 
               ShowInsertButton="True" />
         </Fields>
      </asp:DetailsView>
<!--      <p>
         CustomerID field is auto-generated by db but required by db as DataKey so retrieve as a field but hidden and read-only</p>
         <p>
         NameStyle indicates should be editable and insertable but not visible when read. </p>
         <p>
         FullName shows name in western style depending on NameStyle. Also Read-only. </p>
         <p>
         Other name fields should be used for editing. Left as exercise for reader to alter fullname field in SQL to reflect NameStyle option</p>
         <p>
         Email Address field demonstrates difference between #Bind and #Eval. Data-binding expressions are contained within &lt;%# and %&gt; delimiters and use the Eval and Bind functions. The Eval function is used to define one-way (read-only) binding. The Bind function is used for two-way (updatable) binding. In addition to calling Eval and Bind methods to perform data binding in a data-binding expression, you can call any publicly scoped code within the &lt;%# and %&gt; delimiters to execute that code and return a value during page processing. Data-binding expressions are resolved when the DataBind method of a control or of the Page class is called. For controls such as the GridView, DetailsView, and FormView controls, data-binding expressions are resolved automatically during the control's PreRender event and you are not required to call the DataBind method explicitly.</p>
         <p>
         Sales Person row could be turned into a DropDownList of distinct SalesPeople at AdventureWorks, but we don't have a full list, so can't do that
         </p>
         <p>
         Modified Date should be read-only and not visible when editing or adding a new field. It will be added automatically in the database on insertion and in the the sql on updates
         </p>
         <p>
         Password Salt and Password Hash need to be calculated before the row is inserted from the Password field. We use some hashing in the RowInserting event
         </p> -->
   </div>
   </form>
</body>
</html>
