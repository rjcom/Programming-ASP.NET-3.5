
Partial Class ApplicationStateDemo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim sb As New StringBuilder()
        sb.AppendFormat("{0}<br />", DirectCast(Application("strStartMsg"), String))
        sb.AppendFormat("{0}<br />", DirectCast(Application("strEndMsg"), String))

        Dim arTest As String() = DirectCast(Application("arBooks"), String())
        sb.AppendFormat("{0}<br />", arTest(1).ToString())

        lblText.Text = sb.ToString()
    End Sub
End Class
