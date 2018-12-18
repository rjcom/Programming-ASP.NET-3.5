
Partial Class SimpleQuery2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim books As List(Of Book) = Book.GetBookList()

        ' Using the DataSource property
        Dim bookTitles = From b In books _
            Select New With {.Title = b.Title}

        lvwBooks.DataSource = bookTitles
        Me.DataBind()
    End Sub

End Class
