<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DropDownListDemoWithAJAX.aspx.vb" Inherits="DropDownListDemoWithAJAX" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>DropDownList Demo with AJAX</title>

   <script type="text/javascript">

       function pageLoad() {
       }
    
   </script>
   <style type="text/css">
      .PromptStyle {
      color: Red;
      font-style:italic;
      }
   </style>
</head>
<body>
   <!--
      Add new AJAX web form to web site called DropDownListDemoWithAJAX.aspx
      Copy DropDownList and Label from DropDownListDemo.aspx to underneath ScriptManager
      Copy code from DropDownListDemo.aspx.cs to DropDownListDemoWithAJAX.aspx.cs
      Run to make sure it still works.
      
      Large lists are awkward to look through, especially in DropDowns possibly taking over a whole screen if there are enough values.
      There are two ways to deal with it. Make it easier to search through the items in the one list with the ListSearchExtender or
      split the list into two or three context lists using CascadingDropDownExtender. The latter uses web services, so we'll look at them in 
      web services chapters.
      
      drag ListSearchExtender onto page under DropDownList. Set targetControlID to ddlBooks and run page.
      type the first letter of a book in the list and focus goes straight to it.
      Tidy up the Ui of the ListSearchExtender a bit more with PromptText, PromptPosition, PromptCssClass
      Add PromptCssClass styles to top of page. Could also use Animations here but won't show this.
      
      You could also fake a dropdownlist and make it only appear when a visitor clicks on an area of the screen.
      Do this with the DropDownExtender. This can be attached to almost any ASP.NET server control. We'll demo it in the panel section as you'll need .
   -->
   <form id="form1" runat="server">
   <div>
      <asp:ScriptManager ID="ScriptManager1" runat="server" />
      <asp:DropDownList ID="ddlBooks" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlBooks_SelectedIndexChanged">
      </asp:DropDownList>
      <cc1:ListSearchExtender ID="ListSearchExtender1" runat="server" TargetControlID="ddlBooks"
          PromptText="Type name of book to find it quicker" PromptPosition="Top" PromptCssClass="PromptStyle">
      </cc1:ListSearchExtender>
      <br />
      <br />
      <asp:Label ID="lblBookInfo" runat="server"></asp:Label>
   </div>
   </form>
</body>
</html>