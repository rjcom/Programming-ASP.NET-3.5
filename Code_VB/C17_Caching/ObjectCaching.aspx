﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ObjectCaching.aspx.vb" Inherits="ObjectCaching" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Object Caching Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:Label ID="lblMessage" runat="server" /><br />
       <asp:GridView ID="gvwCustomers" runat="server" /><br />
       <asp:Button ID="btnClear" runat="server" Text="Clear Cache" 
          onclick="btnClear_Click" />        
       <asp:Button ID="btnPost" runat="server" Text="Post" />
    </div>
    </form>
</body>
</html>
