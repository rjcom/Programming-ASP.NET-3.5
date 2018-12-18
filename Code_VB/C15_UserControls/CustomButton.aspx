<%@ Page Language="VB" AutoEventWireup="true" CodeFile="CustomButton.aspx.vb" Inherits="CustomButton" %>
<%@ Register Assembly="CustomControls" 
   Namespace="CustomControls" TagPrefix="OReilly" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CountedButton Custom Server Control Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <OReilly:CountedButton ID="CountedButton1" runat="server" />
    </div>
    </form>
</body>
</html>
