<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CssDemo.aspx.cs" Inherits="CssDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Css Styles Demo</title>
   <style>@import url(StyleSheet.css); </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:Button ID="Button1" runat="server" Text="Button" CssClass="button" />
       <asp:Label ID="Label1" runat="server" Text="Label" CssClass="label"></asp:Label>
    </div>
    </form>
</body>
</html>
