﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="OutputCaching.aspx.vb" Inherits="OutputCaching" %>

<%@ OutputCache Duration="60" VaryByParam="*" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Output Caching Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:Label ID="lblTime" runat="server" /><br />
      <asp:Label ID="lblUserName" runat="server" /><br />
      <asp:Label ID="lblState" runat="server" />
    </div>
    </form>
</body>
</html>
