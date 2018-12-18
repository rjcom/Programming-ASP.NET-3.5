
Partial Class TabDemo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Generate label controls
        Dim numlabels As Integer = Int32.Parse(ddlLabels.SelectedItem.Value)
        For i As Integer = 1 To numlabels
            Dim lbl As New Label()
            lbl.Text = "Label" & (i).ToString()
            lbl.ID = "Label" & (i).ToString()
            pnlDynamic.Controls.Add(lbl)
            pnlDynamic.Controls.Add(New LiteralControl("<br />"))
        Next

        ' Generate textbox controls
        Dim numBoxes As Integer = Int32.Parse(ddlBoxes.SelectedItem.Value)
        For i As Integer = 1 To numBoxes
            Dim txt As New TextBox()
            txt.Text = "TextBox" & (i).ToString()
            txt.ID = "TextBox" & (i).ToString()
            pnlDynamic.Controls.Add(txt)
            pnlDynamic.Controls.Add(New LiteralControl("<br />"))
        Next
    End Sub
End Class
