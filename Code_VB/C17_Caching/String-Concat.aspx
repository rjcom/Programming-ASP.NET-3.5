<%@ Page Language="VB" AutoEventWireup="false" CodeFile="String-Concat.aspx.vb" Inherits="String_Concat" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>String Concatenation Benchmark</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <h1>String Concatenation Benchmark</h1>
       <h2>Concatenation:</h2>
       <asp:Label ID="lblConcat" runat="server" />
       <br />
       <asp:Label ID="lblConcatString" runat="server" />
       <h2>StringBuilder:</h2>
       <asp:Label ID="lblBuild" runat="server" />
       <br />
       <asp:Label ID="lblBuildString" runat="server" />
    </div>
    </form>
</body>
</html>
