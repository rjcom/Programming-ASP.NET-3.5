<%@ Page Language="VB" AutoEventWireup="false" CodeFile="CheckBoxList-DeclarativeItems.aspx.vb" Inherits="CheckBoxList_CheckBoxList_DeclarativeItems" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>CheckBoxList Demo - Declaring Items Individually</title>
</head>
<body>
   <!--
      Add CheckBoxList-DeclarativeItems.aspx to website.
      Add CheckBoxList control to page. ID = cblItems. 
      Type first three listitems directly into the source. Note intellisense offers <asp:ListItem> as the only choice inside the list.
      Switch to design view and use Collection Editor to add other three items. In common tasks dialog, choose add items.
      Note Collection editor picks up first three items and lets you set enabled and selected propeorties for each listitem as well as its text and value.
      Press OK when done.
      Run form.
      
      Experiment with RepeatDirection, RepeatLayout, RepeatColumns, Height, Width, Font-*, TextAlign, CellPadding and CellSpacing properties of the checkBoxList control to have it presented differently.
      
   -->
   <form id="form1" runat="server">
   <div>
      <asp:CheckBoxList ID="cblItems" runat="server" RepeatDirection="Horizontal" RepeatColumns="2" RepeatLayout="Flow">
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
