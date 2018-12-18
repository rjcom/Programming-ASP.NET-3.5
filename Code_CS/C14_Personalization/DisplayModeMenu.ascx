<%@ Control Language="C#" AutoEventWireup="true" 
   CodeFile="DisplayModeMenu.ascx.cs" Inherits="DisplayModeMenu" %>
<div>
   <asp:Panel ID="Panel1" runat="server" BorderWidth="1" 
      Width="230" BackColor="lightgray"
      Font-Names="Verdana, Arial, Sans Serif">
      <asp:Label ID="Label1" runat="server" Text="Display Mode" 
         Font-Bold="true" Font-Size="8" Width="120" />
      <asp:DropDownList ID="ddlDisplayMode" runat="server" 
         AutoPostBack="true" EnableViewState="false" Width="120" 
         OnSelectedIndexChanged="ddlDisplayMode_SelectedIndexChanged" />
   </asp:Panel>
</div>

