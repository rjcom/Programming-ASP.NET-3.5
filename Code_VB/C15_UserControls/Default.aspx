<%@ Page Language="VB" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Src="Copyright.ascx" TagName="Copyright" TagPrefix="OReilly" %>
<%@ Register Src="CustomerDataList.ascx" TagName="CustomerDL" TagPrefix="OReilly" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Controls Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Hello"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Change" OnClick="Button1_Click" />
        <OReilly:CustomerDL ID="CustomerDL1" runat="server" NumOfColumns="4" Direction="Vertical" />
    </div>
    <OReilly:Copyright ID="Copyright1" runat="server" />
    </form>
</body>
</html>
