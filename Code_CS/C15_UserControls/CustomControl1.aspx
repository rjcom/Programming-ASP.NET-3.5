<%@ Page Language="C#" AutoEventWireup="true" 
   CodeFile="CustomControl1.aspx.cs" Inherits="CustomControl1" %>
<%@ Register Assembly="CustomControls" 
   Namespace="CustomControls" TagPrefix="OReilly" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP.NET Custom Server Control Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <OReilly:ServerControl1 runat="server"
         Text="Hello Custom Control!" />    
    </div>
    </form>
</body>
</html>
