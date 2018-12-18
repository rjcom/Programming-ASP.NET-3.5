﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RequiredFieldValidator.aspx.cs"
   Inherits="RequiredFieldValidator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
   <title>Required Field Validator Demo</title>
</head>
<body>
   <h1>
      Bug Reporter
   </h1>
   <form runat="server" id="frmBugs">
   <table cellpadding="3" border="1">
      <tr>
         <td colspan="3" align="center">
            <asp:Label ID="lblMsg" Text="Please report your bug here" runat="server" />
         </td>
      </tr>
      <tr>
         <td>Book
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
               InitialValue="-- Please Pick A Book --" runat="server" ErrorMessage="Please choose a book" />
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
            <asp:RequiredFieldValidator ID="rfvEdition" ControlToValidate="rblEdition" Display="Static" runat="server"
                 ErrorMessage="Please pick an edition" />
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
               runat="server" ErrorMessage="Please provide bug details" />
         </td>
      </tr>
      <tr>
         <td colspan="3" align="center">
            <asp:Button ID="btnSubmit" Text="Submit Bug" runat="server" 
               onclick="btnSubmit_Click" />
         </td>
      </tr>
   </table>
   </form>
</body>
</html>
