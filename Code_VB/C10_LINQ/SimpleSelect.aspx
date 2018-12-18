﻿<%@ Page Language="VB" AutoEventWireup="true" CodeFile="SimpleSelect.aspx.vb" Inherits="SimpleSelect" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>A Simple Linq Query</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:ListView runat="server" ID="lvwBooks">
         <LayoutTemplate>
            <ul>
               <asp:PlaceHolder runat="server" ID="itemPlaceholder" />
            </ul>
         </LayoutTemplate>
         <ItemTemplate>
            <li><%# Eval("ISBN") %> : <%# Eval("Released") %></li>
         </ItemTemplate>
      </asp:ListView>
    </div>
    </form>
</body>
</html>