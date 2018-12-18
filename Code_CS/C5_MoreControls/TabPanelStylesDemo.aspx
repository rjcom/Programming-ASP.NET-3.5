<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TabPanelStylesDemo.aspx.cs" Inherits="TabPanelStylesDemo" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
    
      function pageLoad() {
      }
    
    </script>
    <style type="text/css">
    .DemoStyles .ajax__tab_header {font-family:Courier New; padding: 10px; border:dotted 2px red;}
    .DemoStyles .ajax__tab_outer {padding:10px;border:solid 2px green;}
    .DemoStyles .ajax__tab_inner {padding:10px;border:dotted 2px blue;}
    .DemoStyles .ajax__tab_tab {padding:10px;border:solid 2px black;background-color:yellow;}
    .DemoStyles .ajax__tab_body {font-family:verdana;border:1px solid black;padding:10px}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
    </div>
    <cc1:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" CssClass="DemoStyles" >
        <cc1:TabPanel runat="server" HeaderText="TabPanel1" ID="TabPanel1">
            <HeaderTemplate>Tab_Header1</HeaderTemplate>
            <ContentTemplate>
                The content of a TabPanel is styled by the .ajax__tab_body style.
                The area containing the tab headers is styled by the .ajax__tab_header style.
                Each individual tab 
            </ContentTemplate>
        </cc1:TabPanel>
        <cc1:TabPanel runat="server" HeaderText="TabPanel2" ID="TabPanel2">
            <HeaderTemplate>Tab_Header2</HeaderTemplate>
            <ContentTemplate>
                You can then specify child classes that you can set in order to style individual elements in the tab panels. For instance, to set the style of the tabs contents, you'd create a style as follows .
            </ContentTemplate>
        </cc1:TabPanel>
    </cc1:TabContainer>
    </form>
</body>
</html>
