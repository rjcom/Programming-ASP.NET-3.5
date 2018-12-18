<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Tracing, Debugging & Error Handling</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:Label ID="lblHeader" runat="server" Font-Bold="True" Font-Names="Arial Black"
         Text="Tracing, Debugging and Error Handling"></asp:Label>
      <br />
      <asp:DropDownList ID="ddlBooks" runat="server" AutoPostBack="True">
      </asp:DropDownList>
      <br />
      <asp:Label ID="lblBooks" runat="server"></asp:Label>
      <br />
      <asp:HyperLink ID="hypBookLink" runat="server" NavigateUrl="TestLink.aspx">Link 
       To</asp:HyperLink>
   </div>
   </form>
</body>
</html>
