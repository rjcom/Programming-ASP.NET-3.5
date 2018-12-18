<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Calendar-SelectionChanged.aspx.vb" Inherits="Calendar_Calendar_SelectionChanged" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Calendar SelectionChanged Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:Calendar ID="Calendar1" runat="server" SelectionMode="DayWeekMonth" OnSelectionChanged="Calendar1_SelectionChanged">
      </asp:Calendar>
      <br />
      <asp:Label ID="lblCount" runat="server" />
      <br />
      <asp:Label ID="lblTodaysDate" runat="server" />
      <br />
      <asp:Label ID="lblSelected" runat="server" />
   </div>
   </form>
</body>
</html>
