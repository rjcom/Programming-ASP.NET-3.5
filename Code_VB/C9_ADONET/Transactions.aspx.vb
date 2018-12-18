Imports System.Data
Imports System.Data.SqlClient

Partial Class Transactions
    Inherits System.Web.UI.Page

    Private ReadOnly connectionString As String = "Data Source=(local)\sql2k5;Initial Catalog=AdventureWorksLT;Integrated Security=True"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If Not IsPostBack Then
            Dim conn As New SqlConnection(connectionString)

            Try
                conn.Open()
                BindOrdersGridView(conn)
                BindCustomerList(conn)
                BindProductList(conn)
            Finally
                If conn.State <> ConnectionState.Closed Then
                    conn.Close()
                End If
            End Try
        End If

    End Sub

    Private Sub BindProductList(ByVal conn As SqlConnection)
        Dim productReader As SqlDataReader = GetDataReader(conn, "Product")
        ddlProduct.DataSource = productReader
        ddlProduct.DataBind()
        productReader.Close()
    End Sub

    Private Sub BindCustomerList(ByVal conn As SqlConnection)
        Dim companyReader As SqlDataReader = GetDataReader(conn, "Customer")
        ddlCompany.DataSource = companyReader
        ddlCompany.DataBind()
        companyReader.Close()
    End Sub

    Private Sub BindOrdersGridView(ByVal conn As SqlConnection)
        Dim orderReader As SqlDataReader = GetDataReader(conn, "Orders")
        OrdersGridView.DataSource = orderReader
        OrdersGridView.DataBind()

        'Close DataReader but keep connection open
        orderReader.Close()
    End Sub

    Private Function GetDataReader(ByVal conn As SqlConnection, ByVal infoRequired As String) As SqlDataReader
        Dim cmdString As New StringBuilder()

        Select Case infoRequired
            Case "Orders"
                cmdString.Append("select o.salesorderid, o.orderdate, c.FirstName + ' ' + c.LastName as 'ContactName', ")
                cmdString.Append("c.companyname, c.phone, o.PurchaseOrderNumber ")
                cmdString.Append("from SalesLT.SalesOrderHeader o ")
                cmdString.Append("inner join SalesLT.Customer c on o.CustomerId = c.CustomerId ")
                cmdString.Append("order by o.salesorderid")
                Exit Select
            Case "OrderDetails"
                Dim index As Integer = OrdersGridView.SelectedIndex
                Dim orderId As Integer = -1

                If index <> -1 Then
                    'get the orderId from the GridView
                    Dim key As DataKey = OrdersGridView.DataKeys(index)
                    orderId = CInt(key.Value)
                End If

                cmdString.Append("select d.UnitPrice, d.OrderQty, p.Name as 'ProductName' ")
                cmdString.Append("from SalesLT.SalesOrderDetail d ")
                cmdString.Append("inner join SalesLT.Product p on d.ProductId = p.ProductId ")
                cmdString.AppendFormat("where d.SalesOrderId = {0}", orderId.ToString())
                Exit Select
            Case "Customer"
                cmdString.Append("select CustomerID, CompanyName from SalesLT.Customer")
                Exit Select
            Case "Product"
                cmdString.Append("select ProductID, Name from SalesLT.Product")
                Exit Select
            Case Else
                Throw New ArgumentException("GetDataReader was given an incorrect request for data")
        End Select

        Dim cmd As New SqlCommand(cmdString.ToString(), conn)

        Return cmd.ExecuteReader()
    End Function

    Protected Sub OrdersGridView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim conn As New SqlConnection(connectionString)

        Try
            conn.Open()
            BindOrdersGridView(conn)
            Dim drDetails As SqlDataReader = GetDataReader(conn, "OrderDetails")

            If drDetails.HasRows Then
                OrderDetailsPanel.Visible = True
                OrderDetailsView.DataSource = drDetails
                OrderDetailsView.DataBind()
            Else
                OrderDetailsPanel.Visible = False
            End If
        Finally
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
    End Sub

    Protected Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim ProductId As Integer = Convert.ToInt32(ddlProduct.SelectedValue)
        Dim Quantity As Integer = Convert.ToInt32(txtQuantity.Text)
        Dim Discount As Integer = Convert.ToInt32(txtDiscount.Text)
        Dim PricePerUnit As Integer = Convert.ToInt32(txtUnitPrice.Text)
        Dim CustomerId As Integer = Convert.ToInt32(ddlCompany.SelectedValue)

        Dim whichTransaction As String = rbTransactionType.SelectedValue.ToString()

        If whichTransaction = "DB" Then
            PerformDBTransaction(CustomerId, ProductId, Quantity, Discount, PricePerUnit)
        Else
            PerformConnectionTransaction(CustomerId, ProductId, Quantity, Discount, PricePerUnit)
        End If
    End Sub

    Private Sub PerformConnectionTransaction(ByVal CustomerId As Integer, ByVal ProductId As Integer, ByVal Quantity As Integer, ByVal Discount As Integer, ByVal PricePerUnit As Integer)
        ' Get connection
        Dim conn As New SqlConnection(connectionString)

        ' Setup command to run sproc spAddOrder
        Dim cmd As New SqlCommand("spAddOrder", conn)
        cmd.CommandType = CommandType.StoredProcedure

        ' Setup Parameters for spAddOrder
        Dim customerIdParam As SqlParameter = cmd.Parameters.Add("@CustomerID", SqlDbType.Int)
        customerIdParam.Value = CustomerId
        customerIdParam.Direction = ParameterDirection.Input

        Dim salesOrderIdParam As SqlParameter = cmd.Parameters.Add("@SalesOrderID", SqlDbType.Int)
        salesOrderIdParam.Direction = ParameterDirection.Output

        ' Declare transaction
        Dim transaction As SqlTransaction = Nothing
        Dim OrderID As Integer = -1

        Try
            ' Open connection 
            ' Create transaction and add to command
            conn.Open()
            transaction = conn.BeginTransaction()
            cmd.Transaction = transaction

            ' Execute the stored procedure and get the ID for the new order
            cmd.ExecuteNonQuery()
            OrderID = Convert.ToInt32(cmd.Parameters("@SalesOrderID").Value)

            ' Now add the details for the order
            Dim cmdAddDetails As New StringBuilder("insert into SalesLT.SalesOrderDetail ")
            cmdAddDetails.Append("(SalesOrderID, OrderQty, ProductID, UnitPrice, UnitPriceDiscount) ")
            cmdAddDetails.AppendFormat("values ({0}, {1}, {2}, {3}, {4})", OrderID.ToString(), Quantity, ProductId, PricePerUnit, Discount)

            ' Re-use the command object for this update and execute it
            cmd.CommandType = CommandType.Text
            cmd.CommandText = cmdAddDetails.ToString()
            cmd.ExecuteNonQuery()

            ' commit the transaction
            transaction.Commit()

            BindOrdersGridView(conn)
        Catch e As Exception
            Trace.Write(e.Message)
            transaction.Rollback()
        Finally
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
        End Try

        'Reset the form
        txtDiscount.Text = String.Empty
        txtQuantity.Text = String.Empty
        txtUnitPrice.Text = String.Empty
        lblNewOrderID.Text = OrderID.ToString()
    End Sub

    Private Sub PerformDBTransaction(ByVal CustomerId As Integer, ByVal ProductId As Integer, ByVal Quantity As Integer, ByVal Discount As Integer, ByVal PricePerUnit As Integer)
        ' Create connection and command
        Dim conn As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand("spAddOrderTransactions", conn)
        cmd.CommandType = CommandType.StoredProcedure

        ' Add Input Parameters
        cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = CustomerId
        cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = ProductId
        cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = Quantity
        cmd.Parameters.Add("@Discount", SqlDbType.Money).Value = Discount
        cmd.Parameters.Add("@UnitPrice", SqlDbType.Money).Value = PricePerUnit

        ' Add Output Parameter
        Dim salesOrderIdParam As SqlParameter = cmd.Parameters.Add("@SalesOrderId", SqlDbType.Int)
        salesOrderIdParam.Direction = ParameterDirection.Output

        ' Setup new order id
        Dim OrderId As Integer = -1

        Try
            conn.Open()

            ' run transaction in DB
            cmd.ExecuteNonQuery()

            ' get new order id
            OrderId = Convert.ToInt32(salesOrderIdParam.Value)

            ' update gridview
            BindOrdersGridView(conn)
        Catch e As Exception
            Trace.Write(e.Message)
        Finally
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
        End Try

        'Reset the form
        txtDiscount.Text = String.Empty
        txtQuantity.Text = String.Empty
        txtUnitPrice.Text = String.Empty
        lblNewOrderID.Text = OrderId.ToString()
    End Sub


End Class
