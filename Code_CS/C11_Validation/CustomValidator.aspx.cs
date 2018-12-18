using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomValidator : Page
{
   protected void cvalEvenNumber_ServerValidate(
      object source, ServerValidateEventArgs args)
   {
      args.IsValid = false;
      int evenNumber = Int32.Parse(args.Value);
      if (evenNumber % 2 == 0)
      {
         args.IsValid = true;
      }
   }
}
