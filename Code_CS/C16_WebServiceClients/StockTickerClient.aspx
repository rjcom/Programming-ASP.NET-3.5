<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockTickerClient.aspx.cs" Inherits="StockTickerClient" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Ticker Client</title>
</head>
<body>
    <h1>Stock Ticker Simple Client</h1>
    <form id="form1" runat="server">
    <div>
      <p>
        <asp:Label ID="lblMessage" runat="server" />
      </p>
      <p>
        <asp:Button ID="btnPost" runat="server" Text="Post"  />
        <asp:Button ID="btnWebService" runat="server" Text="Web Service" 
          onclick="btnWebService_Click" />
      </p>
    </div>
    </form>
</body>
</html>
