using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

public partial class SimpleDataReader : Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
      // Create the connection string
      string connectionString =
          "Data Source=(local)\\sql2k5;Initial Catalog=AdventureWorksLT;" +
          "Integrated Security=True";

      string commandString = "Select [CustomerId], [FirstName], [LastName], [EmailAddress] from SalesLT.Customer";

      // Create the connection object
      SqlConnection conn = new SqlConnection(connectionString);

      // Create a command object
      SqlCommand command = new SqlCommand(commandString);

      // open the connection
      try
      {
          // open the connection
          conn.Open();

          // attach connection to command object
          command.Connection = conn;

          // get the data reader             
          SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

          // bind to the data reader
          GridView1.DataSource = reader;
          GridView1.DataBind();
      }
      catch (Exception ex)
      {
          lblException.Text = ex.Message;
      }
      finally
      {
         // make sure the connection closes
         if (conn.State != ConnectionState.Closed)
         {
            conn.Close();
         }
      }

   }
}
