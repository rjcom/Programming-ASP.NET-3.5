using System;
using System.Text;
using System.Web.UI;

public partial class GridView : Page
{
    protected void gvwCustomers_SelectedIndexChanged(object sender, EventArgs e)
    {
       StringBuilder info = new StringBuilder();
       info.AppendFormat("You are viewing record {0} of {1} (SelectedIndex)<br />",
          gvwCustomers.SelectedIndex.ToString(), gvwCustomers.Rows.Count.ToString());
       info.AppendFormat("You are viewing record {0} of {1} (DataKeys)<br />",
          gvwCustomers.SelectedIndex.ToString(), gvwCustomers.DataKeys.Count);
       info.AppendFormat("You are viewing page {0} of {1} (PageCount)<br />",
          gvwCustomers.PageIndex.ToString(), gvwCustomers.PageCount.ToString());

       info.AppendFormat("<p>Using SelectedRow, Email Address= {0}<br />", gvwCustomers.SelectedRow.Cells[4].Text);

       info.Append("Using SelectedDataKey<br />");

       for (int i = 0; i < gvwCustomers.DataKeyNames.Length; i++)
       {
          info.AppendFormat("{0} : {1}<br />", gvwCustomers.DataKeyNames[i], gvwCustomers.SelectedDataKey.Values[i]);
       }

       info.AppendFormat("Selected Value : {0}", gvwCustomers.SelectedValue.ToString());

       lblInfo.Text = info.ToString();
    }
}
