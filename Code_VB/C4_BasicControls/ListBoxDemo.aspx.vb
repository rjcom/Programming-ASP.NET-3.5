
Partial Class ListBoxDemo
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

            'Now populate the list.       
            For i As Integer = 0 To books.GetLength(0) - 1
                lbxSingle.Items.Add(New ListItem(books(i, 0), books(i, 1)))
                lbxMulti.Items.Add(New ListItem(books(i, 0), books(i, 1)))
            Next
        End If
    End Sub

    Protected Sub lbxSingle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        ' Check to verify that something has been selected.
        If lbxSingle.SelectedIndex > -1 Then
            lblSingle.Text = (lbxSingle.SelectedItem.Text & " ---> ISBN: ") + lbxSingle.SelectedItem.Value
        End If
    End Sub

    Protected Sub lbxMulti_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        If lbxMulti.SelectedItem Is Nothing Then
            lblMulti.Text = "No books selected."
        Else
            Dim sb As New StringBuilder()

            For Each li As ListItem In lbxMulti.Items
                If li.Selected Then
                    sb.AppendFormat("<br/>{0} ---> ISBN: {1}", li.Text, li.Value)
                End If
            Next
            lblMulti.Text = sb.ToString()
        End If
    End Sub
End Class
