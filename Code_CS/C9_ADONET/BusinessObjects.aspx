<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="BusinessObjects.aspx.cs" Inherits="BusinessObjects" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Binding To Business Object</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		 <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1">
       </asp:GridView>

		<asp:ObjectDataSource ID="ObjectDataSource1" runat="server"
		 SelectMethod="GetAllCustomers"
		 TypeName="CustomerBusinessLogic" />
    
    </div>
    </form>
</body>
</html>
