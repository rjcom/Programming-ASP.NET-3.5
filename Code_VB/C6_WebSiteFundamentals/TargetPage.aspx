<%@ Page Language="VB" AutoEventWireup="false" CodeFile="TargetPage.aspx.vb" Inherits="TargetPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Target Page</title>
</head>

<body>
   <h1>Target Page</h1>
   <form id="form1" runat="server">
   <div>
      <p>
         Your favorite activity is 
         <asp:Label runat="server" ID="lblActivity" Text="Unknown" />
      </p>
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
   </div>
   </form>
</body>
</html>
