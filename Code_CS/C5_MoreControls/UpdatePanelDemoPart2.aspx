<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdatePanelDemoPart2.aspx.cs"
   Inherits="UpdatePanelDemoPart2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>UpdatePanel Demo (Part 2)</title>

   <script type="text/javascript">
    
      function pageLoad() {
      }
    
   </script>

</head>
<body>
   <!--
      Part 2. Working with Multiple UPs on the page.
      So you want to be smart and use dividual UPs on a page so only the parts that really need it are async updated rather than it all.
      Copy UpdatePanel1 and all its contents and paste them onto the bottom of the same page.
      Rename controls lblTime2, lblCounter2 and btnAsyncPostback2.
      Add appropriate code to Page_load to update lblTime2 and lblCounter2 on postback to the server.
      Run the page and note that pressing the buttons in either UpdatePanel causes the labels in both UpdatePanels to be updated.
      This is the default Musketeer setting for UpdatePanels. All for one and one for all. One partial postback in any Panel for all Panels to be updated.
      To override this setting, you need to set the UpdateMode property for any UpdatePanel you want to act independently of the others on the page to Conditional rather than Always which is the default.
      To demonstrate, set UpdateMode to Conditional for UpdatePanel2 and run the page again. 
      See now that pressing btnAsyncPostback which is not inside UpdatePanel2 does not cause the labels in UpdatePanel2 to update.
      However, pressing btnAsyncPostback2 still causes the labels in both UpdatePanels to update because UpdatePanel1 still has its UpdateMode set to Always.
      Set UpdateMode to conditional for UpdatePanel1 to see the difference.
      
      An aside - while we're covering UpdatePanel 'modes', it has a second property called RenderMode which determines whether the server renders it as a span or a div. 
      Run the page  again and see that both UpdatePanels are rendered as divs. e.g. <div id="UpdatePanel2"> ... </div>. 
      Now set the RenderMode property for UpdatePanel2 to "inline" (as opposed to the default of "block") and run the page again. View source and you'll see UpdatePanel2 is now rendered as <span id="UpdatePanel2"> ... </span>
   -->
   <form id="form1" runat="server">
   <div>
      <asp:ScriptManager ID="ScriptManager1" runat="server" />
      <h1>
         Update Panel Demo Part 1</h1>
      <p>
         Time:
         <asp:Label ID="lblTime" runat="server" /><br />
         Number of page_loads:
         <asp:Label ID="lblCounter" runat="server" Text="0" />
      </p>
      <p>
         <asp:Button ID="btnStdPostback" runat="server" Text="Standard Postback" />
      </p>
      <br />
      <hr />
      <br />
      <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
         <ContentTemplate>
            <p>
               Time:
               <asp:Label ID="lblTime2" runat="server" /><br />
               Number of page_loads:
               <asp:Label ID="lblCounter2" runat="server" Text="0" />
            </p>
            <p>
               <asp:Button ID="btnAsyncPostback" runat="server" Text="Async Postback" />
            </p>
         </ContentTemplate>
      </asp:UpdatePanel>
      <br />
      <hr />
      <br />
      <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional" RenderMode="Inline">
         <ContentTemplate>
            <p>
               Time:
               <asp:Label ID="lblTime3" runat="server" /><br />
               Number of page_loads:
               <asp:Label ID="lblCounter3" runat="server" Text="0" />
            </p>
            <p>
               <asp:Button ID="btnAsyncPostback2" runat="server" Text="Async Postback 2" />
            </p>
         </ContentTemplate>
      </asp:UpdatePanel>
   </div>
   </form>
</body>
</html>
