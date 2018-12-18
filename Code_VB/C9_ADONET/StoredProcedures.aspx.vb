Imports System.Data
Imports System.Data.SqlClient

Partial Class StoredProcedures
    Inherits System.Web.UI.Page


    Private ReadOnly connectionString As String = "Data Source=(local)\sql2k5;Initial Catalog=AdventureWorksLT;Integrated Security=True"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If Not IsPostBack Then
            Dim ds As DataSet = CreateOrderDataSet()
            OrderGridView.DataSource = ds.Tables("Orders")
            OrderGridView.DataBind()

            UpdateDetailsGrid()
        End If
    End Sub

    Protected Sub OrderGridView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        UpdateDetailsGrid()
    End Sub

    Private Sub UpdateDetailsGrid()

        Dim index As Integer = OrderGridView.SelectedIndex
        If index <> -1 Then
            ' get the order id from the data grid
            Dim key As DataKey = OrderGridView.DataKeys(index)
            Dim orderID As Integer = CInt(key.Value)

            Dim ds As DataSet = CreateOrderDetailsDataSet(orderID)

            OrderDetailsGridView.DataSource = ds
            OrderDetailsGridView.DataBind()
            OrderDetailsPanel.Visible = True
        Else
            OrderDetailsPanel.Visible = False
        End If
    End Sub

#Region "OrderGridView"

    Private Function CreateOrderDataSet() As DataSet
        ' Create a database connection
        Dim connection As New SqlConnection(connectionString)

        ' Create a DataAdapter for the SalesOrderHeader GridView
        Dim OrdersAdapter As SqlDataAdapter = CreateAdapterForOrders(connection)

        ' Create the dataset and use the data adapter to fill it     
        Dim dataSet As New DataSet()

        Try
            connection.Open()
            OrdersAdapter.Fill(dataSet)
        Finally
            If connection.State <> ConnectionState.Closed Then
                connection.Close()
            End If
        End Try
        Return dataSet
    End Function

    Private Function CreateAdapterForOrders(ByVal connection As SqlConnection) As SqlDataAdapter
        ' Set the command to use the spOrders sproc
        Dim cmd As New SqlCommand("spOrders", connection)
        cmd.CommandType = CommandType.StoredProcedure

        ' Set adapter to use sproc as command
        Dim OrdersAdapter As New SqlDataAdapter(cmd)
        OrdersAdapter.TableMappings.Add("Table", "Orders")
        Return OrdersAdapter
    End Function

#End Region

#Region "OrderDetailsGridView"

    Private Function CreateOrderDetailsDataSet(ByVal orderId As Integer) As DataSet
        ' Create a database connection
        Dim connection As New SqlConnection(connectionString)

        ' Create a DataAdapter for the SalesOrderHeader GridView
        Dim OrdersAdapter As SqlDataAdapter = CreateAdapterForOrderDetails(connection, orderId)

        ' Create the dataset and use the data adapter to fill it     
        Dim dataSet As New DataSet()

        Try
            connection.Open()
            OrdersAdapter.Fill(dataSet)
        Finally
            If connection.State <> ConnectionState.Closed Then
                connection.Close()
            End If
        End Try
        Return dataSet
    End Function

    Private Function CreateAdapterForOrderDetails(ByVal connection As SqlConnection, ByVal orderId As Integer) As SqlDataAdapter
        ' Set the command to use the spOrderDetails sproc and parameter
        Dim cmd As New SqlCommand("spOrderDetails", connection)
        cmd.CommandType = CommandType.StoredProcedure

        Dim orderIdParameter As SqlParameter = cmd.Parameters.AddWithValue("@OrderId", orderId)
        orderIdParameter.Direction = ParameterDirection.Input
        orderIdParameter.DbType = DbType.Int32

        ' Set adapter to use sproc as command
        Dim OrderDetailsAdapter As New SqlDataAdapter(cmd)
        OrderDetailsAdapter.TableMappings.Add("Table", "OrderDetails")
        Return OrderDetailsAdapter
    End Function

#End Region


End Class
