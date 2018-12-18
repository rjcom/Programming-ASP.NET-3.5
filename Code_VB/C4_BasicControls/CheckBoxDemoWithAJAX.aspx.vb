
Partial Class CheckBoxDemoWithAJAX
    Inherits System.Web.UI.Page

    Protected Sub lblTime_Init(ByVal sender As Object, ByVal e As EventArgs)
        lblTime.Font.Name = "Verdana"
        lblTime.Font.Size = 20
        lblTime.Font.Bold = True
        lblTime.Font.Italic = True
        lblTime.Text = DateTime.Now.ToString()
    End Sub
    Protected Sub chkUnderline_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        lblTime.Font.Underline = chkUnderline.Checked
    End Sub

    Protected Sub chkOverline_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        lblTime.Font.Overline = chkOverline.Checked
    End Sub

    Protected Sub chkStrikeout_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        lblTime.Font.Strikeout = chkStrikeout.Checked
    End Sub

End Class
