<%@ Page Language="VB" AutoEventWireup="false" CodeFile="UpdatePanelDemoPart3.aspx.vb" Inherits="UpdatePanelDemoPart3" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>UpdatePanel Demo (Part 3)</title>

   <script type="text/javascript">

       function pageLoad() {
       }
    
   </script>

</head>
<body>
   <!--
      Part 3. Toggling Async postback inside the UP from outside the UP.
      So now you can isolate UpdatePanels from each other. 
      But the next issue is that the button causing the updates in the UP is trapped inside the panel as well. From a UI standpoint, this may not be a good thing.
      Fortunately, you can start an async update to the contents of a UP by adding a new asyncpostbacktrigger to the UP's triggers collection specify the control's name and the event to trigger the async post back.
      Cut and paste all the buttons from the three areas to the bottom of the page.
      Now add a <triggers> collection to the UpdatePanels each containing the AsyncPostBackTrigger where the ControlID is the associated button and the veent is click.
      Run the page.
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
         </ContentTemplate>
         <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnAsyncPostback" EventName="Click" />
         </Triggers>
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
         </ContentTemplate>
                  <Triggers>
            <asp:AsyncPostBackTrigger ControlID="btnAsyncPostback2" EventName="Click" />
         </Triggers>
      </asp:UpdatePanel>
      <br />
      <hr />
      <br />
      <p>
         <asp:Button ID="btnStdPostback" runat="server" Text="Standard Postback" />
      </p>
      <p>
         <asp:Button ID="btnAsyncPostback" runat="server" Text="Async Postback" />
      </p>
      <p>
         <asp:Button ID="btnAsyncPostback2" runat="server" Text="Async Postback 2" />
      </p>
   </div>
   </form>
</body>
</html>
