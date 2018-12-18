<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DropDownListDemo.aspx.vb" Inherits="DropDownListDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>DropDownList Demo</title>
</head>
<body>
   <!--
      Add DropDownListDemo.aspx to website
      Drag DropDownList and Label to page. Call them ddlBooks and lblBookInfo respectively. Delete label's text property
      Set DragDownList AutoPostback propoerty to true so it will update label.
      Add code to Page_Load event handler
      Add handler for DropDownList's SelectedIndexChanged event. This is the default event so double clicking on control in design view will do it
      
   -->
   <form id="form1" runat="server">
   <div>
      <asp:DropDownList ID="ddlBooks" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlBooks_SelectedIndexChanged">
      </asp:DropDownList>
      <br />
      <br />
      <asp:Label ID="lblBookInfo" runat="server"></asp:Label>
   </div>
   </form>
</body>
</html>
