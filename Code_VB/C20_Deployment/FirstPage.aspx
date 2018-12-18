<%@ Page Language="VB" AutoEventWireup="false" CodeFile="FirstPage.aspx.vb" Inherits="FirstPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Deployment Example</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <h1>Deployment Example</h1>
      <h2>First Page</h2>
      <asp:Button ID="btnHomePage" runat="server" 
         Text="Go To Home Page" OnClick="btnHomePage_Click" />
      <asp:Button ID="btn2ndPage" runat="server" 
         Text="Go To Second Page" OnClick="btn2ndPage_Click" />
   </div>
   </form>
</body>
</html>

