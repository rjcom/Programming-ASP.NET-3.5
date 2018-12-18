<%@ Page Language="VB" AutoEventWireup="false" CodeFile="UpdatePanelDemoPart1.aspx.vb" Inherits="UpdatePanelDemoPart1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>UpdatePanel Demo (Part 1)</title>

   <script type="text/javascript">

       function pageLoad() {
       }
    
   </script>

</head>
<body>
   <!--
      Add new AJAX Web Form UpdatePanelDemo.aspx to the site.
      Let's start by adding a few controls so we can see the page posting back.
      Add two labels, lblTime and lblCounter and a button btnStdPostBack to the page.
      Delete the lblTime's Text properties. Set lblCounter.Text to 0. 
      Set btnStdPostback.Text to 'Standard Postback'.
      Switch to the code behind page and add code to the Page_Load handler.
      Now run page. 
      Every time you click the button, the whole page is posted back and all the values are updated on the page accompanied by a flicker of the page in the browser as it is reloaded.
      
      Now copy the two labels, paste them below the button and call them lblTime2, lblCounter2 
      Add a new button under them called btnAsyncPostback.
      Adjust the Page_Load routine to update the new labels as well.
      Note that all the code is in the one function.
      Run the page and verify that all the labels update with the same values regardless of which button is pressed.
      
      Now drag an UpdatePanel onto the page
      Cut and paste lblTime2, lblCounter2 and btnAsyncPostback into the UpdatePanel. 
      (In source view, add a <ContentTemplate> child element to the UpdatePanel and cut and paste the controls into that. In Design view, the content tempalte is create automatically)
      Show full source code here.
      Run the page again. 
      Note that clicking btnStdPostBack updates both sets of labels as before, but clicking btnAsyncPostback updates only the values for lblTime2 and lblCounter2
      because the button is in the UpdatePanel, ASP.NET AJAX understands that when it is clicked, only the controls inside the UpdatePanel should be updated. Hence an asychronous or 'partial page' update occurs and no flicker in the browser either as the whole page reloads.
      Thus one of the most useful aspects of AJAX is demonstrated. 
      Two points. Run the partial page update several times so the counters are out of sync. Now click btnStdPostback again so the whole page updates. Note how the counters are back in sync again. lblCounter2 has added one for the latest page_load but lblCounter is now equal to lblCounter2 rather than adding just one.
      This ably demonstrates a key point. When a partial page update occurs through an UpdatePanel, the whole page, its viewstate and the rest is actually posted back to the server, and the values for the new version fo the page calculated but only the values for the controls in the UpdatePanel are sent back. 
      Thus each time a partial page update occured, the value in lblCounter did actually increase, but it wasn't updated on screen. When the full page postback happened, lblCounter got one added to it and updated at last. It always matched lblCounter2 but wasn't updated.
      (Worth checking whether or not it's actually updated in viewstate?)
      Also worth noting at this time is that the button or more generally the control that kicks off the partial page postback in the UpdatePanel doesn't actually have to be contained within it. This will be shown in part 3 of this demo.
      End part 1. Note the code thus far is saved in download as UpdatePanelDemoPart1.aspx
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
      <asp:UpdatePanel ID="UpdatePanel1" runat="server">
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
   </div>
   </form>
</body>
</html>
