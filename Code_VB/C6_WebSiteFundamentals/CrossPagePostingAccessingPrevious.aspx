<%@ Page Language="VB" AutoEventWireup="false" 
    CodeFile="CrossPagePostingAccessingPrevious.aspx.vb" 
    Inherits="CrossPagePostingAccessingPrevious" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Strongly Typed Cross Page Posting Demo</title>
</head>
<body>
   <h1>
      Strongly Typed Cross Page Posting Demo</h1>
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
   </form>
</body>
</html>
