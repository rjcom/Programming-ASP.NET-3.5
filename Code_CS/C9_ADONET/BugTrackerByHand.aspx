﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BugTrackerByHand.aspx.cs" Inherits="BugTrackerByHand" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bug Tracker</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:GridView ID="BugsGridView" runat="server">
       </asp:GridView>
       <asp:GridView ID="BugConstraintsGridView" runat="server">
       </asp:GridView>
    </div>
    </form>
</body>
</html>
