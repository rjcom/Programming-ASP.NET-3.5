<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HyperLinkDemo.aspx.cs" Inherits="HyperLinkDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>HyperLink Demo</title>
</head>
<body>
   <!-- 
      Add web form hyperlinkdemo.aspx to site
      Drag hyperlink control onto page ID=hypLink. 
      Add NavigateURL, Target, Tooltip and Text properties.
      Add font properties as necessary
      
      Renders as <a id="hypLink" title="Visit Microsoft" href="http://www.microsoft.com" target="_blank" style="font-family:Impact;">Go to Microsoft</a>
   -->
   <form id="form1" runat="server">
   <div>
      <asp:HyperLink ID="hypLink" runat="server" NavigateUrl="http://www.microsoft.com" 
         ToolTip="Visit Microsoft" Font-Names="Verdana">Show Microsoft.com</asp:HyperLink> &nbsp;in&nbsp;
      <asp:DropDownList ID="ddlTarget" runat="server" AutoPostBack="true">
         <asp:ListItem Text="A New Window" Value="_blank" Selected="True" />
         <asp:ListItem Text="This Window" Value="_self" />
      </asp:DropDownList>
   </div>
   </form>
</body>
</html>
