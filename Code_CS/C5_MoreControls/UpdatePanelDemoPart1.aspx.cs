using System;
using System.Web.UI;

public partial class UpdatePanelDemoPart1 : Page
{

   protected void Page_Load(object sender, EventArgs e)
   {
      // Get counter1 and increment it
      int counter = Int32.Parse(lblCounter.Text);
      lblCounter.Text = (++counter).ToString();

      // Get counter2 and increment it
      counter = Int32.Parse(lblCounter2.Text);
      lblCounter2.Text = (++counter).ToString();
      
      // Set current date and time
      lblTime.Text = DateTime.Now.ToString();
      lblTime2.Text = DateTime.Now.ToString();
   }
}
