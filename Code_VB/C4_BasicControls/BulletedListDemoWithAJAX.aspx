<%@ Page Language="VB" AutoEventWireup="false" CodeFile="BulletedListDemoWithAJAX.aspx.vb" Inherits="BulletedListDemoWithAJAX" %>


<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>BulletedList Demo With AJAX</title>

   <script type="text/javascript">

       function pageLoad() {
       }
    
   </script>

</head>
<body>
   <!--
      Add new AJAX web form to web site called BulletedListDemoWithAJAX.aspx
      The BulletedList control doesn't have the scope to add a ListSearchExtender so we need an alternate way to 
         search through long lists. This is provided by the PagingBulletedList
      Add BulletedList under ScriptManager. 
      Copy BulletedList, table and 3 listboxes from BulletedListDemo.aspx under ScriptManager in BulletedListDemoWithAJAX.aspx
      Copy event handler code from BulletedListDemo.aspx to BulletedListDemoWithAJAX.aspx.cs
      Run page to make sure you've copied everything across OK.
      
      Add a PagingBulletedListExtender to the page under the bltBooks.
      Set targetControlId to bltBooks and ClientSort to true
      Run page. See how BulletedList now augmented with an index. 
      Choose the letter of the books to begin with and those book titles appear.
      Try also setting IndexSize to 3 and then MaxItemPerPage to 3 to see how you can affect the way the index is shown.
   -->
   <form id="form1" runat="server">
   <div>
      <asp:ScriptManager ID="ScriptManager1" runat="server" />
      <asp:BulletedList ID="bltBooks" runat="server" Target="_blank" OnClick="bltBooks_Click" />
      <cc1:PagingBulletedListExtender ID="PagingBulletedListExtender1" runat="server" TargetControlID="bltBooks"
         ClientSort="true" IndexSize="3" Height="250">
      </cc1:PagingBulletedListExtender>
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
               <asp:ListBox ID="lbxBulletStyle" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lbxSelectedIndexChanged">
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
               <asp:ListBox ID="lbxBulletNumber" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lbxSelectedIndexChanged">
                  <asp:ListItem>1</asp:ListItem>
                  <asp:ListItem>2</asp:ListItem>
                  <asp:ListItem>3</asp:ListItem>
                  <asp:ListItem>4</asp:ListItem>
                  <asp:ListItem>5</asp:ListItem>
                  <asp:ListItem>6</asp:ListItem>
               </asp:ListBox>
            </td>
            <td>
               <asp:ListBox ID="lbxDisplayMode" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lbxSelectedIndexChanged">
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
