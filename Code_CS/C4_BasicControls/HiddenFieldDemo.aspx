<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HiddenFieldDemo.aspx.cs"
   Inherits="HiddenFieldDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>HiddenField Control Demo</title>
</head>
<body>
   <script type="text/javascript" language="javascript">    
      function ChangeHiddenValue()    
      {       
         alert("Entering ChangeHiddenValue");         
         var hdnId = "<%=hdnSecretValue.ClientID%>";       
         var hdn = document.getElementById(hdnId);         
         var txt = document.getElementById("txtSecretValue");         
         hdn.value = txt.value;       
         alert("Value changed");    
      } 
   </script>

   <!--
      Add new web form to site called HiddenFieldDemo.aspx
      Add HiddenField (ID = hdnSecretValue) and TextBox (ID=txtSecretValue) controls to page. Add text in Textbox to store in hiddenfield
      Add html button to change hiddenfield on the browser (onclick=changehiddenvalue())
      Add asp button to cause a postback and update label with new value of hiddenfield (ID = btnPost, text=Post)
      Add label to show hidden value (id = lblSecretValue, no Text value)
      Add script section to <body>
      Switch to design view, double click on hiddenfield to generate ValueChanged handler. Or write it in yourself.
   -->
   <form id="form1" runat="server">
   <div>
      <asp:HiddenField ID="hdnSecretValue" runat="server" 
         onvaluechanged="hdnSecretValue_ValueChanged" />
      Enter secret value:
      <asp:TextBox ID="txtSecretValue" runat="server"></asp:TextBox>
      <br />
      <br />
      <input id="Button1" type="button" value="button" onclick="ChangeHiddenValue()" />
      <asp:Button ID="btnPost" runat="server" Text="Post" />
      <br />
      <br />
      <asp:Label ID="lblSecretValue" runat="server" Text=""></asp:Label>
   </div>
   </form>
</body>
</html>
