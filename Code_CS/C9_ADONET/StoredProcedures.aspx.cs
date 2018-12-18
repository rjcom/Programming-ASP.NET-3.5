using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StoredProcedures : Page
{

   private readonly string connectionString = "Data Source=(local)\\sql2k5;Initial Catalog=AdventureWorksLT;Integrated Security=True";

   protected void Page_Load(object sender, EventArgs e)
   {
      if (!IsPostBack)
      {
         DataSet ds = CreateOrderDataSet();
         OrderGridView.DataSource = ds.Tables["Orders"];
         OrderGridView.DataBind();

         UpdateDetailsGrid();
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

         DataSet ds = CreateOrderDetailsDataSet(orderID);

         OrderDetailsGridView.DataSource = ds;
         OrderDetailsGridView.DataBind();
         OrderDetailsPanel.Visible = true;
      }
      else
      {
         OrderDetailsPanel.Visible = false;
      }
   }

   #region OrderGridView

   private DataSet CreateOrderDataSet()
   {
      // Create a database connection
      SqlConnection connection = new SqlConnection(connectionString);

      // Create a DataAdapter for the SalesOrderHeader GridView
      SqlDataAdapter OrdersAdapter = CreateAdapterForOrders(connection);
      
      // Create the dataset and use the data adapter to fill it     
      DataSet dataSet = new DataSet();

      try
      {
         connection.Open();
         OrdersAdapter.Fill(dataSet);
      }
      finally
      {
         if (connection.State != ConnectionState.Closed)
         {
            connection.Close();
         }
      }
      return dataSet;
   }

   private SqlDataAdapter CreateAdapterForOrders(SqlConnection connection)
   {
      // Set the command to use the spOrders sproc
      SqlCommand cmd = new SqlCommand("spOrders", connection);
      cmd.CommandType = CommandType.StoredProcedure;

      // Set adapter to use sproc as command
      SqlDataAdapter OrdersAdapter = new SqlDataAdapter(cmd);
      OrdersAdapter.TableMappings.Add("Table", "Orders");
      return OrdersAdapter;
   }

   #endregion

   #region OrderDetailsGridView

   private DataSet CreateOrderDetailsDataSet(int orderId)
   {
      // Create a database connection
      SqlConnection connection = new SqlConnection(connectionString);

      // Create a DataAdapter for the SalesOrderHeader GridView
      SqlDataAdapter OrdersAdapter = CreateAdapterForOrderDetails(connection, orderId);

      // Create the dataset and use the data adapter to fill it     
      DataSet dataSet = new DataSet();

      try
      {
         connection.Open();
         OrdersAdapter.Fill(dataSet);
      }
      finally
      {
         if (connection.State != ConnectionState.Closed)
         {
            connection.Close();
         }
      }
      return dataSet;
   }

   private SqlDataAdapter CreateAdapterForOrderDetails(SqlConnection connection, int orderId)
   {
      // Set the command to use the spOrderDetails sproc and parameter
      SqlCommand cmd = new SqlCommand("spOrderDetails", connection);
      cmd.CommandType = CommandType.StoredProcedure;

      SqlParameter orderIdParameter = cmd.Parameters.AddWithValue("@OrderId", orderId);
      orderIdParameter.Direction = ParameterDirection.Input;
      orderIdParameter.DbType = DbType.Int32;

      // Set adapter to use sproc as command
      SqlDataAdapter OrderDetailsAdapter = new SqlDataAdapter(cmd);
      OrderDetailsAdapter.TableMappings.Add("Table", "OrderDetails");
      return OrderDetailsAdapter;
   }

   #endregion
}
