<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ButtonDemoWithAJAX.aspx.vb" Inherits="ButtonDemoWithAJAX" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Button Demo With AJAX</title>

   <script type="text/javascript">
    
      function pageLoad() {
      }
    
   </script>

</head>
<body>
   <!--
      Add AJAX web form ButtonDemoWithAJAX.aspx to site
      Both extenders apply to all three types of button so just use standard button control
      Copy Button control from ButtonDemo.aspx 
      Add click handler for button which redirects browser to url
      Run and try it out
      
      Now add confirmbuttonextender to the page and set targetcontrolid to btnLink and confirmtext.
      Run again. When you click button a dialog pops up asking you to confirm that you want to navigate away
      If you click Cancel, form is not posted back and script in OnClientCancel is called. Very handy for form submission\validation
      
      We'll look at the ModalPopup, the other extender control for a button, a little later on. It works a littel like the confirmextender but relies on us using a panel to define a set of controls to display instead of an alert dialog.
      ModalPopups in Chapter 5.
   -->
   <form id="form1" runat="server">
   <div>
      <asp:ScriptManager ID="ScriptManager1" runat="server" />
      <asp:Button runat="server" ID="btnLink" Text="Link to target page" ToolTip="Click here to go to target page"
         OnClick="btnLink_Click" />
      <cc1:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" TargetControlID="btnLink"
         ConfirmText="Are you sure you want to leave us?">
      </cc1:ConfirmButtonExtender>
   </div>
   </form>
</body>
</html>
