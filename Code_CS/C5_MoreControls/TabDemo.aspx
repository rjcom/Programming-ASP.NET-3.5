<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TabDemo.aspx.cs" Inherits="TabDemo" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Tab Demo</title>

   <script type="text/javascript">
    
      function pageLoad() {
      }
    
   </script>
   
</head>
<body>
   <!--
      Create tabs page
      Copy top panel from Paneldemo.aspx to page
      Drag a TabContainer underneath the panel
      Drag two TabPanels into the TabContainer
      Copy ddlLabels into the first tabpanel and set headertext for tabpanel to Number of Labels
      Copy ddlBoxes into the second tabpanel and set headertext for tabpanel to Number of TextBoxes
      Copy btnRefresh onto the page under the tabcontainer and the relevant bits of the Page_Load handler
      Run Page
      
      Tweak TabContainer presentation with height, width and ActiveTabIndex (zero-based) properties
      Make each TabPanel visible or not using their Enabled property.
      
      You can also customize tabs appearance using CSS styles and the CssClass property for tabcontainer
      
   -->
   <form id="form1" runat="server">
   <div>
      <asp:ScriptManager ID="ScriptManager1" runat="server" />
      <asp:Panel ID="pnlDynamic" runat="server" BackColor="Fuchsia" Height="150px"
         HorizontalAlign="Center" ScrollBars="Auto">
         This is static content in the panel.
         <br />
         This sentence is here to see the effect of changing the padding values. Padding
         values can be specified in terms of pixels (px), centimeters (cm), or percentage
         of the panel&#8217;s width (%).
         <p />
      </asp:Panel>
      <br />
      <hr />
      <br />
      <cc1:TabContainer ID="TabContainer1" runat="server" Height="200" ActiveTabIndex="1">
         <cc1:TabPanel ID="TabPanel1" runat="server" HeaderText="Number of labels">
            <ContentTemplate>
               <p>How many labels should be added to the panel?</p>
               <asp:DropDownList ID="ddlLabels" runat="server">
                  <asp:ListItem Text="0" Value="0" />
                  <asp:ListItem Text="1" Value="1" />
                  <asp:ListItem Text="2" Value="2" />
                  <asp:ListItem Text="3" Value="3" />
                  <asp:ListItem Text="4" Value="4" />
               </asp:DropDownList>
            </ContentTemplate>
         </cc1:TabPanel>
         <cc1:TabPanel ID="TabPanel2" runat="server" HeaderText="Number of textboxes">
            <ContentTemplate>
            <p>How many textboxes should be added to the panel?</p>
               <asp:DropDownList ID="ddlBoxes" runat="server">
                  <asp:ListItem Text="0" Value="0" />
                  <asp:ListItem Text="1" Value="1" />
                  <asp:ListItem Text="2" Value="2" />
                  <asp:ListItem Text="3" Value="3" />
                  <asp:ListItem Text="4" Value="4" />
               </asp:DropDownList>
            </ContentTemplate>
         </cc1:TabPanel>
      </cc1:TabContainer>
      <br />
      <br />
      <asp:Button ID="btnRefresh" Text="Refresh Panel" runat="server" />
   </div>
   </form>
</body>
</html>
