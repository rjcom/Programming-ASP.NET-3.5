﻿<%@ Page Language="C#" AutoEventWireup="true" 
   CodeFile="SecondPage.aspx.cs" Inherits="SecondPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Deployment Example</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <h1>Deployment Example</h1>
      <h2>Second Page</h2>
      <asp:Button ID="btnHomePage" runat="server" 
         Text="Go To Home Page" OnClick="btnHomePage_Click" />
      <asp:Button ID="btn1stPage" runat="server" 
         Text="Go To First Page" OnClick="btn1stPage_Click" />
   </div>
   </form>
</body>
</html>
