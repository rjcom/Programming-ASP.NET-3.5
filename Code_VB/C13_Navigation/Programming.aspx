<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Programming.aspx.vb" Inherits="Programming" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <h1>Programming</h1>
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

