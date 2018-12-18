using System;
using System.Web.UI;

public partial class Calendar_SelectionChanged : Page
{
   protected void Calendar1_SelectionChanged(object sender, EventArgs e)
   {
      lblTodaysDate.Text = "Today's Date is " + Calendar1.TodaysDate.ToShortDateString();
      if (Calendar1.SelectedDate != DateTime.MinValue)
      {
         lblSelected.Text = "The date selected is " + Calendar1.SelectedDate.ToShortDateString();
      }
      lblCountUpdate();
   }

   private void lblCountUpdate() 
   { 
      lblCount.Text = "Count of Days Selected:  " + Calendar1.SelectedDates.Count.ToString(); 
   }

}
