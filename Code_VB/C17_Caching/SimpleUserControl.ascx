﻿<%@ Control Language="VB" AutoEventWireup="false" CodeFile="SimpleUserControl.ascx.vb" Inherits="SimpleUserControl" %>

<%@ OutputCache Duration="10" VaryByParam="*" %>

<hr />
<asp:Label ID="lblTime" runat="server" /><br />
<asp:Label ID="lblUserName" runat="server" Text="Dan" /><br />
<asp:Button ID="btnChange" runat="server" Text="Change Name" 
   onclick="btnChange_Click" />
<hr />
