<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebParts2.aspx.cs" Inherits="WebParts2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style2
        {
            width: 222px;
            height: 141px;
        }
        .style3
        {
            height: 141px;
        }
        .style4
        {
            width: 222px;
            height: 224px;
        }
        .style5
        {
            height: 224px;
        }
        .style6
        {
            height: 141px;
            width: 162px;
        }
        .style7
        {
            height: 224px;
            width: 162px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:WebPartManager ID="WebPartManager1" runat="server">
    </asp:WebPartManager>
    <div>
        <table style="width: 607px">
            <tr>
                <td class="style2">
                    <asp:WebPartZone ID="WebPartZone1" runat="server" HeaderText="News" Height="86px"
                        Width="160px">
                        <ZoneTemplate>
                            <asp:Label ID="Label1" runat="server" Title="Today's News">
                                <br/>
                                Penguin Classics releases new translation of "In Search of Lost Time".
                            </asp:Label>
                        </ZoneTemplate>
                    </asp:WebPartZone>
                </td>
                <td class="style6">
                    <asp:WebPartZone ID="WebPartZone3" runat="server" Height="134px">
                    </asp:WebPartZone>
                </td>
                <td class="style3">
                    <asp:WebPartZone ID="WebPartZone5" runat="server" Height="124px" Width="202px" HeaderText="Our Sponsors">
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
                <td class="style4">
                    <asp:WebPartZone ID="WebPartZone2" runat="server" Height="194px" Width="214px">
                    </asp:WebPartZone>
                </td>
                <td class="style7">
                    <asp:WebPartZone ID="WebPartZone4" runat="server" Height="90px" Width="144px">
                    </asp:WebPartZone>
                </td>
                <td class="style5">
                    <asp:WebPartZone ID="WebPartZone6" runat="server" Height="195px">
                    </asp:WebPartZone>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
