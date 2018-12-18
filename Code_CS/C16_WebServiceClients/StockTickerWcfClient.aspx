<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockTickerWcfClient.aspx.cs"
  Inherits="StockTickerWcfClient" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>WCF Stock Ticker Service Client</title>
</head>
<body>
  <h1>
    WCF Stock Ticker Service Client</h1>
  <form id="form1" runat="server">
  <div>
    <p>
      Select a Stock :
      <asp:DropDownList ID="ddlStocks" runat="server" />
      <asp:Label ID="lblMessage" runat="server" />
    </p>
    <p>
      <asp:Button ID="btnGetPrice" runat="server" OnClick="btnGetPrice_Click" Text="Get Stock Price" />
    </p>
  </div>
  </form>
</body>
</html>
