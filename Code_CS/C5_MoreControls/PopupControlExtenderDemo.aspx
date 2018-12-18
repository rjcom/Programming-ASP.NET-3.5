<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PopupControlExtenderDemo.aspx.cs"
   Inherits="PopupControlExtenderDemo" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Untitled Page</title>

   <script type="text/javascript">
    
      function pageLoad() {
      }
    
   </script>

</head>
<body>
   <!-- 
      Paraphrasing from LASP C3 demo. Continues the idea seen already in the TextBox extenders demo where the 
      CalendarExtender hides a Calendar from site until the TextBox it targets is in focus when it appears.
      The more general PopupExtender allows to hide \ attach any control(s) to most any standard controls until
      they are in focus. (Is CalendarExtender inheriting from popupExtender?)
      
      Add AJAX web form PopupControlExtenderDemo.aspx to website
      Add textBox to form. Call it txtChoice
      Add UpdatePanel to page
      Add RadioButtonList rblWebsites to the UpdatePanel's ContentTemplate. Add listitems decalratively.
      Add PopupControlExtender to page. Id = Popup1Set targetControlID to txtChoice and popupControlId to upnl1
      Run page. The RBL appears when focussed on the textbox but the selected value doesn't appear in textbox or the rbl disappear when this is done.
      Add event handler for SelectedIndexChanged to rblWebsites with given code and set AutoPostBack to true so the page will update automatically to reflect the value selected. Also set Position propeorty to extender to clean up UI.
      
   -->
   <form id="form1" runat="server">
   <div>
      <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true" />
      <p>
         Publisher (Pop Up):
         <asp:TextBox ID="txtChoice" runat="server"></asp:TextBox>
         <cc1:PopupControlExtender ID="Popup1" runat="server" TargetControlID="txtChoice"
            PopupControlID="pnlChoice" Position="Right">
         </cc1:PopupControlExtender>
      </p>
      <asp:UpdatePanel ID="pnlChoice" runat="server">
         <ContentTemplate>
            <asp:Label runat="server" Text="Pick one of the following publishers" />
            <asp:RadioButtonList ID="rblWebsites" runat="server" OnSelectedIndexChanged="rblWebsites_SelectedIndexChanged"
               AutoPostBack="true">
               <asp:ListItem Value="http://www.oreilly.com/">O&#8217;Reilly &amp; Associates</asp:ListItem>
               <asp:ListItem Value="http://www.LibertyAssociates.com">Liberty Associates</asp:ListItem>
               <asp:ListItem Value="http://www.stersol.com" Text="Sterling Solutions"></asp:ListItem>
               <asp:ListItem Value="http://www.hmobius.com">Hmobius</asp:ListItem>
            </asp:RadioButtonList>
         </ContentTemplate>
      </asp:UpdatePanel>
   </div>
   </form>
</body>
</html>
