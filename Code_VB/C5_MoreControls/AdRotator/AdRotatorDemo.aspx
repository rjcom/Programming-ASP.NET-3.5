<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AdRotatorDemo.aspx.vb" Inherits="AdRotator_AdRotatorDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>AdRotator</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <h1>
         AdRotator Control</h1>
      <asp:AdRotator ID="ad" runat="server" Target="_blank" AdvertisementFile="~/AdRotator/ads.xml"
         OnAdCreated="ad_AdCreated" />
      <br />
      Animal:
      <asp:Label ID="lblAnimal" runat="server" />
   </div>
   </form>
</body>
</html>
