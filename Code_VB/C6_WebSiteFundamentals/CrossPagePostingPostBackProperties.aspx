<%@ Page Language="VB" AutoEventWireup="false" CodeFile="CrossPagePostingPostBackProperties.aspx.vb" Inherits="CrossPagePostingPostBackProperties" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Cross Page Posting Properties Demo</title>
</head>
<body>
   <h1>Cross Page Posting Properties Demo</h1>
   <form id="form1" runat="server">
   <p>
   Select your favorite activity:&nbsp;
   <asp:DropDownList ID="ddlFavoriteActivity" 
      runat="server" AutoPostBack="true">
      <asp:ListItem Text="Eating" />
      <asp:ListItem Text="Sleeping" />
      <asp:ListItem Text="Programming" />
      <asp:ListItem Text="Watching TV" />
      <asp:ListItem Text="Sex" />
      <asp:ListItem Text="Skiing" />
      <asp:ListItem Text="Bicycling" />
   </asp:DropDownList>
   </p>
   <div>
      <asp:Button ID="btnServerTransfer" runat="server" 
         Text="Server.Transfer" OnClick="btnServerTransfer_Click" />
      <asp:Button ID="btnRedirect" runat="server" 
         Text="Response.Redirect" OnClick="btnRedirect_Click" />
      <asp:Button ID="btnCrossPage" runat="server" 
         Text="Cross Page Post" PostBackUrl="TargetPage.aspx" />
   </div>
   <p>
   IsPostBack: 
   <asp:Label ID="lblIsPostBack" runat="server" Text="not defined" />       
   <br />       
   IsCrossPagePostBack:       
   <asp:Label ID="lblIsCrossPagePostBack" runat="server" Text="not defined" />      
   <br />       
   PreviousPage:       
   <asp:Label ID="lblPreviousPage" runat="server" Text="not defined" />
   </p>
   </form>
</body>
</html>

