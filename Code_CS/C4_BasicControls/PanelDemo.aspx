<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PanelDemo.aspx.cs" Inherits="PanelDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Panel Demo</title>
   <style type="text/css">
      .topPanel
      {
         padding: 20px;
      }
   </style>
</head>
<body>
   <!--
      Add web form called PanelDemo.aspx to website
      Add Panel control to page called pnlDynamic
      Set initial properties on panel control for changing later. 
      Also add text (static content) to the panel to see effect of padding changes.
      Add CSS style for panel
      
      Add a 4x2 table under pnlDynamic
      Top row. Add a DropDownList ddlLabels to select the number of Labels to add to the panel.
      Second row. Add a DropDownList ddlBoxes to select the number of TextBoxes to add to the panel.
      Third row. Spacer
      Fourth row. Add CheckBox chkHide and Button btnRefresh to trigger the visibility of the panel and refresh its contents.
      Add code to populate the panel to the Page_Load control. Hitting the Button already posts back the form so no need to handle any other events.
      Run page.
      
      Add second Panel control, pnlScroll, under the rest of the contents. Set height, width and groupingtext properties
      Add new Label control, lblPanelContent, to pnlScroll. Remove text property
      Add new 2x2 table under pnlScroll
      Top Row. Add a DropDownList ddlScrollBars to set the type of scrollbars on the panel.
      Second Row. Add a BulletedList rblWrap to define whether or not content wraps to the next line in the panel.
      For both lists, add listitems declaratively, set autopostback to true and selected to true for their first listitem
      Add an event handler for SelectedIndexChanged for each list with the given code.
   -->
   <form id="form1" runat="server">
   <div>
      <h1>
         Dynamically Generated Controls</h1>
      <asp:Panel ID="pnlDynamic" runat="server" Height="150" Width="80%" BackColor="beige"
         Font-Names="Courier New" HorizontalAlign="Center" CssClass="topPanel" ScrollBars="Auto">
         This is static content in the panel.
         <br />
         This sentence is here to see the effect of changing the padding values. Padding
         values can be specified in terms of pixels (px), centimeters (cm), or percentage
         of the panel&#8217;s width (%).
         <p />
         <p />
      </asp:Panel>
      <table>
         <tr>
            <td>
               Number of Labels</td>
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
               Number of TextBoxes</td>
            <td>
               <asp:DropDownList ID="ddlBoxes" runat="server">
                  <asp:ListItem Text="0" Value="0" />
                  <asp:ListItem Text="1" Value="1" />
                  <asp:ListItem Text="2" Value="2" />
                  <asp:ListItem Text="3" Value="3" />
                  <asp:ListItem Text="4" Value="4" />
               </asp:DropDownList></td>
         </tr>
         <tr>
            <td colspan="2">
               &nbsp;</td>
         </tr>
         <tr>
            <td>
               <asp:CheckBox ID="chkHide" Text="Hide Panel" runat="server" /></td>
            <td>
               <asp:Button ID="btnRefresh" runat="server" Text="Refresh Panel" /></td>
         </tr>
      </table>
      <h1>
         Scroll Bars &amp; Wrapping</h1>
      <asp:Panel ID="pnlScroll" runat="server" Height="200px" Width="90%" GroupingText="Scrollbars &amp; Wrap">
         <asp:Label ID="lblPanelContent" runat="server" />
      </asp:Panel>
      <table>
         <tr>
            <td align="right">
               ScrollBars:
            </td>
            <td>
               <asp:DropDownList ID="ddlScrollBars" runat="server" AutoPostBack="true" 
                  OnSelectedIndexChanged="ddlScrollBars_SelectedIndexChanged">
                  <asp:ListItem Text="None" Selected="True" />
                  <asp:ListItem Text="Auto" />
                  <asp:ListItem Text="Both" />
                  <asp:ListItem Text="Horizontal" />
                  <asp:ListItem Text="Vertical" />
               </asp:DropDownList>
            </td>
            <td align="right">
               Wrap:
            </td>
            <td>
               <asp:RadioButtonList ID="rblWrap" runat="server" AutoPostBack="true" RepeatDirection="Horizontal"
                  OnSelectedIndexChanged="rblWrap_SelectedIndexChanged">
                  <asp:ListItem Text="True" Value="true" Selected="True" />
                  <asp:ListItem Text="False" Value="false" />
               </asp:RadioButtonList>
            </td>
         </tr>
      </table>
   </div>
   </form>
</body>
</html>
