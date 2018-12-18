<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckBoxList-RespondingToEvents.aspx.cs" Inherits="CheckBoxList_RespondingToEvents" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CheckBoxList - Responding To Events</title>
</head>
<body>
   <!--
      Add CheckBoxList-RespondingToEvents.aspx to website
      Copy source and code from CheckBoxList-ArrayItemsDataBind.aspx
      Set CheckBoxList AutoPostback propeorty to true
      Add Label, ID lblGenre below CheckBoxList and remove text property
      Add OnSelectedIndexChanged property and event handler. 
      Need to add Using System.text to code for StringBuilder too.
   -->
    <form id="form1" runat="server">
    <div>
      <asp:CheckBoxList ID="cblItems" runat="server" oninit="cblItems_Init" AutoPostBack="true"
         OnSelectedIndexChanged="cblItems_SelectedIndexChanged">
         
         <asp:ListItem>Item 1</asp:ListItem>
         <asp:ListItem>Item 2</asp:ListItem>
         <asp:ListItem>Item 3</asp:ListItem>
         <asp:ListItem>Item 4</asp:ListItem>
         <asp:ListItem>Item 5</asp:ListItem>
         <asp:ListItem>Item 6</asp:ListItem>
      </asp:CheckBoxList>
       <asp:Label ID="lblCategory" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
