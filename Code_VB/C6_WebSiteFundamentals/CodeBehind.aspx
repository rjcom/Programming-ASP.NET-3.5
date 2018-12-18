<%@ Page Language="VB" AutoEventWireup="false" CodeFile="CodeBehind.aspx.vb" Inherits="CodeBehind" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>CodeBehind</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <h1>Code Behind Demo</h1>
       <asp:Button ID="btnHello" runat="server" 
         Text="Hello" onclick="btnHello_Click" /><br />
       <asp:Label ID="lblMessage" runat="server" />
    </div>
    </form>
</body>
</html>
