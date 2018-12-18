<%@ Page Language="VB" AutoEventWireup="false" CodeFile="XmlDataSource.aspx.vb" Inherits="XmlDataSource" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>XML Data Source Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <asp:XmlDataSource ID="XmlDataSource1" runat="server" 
          DataFile="http://feeds.feedburner.com/oreilly/newbooks" 
          TransformFile="~/XSLTFile.xslt" XPath="feed/entry"></asp:XmlDataSource>
    
    </div>
    <asp:GridView ID="GridView1" runat="server" DataSourceID="XmlDataSource1" 
        BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
        CellPadding="4" CellSpacing="2" ForeColor="Black">
        <FooterStyle BackColor="#CCCCCC" />
        <RowStyle BackColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
    </form>
</body>
</html>
