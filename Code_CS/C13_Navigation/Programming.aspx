<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
   CodeFile="Programming.aspx.cs" Inherits="Programming" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
   <h1>
      Programming</h1>
   <hr />
   <table>
      <tr>
         <td>
            <b>Current Node:</b>
         </td>
         <td>
            <asp:Label ID="lblCurrentNode" runat="server" />
         </td>
      </tr>
      <tr>
         <td>
            <b>Child Nodes:</b>
         </td>
         <td>
            <asp:Label ID="lblChildNodes" runat="server" />
         </td>
      </tr>
   </table>
</asp:Content>
