using System;
using System.Security.Cryptography;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DetailsViewCustomRows : Page
{
   // before item is inserted, password hash and salt must be generated
   protected void fvwCustomers_ItemInserting(object sender, FormViewInsertEventArgs e)
   {
      string password = ((TextBox)fvwCustomers.FindControl("PasswordTextBox")).Text;
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
