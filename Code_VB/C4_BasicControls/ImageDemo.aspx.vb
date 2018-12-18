
Partial Class ImageDemo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Select Case ddlAlign.SelectedIndex
            Case 0
                img1.ImageAlign = ImageAlign.NotSet
                img2.ImageAlign = ImageAlign.NotSet
                Exit Select
            Case 1
                img1.ImageAlign = ImageAlign.AbsBottom
                img2.ImageAlign = ImageAlign.AbsBottom
                Exit Select
            Case 2
                img1.ImageAlign = ImageAlign.AbsMiddle
                img2.ImageAlign = ImageAlign.AbsMiddle
                Exit Select
            Case 3
                img1.ImageAlign = ImageAlign.Top
                img2.ImageAlign = ImageAlign.Top
                Exit Select
            Case 4
                img1.ImageAlign = ImageAlign.Bottom
                img2.ImageAlign = ImageAlign.Bottom
                Exit Select
            Case 5
                img1.ImageAlign = ImageAlign.Baseline
                img2.ImageAlign = ImageAlign.Baseline
                Exit Select
            Case 6
                img1.ImageAlign = ImageAlign.Middle
                img2.ImageAlign = ImageAlign.Middle
                Exit Select
            Case 7
                img1.ImageAlign = ImageAlign.TextTop
                img2.ImageAlign = ImageAlign.TextTop
                Exit Select
            Case 8
                img1.ImageAlign = ImageAlign.Left
                img2.ImageAlign = ImageAlign.Left
                Exit Select
            Case 9
                img1.ImageAlign = ImageAlign.Right
                img2.ImageAlign = ImageAlign.Right
                Exit Select
            Case Else
                img1.ImageAlign = ImageAlign.NotSet
                img2.ImageAlign = ImageAlign.NotSet
                Exit Select
        End Select
    End Sub
End Class
