<%@ Page Language="C#" AutoEventWireup="true" 
   CodeFile="ControlStateControl.aspx.cs" Inherits="ControlStateControl" %>

<%@ Register Assembly="CustomControls" 
   Namespace="CustomControls" TagPrefix="OReilly" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Control State Custom Server Control Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:Button ID="btnSize" runat="server" 
         OnClick="btnSize_Click" Text="Increase Size" />
      <OReilly:ServerControlControlState ID="sizeControl" EnableViewState="false" 
         runat="server" Text="Eat me, drink me, grow me" />
   </div>
   </form>
</body>
</html>
