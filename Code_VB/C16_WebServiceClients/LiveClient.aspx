<%@ Page Language="VB" AutoEventWireup="true" CodeFile="LiveClient.aspx.vb" Inherits="LiveClient" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>MS Live Search Service Client</title>
</head>
<body>
  <h1>MS Live Search Service Client</h1>
  <form id="form1" runat="server">
  <div>
    <p>
      <asp:TextBox ID="txtSearchFor" runat="server"></asp:TextBox>
      <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
    </p>
    <p>
      <asp:Label runat="server" ID="lblResults" />
    </p>
  </div>
  </form>
</body>
</html>
