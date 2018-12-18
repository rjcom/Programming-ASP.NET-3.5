<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LabelsAndLiterals.aspx.cs"
   Inherits="LabelsAndLiterals" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Labels and Literals</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:Literal ID="Literal1" runat="server" Text="This is a literal" />
      <asp:Label ID="Label1" runat="server" Text="This is a label" />
      <asp:Label ID="Label2" runat="server" ForeColor="Blue" Font-Bold="True" Text="This is a label styled inline" />
      <asp:Label ID="Label3" runat="server" CssClass="StandardText" Text="This is a label styled with CSS" />
      <asp:Label ID="Label4" runat="server" AssociatedControlID="form1" Text="This is a form label" />
   </div>
   </form>
</body>
</html>
