<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebParts.aspx.cs" Inherits="WebParts" %>

<%@ Register src="DisplayModeMenu.ascx" tagname="DisplayModeMenu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Part Demo</title>
    <style type="text/css">
       .style1
       {
          width: 100%;
       }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:WebPartManager ID="WebPartManager1" runat="server"></asp:WebPartManager>
        <uc1:DisplayModeMenu ID="DisplayModeMenu1" runat="server" />
    <div>
    
       <table class="style1">
          <tr>
             <td>
                <asp:WebPartZone ID="WebPartZone1" runat="server" HeaderText="News" 
                   Height="237px" Width="297px">
                   <ZoneTemplate>
                      <asp:Label ID="Label1" runat="server" Title="Today's News">
                        <br />Penguin Classics releases new translation of "In Search of Lost Time".
                      </asp:Label>
                   </ZoneTemplate>
                </asp:WebPartZone>
             </td>
             <td>
                <asp:WebPartZone ID="WebPartZone2" runat="server" Height="251px" Width="74px">
                </asp:WebPartZone>
             </td>
             <td>
                <asp:WebPartZone ID="WebPartZone3" runat="server" Height="239px" Width="172px" 
                   HeaderText="Sponsors">
                   <ZoneTemplate>
                      <asp:ListBox ID="ListBox1" runat="server" Title="Our Sponsors">
                         <asp:ListItem>Acme Widgets</asp:ListItem>
                         <asp:ListItem>Ziggy Spondooliks</asp:ListItem>
                         <asp:ListItem>Jerry Dorsey</asp:ListItem>
                         <asp:ListItem>Zinglebert Dambledack</asp:ListItem>
                         <asp:ListItem>Ziplok The Prophet</asp:ListItem>
                      </asp:ListBox>
                   </ZoneTemplate>
                </asp:WebPartZone>
             </td>
          </tr>
          <tr>
             <td>
                <asp:CatalogZone ID="CatalogZone1" runat="server">
                   <ZoneTemplate>
                      <asp:DeclarativeCatalogPart ID="DeclarativeCatalogPart1" runat="server">
                         <WebPartsTemplate>
                            <asp:Calendar ID="Calendar1" runat="server" Title="Calendar" />
                            <asp:FileUpload ID="FileUpload1" runat="server" Title="Upload Files" />
                         </WebPartsTemplate>
                      </asp:DeclarativeCatalogPart>
                   </ZoneTemplate>
                </asp:CatalogZone>
             </td>
             <td>
                <asp:WebPartZone ID="WebPartZone5" runat="server" Height="182px" Width="216px">
                </asp:WebPartZone>
             </td>
             <td>
                <asp:WebPartZone ID="WebPartZone6" runat="server" Height="272px" Width="92px">
                </asp:WebPartZone>
             </td>
          </tr>
       </table>
    
    </div>
       
        <asp:EditorZone ID="EditorZone1" runat="server" BackColor="#F7F6F3" 
            BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana" Padding="6">
            <FooterStyle BackColor="#E2DED6" HorizontalAlign="Right" />
            <PartTitleStyle Font-Bold="True" Font-Size="0.8em" ForeColor="#333333" />
            <PartChromeStyle BorderColor="#E2DED6" BorderStyle="Solid" BorderWidth="1px" />
            <PartStyle BorderColor="#F7F6F3" BorderWidth="5px" />
            <LabelStyle Font-Size="0.8em" ForeColor="#333333" />
            <VerbStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" />
            <ErrorStyle Font-Size="0.8em" />
            <EmptyZoneTextStyle Font-Size="0.8em" ForeColor="#333333" />
            <ZoneTemplate>
                <asp:LayoutEditorPart ID="LayoutEditorPart1" runat="server" />
                <asp:AppearanceEditorPart ID="AppearanceEditorPart1" runat="server" />
            </ZoneTemplate>
            <EditUIStyle Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" />
            <HeaderStyle BackColor="#E2DED6" Font-Bold="True" Font-Size="0.8em" 
                ForeColor="#333333" />
            <HeaderVerbStyle Font-Bold="False" Font-Size="0.8em" Font-Underline="False" 
                ForeColor="#333333" />
            <InstructionTextStyle Font-Size="0.8em" ForeColor="#333333" />
        </asp:EditorZone>
       
    </form>
</body>
</html>
