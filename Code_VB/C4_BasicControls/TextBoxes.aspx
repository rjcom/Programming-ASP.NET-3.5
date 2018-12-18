<%@ Page Language="VB" AutoEventWireup="false" CodeFile="TextBoxes.aspx.vb" Inherits="TextBoxes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Textbox Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:TextBox ID="txtInput" runat="server" AutoPostBack="true" 
          ontextchanged="txtInput_TextChanged">Enter some text</asp:TextBox>
       <asp:TextBox ID="txtEcho" runat="server" BackColor="lightgray" ReadOnly="true"></asp:TextBox>
    </div>
    </form>
</body>
</html>
