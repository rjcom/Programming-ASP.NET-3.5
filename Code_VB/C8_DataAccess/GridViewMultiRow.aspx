<%@ Page Language="VB" AutoEventWireup="false" CodeFile="GridViewMultiRow.aspx.vb" Inherits="GridViewMultiRow" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>GridView Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:SqlDataSource ID="dsCustomers" runat="server" ConnectionString="<%$ ConnectionStrings:AWLTConnection %>"
         SelectCommand="SELECT [CustomerId], [FirstName], [LastName], [EmailAddress] FROM [SalesLT].[Customer]"></asp:SqlDataSource>
      <asp:GridView ID="gvwCustomers" runat="server" DataSourceID="dsCustomers"
         AllowPaging="True" PageSize="5" BackColor="White" BorderColor="#999999" 
           BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" 
           GridLines="Vertical" Caption="This is the caption" ShowFooter="true" ShowHeader="true">
          <Columns>
              <asp:CommandField ShowSelectButton="True" />
          </Columns>
          <FooterStyle BackColor="#CCCCCC" />
          <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
          <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
          <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
          <AlternatingRowStyle BackColor="#CCCCCC" />
      </asp:GridView>
   </div>
   </form>
</body>
</html>