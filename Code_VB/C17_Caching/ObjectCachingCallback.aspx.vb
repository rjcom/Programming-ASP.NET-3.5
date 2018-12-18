Imports System.Data
Imports System.Xml
Imports System.IO

Partial Class ObjectCachingCallback
    Inherits System.Web.UI.Page

    Public Shared onRemove As CacheItemRemovedCallback = Nothing

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        CreateGridView()

    End Sub



    Private Sub CreateGridView()

        Dim dsGrid As DataSet
        dsGrid = DirectCast(Cache("GridViewDataSet"), DataSet)

        onRemove = New CacheItemRemovedCallback(AddressOf Me.RemovedCallback)

        If dsGrid Is Nothing Then
            dsGrid = GetDataSet()
            Dim fileDependsArray As String() = {Server.MapPath("Customers.xml")}
            Dim cacheDependsArray As String() = {"Depend0", "Depend1", "Depend2"}
            Dim cacheDepends As New CacheDependency(fileDependsArray, cacheDependsArray)
            Cache.Insert("GridViewDataSet", dsGrid, cacheDepends, DateTime.Now.AddSeconds(10), Cache.NoSlidingExpiration, CacheItemPriority.[Default], _
            onRemove)
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

    Public Sub RemovedCallback(ByVal cacheKey As String, ByVal cacheObject As Object, ByVal reasonToRemove As CacheItemRemovedReason)

        WriteFile("Cache removed for following reason: " & reasonToRemove.ToString())

    End Sub

    Private Sub WriteFile(ByVal strText As String)

        Dim writer As New StreamWriter("~" & vbTab & "est.txt", True)
        writer.WriteLine(String.Format("{0} {1}", DateTime.Now.ToString(), strText))
        writer.Close()

    End Sub

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
