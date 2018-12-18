using System;
using System.Web.UI;

public partial class UserControlEvents : Page
{
   protected void Page_Load(object sender, EventArgs e)
   { 
      CustomerDL1.EditRecord += 
         new CustomerDataList.EditRecordHandler(CustomerDL1_EditRecord);
      CustomerDL1.FinishedEditRecord +=
         new CustomerDataList.FinishedEditRecordHandler(CustomerDL1_FinishedEditRecord);
   }

   protected void Button1_Click(object sender, EventArgs e)
   {
      Label1.Text = "Changed!";
   }

   protected void CustomerDL1_EditRecord(
       object sender, CustomerDataList.ChangedRecordEventArgs e)
   {
      lblDisplayCompany.Text = "Editing " + e.CompanyName;
   }

   protected void CustomerDL1_FinishedEditRecord(object sender, EventArgs e)
   {
      lblDisplayCompany.Text = String.Empty;
   }

}
