Imports System.Data
Imports System.Data.SqlClient

Partial Class DataRelations
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If Not IsPostBack Then
            UpdateDetailsGrid()

            Dim ds As DataSet = CreateDataSet()
            OrderGridView.DataSource = ds.Tables("Orders")
            OrderGridView.DataBind()

            ' create the dataview and bind to the details grid
            Dim detailsView As New DataView(ds.Tables("Details"))
            OrderDetailsGridView.DataSource = detailsView
            Session("DetailsView") = detailsView
            OrderDetailsGridView.DataBind()

            ' bind the relations grid to the relations collection
            OrderRelationsGridView.DataSource = ds.Relations
            OrderRelationsGridView.DataBind()
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
            Dim detailsView As DataView = DirectCast(Session("detailsView"), DataView)
            detailsView.RowFilter = "SalesOrderID = " & orderID
            OrderDetailsGridView.DataSource = detailsView
            OrderDetailsGridView.DataBind()
            OrderDetailsPanel.Visible = True
        Else
            OrderDetailsPanel.Visible = False
        End If
    End Sub

    Private Function CreateDataSet() As DataSet
        ' Create connection string and Connection object
        Dim connectionString As String = "Data Source=(local)\sql2k5;Initial Catalog=AdventureWorksLT;" & "Integrated Security=True"
        Dim connection As New SqlConnection(connectionString)

        ' Create a DataAdapter for the SalesOrderHeader GridView
        Dim OrdersAdapter As SqlDataAdapter = CreateAdapterForOrders(connection)

        ' Create a 2nd DataAdapter for the SalesOrderDetail GridView
        Dim OrderDetailsAdapter As SqlDataAdapter = CreateAdapterForOrderDetails(connection)

        ' Create a 3rd DataAdapter for the Products table
        Dim ProductsAdapter As SqlDataAdapter = CreateAdapterForProducts(connection)

        ' Create the dataset and use the data adapter to fill it     
        Dim dataSet As New DataSet()


        Try
            'connection.Open();
            OrdersAdapter.Fill(dataSet)
            OrderDetailsAdapter.Fill(dataSet)
            ProductsAdapter.Fill(dataSet)
        Finally
            If connection.State <> ConnectionState.Closed Then
                connection.Close()
            End If
        End Try

        CreateRelationsInDataSet(dataSet)

        Return dataSet
    End Function



    Private Shared Function CreateAdapterForOrders(ByVal connection As SqlConnection) As SqlDataAdapter
        'Build the SQL command
        Dim s As New StringBuilder("select o.SalesOrderID, o.OrderDate, c.CompanyName, c.FirstName + ' ' + c.LastName as 'Contact', o.TotalDue")
        s.Append(" from SalesLT.SalesOrderHeader o ")
        s.Append("inner join SalesLT.Customer c on c.CustomerID = o.CustomerID")

        Dim OrdersAdapter As New SqlDataAdapter()
        OrdersAdapter.SelectCommand = New SqlCommand(s.ToString(), connection)
        OrdersAdapter.TableMappings.Add("Table", "Orders")
        Return OrdersAdapter
    End Function

    Private Shared Function CreateAdapterForOrderDetails(ByVal connection As SqlConnection) As SqlDataAdapter
        ' Build the SQL command
        Dim s As New StringBuilder("Select d.SalesOrderId, p.Name, p.ProductID, d.OrderQty, d.UnitPrice, d.LineTotal ")
        s.Append("from SalesLT.SalesOrderDetail d ")
        s.Append("inner join SalesLT.Product p on d.productid = p.productid")

        Dim OrderDetailsAdapter As New SqlDataAdapter()
        OrderDetailsAdapter.SelectCommand = New SqlCommand(s.ToString(), connection)
        OrderDetailsAdapter.TableMappings.Add("Table", "Details")
        Return OrderDetailsAdapter
    End Function

    Private Shared Function CreateAdapterForProducts(ByVal connection As SqlConnection) As SqlDataAdapter
        Dim cmdString As String = "Select ProductID, Name from SalesLT.Product"

        Dim ProductsAdapter As New SqlDataAdapter()
        ProductsAdapter.SelectCommand = New SqlCommand(cmdString, connection)
        ProductsAdapter.TableMappings.Add("Table", "Products")
        Return ProductsAdapter
    End Function

    Private Shared Sub CreateRelationsInDataSet(ByVal dataSet As DataSet)
        ' declare the DataRelation and DataColumn objects     
        Dim dataRelation As DataRelation
        Dim dataColumn1 As DataColumn
        Dim dataColumn2 As DataColumn
        ' set the dataColumns to create the relationship      
        ' between Bug and Order Details on the OrderID key      
        dataColumn1 = dataSet.Tables("Orders").Columns("SalesOrderID")
        dataColumn2 = dataSet.Tables("Details").Columns("SalesOrderID")
        dataRelation = New DataRelation("OrdersToDetails", dataColumn1, dataColumn2)
        ' add the new DataRelation to the dataset     
        dataSet.Relations.Add(dataRelation)

        ' reuse the DataColumns and DataRelation objects      
        ' to create the relation between Order Details and Products        
        dataColumn1 = dataSet.Tables("Products").Columns("ProductID")
        dataColumn2 = dataSet.Tables("Details").Columns("ProductID")
        dataRelation = New DataRelation("ProductIDToName", dataColumn1, dataColumn2)
        dataSet.Relations.Add(dataRelation)
        Exit Sub
    End Sub


End Class
