
Partial Class SimpleSelect
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim books As List(Of Book) = Book.GetBookList()

        ' Using the DataSource property
        Dim bookTitles = From b In books _
            Select New With {.ISBN = b.ISBN, .Released = (If(b.ReleaseDate < DateTime.Now, "Out now", "Coming soon"))}

        lvwBooks.DataSource = bookTitles
        Me.DataBind()
    End Sub


End Class
