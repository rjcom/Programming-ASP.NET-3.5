﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Deployment Example</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <h1>Deployment Example</h1>
      <h2>Home Page</h2>
      <asp:Label ID="lblTime" runat="server" />
      <br />
      <asp:Button ID="btn1stPage" runat="server" 
         Text="Go To First Page" OnClick="btn1stPage_Click" />
      <asp:Button ID="btn2ndPage" runat="server" 
         Text="Go To Second Page" OnClick="btn2ndPage_Click" />
   </div>
   </form>
</body>
</html>
