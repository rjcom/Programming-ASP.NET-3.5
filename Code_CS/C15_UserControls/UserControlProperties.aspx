<%@ Page Language="C#" AutoEventWireup="true" 
     CodeFile="UserControlProperties.aspx.cs" Inherits="UserControlProperties" %>
<%@ Register src="CustomerDataList.ascx" 
   tagname="CustomerDL" tagprefix="OReilly" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Control Properties</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <p>
         Number of columns: 
         <asp:DropDownList ID="ddlColumns" runat="server">
            <asp:ListItem Text="1" Value="1" />
            <asp:ListItem Text="2" Value="2" />
            <asp:ListItem Text="3" Value="3" />
            <asp:ListItem Text="9" Value="9" />
         </asp:DropDownList>
         <br />
         Layout direction :
         <asp:DropDownList ID="ddlDirection" runat="server">
            <asp:ListItem Text="Horizontal" Value="Horizontal" />
            <asp:ListItem Text="Vertical" Value="Vertical" />
         </asp:DropDownList>
         <br />
         <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
      </p>
      <OReilly:CustomerDL ID="CustomerDL1" runat="server" />
    </div>
    </form>
</body>
</html>
