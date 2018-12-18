<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PanelDemo.aspx.cs" Inherits="PanelDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Panel Demo</title>
</head>
<body>
   <!--
      First Demo. Dynamically Adding Controls To The Panel
      Add Panel control with ID pnlDynamic and height 150px and width 80%
      Also set BackColor to make it visible, scrollbars and content to make it obvious what's happened
      Add two column table by four rows
      Row one contains a dropdownlist for the number of labels to add to the panel.
      Row two contains a dropdownlist for the number fo textboxes to add to the panel.
      Row three is a blank 
      Row four contains a checkbox to toggel the panel's visibility and a button to make the changes. 
      Add event handler for Page_Load method which is run when page is initially loaded or the button checked
      Run page
      
      Second Demo. Adding scrollbars and word wrap to the panels
      Add second panel control with ID pnlScroll and GroupingText of "Scrollbars and Wrap"
      Also set height and width and add a Label control lblPanelContent into the panel directly.
      Add two by two table to the page 
      Row one contains a dropdownlist ddlScrollBars for the ScrollBars property of the panel - AutoPostBack = true
      Row two contains a radiobuttonlist rblWrap for the wrap property of the panel - AutoPostback = true
      
      Add more to the Page_Load event handler to add long text to the panel's label control.
      Add (default) event handler for ddlScrollBars SelectedIndexChanged handler
      Add (default) event handler for rblWrap SelectedIndexChanged handler
   -->
   <form id="form1" runat="server">
   <div>
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
      <hr />
      <h1>
         Scrollbars and Wrapping</h1>
      <asp:Panel Height="200px" ID="pnlScroll" runat="server" Width="90%" GroupingText="ScrollBars and Wrap">
         <asp:Label ID="lblPanelContent" runat="server"></asp:Label>
      </asp:Panel>
      <table>
         <tr>
            <td>
               ScrollBars:</td>
            <td>
               <asp:DropDownList ID="ddlScrollBars" AutoPostBack="true" runat="server" 
                  OnSelectedIndexChanged="ddlScrollBars_SelectedIndexChanged">
                  <asp:ListItem Text="None" Selected="True" />
                  <asp:ListItem Text="Auto" />
                  <asp:ListItem Text="Both" />
                  <asp:ListItem Text="Horizontal" />
                  <asp:ListItem Text="Vertical" />
               </asp:DropDownList>
            </td>
         </tr>
         <tr>
            <td>
               Wrap:</td>
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
