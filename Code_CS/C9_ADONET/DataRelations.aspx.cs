using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataRelations : Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
      if (!IsPostBack)
      {
         UpdateDetailsGrid();

         DataSet ds = CreateDataSet();
         OrderGridView.DataSource = ds.Tables["Orders"];
         OrderGridView.DataBind();

         // create the dataview and bind to the details grid
         DataView detailsView = new DataView(ds.Tables["Details"]);
         OrderDetailsGridView.DataSource = detailsView;
         Session["DetailsView"] = detailsView;
         OrderDetailsGridView.DataBind();

         // bind the relations grid to the relations collection
         OrderRelationsGridView.DataSource = ds.Relations;
         OrderRelationsGridView.DataBind();
      }
   }

   protected void OrderGridView_SelectedIndexChanged(object sender, EventArgs e)
   {
      UpdateDetailsGrid();
   }

   private void UpdateDetailsGrid()
   {

      int index = OrderGridView.SelectedIndex;
      if (index != -1)
      {
         // get the order id from the data grid
         DataKey key = OrderGridView.DataKeys[index];
         int orderID = (int)key.Value;
         DataView detailsView = (DataView)Session["detailsView"];
         detailsView.RowFilter = "SalesOrderID = " + orderID;
         OrderDetailsGridView.DataSource = detailsView;
         OrderDetailsGridView.DataBind();
         OrderDetailsPanel.Visible = true;
      }
      else
      {
         OrderDetailsPanel.Visible = false;
      }
   }

   private DataSet CreateDataSet()
   {
      // Create connection string and Connection object
      string connectionString =
         "Data Source=(local)\\sql2k5;Initial Catalog=AdventureWorksLT;" +
          "Integrated Security=True";
      SqlConnection connection = new SqlConnection(connectionString);

      // Create a DataAdapter for the SalesOrderHeader GridView
      SqlDataAdapter OrdersAdapter = CreateAdapterForOrders(connection);

      // Create a 2nd DataAdapter for the SalesOrderDetail GridView
      SqlDataAdapter OrderDetailsAdapter = CreateAdapterForOrderDetails(connection);     

      // Create a 3rd DataAdapter for the Products table
      SqlDataAdapter ProductsAdapter = CreateAdapterForProducts(connection);
      
      // Create the dataset and use the data adapter to fill it     
      DataSet dataSet = new DataSet();


      try
      {
         //connection.Open();
         OrdersAdapter.Fill(dataSet);
         OrderDetailsAdapter.Fill(dataSet);
         ProductsAdapter.Fill(dataSet);
      }
      finally
      {
         if (connection.State != ConnectionState.Closed)
         {
            connection.Close();
         }
      }

      CreateRelationsInDataSet(dataSet);

      return dataSet;
   }



   private static SqlDataAdapter CreateAdapterForOrders(SqlConnection connection)
   {
      //Build the SQL command
      StringBuilder s = new StringBuilder("select o.SalesOrderID, o.OrderDate, c.CompanyName, c.FirstName + ' ' + c.LastName as 'Contact', o.TotalDue");
      s.Append(" from SalesLT.SalesOrderHeader o ");
      s.Append("inner join SalesLT.Customer c on c.CustomerID = o.CustomerID");

      SqlDataAdapter OrdersAdapter = new SqlDataAdapter();
      OrdersAdapter.SelectCommand = new SqlCommand(s.ToString(), connection);
      OrdersAdapter.TableMappings.Add("Table", "Orders");
      return OrdersAdapter;
   }     

   private static SqlDataAdapter CreateAdapterForOrderDetails(SqlConnection connection)
   {
      // Build the SQL command
      StringBuilder s = new StringBuilder("Select d.SalesOrderId, p.Name, p.ProductID, d.OrderQty, d.UnitPrice, d.LineTotal ");
      s.Append("from SalesLT.SalesOrderDetail d ");
      s.Append("inner join SalesLT.Product p on d.productid = p.productid");

      SqlDataAdapter OrderDetailsAdapter = new SqlDataAdapter();
      OrderDetailsAdapter.SelectCommand = new SqlCommand(s.ToString(), connection);
      OrderDetailsAdapter.TableMappings.Add("Table", "Details");
      return OrderDetailsAdapter;
   }

   private static SqlDataAdapter CreateAdapterForProducts(SqlConnection connection)
   {
      string cmdString = "Select ProductID, Name from SalesLT.Product";

      SqlDataAdapter ProductsAdapter = new SqlDataAdapter();
      ProductsAdapter.SelectCommand = new SqlCommand(cmdString, connection);
      ProductsAdapter.TableMappings.Add("Table", "Products");
      return ProductsAdapter;
   }

   private static void CreateRelationsInDataSet(DataSet dataSet)
   {
      // declare the DataRelation and DataColumn objects     
      DataRelation dataRelation;
      DataColumn dataColumn1;
      DataColumn dataColumn2;
      // set the dataColumns to create the relationship      
      // between Bug and Order Details on the OrderID key      
      dataColumn1 = dataSet.Tables["Orders"].Columns["SalesOrderID"];
      dataColumn2 = dataSet.Tables["Details"].Columns["SalesOrderID"];
      dataRelation = new DataRelation("OrdersToDetails", dataColumn1, dataColumn2);
      // add the new DataRelation to the dataset     
      dataSet.Relations.Add(dataRelation);

      // reuse the DataColumns and DataRelation objects      
      // to create the relation between Order Details and Products        
      dataColumn1 = dataSet.Tables["Products"].Columns["ProductID"];
      dataColumn2 = dataSet.Tables["Details"].Columns["ProductID"];
      dataRelation = new DataRelation("ProductIDToName", dataColumn1, dataColumn2);
      dataSet.Relations.Add(dataRelation);
      return;
   }
}
