Imports System.Data
Imports System.Xml

Partial Class ObjectCachingFileDependency
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        CreateGridView()

    End Sub

    Private Sub CreateGridView()

        Dim dsGrid As DataSet
        dsGrid = DirectCast(Cache("GridViewDataSet"), DataSet)
        If dsGrid Is Nothing Then
            dsGrid = GetDataSet()
            Dim fileDepends As New CacheDependency(Server.MapPath("Customers.xml"))
            Cache.Insert("GridViewDataSet", dsGrid, fileDepends)
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

End Class
