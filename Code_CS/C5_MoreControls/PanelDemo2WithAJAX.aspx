<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PanelDemo2WithAJAX.aspx.cs"
   Inherits="PanelDemo2WithAJAX" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Untitled Page</title>

   <script type="text/javascript">
    
      function pageLoad() {
      }
    
   </script>

</head>
<body>
   <!--
      Demo of CollapsiblePanel and Accordion Controls
      CP Stage1. 
      Create label lblChoice, two more labels (lblCollapse and lblExpand so no postback) and panel pnlWebsites with radioButtonlist inside it. The idea is that when you click on the label, the panel will appear until you click on the label again. (Note that the CP will survive postback and retain state. Compare and contrast at some point with the DropDown control, which can be emulated with this but works slightly differently (uses an UpdatePanel for a start)
      Now add CollapsiblePanelExtender with ID and runat. We want pnlWebsites to collapse, so TargetControlID="pnlWebsites".
      Running the page doesn't do much at the moment as the collapse/expand actions aren't hooked up to anything in particular.
      Set CollapseControlID and ExpandControlID to respective labels and Collapsed to true.
      Run page and even if it doesn't look like you can, click the text labels to expand or collapse the panel.
      Don't forget to select a value just to verify that postbacks still occur.
      
     Extend it a bit. The CPE allows you to specify other controls whose values changes depending on whether the panel is collapsed or visible.
     First a text control like a label. Set textControlID, expandedtext and collapsedtext accordingly
     Second an image control. Set imageControlID, expandedimage and collapsedimage accordingly
     Third step - a few tweaks. expanddirection and collapsedsize. Note collapsedsize is ints only without the px. 
     AutoExpand and AutoCollapse set to true if you want to toggle the state of the panel by mousing over it.
   -->
   <form id="form1" runat="server">
   <div>
      <asp:ScriptManager ID="ScriptManager1" runat="server" />
      <p>
         <asp:Label ID="lblCollapse" runat="server" Text="Click to Collapse" />
         ||
         <asp:Label ID="lblExpand" runat="server" Text="Click to Expand" />
      </p>
      <p>
         <asp:Image ID="imgToggle" runat="server" /> : <asp:Label ID="lblState" runat="server" />
      </p>
      <p>
         <asp:Label ID="lblChoices" runat="server" />
      </p>
      <p>
         <cc1:CollapsiblePanelExtender ID="CollapsiblePanelExtender1" runat="server" TargetControlID="pnlWebsites"
            CollapseControlID="lblCollapse" ExpandControlID="lblExpand" Collapsed="true" 
            ExpandedText="Currently Expanded" CollapsedText="Currently Collapsed" TextLabelID="lblState"
            ExpandedImage="ToggleButton_Checked.gif" CollapsedImage="ToggleButton_Unchecked.gif" ImageControlID="imgToggle"
            ExpandDirection="Horizontal" CollapsedSize="100">
         </cc1:CollapsiblePanelExtender>
         <asp:Panel runat="server" ID="pnlWebSites">
            <asp:RadioButtonList ID="rblWebsites" runat="server" AutoPostBack="true">
               <asp:ListItem Value="http://www.oreilly.com/">O&#8217;Reilly &amp; Associates</asp:ListItem>
               <asp:ListItem Value="http://www.LibertyAssociates.com">Liberty Associates</asp:ListItem>
               <asp:ListItem Value="http://www.stersol.com" Text="Sterling Solutions"></asp:ListItem>
               <asp:ListItem Value="http://www.hmobius.com">Hmobius</asp:ListItem>
            </asp:RadioButtonList>
         </asp:Panel>
      </p>
   </div>
   </form>
</body>
</html>
