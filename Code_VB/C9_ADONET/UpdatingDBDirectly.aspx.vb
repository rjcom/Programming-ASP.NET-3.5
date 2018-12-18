Imports System.Data
Imports System.Data.SqlClient

Partial Class UpdatingDBDirectly
    Inherits System.Web.UI.Page

    Private ReadOnly connectionString As String = "Data Source=(local)\sql2k5;Initial Catalog=AdventureWorksLT;Integrated Security=True"

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If Not IsPostBack Then
            PopulateCategoryList()
            PopulateGrid()
        End If
    End Sub

    Private Sub PopulateCategoryList()
        ' Create connection to AdventureWorksLT
        Dim connection As New SqlConnection(connectionString)

        ' Create SqlCommand
        Dim cmdString As New StringBuilder("SELECT DISTINCT ProductCategoryID, Name FROM SalesLT.ProductCategory ")
        cmdString.Append("WHERE (ParentProductCategoryID IS NULL) ORDER BY ProductCategoryID")
        Dim cmd As New SqlCommand(cmdString.ToString(), connection)

        Try
            connection.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While dr.Read()
                ddlParentCategory.Items.Add(New ListItem(dr("Name").ToString(), dr("ProductCategoryID").ToString()))
            End While

            dr.Close()
        Finally
            If connection.State <> ConnectionState.Closed Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub PopulateGrid()
        ' Create connection to AdventureWorksLT
        Dim connection As New SqlConnection(connectionString)

        ' Create SqlCommand string
        Dim cmdString As New StringBuilder("SELECT child.ProductCategoryId, child.Name AS 'Category', child.ParentProductCategoryID, parent.Name AS 'ParentCategory'")
        cmdString.Append("FROM SalesLT.ProductCategory AS child INNER JOIN ")
        cmdString.Append("SalesLT.ProductCategory AS parent ON child.ParentProductCategoryID = parent.ProductCategoryID")

        Dim cmd As New SqlCommand(cmdString.ToString(), connection)

        Try
            connection.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            CategoryGridView.DataSource = dr
            CategoryGridView.DataBind()

            dr.Close()
        Finally
            If connection.State <> ConnectionState.Closed Then
                connection.Close()
            End If
        End Try
    End Sub


    Protected Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim insertCommand As String = [String].Format("insert into SalesLT.ProductCategory ([ParentProductCategoryID], [Name]) values ('{0}', '{1}')", ddlParentCategory.SelectedValue, txtName.Text)
        UpdateDB(insertCommand)
        PopulateGrid()
    End Sub

    Protected Sub btnEdit_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim updateCommand As String = [String].Format("Update SalesLT.ProductCategory SET Name='{0}', ParentProductCategoryID='{1}' where ProductCategoryID='{2}'", txtName.Text, ddlParentCategory.SelectedValue, hdnCategoryID.Value)
        UpdateDB(updateCommand)
        PopulateGrid()
    End Sub
    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim deleteCommand As String = [String].Format("delete from SalesLT.ProductCategory where ProductCategoryID ='{0}'", hdnCategoryID.Value)
        UpdateDB(deleteCommand)
        PopulateGrid()
    End Sub

    Private Sub UpdateDB(ByVal cmdString As String)
        Dim connection As New SqlConnection(connectionString)
        Dim command As New SqlCommand(cmdString, connection)

        Try
            connection.Open()
            command.ExecuteNonQuery()
        Finally
            If connection.State <> ConnectionState.Closed Then
                connection.Close()
            End If
        End Try
    End Sub

    Protected Sub CategoryGridView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim selectedIndex As Integer = CategoryGridView.SelectedIndex

        If selectedIndex <> -1 Then
            Dim selectedValues As TableCellCollection = CategoryGridView.Rows(selectedIndex).Cells

            ' Have to know the order of these cells in the Grid
            hdnCategoryID.Value = selectedValues(1).Text
            txtName.Text = selectedValues(2).Text
            ddlParentCategory.SelectedValue = selectedValues(3).Text
        End If
    End Sub


End Class
