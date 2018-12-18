
Partial Class RadioButtonListDemo
    Inherits System.Web.UI.Page

    Protected Sub lblTime_Init(ByVal sender As Object, ByVal e As EventArgs) Handles lblTime.Init
        lblTime.Font.Name = "Verdana"
        lblTime.Font.Size = 20
        lblTime.Font.Bold = True
        lblTime.Font.Italic = True
        lblTime.Text = DateTime.Now.ToString()
    End Sub


    Protected Sub rblSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rblSize.SelectedIndexChanged
        '  Check to verify that something has been selected.    
        If (rblSize.SelectedIndex > -1) Then
            Dim size As Integer = CType(rblSize.SelectedItem.Value, Int32)
            lblTime.Font.Size = size
        End If

    End Sub
End Class
