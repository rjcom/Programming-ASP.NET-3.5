<%@ Page Language="VB" AutoEventWireup="true" 
   CodeFile="ViewStateControl.aspx.vb" Inherits="ViewStateControl" %>

<%@ Register Assembly="CustomControls" 
   Namespace="CustomControls" TagPrefix="OReilly" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>View State Custom Server Control Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:Button ID="btnSize" runat="server" 
         OnClick="btnSize_Click" Text="Increase Size" />
      <OReilly:ServerControlViewState ID="sizeControl" EnableViewState="false" 
         runat="server" Text="Eat me, drink me, grow me" />
   </div>
   </form>
</body>
</html>
