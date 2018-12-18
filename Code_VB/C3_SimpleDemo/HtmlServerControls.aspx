<%@ Page Language="VB" AutoEventWireup="false" CodeFile="HtmlServerControls.aspx.vb" Inherits="HtmlServerControls" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>HTML Server Controls Demo</title>
   <style type="text/css">
      .style1
      {
         width: 100%;
      }
   </style>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <h1>
         HTML Server Controls</h1>
      <table class="style1">
         <tr>
            <td>
               Name
            </td>
            <td>
               <input id="txtName" type="text" runat="server"/>
            </td>
         </tr>
         <tr>
            <td>
               Street
            </td>
            <td>
               <input id="txtStreet" type="text" runat="server"/>
            </td>
         </tr>
         <tr>
            <td>
               City
            </td>
            <td>
               <input id="txtCity" type="text" runat="server"/>
            </td>
         </tr>
         <tr>
            <td>
               State
            </td>
            <td>
               <input id="txtState" type="text" runat="server"/>
            </td>
         </tr>
         <tr>
            <td>
               &nbsp;
            </td>
            <td>
               &nbsp;
            </td>
         </tr>
         <tr>
            <td>
               &nbsp;
            </td>
            <td id="tdInnerHtml" runat="server">
               &nbsp;
            </td>
         </tr>
      </table>
      <input id="Button1" type="button" value="button" runat="server" onserverclick="Button1_OnServerClick" /></div>
   </form>
</body>
</html>

