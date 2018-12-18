
Partial Class UpdatePanelDemoPart2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Get counter1 and increment it
        Dim counter As Integer = Int32.Parse(lblCounter.Text)
        counter += 1
        lblCounter.Text = counter.ToString()

        ' Get counter2 and increment it
        counter = Int32.Parse(lblCounter2.Text)
        counter += 1
        lblCounter2.Text = counter.ToString()

        ' Get counter3 and increment it
        counter = Int32.Parse(lblCounter3.Text)
        counter += 1
        lblCounter3.Text = counter.ToString()

        ' Set current date and time
        lblTime.Text = DateTime.Now.ToString()
        lblTime2.Text = DateTime.Now.ToString()
        lblTime3.Text = DateTime.Now.ToString()
    End Sub
End Class
