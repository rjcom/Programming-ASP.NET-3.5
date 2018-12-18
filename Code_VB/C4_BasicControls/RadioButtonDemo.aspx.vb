
Partial Class RadioButtonDemo
    Inherits System.Web.UI.Page



    Protected Sub grpSize_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rdoSize10.CheckedChanged, rdoSize14.CheckedChanged, rdoSize16.CheckedChanged
        Dim rb As RadioButton = DirectCast(sender, RadioButton)

        Select Case rb.ID
            Case "rdoSize10"
                lblTime.Font.Size = 10
                Exit Select
            Case "rdoSize14"
                lblTime.Font.Size = 14
                Exit Select
            Case "rdoSize16"
                lblTime.Font.Size = 16
                Exit Select
        End Select
    End Sub

    Protected Sub lblTime_Init(ByVal sender As Object, ByVal e As EventArgs) Handles lblTime.Init
        lblTime.Font.Name = "Verdana"
        lblTime.Font.Size = 20
        lblTime.Font.Bold = True
        lblTime.Font.Italic = True
        lblTime.Text = DateTime.Now.ToString()
    End Sub
End Class
