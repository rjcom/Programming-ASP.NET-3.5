<%@ Page Language="VB" AutoEventWireup="false" CodeFile="CheckBoxList-ArrayItems.aspx.vb" Inherits="CheckBoxList_CheckBoxList_ArrayItems" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>CheckBoxListDemo - Populating Items From An Array</title>
</head>
<body>
    <!--
      Add CheckBoxList-ArrayItems.aspx to website.
      Add CheckBoxList control to page. ID = cblItems. 
      Type all six listitems directly into the source as before.
      Switch to design view and add an handler to cblItems for the Init event.
      Run form.
      
   -->
    <form id="form1" runat="server">
    <div>
        <asp:CheckBoxList ID="cblItems" runat="server" RepeatDirection="Horizontal" RepeatColumns="2"
            RepeatLayout="Flow">
            <asp:ListItem>Item 1</asp:ListItem>
            <asp:ListItem>Item 2</asp:ListItem>
            <asp:ListItem>Item 3</asp:ListItem>
            <asp:ListItem>Item 4</asp:ListItem>
            <asp:ListItem>Item 5</asp:ListItem>
            <asp:ListItem>Item 6</asp:ListItem>
        </asp:CheckBoxList>
    </div>
    </form>
</body>
</html>

