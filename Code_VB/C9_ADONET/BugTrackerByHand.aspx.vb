Imports System.Data
Partial Class BugTrackerByHand
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If Not IsPostBack Then
            ' call the method whichthat creates the tables and the relations
            Dim ds As DataSet = CreateDataSet()

            ' set the data source for the grid to the first table
            BugsGridView.DataSource = ds.Tables("Bugs")
            BugsGridView.DataBind()

            BugConstraintsGridView.DataSource = ds.Tables("Bugs").Constraints
            BugConstraintsGridView.DataBind()
        End If
    End Sub

    Private Function CreateDataSet() As DataSet
        ' Create a new DataSet object for tables and realtions
        Dim dataSet As New DataSet()

        ' Create the Bugs table and add it to the DataSet
        Dim tblBugs As DataTable = CreateBugsTable()
        dataSet.Tables.Add(tblBugs)

        ' Create the Product Table and add it to the DataSet
        Dim tblProduct As DataTable = CreateProductTable()
        dataSet.Tables.Add(tblProduct)

        ' Create the People Table and add it to the DataSet
        Dim tblPeople As DataTable = CreatePeopleTable()
        dataSet.Tables.Add(tblPeople)

        ' Create the Foreign Key Constraint People.PersonID = Bugs.ReporterID
        CreateForeignKeyAndDataRelation(dataSet, "BugToPerson", tblPeople, "PersonID", tblBugs, "ReporterID")

        ' Create the Foreign Key Constraint Product.ProductID = Bugs.ProductID
        CreateForeignKeyAndDataRelation(dataSet, "BugToProduct", tblProduct, "ProductID", tblBugs, "ProductID")

        Return dataSet
    End Function

#Region "Generic Table Methods"

    Private Sub AddNewPrimaryKeyColumn(ByVal table As DataTable, ByVal ColumnName As String)
        AddNewColumn(table, "System.Int32", ColumnName, False)
        Dim PkColumn As DataColumn = table.Columns(ColumnName)

        ' Set column as auto-increment field
        PkColumn.AutoIncrement = True
        ' autoincrementing
        PkColumn.AutoIncrementSeed = 1
        ' starts at 1
        PkColumn.AutoIncrementStep = 1
        ' increments by 1
        ' Make sure all values are unique
        Dim constraintName As String = [String].Format("Unique_{0}", ColumnName)
        Dim constraint As New UniqueConstraint(constraintName, PkColumn)
        table.Constraints.Add(constraint)

        ' Set column as primary key for table
        Dim columnArray As DataColumn() = New DataColumn() {PkColumn}
        table.PrimaryKey = columnArray
    End Sub

    Private Sub AddNewColumn(ByVal table As DataTable, ByVal ColumnType As String, ByVal ColumnName As String, ByVal AllowNulls As Boolean, ByVal DefaultValue As Object, ByVal MaxLength As Integer)
        Dim newColumn As DataColumn = table.Columns.Add(ColumnName, Type.[GetType](ColumnType))
        newColumn.AllowDBNull = AllowNulls
        newColumn.MaxLength = MaxLength
        newColumn.DefaultValue = DefaultValue
    End Sub

    Private Sub AddNewColumn(ByVal table As DataTable, ByVal ColumnType As String, ByVal ColumnName As String, ByVal AllowNulls As Boolean, ByVal DefaultValue As Object)
        AddNewColumn(table, ColumnType, ColumnName, AllowNulls, DefaultValue, -1)
    End Sub

    Private Sub AddNewColumn(ByVal table As DataTable, ByVal ColumnType As String, ByVal ColumnName As String, ByVal AllowNulls As Boolean)
        AddNewColumn(table, ColumnType, ColumnName, AllowNulls, Nothing, -1)
    End Sub

    Private Sub CreateForeignKeyAndDataRelation(ByVal dataSet As DataSet, ByVal relationName As String, ByVal parentTable As DataTable, ByVal primaryKeyColumnName As String, ByVal childTable As DataTable, ByVal foreignKeyColumnName As String)
        ' Get references to related columns
        Dim primaryKeyColumn As DataColumn = parentTable.Columns(primaryKeyColumnName)
        Dim foreignKeyColumn As DataColumn = childTable.Columns(foreignKeyColumnName)
        Dim foreignKeyConstraintName As String = [String].Format("FK_{0}", relationName)

        ' Create foreign key constraint
        Dim fk As New ForeignKeyConstraint(foreignKeyConstraintName, primaryKeyColumn, foreignKeyColumn)
        fk.DeleteRule = Rule.Cascade
        ' if parent row is deleted, all rows related in child table are deleted too
        fk.UpdateRule = Rule.Cascade
        childTable.Constraints.Add(fk)
        ' add the new constraint
        ' Add a DataRelation representing the FKConstraint to the DataSet
        Dim relation As New DataRelation(relationName, primaryKeyColumn, foreignKeyColumn)
        dataSet.Relations.Add(relation)
    End Sub

#End Region

#Region "Bugs Table"

    Private Function CreateBugsTable() As DataTable
        Dim tblBugs As New DataTable("Bugs")

        ' Add columns
        AddNewPrimaryKeyColumn(tblBugs, "BugID")
        AddNewColumn(tblBugs, "System.Int32", "ProductID", False, 1)
        AddNewColumn(tblBugs, "System.String", "Version", False, "0.1", 50)
        AddNewColumn(tblBugs, "System.String", "Description", False, "", 8000)
        AddNewColumn(tblBugs, "System.Int32", "ReporterID", False)

        ' Add some rows to the table
        AddNewBug(tblBugs, 1, "0.1", "Crashes on load", 5)
        AddNewBug(tblBugs, 1, "0.1", "Does not report correct owner of bug", 5)
        AddNewBug(tblBugs, 1, "0.1", "Does not show history of previous action", 6)
        AddNewBug(tblBugs, 1, "0.1", "Fails to reload properly", 5)
        AddNewBug(tblBugs, 2, "0.1", "Loses data overnight", 5)
        AddNewBug(tblBugs, 2, "0.1", "HTML is not shown properly", 6)
        Return tblBugs
    End Function

    Private Sub AddNewBug(ByVal bugTable As DataTable, ByVal product As Integer, ByVal version As String, ByVal description As String, ByVal reporter As Integer)
        Dim newRow As DataRow = bugTable.NewRow()
        newRow("ProductID") = product
        newRow("Version") = version
        newRow("Description") = description
        newRow("ReporterID") = reporter
        bugTable.Rows.Add(newRow)
    End Sub


#End Region

#Region "Product Table"

    Private Function CreateProductTable() As DataTable
        Dim tblProduct As New DataTable("lkProduct")

        ' Add columns
        AddNewPrimaryKeyColumn(tblProduct, "ProductID")
        AddNewColumn(tblProduct, "System.String", "ProductDescription", False, "", 8000)

        ' Add rows to the Product table
        AddNewProduct(tblProduct, "BugX Bug Tracking")
        AddNewProduct(tblProduct, "PIM - My Personal Information Manager")
        Return tblProduct
    End Function

    Private Sub AddNewProduct(ByVal productTable As DataTable, ByVal description As String)
        Dim newRow As DataRow = productTable.NewRow()
        newRow("ProductDescription") = description
        productTable.Rows.Add(newRow)
    End Sub

#End Region

#Region "People Table"

    Private Function CreatePeopleTable() As DataTable
        Dim tblPeople As New DataTable("People")

        ' Add column
        AddNewPrimaryKeyColumn(tblPeople, "PersonID")
        AddNewColumn(tblPeople, "System.String", "FullName", False, "", 8000)
        AddNewColumn(tblPeople, "System.String", "Email", False, "", 100)
        AddNewColumn(tblPeople, "System.String", "Phone", False, "", 20)
        AddNewColumn(tblPeople, "System.Int32", "Role", False, 0)

        ' Add new people
        AddNewPerson(tblPeople, "Dan Maharry", "danm@hmobius.com", "212-555-0285", 1)
        AddNewPerson(tblPeople, "Jesse Liberty", "jliberty@libertyassociates.com", "617-555-7301", 1)
        AddNewPerson(tblPeople, "Dan Hurwitz", "dhurwitz@stersol.com", "781-555-3375", 1)
        AddNewPerson(tblPeople, "John Galt", "jGalt@franconia.com", "617-555-9876", 1)
        AddNewPerson(tblPeople, "John Osborn", "jOsborn@oreilly.com", "617-555-3232", 3)
        AddNewPerson(tblPeople, "Ron Petrusha", "ron@oreilly.com", "707-555-0515", 2)
        AddNewPerson(tblPeople, "Tatiana Diaz", "tatiana@oreilly.com", "617-555-1234", 2)
        Return tblPeople
    End Function

    Private Sub AddNewPerson(ByVal table As DataTable, ByVal name As String, ByVal email As String, ByVal phone As String, ByVal role As Integer)
        Dim newRow As DataRow = table.NewRow()
        newRow("FullName") = name
        newRow("email") = email
        newRow("Phone") = phone
        newRow("Role") = role
        table.Rows.Add(newRow)
    End Sub

#End Region


End Class
