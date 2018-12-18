using System;
using System.Collections.Specialized;
using System.Web.Profile;

/// <summary>
/// Summary description for CustomProfile
/// </summary>
public class CustomProfile : ProfileBase
{
   public string lastName
   {
      get { return base["LastName"] as string; }
      set { base["LastName"] = value; }
   }

   public string firstName
   {
      get { return base["FirstName"] as string; }
      set { base["FirstName"] = value; }
   }

   public string phoneNumber
   {
      get { return base["PhoneNumber"] as string; }
      set { base["PhoneNumber"] = value; }
   }

   public DateTime birthDate
   {
      get { return (DateTime)(base["BirthDate"]); }
      set { base["BirthDate"] = value; }
   }

   [SettingsAllowAnonymous(true)]
   public StringCollection favoriteBooks
   {
      get { return base["FavoriteBooks"] as StringCollection; }
      set { base["FavoriteBooks"] = value; }
   }
}
