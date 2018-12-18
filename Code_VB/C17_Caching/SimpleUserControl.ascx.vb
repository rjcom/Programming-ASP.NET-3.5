
Partial Class SimpleUserControl
    Inherits System.Web.UI.UserControl

    Public Property UserName() As String
        Get
            Return lblUserName.Text
        End Get
        Set(ByVal value As String)
            lblUserName.Text = value
        End Set
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        lblTime.Text = String.Format("Control time is {0}", DateTime.Now.ToLongTimeString())

    End Sub

    Protected Sub btnChange_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnChange.Click

        lblUserName.Text = "Janey"

    End Sub

End Class
