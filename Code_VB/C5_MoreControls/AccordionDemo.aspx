<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AccordionDemo.aspx.vb" Inherits="AccordionDemo" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Accordion Demo</title>

   <script type="text/javascript">
    
      function pageLoad() {
      }
    
   </script>

   <style type="text/css">
      .header 
      {
         background-color: Aqua;
         padding : 5px;
         border : solid 1px black;
         color : Black;
      }
      .selectedheader
      {
         background-color: Green;
         padding : 5px;
         border : solid 1px black;
         color : Yellow;
      }
      .content
      {
         padding: 5px;
         font-style: italic;
         font-family: Arial;
      }
   </style>
</head>
<body>
   <!--
      Add AccordionDemo.aspx to the website
      Accordion is standalone, so just add an Accordion to the page, and in it two panes, each with header and content.
      Run page. First pane is expanded by default. Click on second to expand it and collapse the first.
      
      Tweaks. 
      Basic operation. RequireOpenedPane=false. Still only one pane can be open at any one time, 
      and pane 1 still open by default on initial load, but now you can collapse it.
      Setup styles - CssStyle, HeaderCssStyle, HeaderSelectedCssStyle and ContentCssStyle
      Transitions - FadeTransitions, TransitionDuration and FramesPerSecond
      How much space it takes up on the page - AutoSize
      More behavior - SelectedIndex and SuppressHeaderPostbacks
      DataBinding - HeaderTemplate, ContentTemplate, DataSource, DataSourceID, DataMember (more in c8?)
   -->
   <form id="form1" runat="server">
   <div>
      <asp:ScriptManager ID="ScriptManager1" runat="server" />
      <cc1:Accordion ID="Accordion1" runat="server" RequireOpenedPane="false" 
         HeaderCssClass="header" HeaderSelectedCssClass="selectedheader" ContentCssClass="content"
         FadeTransitions="false" TransitionDuration="2000" FramesPerSecond="5"
         AutoSize="Limit">
         <Panes>
            <cc1:AccordionPane runat="server" ID="pane1">
               <Header>Question</Header>
               <Content>Why did the developer cross the road?</Content>
            </cc1:AccordionPane>
            <cc1:AccordionPane runat="server" ID="pane2">
               <Header>Unfunny Answer</Header>
               <Content>The chicken had a gun</Content>
            </cc1:AccordionPane>
         </Panes>
      </cc1:Accordion>
   </div>
   </form>
</body>
</html>
