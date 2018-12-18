<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
   protected void lblTime_Init(object sender, EventArgs e)
   {
      lblTime.Font.Name = "Verdana";
      lblTime.Font.Size = 20;
      lblTime.Font.Underline = true;
      lblTime.Font.Bold = true;
      lblTime.Font.Italic = true;
      lblTime.Font.Overline = true;
      lblTime.Font.Strikeout = true;
      lblTime.Text = DateTime.Now.ToString() +
         ". Font Name: " +
         lblTime.Font.Name;
   }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Notepad or Visual Studio</title>
</head>
<body>
   <form id="form1" runat="server">
   <h2>
      Basics</h2>
   <asp:Label ID="lblTime" runat="server" OnInit="lblTime_Init" Text="Label"></asp:Label>
   </form>
</body>
</html>
