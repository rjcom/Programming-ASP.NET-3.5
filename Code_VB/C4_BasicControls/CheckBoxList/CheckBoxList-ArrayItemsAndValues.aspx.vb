
Partial Class CheckBoxList_CheckBoxList_ArrayItemsAndValues
    Inherits System.Web.UI.Page

    Protected Sub cblItems_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles cblItems.Init
        'create an array of items to add
        Dim Genres() As String = {"SciFi", "Novels", "Computers", "History", "Religion"}
        Dim Code() As String = {"sf", "nvl", "cmp", "his", "rel"}

        For i As Integer = 0 To Genres.Length - 1
            cblItems.Items.Add(New ListItem(Genres(i), Code(i)))
        Next

    End Sub
End Class
