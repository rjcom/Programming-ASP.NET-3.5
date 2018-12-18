using System;

public partial class ASPNETUsingCodeBehind : System.Web.UI.Page
{
    protected void lblTime_Init(object sender, EventArgs e)
    {
       lblTime.Font.Name = "Verdana";
       lblTime.Font.Size = 20;
       lblTime.Font.Underline = true;
       lblTime.Font.Bold = true;
       lblTime.Font.Italic = true;
       lblTime.Font.Overline = true;
       lblTime.Font.Strikeout = true;
       lblTime.Text = DateTime.Now.ToString() +
          ". Font Name: " +
          lblTime.Font.Name;
    }
}
