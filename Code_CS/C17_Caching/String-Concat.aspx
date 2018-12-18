<%@ Page Language="C#" AutoEventWireup="true" CodeFile="String-Concat.aspx.cs" Inherits="String_Concat" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
   <title>String Concatenation Benchmark</title>
</head>
<body>
   <form id="Form1" runat="server">
   <h1>String Concatenation Benchmark</h1>
   <h2>Concatenation:</h2>
   <asp:Label ID="lblConcat" runat="server" />
   <br />
   <asp:Label ID="lblConcatString" runat="server" />
   <h2>StringBuilder:</h2>
   <asp:Label ID="lblBuild" runat="server" />
   <br />
   <asp:Label ID="lblBuildString" runat="server" />
   </form>
</body>
</html>
