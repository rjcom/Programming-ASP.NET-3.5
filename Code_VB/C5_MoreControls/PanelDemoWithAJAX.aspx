<%@ Page Language="VB" AutoEventWireup="false" CodeFile="PanelDemoWithAJAX.aspx.vb" Inherits="PanelDemoWithAJAX" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Panel Extender Demo - DropShadows and DragPanels</title>

   <script type="text/javascript">
    
      function pageLoad() {
      }
    
   </script>

</head>
<body>
   <!--
      Add new AJAX ASP page. 
      Copy the pnlDynamic panel from non-AJAX page
      
      First extender is the DropShadowExtender. Add it to page under and set targetControlId to pnlDynamic. 
      Run page and observe. Change Opacity from default of 0.5, Rounded to true, and radius to 5. Run page again
      
      Second extender is the DragPanelExtender. Add it to page under and set targetControlId to pnlDynamic.
      Run page. Note how if you try and drag the panel lower than the end of the page if reverts back to its previous page.
      Try moving it up and it sticks. Now move it down and it goes back to that position. 
      Also the dropshadow stays where it was originally.
      
      So set the height of the div containing everything to 800px and 
      set the trackposition property of the dropshadowextender to true.
      Run the page again. Things work better but the dropshadow still waits for the drag to finish before it moves.
      Unfortunately, that's just how it works.
   -->
   <form id="form1" runat="server">
   <div style="height:800px;">
      <asp:ScriptManager ID="ScriptManager1" runat="server">
      </asp:ScriptManager>    
      <h1>
         Dynamic Contents</h1>
      <asp:Panel ID="pnlDynamic" runat="server" BackColor="Fuchsia" Height="150px" Width="80%"
         HorizontalAlign="Center" Font-Names="Courier" ScrollBars="Auto">
         This is static content in the panel.
         <br />
         This sentence is here to see the effect of changing the padding values. Padding
         values can be specified in terms of pixels (px), centimeters (cm), or percentage
         of the panel&#8217;s width (%).
         <p />
      </asp:Panel>
      <cc1:DropShadowExtender ID="DropShadowExtender1" runat="server" TargetControlID="pnlDynamic" TrackPosition="true">
      </cc1:DropShadowExtender>
      <cc1:DragPanelExtender ID="DragPanelExtender1" runat="server" TargetControlID="pnlDynamic">
      </cc1:DragPanelExtender>
            <table>
         <tr>
            <td>
               Number of labels:</td>
            <td>
               <asp:DropDownList ID="ddlLabels" runat="server">
                  <asp:ListItem Text="0" Value="0" />
                  <asp:ListItem Text="1" Value="1" />
                  <asp:ListItem Text="2" Value="2" />
                  <asp:ListItem Text="3" Value="3" />
                  <asp:ListItem Text="4" Value="4" />
               </asp:DropDownList>
            </td>
         </tr>
         <tr>
            <td>
               Number of textboxes:</td>
            <td>
               <asp:DropDownList ID="ddlBoxes" runat="server">
                  <asp:ListItem Text="0" Value="0" />
                  <asp:ListItem Text="1" Value="1" />
                  <asp:ListItem Text="2" Value="2" />
                  <asp:ListItem Text="3" Value="3" />
                  <asp:ListItem Text="4" Value="4" />
               </asp:DropDownList>
            </td>
         </tr>
         <tr>
            <td colspan="2">
               &nbsp;</td>
         </tr>
         <tr>
            <td>
               <asp:CheckBox ID="chkVisible" Text="Make Panel Visible" runat="server" />
            </td>
            <td>
               <asp:Button ID="btnRefresh" Text="Refresh Panel" runat="server" />
            </td>
         </tr>
      </table>
   </div>
   </form>
</body>
</html>

