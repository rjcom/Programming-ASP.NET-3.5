<%@ Page Language="VB" AutoEventWireup="true" CodeFile="UserControlEvents.aspx.vb"
   Inherits="UserControlEvents" %>

<%@ Register Src="Copyright.ascx" TagName="Copyright" TagPrefix="OReilly" %>
<%@ Register Src="CustomerDataList.ascx" TagName="CustomerDL" TagPrefix="OReilly" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>User Control Events Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <p>
         <asp:Label ID="Label1" runat="server" Text="Hello"></asp:Label>
         <asp:Button ID="Button1" runat="server" Text="Change" OnClick="Button1_Click" />
      </p>
      <p>
         <asp:Label ID="lblDisplayCompany" runat="server" />
      </p>
      <OReilly:CustomerDL ID="CustomerDL1" runat="server" NumOfColumns="4" Direction="Vertical" />
   </div>
   <OReilly:Copyright ID="Copyright1" runat="server" />
   </form>
</body>
</html>
