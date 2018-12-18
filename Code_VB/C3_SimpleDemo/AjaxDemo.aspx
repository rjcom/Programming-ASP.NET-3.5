<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AjaxDemo.aspx.vb" Inherits="AjaxDemo" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>A Simple Demo Of ASP.NET Server Controls</title>

   <script type="text/javascript">
    
      function pageLoad() {
      }
    
   </script>

</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:ScriptManager ID="ScriptManager1" runat="server" />
      <h1>
         A Simple Demo Of ASP.NET Server Controls</h1>
      <h2>
         The date and time is
         <% =DateTime.Now.ToString() %>.</h2>
      <asp:UpdatePanel ID="UpdatePanel1" runat="server">
         <ContentTemplate>
            <p>
               &nbsp;</p>
            <p>
               <asp:TextBox ID="txtBookName" runat="server" Width="250px">Enter a book name.</asp:TextBox>
               <asp:Button ID="btnBookName" runat="server" Text="Book Name" OnClick="btnBookName_Click" />
               <cc1:ConfirmButtonExtender ID="btnBookName_ConfirmButtonExtender" runat="server"
                  ConfirmText="Are you sure about this?" Enabled="True" TargetControlID="btnBookName">
               </cc1:ConfirmButtonExtender>
            </p>
            <p>
               <asp:Literal ID="litBookName" runat="server"></asp:Literal>
            </p>
         </ContentTemplate>
      </asp:UpdatePanel>
   </div>
   </form>
</body>
</html>
