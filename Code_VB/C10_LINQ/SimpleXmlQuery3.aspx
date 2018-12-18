<%@ Page Language="VB" AutoEventWireup="true" CodeFile="SimpleXmlQuery3.aspx.vb" Inherits="SimpleXmlQuery3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>A Simple Xml Query</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:GridView runat="server" ID="gvwAuthors" />
      <asp:ListView runat="server" ID="lvwAuthors">
         <LayoutTemplate>
            <ul>
               <asp:PlaceHolder runat="server" ID="itemPlaceholder" />
            </ul>
         </LayoutTemplate>
         <ItemTemplate>
            <li><%# Eval("AuthorId") %></li>
         </ItemTemplate>
      </asp:ListView>
    </div>
    </form>
</body>
</html>
