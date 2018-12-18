<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ListView.aspx.vb" Inherits="ListView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>ListView Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:SqlDataSource ID="dsCustomers" runat="server" ConnectionString="<%$ ConnectionStrings:AWLTConnection %>"
         SelectCommand="SELECT [FirstName], [LastName], [EmailAddress], [ModifiedDate] FROM [SalesLT].[Customer]">
      </asp:SqlDataSource>
      <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" PageSize="10">
         <Fields>
            <asp:NextPreviousPagerField  />
            <asp:NumericPagerField  />
         </Fields>
      </asp:DataPager>
      <asp:ListView ID="ListView1" runat="server" DataSourceID="dsCustomers">
         <LayoutTemplate>
            <p><asp:Button ID="btnSortOnDate" runat="server" CommandName="Sort" CommandArgument="ModifiedDate"
               Text="Sort on date" />
            <asp:Button ID="btnSortOnLastName" runat="server" Text="Sort by Last Name" OnClick="btnSortOnLastName_Click"  />   
            </p>
            <div id="CustomerReport">
               <asp:PlaceHolder runat="server" ID="itemPlaceholder" />
            </div>
         </LayoutTemplate>
         <ItemTemplate>
            <p>
               <a href="<%# Eval("EmailAddress", "mailto:{0}") %>">
                  <%# Eval("FirstName") %>
                  <%# Eval("LastName") %></a> last contacted us on
               <%# Eval("ModifiedDate", "{0:dd MMM yyyy}") %>
            </p>
         </ItemTemplate>
      </asp:ListView>
   </div>
   </form>
</body>
</html>
