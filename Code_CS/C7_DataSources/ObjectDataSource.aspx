<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ObjectDataSource.aspx.cs" Inherits="ObjectDataSource" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ObjectDataSource Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
          SelectMethod="GetCustomers" TypeName="Customer"></asp:ObjectDataSource>
    
    </div>
    <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" 
       BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" 
       DataSourceID="ObjectDataSource1" ForeColor="Black" CellSpacing="2">
        <FooterStyle BackColor="#CCCCCC" />
        <RowStyle BackColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
    </form>
</body>
</html>
