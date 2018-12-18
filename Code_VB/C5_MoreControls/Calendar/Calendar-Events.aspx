<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Calendar-Events.aspx.vb" Inherits="Calendar_Calendar_Events" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Calendar DayRender Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:Label ID="lblMonthChanged" runat="server" />
      <asp:Calendar ID="Calendar1" runat="server" SelectionMode="DayWeekMonth" 
         OnSelectionChanged="Calendar1_SelectionChanged" 
         ondayrender="Calendar1_DayRender" 
         onvisiblemonthchanged="Calendar1_VisibleMonthChanged">
      </asp:Calendar>
      <br />
      <asp:Label ID="lblCount" runat="server" />
      <br />
      <asp:Label ID="lblTodaysDate" runat="server" />
      <br />
      <asp:Label ID="lblSelected" runat="server" />
      <br />
      <table>
         <tr>
            <td>
               Select a month:
            </td>
            <td>
               <asp:DropDownList ID="ddl" runat="server" AutoPostBack="true" 
                  onselectedindexchanged="ddl_SelectedIndexChanged">
                  <asp:ListItem Text="January" Value="1" />
                  <asp:ListItem Text="February" Value="2" />
                  <asp:ListItem Text="March" Value="3" />
                  <asp:ListItem Text="April" Value="4" />
                  <asp:ListItem Text="May" Value="5" />
                  <asp:ListItem Text="June" Value="6" />
                  <asp:ListItem Text="July" Value="7" />
                  <asp:ListItem Text="August" Value="8" />
                  <asp:ListItem Text="September" Value="9" />
                  <asp:ListItem Text="October" Value="10" />
                  <asp:ListItem Text="November" Value="11" />
                  <asp:ListItem Text="December" Value="12" />
               </asp:DropDownList>
            </td>
            <td>
               <asp:Button ID="btnTgif" runat="server" Text="TGIF" onclick="btnTgif_Click" />
            </td>
         </tr>
         <tr>
            <td colspan="2">
               &nbsp;</td>
         </tr>
         <tr>
            <td colspan="2">
               <b>Day Range</b></td>
         </tr>
         <tr>
            <td>
               Starting Day</td>
            <td>
               Ending Day</td>
         </tr>
         <tr>
            <td>
               <asp:TextBox ID="txtStart" runat="server" Width="25" MaxLength="2" />
            </td>
            <td>
               <asp:TextBox ID="txtEnd" runat="server" Width="25" MaxLength="2" />
            </td>
            <td>
               <asp:Button ID="btnRange" runat="server" Text="Apply" 
                  onclick="btnRange_Click" />
            </td>
         </tr>
      </table>
   </div>
   </form>
</body>
</html>
