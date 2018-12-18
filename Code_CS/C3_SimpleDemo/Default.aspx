<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>A Simple Demo Of ASP.NET Server Controls</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <h1>
         A Simple Demo Of ASP.NET Server Controls</h1>
      <h2>
         The date and time is
         <% =DateTime.Now.ToString() %>.</h2>
      <p>
         &nbsp;</p>
      <p>
         <asp:TextBox ID="txtBookName" runat="server" Width="250px">Enter a book name.</asp:TextBox><asp:Button
            ID="btnBookName" runat="server" Text="Book Name" 
            onclick="btnBookName_Click" />
      </p>
      <p>
         <asp:Literal ID="litBookName" runat="server"></asp:Literal>
      </p>
   </div>
   </form>
</body>
</html>
