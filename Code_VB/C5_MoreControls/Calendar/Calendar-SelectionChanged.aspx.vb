
Partial Class Calendar_Calendar_SelectionChanged
    Inherits System.Web.UI.Page


    Protected Sub Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        lblTodaysDate.Text = "Today's Date is " + Calendar1.TodaysDate.ToShortDateString()
        If Calendar1.SelectedDate <> DateTime.MinValue Then
            lblSelected.Text = "The date selected is " + Calendar1.SelectedDate.ToShortDateString()
        End If
        lblCountUpdate()
    End Sub

    Private Sub lblCountUpdate()
        lblCount.Text = "Count of Days Selected:  " + Calendar1.SelectedDates.Count.ToString()
    End Sub
End Class
