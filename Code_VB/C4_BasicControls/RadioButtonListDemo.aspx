<%@ Page Language="VB" AutoEventWireup="false" CodeFile="RadioButtonListDemo.aspx.vb" Inherits="RadioButtonListDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>RadioButtonList Demo</title>
</head>
<body>
   <!--
      Add RadioButtonList.aspx to web site
      Drag RadioButtonList and Label to page. Call them rblSize and lblTime respectively.
      Add init event handler for Label and add code as in previous pages.
      Set AutoPostBack to true for RadioButtonList so selection changes will post the page back.
      Add event handler for SelectedIndexChanged for rblSize. This is the default event for RadioButtonlist so double click on it in design view will work.
      Add ListItems decalratively to rblSize in source view or with collection editor in design view.
   -->
   <form id="form1" runat="server">
   <div>
      <asp:RadioButtonList ID="rblSize" runat="server" AutoPostBack="true" 
         onselectedindexchanged="rblSize_SelectedIndexChanged">
         <asp:ListItem Text="10pt" Value="10" />
         <asp:ListItem Text="14pt" Value="14" />
         <asp:ListItem Text="16pt" Value="16" />
      </asp:RadioButtonList>
      <br />
      <br />
      <asp:Label ID="lblTime" runat="server" OnInit="lblTime_Init"></asp:Label>
   </div>
   </form>
</body>
</html>
