using System;
using System.Text;
using System.Web.UI;

public partial class DetailsView : Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
       if (IsPostBack)
       {
           StringBuilder info = new StringBuilder();
           info.AppendFormat("You are viewing record {0} of {1}<br />",
              CustomerDetails.DataItemIndex.ToString(), CustomerDetails.DataItemCount.ToString());

           for (int i = 0; i < CustomerDetails.DataKeyNames.Length; i++)
           {
               info.AppendFormat("{0} : {1}<br />", CustomerDetails.DataKeyNames[i], CustomerDetails.DataKey.Values[i]);
           }

           info.AppendFormat("Selected Value : {0}", CustomerDetails.SelectedValue.ToString());

           lblInfo.Text = info.ToString();
       }
   }
}
