
Partial Class Welcome
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Profile.UserName IsNot Nothing AndAlso Profile.IsAnonymous = False Then
            pnlInfo.Visible = True
            lblFullName.Text = (Profile.firstName & " ") + Profile.lastName
            lblPhone.Text = Profile.phoneNumber
            lblBirthDate.Text = Profile.birthDate.ToShortDateString()

            lbBooks.Items.Clear()
        Else
            pnlInfo.Visible = False
        End If

        If Profile.favoriteBooks IsNot Nothing Then
            For Each bookName As String In Profile.favoriteBooks
                lbBooks.Items.Add(bookName)
            Next
        End If

    End Sub


    Public Overloads Overrides Property StyleSheetTheme() As String
        Get
            If (Not Profile.IsAnonymous) AndAlso Profile.Theme IsNot Nothing Then
                Return Profile.Theme
            Else
                Return "DarkBlue"
            End If
        End Get
        Set(ByVal value As String)
            Profile.Theme = value
        End Set
    End Property

    Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)

        If Not Profile.IsAnonymous Then
            Page.Theme = Profile.Theme
        End If

    End Sub

End Class
