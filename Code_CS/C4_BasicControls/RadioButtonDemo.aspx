<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RadioButtonDemo.aspx.cs"
   Inherits="RadioButtonDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>RadioButton Demo</title>
</head>
<body>
   <!--
      Add new web form RabioButtonDemo.aspx to web site
      Add three RadioButtons to page, with IDs rdoSize10, rdoSize14 and rdosize16 and appropriate Text properties
      Set AutoPostBack to true for all thre Radiobuttons as they don't postback by default.
      Set GroupName for all three buttons to grpSize to associate them with each other.
      Add Label, with ID lblTime. Clear text property. 
      Add handler for lblTime_OnInit
      
      Doubleclick rdoSize10 in design view to create default event handler for CheckedChanged.
      Add handler for rdoSize10_CheckedChanged.
      Rename handler to grpSize_CheckedChanged. 
      In source view, update name of handler for rdoSize10 and add it also to rdoSize14 and rdoSize16
   -->
   <form id="form1" runat="server">
   <div>
      <asp:RadioButton ID="rdoSize10" runat="server" Text="10pt" GroupName="grpSize" AutoPostBack="true" OnCheckedChanged="grpSize_CheckedChanged" />
      <asp:RadioButton ID="rdoSize14" runat="server" Text="14pt" GroupName="grpSize" AutoPostBack="true" OnCheckedChanged="grpSize_CheckedChanged" />
      <asp:RadioButton ID="rdoSize16" runat="server" Text="16pt" GroupName="grpSize" AutoPostBack="true" OnCheckedChanged="grpSize_CheckedChanged" />
      <br />
      <br />
      <asp:Label ID="lblTime" runat="server" OnInit="lblTime_Init"></asp:Label>
   </div>
   </form>
</body>
</html>
