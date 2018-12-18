
Partial Class _AtChapterEnd
    Inherits System.Web.UI.Page

    Protected Sub ddlBooks_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlBooks.SelectedIndexChanged

        Try
            Dim a As Int32 = 0
            Dim b As Int32 = 5 / a
        Catch ex As Exception
            Trace.Warn("UserAction", "Calling b=5/a", ex)
        End Try

        If (ddlBooks.SelectedIndex <> -1) Then
            lblBooks.Text = String.Format("{0}, ISBN : {1}", ddlBooks.SelectedItem.Text, ddlBooks.SelectedValue)
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Trace.Write("In Page_Load")

        If (Not IsPostBack) Then

            Trace.Write("Page_Load", "Not Postback")
            'Build 2 dimensional array for the lists       
            'First dimension contains bookname       
            '2nd dimension contains ISBN number  
            Dim bookList(,) As String = { _
                {"9780596513979", "Learning ASP.NET 2.0 with AJAX"}, _
                {"9780596510503", "Building a Web 2.0 Portal with ASP.NET 3.5"}, _
                {"9780596514822", "Head First C#"}, _
                {"9780596514242", "Programming ASP.NET AJAX"}, _
                {"059652756X", "Programming .NET 3.5"}, _
                {"9780596526993", "Programming WCF Services"} _
            }

            For i As Int32 = 0 To bookList.GetLength(0) - 1
                ' Add both text and value
                ddlBooks.Items.Add(New ListItem(bookList(i, 1), bookList(i, 1)))
            Next
        End If

    End Sub
End Class
