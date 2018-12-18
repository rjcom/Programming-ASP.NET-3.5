using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

public partial class ObjectCaching : Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
      CreateGridView();
   }

   private void CreateGridView()
   {
      DataSet dsGrid;
      dsGrid = (DataSet)Cache["GridViewDataSet"];
      if (dsGrid == null)
      {
         dsGrid = GetDataSet();
         //Cache["GridViewDataSet"] = dsGrid;
         Cache.Insert("GridViewDataSet", dsGrid);
         lblMessage.Text = "Data from database.";
      }
      else
      {
         lblMessage.Text = "Data from cache.";
      }

      gvwCustomers.DataSource = dsGrid.Tables[0];
      gvwCustomers.DataBind();
   }

   private DataSet GetDataSet()
   {
      // connect to the Northwind database
      string connectionString = ConfigurationManager.
         ConnectionStrings["AWLTConnectionString"].ConnectionString;

      // get records from the Customer table
      string commandString = 
         "SELECT TOP 10 CustomerID, FirstName, LastName, " + 
         "EmailAddress FROM SalesLT.Customer";

      // create the data set command object and the DataSet
      SqlDataAdapter dataAdapter = 
         new SqlDataAdapter(commandString, connectionString);

      DataSet dsData = new DataSet();

      // fill the data set object
      dataAdapter.Fill(dsData, "Customers");

      return dsData;
   }


   protected void btnClear_Click(object sender, EventArgs e)
   {
      Cache.Remove("GridViewDataSet");
      CreateGridView();
   }
}
