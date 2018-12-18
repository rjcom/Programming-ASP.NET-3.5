<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateProgressDemo.aspx.cs"
   Inherits="UpdateProgressDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>UpdateProgress Demo</title>

   <script type="text/javascript">
    
      function pageLoad() {
      }
    
   </script>

</head>
<body>
   <!--
      Part 4. UpdateProgress 
      There are lots of variants on nesting UPs so we'll skip to the question of what happens if the update takes a while
      Answer, we associate an UpdateProgress control with the UpdatePanel that might take some time. Then, if after som given time, the update hasn't finished, the UpdateProgress control kicks in showing an animation to say things are working, honest :)
      Copy page from Part2, so buttons back to their UPs and carry on.
      Add line to Page_Load so update takes five seconds. 
      Run page to see how long it feels.
      Add UpdateProgress control page - doesn't need to be in the UP. Set AssociatedUpdatePanelID to UpdatePanel1.
      Add a message to its ProgressTemplate. This is added automatically in design view. Manually in source view.
      Run again and click the button for UP1. 
      After 0.5 seconds, the UpdateProgress control kicks in and the contents of the ProgressTemplate are added to the screen until the Update is complete.
      Tweak how it works using the DisplayAfter property to set the number of milliseconds the control will display after the async update was started. Use the DynamicUpdate property to set whether or not the page should include a blank area for the Progress Template's contents or if it should just be added dynamically to the page (as is the case in this example).
   -->
   <form id="form1" runat="server">
   <div>
      <asp:ScriptManager ID="ScriptManager1" runat="server" />
      <h1>
         Update Panel Demo</h1>
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
               <asp:Button ID="btnAsyncPostback" runat="server" Text="Async Postback" 
                  onclick="btnAsyncPostback_Click" />
            </p>
         </ContentTemplate>
      </asp:UpdatePanel>
      <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
         <ProgressTemplate>
            <p style="color:Red;">Please wait. This page is loading.</p>
         </ProgressTemplate>
      </asp:UpdateProgress>
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
