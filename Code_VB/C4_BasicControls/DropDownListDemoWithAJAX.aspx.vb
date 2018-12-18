
Partial Class DropDownListDemoWithAJAX
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not IsPostBack) Then

            'Build 2 dimensional array for the lists       
            'First dimension contains bookname       
            '2nd dimension contains ISBN number  
            Dim books(,) As String = { _
            {"Learning ASP.NET 2.0 with AJAX", "9780596513976"}, _
            {"Beginning ASP.NET 2.0 with C#", "9780470042583"}, _
            {"Programming C#", "9780596527433"}, _
            {"Programming .NET 3.5", "978059652756X"}, _
            {"Programming .NET Windows Applications", "0596003218"}, _
            {"Programming ASP.NET 3e", "0596001711"}, _
            {"WebClasses From Scratch", "0789721260"}, _
            {"Teach Yourself C++ in 21 Days", "067232072X"}, _
            {"Teach Yourself C++ in 10 Minutes", "067231603X"}, _
            {"XML & Java From Scratch", "0789724766"}, _
            {"XML Web Documents From Scratch", "0789723166"}, _
            {"Clouds To Code", "1861000952"}, _
            {"C++ Unleashed", "0672312395"} _
            }


            For i As Int32 = 0 To books.GetLength(0) - 1
                ' Add both text and value
                ddlBooks.Items.Add(New ListItem(books(i, 0), "http://www.amazon.com/gp/product/" + books(i, 1)))
            Next
        End If
    End Sub

    Protected Sub ddlBooks_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlBooks.SelectedIndexChanged
        If (ddlBooks.SelectedIndex <> -1) Then
            lblBookInfo.Text = ddlBooks.SelectedItem.Text + " --->ISBN: " + ddlBooks.SelectedValue
        End If

    End Sub

End Class
