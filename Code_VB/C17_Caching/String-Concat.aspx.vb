
Partial Class String_Concat
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal Source As Object, ByVal E As EventArgs) Handles Me.Load

        Dim intLimit As Integer = 10000
        Dim startTime As DateTime
        Dim endTime As DateTime
        Dim elapsedTime As TimeSpan
        Dim strSub As String
        Dim strWhole As String = ""

        ' Do string concat first 
        startTime = DateTime.Now
        For i As Integer = 0 To intLimit - 1
            strSub = i.ToString()
            strWhole = (strWhole & " ") + strSub
        Next
        endTime = DateTime.Now

        elapsedTime = endTime - startTime
        lblConcat.Text = elapsedTime.ToString()
        'lblConcatString.Text = strWhole; 

        ' Do stringBuilder next 
        startTime = DateTime.Now
        Dim sb As New StringBuilder()
        For i As Integer = 0 To intLimit - 1
            strSub = i.ToString()
            sb.Append(" ")
            sb.Append(strSub)
        Next
        endTime = DateTime.Now
        elapsedTime = endTime - startTime
        lblBuild.Text = elapsedTime.ToString()
        'lblBuildString.Text = sb.ToString(); 

    End Sub

End Class
