
Partial Class CheckBoxList_CheckBoxList_ArrayItemsDataBind
    Inherits System.Web.UI.Page

    Protected Sub cblItems_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles cblItems.Init
        'create an array of items to add
        Dim Genres() As String = {"SciFi", "Novels", "Computers", "History", "Religion"}
        cblItems.DataSource = Genres
        cblItems.DataBind()
    End Sub
End Class
