
Partial Class StateBagDemo
    Inherits System.Web.UI.Page

    Public Property Counter() As Integer
        Get
            If ViewState("intCounter") IsNot Nothing Then
                Return CInt(ViewState("intCounter"))
            Else
                Return 0
            End If
        End Get
        Set(ByVal value As Integer)
            ViewState("intCounter") = value
        End Set
    End Property


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblCounter.Text = Counter.ToString()
        Counter = Counter + 1
    End Sub
End Class
