using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Text;

public partial class DataListCustomRows : Page
{
   protected void DataList1_EditCommand(object source, DataListCommandEventArgs e)
   {
      DataList1.SelectedIndex = -1;
      DataList1.EditItemIndex = e.Item.ItemIndex;
      DataBind();
   }

   protected void DataList1_DeleteCommand(object source, DataListCommandEventArgs e)
   {
      // (1) Get the recordID from the selected item
      string recordID = (DataList1.DataKeys[e.Item.ItemIndex]).ToString();

      // (2) Get a reference to the customerID parameter
      Parameter param = dsCustomers.DeleteParameters["CustomerID"];

      // (3) Set the parameter's default value to the value for
      // the record to delete
      param.DefaultValue = recordID;

      // (4) Delete the record
      dsCustomers.Delete();

      // (5) Rebind the list
      DataBind();
   }
   protected void DataList1_UpdateCommand(object source, DataListCommandEventArgs e)
   {
      dsCustomers.UpdateParameters["CustomerID"].DefaultValue = (DataList1.DataKeys[e.Item.ItemIndex]).ToString();
      dsCustomers.UpdateParameters["NameStyle"].DefaultValue = ((CheckBox)e.Item.FindControl("NameStyleCheckBox")).Checked.ToString();
      dsCustomers.UpdateParameters["Title"].DefaultValue = ((TextBox)e.Item.FindControl("TitleTextBox")).Text;
      dsCustomers.UpdateParameters["FirstName"].DefaultValue = ((TextBox)e.Item.FindControl("FirstNameTextBox")).Text;
      dsCustomers.UpdateParameters["MiddleName"].DefaultValue = ((TextBox)e.Item.FindControl("MiddleNameTextBox")).Text;
      dsCustomers.UpdateParameters["LastName"].DefaultValue = ((TextBox)e.Item.FindControl("LastNameTextBox")).Text;
      dsCustomers.UpdateParameters["Suffix"].DefaultValue = ((TextBox)e.Item.FindControl("SuffixTextBox")).Text;
      dsCustomers.UpdateParameters["CompanyName"].DefaultValue = ((TextBox)e.Item.FindControl("CompanyNameTextBox")).Text;
      dsCustomers.UpdateParameters["SalesPerson"].DefaultValue = ((TextBox)e.Item.FindControl("SalesPersonTextBox")).Text;
      dsCustomers.UpdateParameters["EmailAddress"].DefaultValue = ((TextBox)e.Item.FindControl("EmailAddressTextBox")).Text;
      dsCustomers.UpdateParameters["Phone"].DefaultValue = ((TextBox)e.Item.FindControl("PhoneTextBox")).Text;

      dsCustomers.Update();

      DataList1.EditItemIndex = -1;
      DataBind();
   }
   protected void DataList1_CancelCommand(object source, DataListCommandEventArgs e)
   {
      DataList1.EditItemIndex = -1;
      DataList1.SelectedIndex = -1;
      lblInfo.Text = "";

      DataList1.DataBind();
   }

   protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
   {
      StringBuilder info = new StringBuilder();
      info.AppendFormat("You are viewing record {0} of {1} <br />",
         DataList1.SelectedIndex.ToString(), DataList1.Items.Count.ToString());
      info.AppendFormat("You are viewing record {0} of {1} <br />",
         DataList1.SelectedIndex.ToString(), DataList1.DataKeys.Count);

      info.Append("Using DataKey<br />");
      info.AppendFormat("{0} : {1}<br />", DataList1.DataKeyField, DataList1.SelectedValue.ToString());

      lblInfo.Text = info.ToString();

      DataList1.DataBind();
   }
}
