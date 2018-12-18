
Partial Class SimpleWhere2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim books As IEnumerable(Of Book) = Book.GetBookList()
        Dim stats As IEnumerable(Of BookStats) = BookStats.GetBookStats()

        ' Using the DataSource property
        Dim bookTitles = From b In books _
            Join s In stats On b.ISBN Equals s.ISBN _
            Where b.ReleaseDate > DateTime.Now _
            Where s.Pages > 700 _
            Select New With {.Name = b.Title, .ReleaseDate = b.ReleaseDate, .Pages = s.Pages}

        lvwBooks.DataSource = bookTitles
        Me.DataBind()
    End Sub


End Class
