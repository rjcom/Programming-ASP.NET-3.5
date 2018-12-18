<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ButtonDemo.aspx.cs"
   Inherits="ButtonDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Button Demo</title>
</head>
<body>
   <!--
      Add buttondemo.aspx web form to site
      Add button control to page. ID=btnlink. Add text and tooltip to control
      Get image for imagebutton (Note where to find it). Add to website
      Add imagebutton control to page. ID=imgLink". Allow intellisense to help set Imageurl. Set alternatetext and tooltip as for button control
      Add LinkButton control to page. ID="lnkLink". Set Tooltip and text as before. Change font-name and font-size as you prefer.
      Add Click event to Button control by double-clicking on it in design view or editing it.
      Set onclick for imagebutton and linkbutton to same event with onclick="btnLink_Click"
      
      If they want to, reader can experiment with redirecting the page elsewhere. For example with the AJAX button extensions.
   -->
   <form id="form1" runat="server">
   <div>
      <asp:Button runat="server" ID="btnLink" Text="Link to target page" 
         ToolTip="Click here to go to target page" onclick="btnLink_Click" />
      <asp:ImageButton runat="server" ID="imgLink" ImageUrl="~/popflyDuck.png" AlternateText="Link to target page" ToolTip="Click here to go to target page" onclick="btnLink_Click" />
      <asp:LinkButton runat="server" ID="lnkLink" ToolTip="Click here to go to target page" Font-Names="Impact" Font-Size="X-Large" onclick="btnLink_Click">Link to Target Page</asp:LinkButton>
   </div>
   </form>
</body>
</html>
