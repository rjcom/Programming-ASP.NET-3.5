using System;

public partial class RadioButtonListDemo : System.Web.UI.Page
{
   protected void lblTime_Init(object sender, EventArgs e)
   {
      lblTime.Font.Name = "Verdana";
      lblTime.Font.Size = 20;
      lblTime.Font.Bold = true;
      lblTime.Font.Italic = true;
      lblTime.Text = DateTime.Now.ToString();
   }


   protected void rblSize_SelectedIndexChanged(object sender, EventArgs e)
   {
      //  Check to verify that something has been selected.    
      if (rblSize.SelectedIndex > -1)
      {
         int size = Convert.ToInt32(rblSize.SelectedItem.Value); 
         lblTime.Font.Size = size;
      }
   }
}
