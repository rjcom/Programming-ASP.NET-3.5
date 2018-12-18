<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ListBoxDemo.aspx.vb" Inherits="ListBoxDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>ListBox Demo</title>
</head>
<body>
   <!--
      Add new web form ListBoxDemo.aspx to web site
      Add a ListBox and Label to demo single selection. Call them lbxSingle and lblSingle.
      Add a ListBox and Label to demo multiple selection. Call them lbxMulti and lblMulti.
      Add a couple of headings onscreen to distinguish between the two
      Set AutoPostback to true and delete text property from both labels.
      Set SelectionMode=Multiple for lbxMulti
      Add code for Page_Load handler
      Create SelectedIndexChanged handlers for both listboxes. Double-clicking on them in design view will work.
      Add code to handlers.
   -->
   <form id="form1" runat="server">
   <div>
      <h2>
         Single Selection</h2>
      <asp:ListBox ID="lbxSingle" runat="server" AutoPostBack="true" Rows="6"
         onselectedindexchanged="lbxSingle_SelectedIndexChanged"></asp:ListBox>
      <br />
      <br />
      <asp:Label ID="lblSingle" runat="server"></asp:Label>
      <h2>
         Multiple Selection</h2>
      <asp:ListBox ID="lbxMulti" runat="server" AutoPostBack="true" 
         SelectionMode="Multiple" onselectedindexchanged="lbxMulti_SelectedIndexChanged"></asp:ListBox>
      <br />
      <br />
      <asp:Label ID="lblMulti" runat="server"></asp:Label>
   </div>
   </form>
</body>
</html>
