<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ClientSideProcessing.aspx.cs"
   Inherits="ClientSideProcessing" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Client-Side Processing</title>
</head>

<script language="javascript">
       function ButtonTest()
       {
          alert("Button clicked - client side processing");
       }

       function DoChange()
       {
          document.getElementById("btnSave").disabled=false;
       }
</script>

<body>
   <form id="form1" runat="server">
   <div>
      <h1>
         Client-Side Processing</h1>
      <input id="btnHTML" type="button" value="HTML Button" runat="server" onclick="javascript:ButtonTest();"
         onserverclick="btnHTML_ServerClick" />
      <asp:Button ID="btnServer" runat="server" Text="ASP.NET Button" OnClientClick="javascript:ButtonTest();"
         OnClick="btnServer_Click" />
      <br />
      <input id="txtHTML" type="text" runat="server" onchange="javascript:DoChange();" /><br />
      <br />
      <asp:TextBox ID="TextBox1" runat="server" onchange="javascript:DoChange();"></asp:TextBox>
      <br />
      <asp:Button ID="btnSave" runat="server" Text="Save" Enabled="false" />
   </div>
   </form>
</body>
</html>
