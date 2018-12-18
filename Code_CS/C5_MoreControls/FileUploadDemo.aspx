<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FileUploadDemo.aspx.cs" Inherits="FileUploadDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>FileUpload Control Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <h1>
         FileUpload Control</h1>
      <asp:FileUpload ID="FileUpload1" runat="server" />
      <br />
      <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
      <asp:Button ID="btnDisplay" runat="server" Text="Display" OnClick="btnDisplay_Click" />
      <br />
      <br />
      <asp:Label ID="lblMessage" runat="server" />
      <asp:Label ID="lblDisplay" runat="server" />
   </div>
   </form>
</body>
</html>
