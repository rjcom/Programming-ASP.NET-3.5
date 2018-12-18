
Partial Class ASPNETUsingCodeBehind
    Inherits System.Web.UI.Page

    Protected Sub lblTime_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTime.Init
        lblTime.Font.Name = "Verdana"
        lblTime.Font.Size = 20
        lblTime.Font.Underline = True
        lblTime.Font.Bold = True
        lblTime.Font.Italic = True
        lblTime.Font.Overline = True
        lblTime.Font.Strikeout = True
        lblTime.Text = DateTime.Now.ToString() + ". Font Name: " + lblTime.Font.Name
    End Sub
End Class
