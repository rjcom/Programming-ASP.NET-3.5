using System;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerDataList : UserControl
{
   public class ChangedRecordEventArgs : EventArgs
   {
      private string companyName;

      public string CompanyName
      {
         get { return companyName; }
      }

      public ChangedRecordEventArgs(string companyName)
      {
         this.companyName = companyName;
      }
   }

   private int numOfColumns = 3;
   private RepeatDirection direction = RepeatDirection.Horizontal;

   public int NumOfColumns
   {
      get { return numOfColumns; }
      set { numOfColumns = value; }
   }

   public RepeatDirection Direction
   {
      get { return direction; }
      set { direction = value; }
   }

   protected void Page_PreRender(object sender, EventArgs e)
   {
      DataList1.RepeatColumns = NumOfColumns;
      DataList1.RepeatDirection = Direction;
   }

   public delegate void EditRecordHandler(object sender, ChangedRecordEventArgs e);
   public event EditRecordHandler EditRecord;

   public delegate void FinishedEditRecordHandler(object sender, EventArgs e);
   public event FinishedEditRecordHandler FinishedEditRecord;

   protected virtual void OnEditRecord(ChangedRecordEventArgs e)
   {
      if (EditRecord != null)
      {
         EditRecord(this, e);
      }
   }

   protected virtual void OnFinishedEditRecord(EventArgs e)
   {
      if (FinishedEditRecord != null)
      {
         FinishedEditRecord(this, e);
      }
   }


   protected void DataList1_EditCommand(object source, DataListCommandEventArgs e)
   {
      DataList1.SelectedIndex = -1;
      DataList1.EditItemIndex = e.Item.ItemIndex;
      DataBind();

      // Now raise OnEditRecord event
      Label lbl = (Label) e.Item.FindControl("CompanyNameLabel");         
      string companyName = lbl.Text;         
      ChangedRecordEventArgs cre = new ChangedRecordEventArgs(companyName);         
      OnEditRecord(cre);
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
      dsCustomers.UpdateParameters["NameStyle"].DefaultValue = ((CheckBox)e.Item.FindControl("NameStyleTextBox")).Checked.ToString();
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
      DataList1.DataBind();

      OnFinishedEditRecord(new EventArgs());
   }
   protected void DataList1_CancelCommand(object source, DataListCommandEventArgs e)
   {
      DataList1.EditItemIndex = -1;
      DataList1.SelectedIndex = -1;

      DataList1.DataBind();

      OnFinishedEditRecord(new EventArgs());
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

      DataList1.DataBind();
   }
}
