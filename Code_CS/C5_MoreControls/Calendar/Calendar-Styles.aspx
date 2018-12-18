<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calendar-Styles.aspx.cs"
   Inherits="Calendar_Styles" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Calendar Control Styles</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:Calendar ID="Calendar1" runat="server" SelectionMode="DayWeekMonth" CellPadding="7"
         CellSpacing="5" DayNameFormat="FirstTwoLetters" FirstDayOfWeek="Monday" NextMonthText="Next >"
         PrevMonthText="< Prev" ShowGridLines="True" DayStyle-BackColor="White" 
         DayStyle-ForeColor="Black" DayStyle-Font-Names="Arial">
         <DayHeaderStyle BackColor="Black" Font-Names="Arial Black" ForeColor="White" />
         <SelectedDayStyle BackColor="Cornsilk" Font-Bold="True" Font-Italic="True" Font-Names="Arial"
            ForeColor="Blue" />
         <SelectorStyle BackColor="Cornsilk" Font-Names="Arial" ForeColor="Red" />
         <WeekendDayStyle BackColor="LavenderBlush" Font-Names="Arial" ForeColor="Purple" />
         <OtherMonthDayStyle BackColor="LightGray" Font-Names="Arial" ForeColor="White" />
         <TodayDayStyle BackColor="Cornsilk" Font-Bold="True" Font-Names="Arial" ForeColor="Green" />
         <NextPrevStyle BackColor="DarkGray" Font-Names="Arial" ForeColor="Yellow" />
         <TitleStyle BackColor="Gray" Font-Names="Arial Black" ForeColor="White" HorizontalAlign="Left" />
      </asp:Calendar>
   </div>
   </form>
</body>
</html>
