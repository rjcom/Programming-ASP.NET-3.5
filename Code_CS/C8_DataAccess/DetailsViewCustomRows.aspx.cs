using System;
using System.Security.Cryptography;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DetailsViewCustomRows : Page
{
   protected void dvwCustomers_ModeChanged(object sender, EventArgs e)
   {
      bool readOnly = (dvwCustomers.CurrentMode == DetailsViewMode.ReadOnly);

      dvwCustomers.Fields[1].Visible = readOnly;   //FullName
      dvwCustomers.Fields[2].Visible = !readOnly;  //NameStyle
      dvwCustomers.Fields[3].Visible = !readOnly;  //Title
      dvwCustomers.Fields[4].Visible = !readOnly;  //FirstName
      dvwCustomers.Fields[5].Visible = !readOnly;  //MiddleName
      dvwCustomers.Fields[6].Visible = !readOnly;  //LastName
      dvwCustomers.Fields[7].Visible = !readOnly;  //Suffix
      dvwCustomers.Fields[12].Visible = readOnly;  //ModifiedDate
      dvwCustomers.Fields[13].Visible = readOnly;  //PasswordHash
      dvwCustomers.Fields[14].Visible = readOnly;  //PasswordSalt

      //Password field can only be viewed when adding a new record, so a little different logic
      if (dvwCustomers.CurrentMode == DetailsViewMode.Insert)
      {
         dvwCustomers.Fields[15].Visible = true;
      }
      else
      {
         dvwCustomers.Fields[15].Visible = false;
      }

   }

   // before item is inserted, password hash and salt must be generated
   protected void dvwCustomers_ItemInserting(object sender, DetailsViewInsertEventArgs e)
   {
      string password = ((TextBox)dvwCustomers.FindControl("txtPasswordInsert")).Text;
      string salt = GetSalt();
      string hash = GetHashFromPlainTextAndSalt(password, salt);
      e.Values["PasswordHash"] = hash;
      e.Values["PasswordSalt"] = salt;
   }

   private string GetHashFromPlainTextAndSalt(string password, string salt)
   {
      SHA1CryptoServiceProvider hasher = new SHA1CryptoServiceProvider();
      byte[] clearBytes = Encoding.UTF8.GetBytes(salt + password);
      byte[] hashedBytes = hasher.ComputeHash(clearBytes);
      return Convert.ToBase64String(hashedBytes);
   }

   private string GetSalt()
   {
      byte[] buffer = new byte[5];
      RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
      rng.GetBytes(buffer);
      return Convert.ToBase64String(buffer);
   }


}
