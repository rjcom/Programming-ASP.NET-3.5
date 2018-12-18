<%@ Page Language="VB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
    Protected Sub lblTime_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTime.Init
        lblTime.Font.Name = "Verdana"
        lblTime.Font.Size = 20
        lblTime.Font.Underline = True
        lblTime.Font.Bold = True
        lblTime.Font.Italic = True
        lblTime.Font.Overline = True
        lblTime.Font.Strikeout = True
        lblTime.Text = DateTime.Now.ToString() + ". Font Name: " + lblTime.Font.Name
    End Sub
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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