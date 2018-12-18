using System;
using System.Web.UI;

public partial class SlidersAndRatingsDemo : Page
{
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       lblChoices.Text = String.Format("Pavarotti gets {0}/{1} stars at {2} decibels", 
          Rating1.CurrentRating.ToString(), 
          Rating1.MaxRating.ToString(),
          txtHiddenSlider.Text); 
    }
}
