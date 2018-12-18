<%@ Page Language="VB" AutoEventWireup="false" CodeFile="StateBagDemo.aspx.vb" Inherits="StateBagDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>State Bag Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <h1>State Bag</h1>
      Counter:
      <asp:Label ID="lblCounter" runat="server" />
      <asp:Button ID="btnIncrement" runat="server" Text="Increment Counter" />
   </div>
   </form>
</body>
</html>