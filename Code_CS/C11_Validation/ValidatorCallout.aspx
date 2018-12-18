<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ValidatorCallout.aspx.cs"
   Inherits="ValidatorCallout" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>SetFocusOnError and ValidatorCallouts</title>

   <script type="text/javascript">
    
      function pageLoad() {
      }
    
   </script>

   <style media="screen" type="text/css">
      .validatorCallout
      {
         background-color: Yellow;
      }
   </style>
</head>
<body>
  
   <h1>
      Bug Reporter
   </h1>
   <form runat="server" id="frmBugs">
    <asp:ScriptManager ID="ScriptManager1" runat="server" />
   <table cellpadding="3" border="1">
      <tr>
         <td colspan="3" align="center">
            <asp:Label ID="lblMsg" Text="Please report your bug here" runat="server" />
         </td>
      </tr>
      <tr>
         <td>
            Book
         </td>
         <td>
            <!-- Drop down list with the books (must pick one) -->
            <asp:DropDownList ID="ddlBooks" runat="server">
               <asp:ListItem>-- Please Pick A Book --</asp:ListItem>
               <asp:ListItem>Programming ASP.NET 4e</asp:ListItem>
               <asp:ListItem>Learning ASP.NET With AJAX</asp:ListItem>
               <asp:ListItem>Programming C# 2008</asp:ListItem>
               <asp:ListItem>Programming Visual Basic 2008</asp:ListItem>
            </asp:DropDownList>
         </td>
         <td>
            <!-- Validator for the drop down -->
            <asp:RequiredFieldValidator ID="rfvBooks" ControlToValidate="ddlBooks" Display="Static"
               InitialValue="-- Please Pick A Book --" runat="server" ErrorMessage="Please choose a book" 
               SetFocusOnError="true" Text="*" />
            <cc1:ValidatorCalloutExtender ID="rfvBooks_ValidatorCalloutExtender" runat="server"
               Enabled="True" TargetControlID="rfvBooks" HighlightCssClass="validatorCalloutHighlight">
            </cc1:ValidatorCalloutExtender>
         </td>
      </tr>
      <tr>
         <td>
            Edition:
         </td>
         <td>
            <asp:RadioButtonList ID="rblEdition" RepeatLayout="Flow" runat="server">
               <asp:ListItem>1st</asp:ListItem>
               <asp:ListItem>2nd</asp:ListItem>
               <asp:ListItem>3rd</asp:ListItem>
               <asp:ListItem>4th</asp:ListItem>
            </asp:RadioButtonList>
         </td>
         <!-- Validator for editions -->
         <td>
            <asp:RequiredFieldValidator ID="rfvEdition" ControlToValidate="rblEdition" Display="Static"
               runat="server" ErrorMessage="Please pick an edition" Text="*" SetFocusOnError="true"/>
             <cc1:ValidatorCalloutExtender ID="rfvEdition_ValidatorCalloutExtender" runat="server"
               Enabled="True" TargetControlID="rfvEdition" HighlightCssClass="validatorCalloutHighlight">
            </cc1:ValidatorCalloutExtender>
         </td>
      </tr>
      <tr>
         <td>
            Bug:
         </td>
         <!-- Multi-line text for the bug entry -->
         <td>
            <asp:TextBox ID="txtBug" runat="server" TextMode="MultiLine" />
         </td>
         <!-- Validator for the text box-->
         <td>
            <asp:RequiredFieldValidator ID="rfvBug" ControlToValidate="txtBug" Display="Static"
               runat="server" Text="*" ErrorMessage="Please provide bug details" SetFocusOnError="true"/>
            <cc1:ValidatorCalloutExtender ID="rfvBug_ValidatorCalloutExtender" runat="server"
               Enabled="True" TargetControlID="rfvBug" HighlightCssClass="validatorCalloutHighlight">
            </cc1:ValidatorCalloutExtender>
         </td>
      </tr>
      <tr>
         <td colspan="3" align="center">
            <asp:Button ID="btnSubmit" Text="Submit Bug" runat="server" />
         </td>
      </tr>
   </table>
      <asp:ValidationSummary ID="ValidationSummary1" runat="server"
      DisplayMode="BulletList" HeaderText="The following errors were found: " ShowSummary="true" />

   </form>
</body>
</html>
