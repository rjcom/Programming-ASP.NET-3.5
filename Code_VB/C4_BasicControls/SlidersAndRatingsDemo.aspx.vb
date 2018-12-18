
Partial Class SlidersAndRatingsDemo
    Inherits System.Web.UI.Page

    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        lblChoices.Text = String.Format("Pavarotti gets {0}/{1} stars at {2} decibels", _
           Rating1.CurrentRating.ToString(), _
           Rating1.MaxRating.ToString(), _
           txtHiddenSlider.Text)
    End Sub
End Class
