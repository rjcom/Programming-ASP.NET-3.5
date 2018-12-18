<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ImageMapDemo.aspx.vb" Inherits="ImageMapDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>ImageMap Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <h2>
         Rectangular &amp; Circular HotSpots</h2>
      <asp:ImageMap ID="imgmapYesNoMaybe" runat="server" ImageUrl="~/YesNoMaybe.gif" HotSpotMode="Postback"
         OnClick="imgmapYesNoMaybe_Click">
         <asp:RectangleHotSpot PostBackValue="Yes" Bottom="60" Top="21" Left="17" Right="103"
            AlternateText="Damn right" />
         <asp:RectangleHotSpot HotSpotMode="PostBack" PostBackValue="No" Bottom="60" Top="21"
            Left="122" Right="208" AlternateText="Hell no" />
         <asp:RectangleHotSpot PostBackValue="Maybe" Bottom="122" Top="83" Left="16" Right="101"
            AlternateText="Well..., I’ll think about it" />
         <asp:CircleHotSpot HotSpotMode="Navigate" X="165" Y="106" Radius="25" NavigateUrl="http://www.ora.com"
            Target="_blank" AlternateText="I’ll have to think about it." />
      </asp:ImageMap>
      <asp:Label ID="lblMessage" runat="server" />
      <h2>
         Polygon HotSpots</h2>
      <asp:ImageMap ID="imgmapPlot" runat="server" ImageUrl="~/plot.gif" HotSpotMode="PostBack"
         OnClick="imgmapYesNoMaybe_Click">
         <asp:PolygonHotSpot Coordinates="4,245,4,3,495,3,495,45," AlternateText="Above the band" PostBackValue="Above the band" />
         <asp:PolygonHotSpot Coordinates="4,245,495,45,495,112,3,264" AlternateText="In the band"
            PostBackValue="In the band" />
         <asp:PolygonHotSpot Coordinates="495,45,495,112,495,320,4,320" AlternateText="Below the band" PostBackValue="Below the band" />
      </asp:ImageMap>
   </div>
   </form>
</body>
</html>
