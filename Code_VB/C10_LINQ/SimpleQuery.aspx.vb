
Partial Class SimpleQuery
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim books As List(Of Book) = Book.GetBookList()

        ' Using inline binding
        Dim bookTitles = From b In books _
            Select b.Title

        For Each bookTitle In bookTitles
            lblBooks.Text += String.Format("{0}<br />", bookTitle)
        Next
    End Sub


End Class
