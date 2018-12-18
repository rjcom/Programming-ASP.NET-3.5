
Partial Class SimpleGroupBy
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim books As IEnumerable(Of Book) = Book.GetBookList()
        Dim stats As IEnumerable(Of BookStats) = BookStats.GetBookStats()

        ' Using the DataSource property
        Dim bookTitles = From b In books _
            Join s In stats On b.ISBN Equals s.ISBN _
            Let outYet = (If(b.ReleaseDate < DateTime.Now, "Out now", "Coming Soon")) _
            Order By s.Rank _
            Group New With {.Title = b.Title, .Price = b.Price, .Pages = s.Pages} By key = outYet _
                Into Values = Group _
                Select New With {.Status = key, .Values = Values}

        For Each group In bookTitles
            lblBooks.Text += String.Format("<h2>{0}</h2>", group.Status)
            For Each book In group.Values
                lblBooks.Text += String.Format("<p>{0}, {1:c} : {2} pages</p>", book.Title, book.Price, book.Pages)
            Next
        Next
    End Sub


End Class
