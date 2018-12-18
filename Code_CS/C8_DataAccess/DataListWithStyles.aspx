<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataListWithStyles.aspx.cs" Inherits="DataListWithStyles" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>A Black and Blue DataList</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <asp:SqlDataSource ID="dsCutomers" runat="server" 
          ConnectionString="<%$ ConnectionStrings:AWLTConnection %>" 
          
          SelectCommand="SELECT TOP 9 [CustomerID], [FirstName], [LastName], [CompanyName], [EmailAddress], [Phone], [ModifiedDate] FROM [SalesLT].[Customer]">
       </asp:SqlDataSource>
    
       <asp:DataList ID="DataList1" runat="server" BackColor="White" 
          BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
          DataKeyField="CustomerID" DataSourceID="dsCutomers" ForeColor="Black" 
          GridLines="Vertical" RepeatColumns="3" RepeatDirection="Horizontal">
          <FooterStyle BackColor="#CCCCCC" />
          <AlternatingItemStyle BackColor="#CCCCCC" />
          <SelectedItemStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
          <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
          <ItemTemplate>
             CustomerID:
             <asp:Label ID="CustomerIDLabel" runat="server" 
                Text='<%# Eval("CustomerID") %>' />
             <br />
             FirstName:
             <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
             <br />
             LastName:
             <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
             <br />
             CompanyName:
             <asp:Label ID="CompanyNameLabel" runat="server" 
                Text='<%# Eval("CompanyName") %>' />
             <br />
             EmailAddress:
             <asp:Label ID="EmailAddressLabel" runat="server" 
                Text='<%# Eval("EmailAddress") %>' />
             <br />
             Phone:
             <asp:Label ID="PhoneLabel" runat="server" Text='<%# Eval("Phone") %>' />
             <br />
             ModifiedDate:
             <asp:Label ID="ModifiedDateLabel" runat="server" 
                Text='<%# Eval("ModifiedDate") %>' />
             <br />
          </ItemTemplate>
       </asp:DataList>
    
    </div>
    </form>
</body>
</html>
