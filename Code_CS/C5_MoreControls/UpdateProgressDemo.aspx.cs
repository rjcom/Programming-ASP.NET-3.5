﻿using System;
using System.Web.UI;

public partial class UpdateProgressDemo : Page
{

   protected void Page_Load(object sender, EventArgs e)
   {
      // Get counter1 and increment it
      int counter = Int32.Parse(lblCounter.Text);
      lblCounter.Text = (++counter).ToString();

      // Get counter2 and increment it
      counter = Int32.Parse(lblCounter2.Text);
      lblCounter2.Text = (++counter).ToString();

      // Get counter2 and increment it
      counter = Int32.Parse(lblCounter3.Text);
      lblCounter3.Text = (++counter).ToString();
      
      // Set current date and time
      lblTime.Text = DateTime.Now.ToString();
      lblTime2.Text = DateTime.Now.ToString();
      lblTime3.Text = DateTime.Now.ToString();
   }
   protected void btnAsyncPostback_Click(object sender, EventArgs e)
   {
      System.Threading.Thread.Sleep(5000);
   }
}
