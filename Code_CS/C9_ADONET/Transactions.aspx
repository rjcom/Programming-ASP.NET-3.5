<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Transactions.aspx.cs" Inherits="Transactions" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Transactions Demo</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:GridView ID="OrdersGridView" runat="server" DataKeyNames="SalesOrderID" OnSelectedIndexChanged="OrdersGridView_SelectedIndexChanged"
         AutoGenerateColumns="False">
         <Columns>
            <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Details" />
            <asp:BoundField DataField="SalesOrderID" HeaderText="OrderID" />
            <asp:BoundField DataField="OrderDate" HeaderText="Order Date" />
            <asp:BoundField DataField="CompanyName" HeaderText="Company" />
            <asp:BoundField DataField="ContactName" HeaderText="Contact" />
            <asp:BoundField DataField="Phone" HeaderText="Phone" />
            <asp:BoundField DataField="PurchaseOrderNumber" HeaderText="Purchase Order#" />
         </Columns>
      </asp:GridView>
      <asp:Panel ID="OrderDetailsPanel" runat="server" Visible="false">
         <asp:DetailsView ID="OrderDetailsView" runat="server" AutoGenerateRows="False">
            <Fields>
               <asp:BoundField DataField="ProductName" HeaderText="Product" />
               <asp:BoundField DataField="UnitPrice" HeaderText="Unit Price" />
               <asp:BoundField DataField="OrderQty" HeaderText="Quantity" />
            </Fields>
         </asp:DetailsView>
      </asp:Panel>
      <h3>
         Place new order</h3>
      <table>
         <tr>
            <td>
               Company:
            </td>
            <td>
               <asp:DropDownList ID="ddlCompany" DataValueField="CustomerID" DataTextField="CompanyName"
                  Width="160" runat="server" />
            </td>
            <td>
               Product:
            </td>
            <td>
               <asp:DropDownList ID="ddlProduct" runat="server" DataValueField="ProductID" DataTextField="Name"
                  Width="160" />
            </td>
            <td>
            </td>
            <td>
            </td>
         </tr>
         <tr>
            <td>
               Unit Price:
            </td>
            <td>
               <asp:TextBox ID="txtUnitPrice" runat="server" Width="48px" Text="0" />
            </td>
            <td>
               Quantity:
            </td>
            <td>
               <asp:TextBox ID="txtQuantity" runat="server" Width="48px" Text="0" />
            </td>
            <td>
               Discount:
            </td>
            <td>
               <asp:TextBox ID="txtDiscount" runat="server" Width="48px" Text="0" />
            </td>
         </tr>
         <tr>
            <td colspan="4">
               <asp:RadioButtonList ID="rbTransactionType" runat="server" RepeatDirection="Horizontal">
                  <asp:ListItem Value="DB" Selected="true">Database Transaction</asp:ListItem>
                  <asp:ListItem Value="Connection">Connection Transaction</asp:ListItem>
               </asp:RadioButtonList>
            </td>
            <td>
               <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            </td>
            <td>
               <asp:Label ID="lblNewOrderID" runat="server" Text="" />
            </td>
         </tr>
      </table>
   </div>
   </form>
</body>
</html>
