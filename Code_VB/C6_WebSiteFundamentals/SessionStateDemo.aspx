<%@ Page Language="VB" AutoEventWireup="false" CodeFile="SessionStateDemo.aspx.vb" Inherits="SessionStateDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Session State Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Session State</h1>
        <h3>
            Select a book category</h3>
        <asp:RadioButtonList ID="rbl" runat="server" CellSpacing="20" RepeatColumns="3"
            RepeatDirection="Horizontal" OnSelectedIndexChanged="rbl_SelectedIndexChanged">
            <asp:ListItem Value="n">.NET</asp:ListItem>
            <asp:ListItem Value="d">Databases</asp:ListItem>
            <asp:ListItem Value="h">Hardware</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="btn" runat="server" Text="Submit" OnClick="btn_Click" />
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server" />
        <br />
        <br />
        <asp:DropDownList ID="ddl" runat="server" Visible="False" />
    </div>
    </form>
</body>
</html>
