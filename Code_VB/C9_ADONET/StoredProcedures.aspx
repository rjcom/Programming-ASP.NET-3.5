<%@ Page Language="VB" AutoEventWireup="true" CodeFile="StoredProcedures.aspx.vb" Inherits="StoredProcedures" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>DataTables Relationship Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:GridView ID="OrderGridView" runat="server"
          AutoGenerateColumns="False" DataKeyNames="SalesOrderID" 
          onselectedindexchanged="OrderGridView_SelectedIndexChanged">
          <Columns>
             <asp:ButtonField CommandName="Select" Text="Details" />
             <asp:BoundField DataField="SalesOrderID" HeaderText="OrderID" />
             <asp:BoundField DataField="OrderDate" HeaderText="Order Date" />
             <asp:BoundField DataField="CompanyName" HeaderText="Company" />
             <asp:BoundField DataField="Contact" HeaderText="Contact" />
             <asp:BoundField DataField="TotalDue" HeaderText="Total Due" />
          </Columns>
       </asp:GridView>
       
       <asp:Panel ID="OrderDetailsPanel" runat="server">
          <asp:GridView ID="OrderDetailsGridView" runat="server" 
             AutoGenerateColumns="False">
             <Columns>
                <asp:BoundField DataField="Name" HeaderText="Product" />
                <asp:BoundField DataField="OrderQty" HeaderText="Quantity" />
                <asp:BoundField DataField="UnitPrice" HeaderText="Price Per Unit" />
                <asp:BoundField DataField="LineTotal" HeaderText="Total" />
             </Columns>
          </asp:GridView>
       </asp:Panel>
    </div>
    </form>
</body>
</html>
