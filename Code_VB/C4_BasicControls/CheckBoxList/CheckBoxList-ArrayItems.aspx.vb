
Partial Class CheckBoxList_CheckBoxList_ArrayItems
    Inherits System.Web.UI.Page

    Protected Sub cblItems_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles cblItems.Init
        'create an array of items to add
        Dim Genres() As String = {"SciFi", "Novels", "Computers", "History", "Religion"}
        For Each genre As String In Genres
            cblItems.Items.Add(New ListItem(genre))
        Next
    End Sub
End Class
