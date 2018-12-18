<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckBoxList-ArrayItemsDataBind.aspx.cs"
   Inherits="CheckBoxList_ArrayItemsDataBind" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>CheckBoxListDemo - Bind Data Items from An Array</title>
</head>
<body>
   <!--
      Add checkBoxList-ArrayItemsDataBind.aspx to website
      Copy source and code from chacekboxlist-arrayitems.aspx
   -->
   <form id="form1" runat="server">
   <div>
        <asp:CheckBoxList ID="cblItems" runat="server" RepeatDirection="Horizontal" RepeatColumns="2"
            RepeatLayout="Flow" OnInit="cblItems_Init">
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
