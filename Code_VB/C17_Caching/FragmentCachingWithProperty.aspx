<%@ Page Language="VB" AutoEventWireup="false" CodeFile="FragmentCachingWithProperty.aspx.vb" Inherits="FragmentCachingWithProperty" %>

<%@ Register Src="~/SimpleUserControl.ascx" TagPrefix="OReilly" TagName="CachedControl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fragment Caching Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:Label ID="lblPageTime" runat="server" /><br />
      <OReilly:CachedControl ID="CachedControl1" runat="server" /><br />
      <asp:Label ID="lblUserName" runat="server" /><br />
      <asp:Button ID="btnChange" runat="server" Text="Change Name" 
          onclick="btnChange_Click" />
    </div>
    </form>
</body>
</html>
