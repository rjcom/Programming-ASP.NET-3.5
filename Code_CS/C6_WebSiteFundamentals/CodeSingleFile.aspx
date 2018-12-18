<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
   protected void btnHello_Click(object sender, EventArgs e)
   {
      lblMessage.Text = "Hello. The time is " +
         DateTime.Now.ToLongTimeString();
   } 
</script>

<html>
<head runat="server">
   <title>Single File Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <h1>Code-Beside</h1>
      <asp:Button ID="btnHello" runat="server" 
         Text="Hello" OnClick="btnHello_Click" />
      <br />
      <asp:Label ID="lblMessage" runat="server" />
   </div>
   </form>
</body>
</html>
