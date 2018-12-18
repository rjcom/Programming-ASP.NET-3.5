Imports System.Data
Imports System.Data.SqlClient

Partial Class SimpleADONetGridView
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        ' 1. Create the connection string and command string
        Dim connectionString As String = "Data Source=(local)\sql2k5;Initial Catalog=AdventureWorksLT;Integrated Security=True"

        Dim commandString As String = "Select [CustomerId], [FirstName], [LastName], [EmailAddress]  from SalesLT.Customer"

        ' 2. Pass the strings to the SqlDataAdapter constructor
        Dim dataAdapter As New SqlDataAdapter(commandString, connectionString)

        ' 3. Create a DataSet
        Dim dataSet As New DataSet()
        ' 4. fill the dataset object         
        dataAdapter.Fill(dataSet, "Customers")

        ' 5. Get the table from the dataset         
        Dim dataTable As DataTable = dataSet.Tables("Customers")

        ' 6. Bind to the Gridview         
        GridView1.DataSource = dataTable
        GridView1.DataBind()
    End Sub


End Class
