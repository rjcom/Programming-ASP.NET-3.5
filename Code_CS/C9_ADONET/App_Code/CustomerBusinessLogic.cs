using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Stateless business logic that encapsulates what 
/// can be done with a Customer object
/// All methods are static
/// </summary>
public static class CustomerBusinessLogic
{
   public static void UpdateCustomerInformation(AdvWorksCustomer customer)
   {
      bool returnValue = customer.Save();
      if (returnValue == false)
      {
         throw new ApplicationException("Unable to update customer");
      }
   }

   public static AdvWorksCustomer GetCustomer(string custID)
   {
      return new AdvWorksCustomer(custID);
   }

   public static ICollection GetAllCustomers()
   {
      ArrayList allCustomers = new ArrayList();
      String cmdAllCustomersString = "Select CustomerID from SalesLT.Customer";
      String connString =
       "Data Source=(local)\\sql2k5;Initial Catalog=AdventureWorksLT;Integrated Security=True";
      SqlDataSource dataSource = new SqlDataSource(connString, cmdAllCustomersString);

      try
      {
         // select with no arguments
         IEnumerable CustomerIDs = dataSource.Select(DataSourceSelectArguments.Empty);

         IEnumerator enumerator = CustomerIDs.GetEnumerator();
         while (enumerator.MoveNext())
         {
            DataRowView drv = enumerator.Current as DataRowView;
            if (drv != null)
            {
               string customerID = drv["CustomerID"].ToString();
               AdvWorksCustomer cust = new AdvWorksCustomer(customerID);
               allCustomers.Add(cust);
            }
         }
      }
      finally
      {
         dataSource.Dispose();
      }
      return allCustomers;
   }
}


public class AdvWorksCustomer
{
   private object customerID;
   public string FirstName { get; set; }
   public string MiddleName { get; set; }
   public string LastName { get; set; }
   public string Suffix { get; set; }
   public string CompanyName { get; set; }
   public string SalesPerson { get; set; }
   public string EmailAddress { get; set; }
   public string Phone { get; set; }
   public DateTime ModifiedDate { get; set; }
   public string PasswordHash { get; set; }
   public string PasswordSalt { get; set; }

   public bool Save()
   {
      return true;
   }

   // default constructor
   public AdvWorksCustomer()
   {
      customerID = DBNull.Value;
      FirstName = String.Empty;
      MiddleName = String.Empty;
      LastName = String.Empty;
      Suffix = String.Empty;
      CompanyName = String.Empty;
      SalesPerson = String.Empty;
      EmailAddress = String.Empty;
      Phone = String.Empty;
      PasswordHash = String.Empty;
      PasswordSalt = String.Empty;
      ModifiedDate = DateTime.MinValue;
   }

   // Business object representing a Customer from the AdventureWorksLT database
   public AdvWorksCustomer(string customerID)
   {
      String connString =
         "Data Source=(local)\\sql2k5;Initial Catalog=AdventureWorksLT;Integrated Security=True";

      StringBuilder cmdString = new StringBuilder("Select FirstName, MiddleName, LastName, Suffix, ");
      cmdString.Append("CompanyName, SalesPerson, EmailAddress, Phone, ");
      cmdString.Append("PasswordHash, PasswordSalt, ModifiedDate ");
      cmdString.Append("from SalesLT.Customer ");
      cmdString.Append("where CustomerID = @customerID");

      // Create connection and command objects 
      SqlConnection conn = new SqlConnection(connString);
      SqlCommand cmd = new SqlCommand(cmdString.ToString(), conn);
      cmd.Parameters.Add("@customerID", SqlDbType.VarChar).Value = customerID;

      try
      {
         conn.Open();
         SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
         if (dr != null && dr.Read())
         {
            FirstName = dr["FirstName"].ToString();
            MiddleName = dr["MiddleName"].ToString();
            LastName = dr["LastName"].ToString();
            Suffix = dr["Suffix"].ToString();
            CompanyName = dr["CompanyName"].ToString();
            SalesPerson = dr["SalesPerson"].ToString();
            EmailAddress = dr["EmailAddress"].ToString();
            Phone = dr["Phone"].ToString();
            PasswordHash = dr["PasswordHash"].ToString();
            PasswordSalt = dr["PasswordSalt"].ToString();
            ModifiedDate = Convert.ToDateTime(dr["ModifiedDate"]);
         }
         else
         {
            throw new ApplicationException(
              "Data not found for customer ID " + customerID);
         }
         dr.Close();
      }
      finally
      {
         if (conn.State != ConnectionState.Closed)
         {
            conn.Close();
         }
      }
   }
}