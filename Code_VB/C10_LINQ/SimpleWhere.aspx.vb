
Partial Class SimpleWhere
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim books As IEnumerable(Of Book) = Book.GetBookList()
        Dim stats As IEnumerable(Of BookStats) = BookStats.GetBookStats()

        ' Using the DataSource property
        Dim bookTitles = From b In books _
            Join s In stats On b.ISBN Equals s.ISBN _
            Where s.Sales > 60000 _
            Select New With {.Name = b.Title, .Sales = s.Sales}

        lvwBooks.DataSource = bookTitles
        Me.DataBind()
    End Sub


End Class
