Imports System.Data
Imports System.Data.SqlClient

Partial Class ObjectCaching
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        CreateGridView()

    End Sub

    Private Sub CreateGridView()

        Dim dsGrid As DataSet
        dsGrid = DirectCast(Cache("GridViewDataSet"), DataSet)
        If dsGrid Is Nothing Then
            dsGrid = GetDataSet()
            'Cache["GridViewDataSet"] = dsGrid; 
            Cache.Insert("GridViewDataSet", dsGrid)
            lblMessage.Text = "Data from database."
        Else
            lblMessage.Text = "Data from cache."
        End If

        gvwCustomers.DataSource = dsGrid.Tables(0)
        gvwCustomers.DataBind()

    End Sub

    Private Function GetDataSet() As DataSet

        ' connect to the Northwind database 
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("AWLTConnectionString").ConnectionString

        ' get records from the Customer table 
        Dim commandString As String = "SELECT TOP 10 CustomerID, FirstName, LastName, " & "EmailAddress FROM SalesLT.Customer"

        ' create the data set command object and the DataSet 
        Dim dataAdapter As New SqlDataAdapter(commandString, connectionString)

        Dim dsData As New DataSet()

        ' fill the data set object 
        dataAdapter.Fill(dsData, "Customers")

        Return dsData

    End Function


    Protected Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click

        Cache.Remove("GridViewDataSet")
        CreateGridView()

    End Sub

End Class
