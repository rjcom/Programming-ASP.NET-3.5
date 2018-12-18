<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SqlDataSource.aspx.cs" Inherits="SqlDataSource" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SqlDataSource Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
          DataSourceID="SqlDataSource1" 
          EmptyDataText="There are no data records to display." BackColor="#CCCCCC" 
            BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" 
            CellSpacing="2" ForeColor="Black">
           <FooterStyle BackColor="#CCCCCC" />
           <RowStyle BackColor="White" />
          <Columns>
             <asp:BoundField DataField="SystemInformationID" 
                HeaderText="SystemInformationID" ReadOnly="True" 
                SortExpression="SystemInformationID" />
             <asp:BoundField DataField="Database_Version" HeaderText="Database_Version" 
                SortExpression="Database_Version" />
             <asp:BoundField DataField="VersionDate" HeaderText="VersionDate" 
                SortExpression="VersionDate" />
             <asp:BoundField DataField="ModifiedDate" HeaderText="ModifiedDate" 
                SortExpression="ModifiedDate" />
          </Columns>
           <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
           <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
           <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
       </asp:GridView>
       <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
          ConnectionString="<%$ ConnectionStrings:AdventureWorksLTConnectionString %>" 
          ProviderName="<%$ ConnectionStrings:AdventureWorksLTConnectionString.ProviderName %>" 
          SelectCommand="SELECT [SystemInformationID], [Database Version] AS Database_Version, [VersionDate], [ModifiedDate] FROM [BuildVersion]">
       </asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
