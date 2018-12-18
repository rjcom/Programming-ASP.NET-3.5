<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataList.aspx.cs" Inherits="DataList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Simple DataList Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:SqlDataSource ID="dsCustomers" runat="server" ConnectionString="<%$ ConnectionStrings:AWLTConnection %>"
         SelectCommand="SELECT TOP 10 [CustomerID] FROM [SalesLT].[Customer] ORDER BY [CustomerID]">
      </asp:SqlDataSource>
      <table style="text-align:center;" cellpadding="5" cellspacing="0">
         <thead>
            <tr>
               <td>&nbsp;</td>
               <td>RepeatDirection="<i>Horizontal</i>"</td>
               <td>RepeatDirection="<i>Vertical</i>"</td>
            </tr>
         </thead>
         <tr >
            <td style="border-bottom:solid 2px black;">RepeatLayout="<i>table</i>"</td>
            <td style="border-bottom:solid 2px black;border-right:solid 2px black;">
                  <asp:DataList ID="dlCustomers" runat="server" DataSourceID="dsCustomers" 
         RepeatDirection="Horizontal" RepeatColumns="2" GridLines="Both">
         <HeaderTemplate>
            The DataList Header
         </HeaderTemplate>
         <FooterTemplate>
            The DataList Footer
         </FooterTemplate>
         <ItemTemplate>
            I:
            <%# Eval("CustomerID") %>
         </ItemTemplate>
         <AlternatingItemTemplate>
            A:
            <%# Eval("CustomerID") %>
         </AlternatingItemTemplate>
         <AlternatingItemStyle HorizontalAlign="Right" />
         <ItemStyle HorizontalAlign="Left" />
      </asp:DataList>
            
            </td>
            <td style="border-bottom:solid 2px black;">      <asp:DataList ID="DataList1" 
                  runat="server" DataSourceID="dsCustomers" 
         RepeatDirection="Vertical" RepeatColumns="2" GridLines="Both" CssClass="TestClass">
         <HeaderTemplate>
            The DataList Header
         </HeaderTemplate>
         <FooterTemplate>
            The DataList Footer
         </FooterTemplate>
         <ItemTemplate>
            I:
            <%# Eval("CustomerID") %>
         </ItemTemplate>
         <AlternatingItemTemplate>
            A:
            <%# Eval("CustomerID") %>
         </AlternatingItemTemplate>
         <AlternatingItemStyle HorizontalAlign="Right" />
         <ItemStyle HorizontalAlign="Left" />
      </asp:DataList></td>
         </tr>
         <tr>
            <td>RepeatLayout="<i>flow</i>"</td>
            <td style="border-right:solid 2px black;">
                  <asp:DataList ID="DataList2" runat="server" DataSourceID="dsCustomers" 
         RepeatDirection="Horizontal" RepeatLayout="flow" RepeatColumns="2" GridLines="Both">
         <HeaderTemplate>
            The DataList Header
         </HeaderTemplate>
         <FooterTemplate>
            The DataList Footer
         </FooterTemplate>
         <ItemTemplate>
            I:
            <%# Eval("CustomerID") %>
         </ItemTemplate>
         <AlternatingItemTemplate>
            A:
            <%# Eval("CustomerID") %>
         </AlternatingItemTemplate>
         <AlternatingItemStyle HorizontalAlign="Right" />
         <ItemStyle HorizontalAlign="Left" />
      </asp:DataList>
            
            </td>
            <td>      <asp:DataList ID="DataList3" runat="server" DataSourceID="dsCustomers" 
         RepeatDirection="Vertical" RepeatLayout="flow" RepeatColumns="2" GridLines="Both" 
                  CssClass="TestClass">
         <HeaderTemplate>
            The DataList Header
         </HeaderTemplate>
         <FooterTemplate>
            The DataList Footer
         </FooterTemplate>
         <ItemTemplate>
            I:
            <%# Eval("CustomerID") %>
         </ItemTemplate>
         <AlternatingItemTemplate>
            A:
            <%# Eval("CustomerID") %>
         </AlternatingItemTemplate>
         <AlternatingItemStyle HorizontalAlign="Right" />
         <ItemStyle HorizontalAlign="Left" />
      </asp:DataList></td>
         </tr>
      </table>
   </div>
   </form>
</body>
</html>
