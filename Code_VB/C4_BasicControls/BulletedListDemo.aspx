<%@ Page Language="VB" AutoEventWireup="false" CodeFile="BulletedListDemo.aspx.vb" Inherits="BulletedListDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>BulletedList Demo</title>
</head>
<body>
   <!-- 
      Add BulletedListDemo.aspx to web site
      Add BulletedList to the page. Call it bltBooks. Set Target property.
      Copy Page_Load from DropDownListDemo.aspx and change slightly so amazon urls are set in values
      Add a 3x3 HTML table to the page under the BulletedList
      First row merge into one cell, give it ID=tdMessage and runat properties
      Second row. Add headings to each cell
      Third row, first cell. Add ListBox called lbxBulletStyle and populate it declaratively
      Third row, second cell. Add ListBox called lbxBulletNumber and populate it declaratively
      Third row, third cell. Add ListBox called lbxDisplayMode and populate it declaratively
      Set AutoPostBack = true for all ListBoxes
      Add SelectedIndexChanged event handler for first ListBox with code as given. (This is the default handler so so double click in design view will do)
      Set SelectedIndexChanged event handler for other ListBoxes to the same handler 
      Add Click event handler for bltWebsites. (This is the default handler so so double click in design view will do)
   -->   
   <form id="form1" runat="server">
   <div>
      <asp:BulletedList ID="bltBooks" runat="server" Target="_blank" onclick="bltBooks_Click" />
      <table>
         <tr>
            <td colspan="3" id="tdMessage" runat="server">
            </td>
         </tr>
         <tr>
            <td>
               <em>BulletStyle</em>
            </td>
            <td>
               <em>FirstBulletNumber</em>
            </td>
            <td>
               <em>DisplayMode</em>
            </td>
         </tr>
         <tr>
            <td>
               <asp:ListBox ID="lbxBulletStyle" runat="server" AutoPostBack="true" 
                  onselectedindexchanged="lbxSelectedIndexChanged">
                  <asp:ListItem>NotSet</asp:ListItem>
                  <asp:ListItem>Numbered</asp:ListItem>
                  <asp:ListItem>LowerAlpha</asp:ListItem>
                  <asp:ListItem>UpperAlpha</asp:ListItem>
                  <asp:ListItem>LowerRoman</asp:ListItem>
                  <asp:ListItem>UpperRoman</asp:ListItem>
                  <asp:ListItem>Disc</asp:ListItem>
                  <asp:ListItem>Circle</asp:ListItem>
                  <asp:ListItem>Square</asp:ListItem>
                  <asp:ListItem>CustomImage</asp:ListItem>
               </asp:ListBox>
            </td>
            <td>
               <asp:ListBox ID="lbxBulletNumber" runat="server" AutoPostBack="true" 
                  onselectedindexchanged="lbxSelectedIndexChanged">
                  <asp:ListItem>1</asp:ListItem>
                  <asp:ListItem>2</asp:ListItem>
                  <asp:ListItem>3</asp:ListItem>
                  <asp:ListItem>4</asp:ListItem>
                  <asp:ListItem>5</asp:ListItem>
                  <asp:ListItem>6</asp:ListItem>
               </asp:ListBox>
            </td>
            <td>
               <asp:ListBox ID="lbxDisplayMode" runat="server" AutoPostBack="true"
                  onselectedindexchanged="lbxSelectedIndexChanged">
                  <asp:ListItem>Text</asp:ListItem>
                  <asp:ListItem>HyperLink</asp:ListItem>
                  <asp:ListItem>LinkButton</asp:ListItem>
               </asp:ListBox>
            </td>
         </tr>
      </table>
   </div>
   </form>
</body>
</html>

