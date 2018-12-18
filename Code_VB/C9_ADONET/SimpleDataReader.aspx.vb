Imports System.Data
Imports System.Data.SqlClient

Partial Class SimpleDataReader
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        ' Create the connection string
        Dim connectionString As String = "Data Source=(local)\sql2k5;Initial Catalog=AdventureWorksLT;" & "Integrated Security=True"

        Dim commandString As String = "Select [CustomerId], [FirstName], [LastName], [EmailAddress] from SalesLT.Customer"

        ' Create the connection object
        Dim conn As New SqlConnection(connectionString)

        ' Create a command object
        Dim command As New SqlCommand(commandString)

        ' open the connection
        Try
            ' open the connection
            conn.Open()

            ' attach connection to command object
            command.Connection = conn

            ' get the data reader             
            Dim reader As SqlDataReader = command.ExecuteReader(CommandBehavior.CloseConnection)

            ' bind to the data reader
            GridView1.DataSource = reader
            GridView1.DataBind()
        Catch ex As Exception
            lblException.Text = ex.Message
        Finally
            ' make sure the connection closes
            If conn.State <> ConnectionState.Closed Then
                conn.Close()
            End If
        End Try

    End Sub


End Class
