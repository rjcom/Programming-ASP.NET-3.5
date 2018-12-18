<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckBoxList-ArrayItemsAndValues.aspx.cs" Inherits="CheckBoxList_ArrayItemsAndValues" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>CheckBoxListDemo - Populating Items From An Array</title>
</head>
<body>
   <!--
      Add CheckBoxList-ArrayItemsAndValues.aspx to website.
      Copy source and C# from CheckBoxlist-ArrayItems.aspx
      Add value params to listitems in source
      Add second array to code and modify loop
      Run form.
      
   -->   
   <form id="form1" runat="server">
   <div>
        <asp:CheckBoxList ID="cblItems" runat="server" RepeatDirection="Horizontal" RepeatColumns="2"
            RepeatLayout="Flow" OnInit="cblItems_Init">
         <asp:ListItem Value="1">Item 1</asp:ListItem>
         <asp:ListItem Value="2" Text="Item 2" />
         <asp:ListItem Text="Item 3" />
         <asp:ListItem Text="Item 4">Inner Item 4</asp:ListItem>
         <asp:ListItem Value="5"></asp:ListItem>
         <asp:ListItem>Item 6</asp:ListItem>
      </asp:CheckBoxList>
   </div>
   </form>
</body>
</html>
