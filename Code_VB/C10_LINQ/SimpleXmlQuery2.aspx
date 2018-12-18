<%@ Page Language="VB" AutoEventWireup="true" CodeFile="SimpleXmlQuery2.aspx.vb" Inherits="SimpleXmlQuery2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Simple Xml Query 2</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
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