<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ImageDemo.aspx.vb" Inherits="ImageDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Image Control Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <p>
         <asp:Image ID="img1" runat="server" AlternateText="Popfly Duck" ImageUrl="~/popflyDuck.png" />This
         is a sample paragraph which is being used to demonstrate the effects of various
         values of ImageAlign. As you will see, the effects are sometimes difficult to pin
         down, and vary depending on the width of the browser window.
      </p>
      <hr />
      <asp:Button ID="Button1" runat="server" Text="Sample Button" />
      <asp:Image ID="img2" runat="server" AlternateText="Popfly Duck" ImageUrl="~/popflyDuck.png" />
      <hr />
      <asp:DropDownList ID="ddlAlign" runat="server" AutoPostBack="True">
         <asp:ListItem Text="NotSet" />
         <asp:ListItem Text="AbsBottom" />
         <asp:ListItem Text="AbsMiddle" />
         <asp:ListItem Text="Top" />
         <asp:ListItem Text="Bottom" />
         <asp:ListItem Text="BaseLine" />
         <asp:ListItem Text="TextTop" />
         <asp:ListItem Text="Left" />
         <asp:ListItem Text="Right" />
      </asp:DropDownList>
   </div>
   </form>
</body>
</html>
