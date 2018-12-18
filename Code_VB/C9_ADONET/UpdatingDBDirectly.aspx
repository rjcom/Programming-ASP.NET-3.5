<%@ Page Language="VB" AutoEventWireup="true" CodeFile="UpdatingDBDirectly.aspx.vb" Inherits="UpdatingDBDirectly" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Updating DB Directly</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:GridView ID="CategoryGridView" runat="server" 
         DataKeyNames="ProductCategoryId" 
         OnSelectedIndexChanged="CategoryGridView_SelectedIndexChanged" 
         BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" 
         CellPadding="3" ForeColor="Black" GridLines="Vertical">
         <FooterStyle BackColor="#CCCCCC" />
         <Columns>
            <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
         </Columns>
         <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
         <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
         <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
         <AlternatingRowStyle BackColor="#CCCCCC" />
      </asp:GridView>
      <asp:HiddenField ID="hdnCategoryID" runat="server" />
      <asp:Label ID="Label1" runat="server" Text="Category Name: " />
      <asp:TextBox ID="txtName" runat="server" /><br />
      <asp:Label ID="Label2" runat="server" Text="Parent Category: " />
      <asp:DropDownList ID="ddlParentCategory" runat="server" />
      <br />
      <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
      <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
      <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
   </div>
   </form>
</body>
</html>
