Imports System.Data
Imports System.Xml

Partial Class ObjectCachingItemDependency
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        CreateGridView()

    End Sub

    Private Sub CreateGridView()

        Dim dsGrid As DataSet
        dsGrid = DirectCast(Cache("GridViewDataSet"), DataSet)
        If dsGrid Is Nothing Then
            dsGrid = GetDataSet()
            Dim fileDependsArray As String() = {Server.MapPath("Customers.xml")}
            Dim cacheDependsArray As String() = {"Depend0", "Depend1", "Depend2"}
            Dim cacheDepends As New CacheDependency(fileDependsArray, cacheDependsArray)
            Cache.Insert("GridViewDataSet", dsGrid, cacheDepends)
            lblMessage.Text = "Data from XML file."
        Else
            lblMessage.Text = "Data from cache."
        End If

        gvwCustomers.DataSource = dsGrid.Tables(0)
        gvwCustomers.DataBind()

    End Sub

    Private Function GetDataSet() As DataSet

        Dim dsData As New DataSet()
        Dim doc As New XmlDataDocument()
        doc.DataSet.ReadXml(Server.MapPath("Customers.xml"))
        dsData = doc.DataSet
        Return dsData

    End Function


    Protected Sub btnClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear.Click

        Cache.Remove("GridViewDataSet")
        CreateGridView()

    End Sub

    Protected Sub btnInit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInit.Click

        ' Initialize caches to depend on. 
        Cache("Depend0") = "This is the first dependency."
        Cache("Depend1") = "This is the 2nd dependency."
        Cache("Depend2") = "This is the 3rd dependency."

    End Sub

    Protected Sub btnChange_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnChange.Click

        Cache("Depend0") = "This is a changed first dependency."

    End Sub

End Class
