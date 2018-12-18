<%@ Page Language="VB" AutoEventWireup="false" CodeFile="CheckBoxDemo.aspx.vb" Inherits="CheckBoxDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Checkbox Demo</title>
</head>
<body>
   <!--
      Add CheckBoxDemo.aspx to web site
      Add three checkbox controls, with ID chkUnderline, chkOverline, chkStrikeOut and appropriate Text properties.
      Add Label, with ID lblTime. Clear text property. 
      Add handler for lblTime_OnInit
      Add handler for CheckedChanged event for all three checkBoxes
   -->
   <form id="form1" runat="server">
   <div>
      <asp:CheckBox ID="chkUnderline" runat="server" Text="Underline?" oncheckedchanged="chkUnderline_CheckedChanged"
         AutoPostBack="true" />
      <asp:CheckBox ID="chkOverline" runat="server" Text="Overline?" oncheckedchanged="chkOverline_CheckedChanged"
         AutoPostBack="true" />
      <asp:CheckBox ID="chkStrikeout" runat="server" Text="Strikeout?" oncheckedchanged="chkStrikeout_CheckedChanged"
         AutoPostBack="true" />
      <br />
      <br />
      <asp:Label ID="lblTime" runat="server" oninit="lblTime_Init" />
   </div>
   </form>
</body>
</html>
