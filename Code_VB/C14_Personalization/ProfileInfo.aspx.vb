
Partial Class ProfileInfo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            If Profile.IsAnonymous = True Then
                pnlNonAnonymousInfo.Visible = False
            Else
                txtLastName.Text = Profile.lastName
                txtFirstName.Text = Profile.firstName
                txtPhone.Text = Profile.phoneNumber
                txtBirthDate.Text = Profile.birthDate.ToShortDateString()
            End If

            If Profile.favoriteBooks IsNot Nothing Then
                For Each bookName As String In Profile.favoriteBooks
                    cblFavoriteBooks.Items.FindByText(bookName).Selected = True
                Next
            End If
        End If

    End Sub

    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs)

        If Profile.IsAnonymous = False Then
            Profile.lastName = txtLastName.Text
            Profile.firstName = txtFirstName.Text
            Profile.phoneNumber = txtPhone.Text
            Dim birthDate As DateTime = DateTime.Parse(txtBirthDate.Text)
            Profile.birthDate = birthDate
        End If

        Profile.favoriteBooks = New StringCollection()
        For Each li As ListItem In cblFavoriteBooks.Items
            If li.Selected Then
                Profile.favoriteBooks.Add(li.Value.ToString())
            End If
        Next

        Response.Redirect("Welcome.aspx")

    End Sub

    Protected Sub Set_Theme(ByVal sender As Object, ByVal e As EventArgs)

        Dim btn As Button = DirectCast(sender, Button)
        If btn.Text = "Psychedelic" Then
            Profile.Theme = "Psychedelic"
        Else
            Profile.Theme = "DarkBlue"
        End If

    End Sub

End Class
