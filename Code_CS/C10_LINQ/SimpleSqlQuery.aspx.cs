using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

public partial class SimpleSqlQuery : Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
      using (AwltCustomersDataContext db = new AwltCustomersDataContext())
      {
         var firstFiveCustomers =
            from customer in db.Customers.Take(5)
            select customer;

         foreach (var customer in firstFiveCustomers)
         {
            lblCustomers.Text += String.Format("<p>{0} {1}</p>", customer.FirstName, customer.LastName);
         }
      }
   }
}
