using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Transactions : Page
{
   private readonly string connectionString = "Data Source=(local)\\sql2k5;Initial Catalog=AdventureWorksLT;Integrated Security=True";

   protected void Page_Load(object sender, EventArgs e)
   {
      if (!IsPostBack)
      {
         SqlConnection conn = new SqlConnection(connectionString);

         try
         {
            conn.Open();
            BindOrdersGridView(conn);
            BindCustomerList(conn);
            BindProductList(conn);
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

   private void BindProductList(SqlConnection conn)
   {
      SqlDataReader productReader = GetDataReader(conn, "Product");
      ddlProduct.DataSource = productReader;
      ddlProduct.DataBind();
      productReader.Close();
   }

   private void BindCustomerList(SqlConnection conn)
   {
      SqlDataReader companyReader = GetDataReader(conn, "Customer");
      ddlCompany.DataSource = companyReader;
      ddlCompany.DataBind();
      companyReader.Close();
   }

   private void BindOrdersGridView(SqlConnection conn)
   {
      SqlDataReader orderReader = GetDataReader(conn, "Orders");
      OrdersGridView.DataSource = orderReader;
      OrdersGridView.DataBind();

      //Close DataReader but keep connection open
      orderReader.Close();
   }

   private SqlDataReader GetDataReader(SqlConnection conn, string infoRequired)
   {
      StringBuilder cmdString = new StringBuilder();

      switch (infoRequired)
      {
         case "Orders":
            cmdString.Append("select o.salesorderid, o.orderdate, c.FirstName + ' ' + c.LastName as 'ContactName', ");
            cmdString.Append("c.companyname, c.phone, o.PurchaseOrderNumber ");
            cmdString.Append("from SalesLT.SalesOrderHeader o ");
            cmdString.Append("inner join SalesLT.Customer c on o.CustomerId = c.CustomerId ");
            cmdString.Append("order by o.salesorderid");
            break;
         case "OrderDetails":
            int index = OrdersGridView.SelectedIndex;
            int orderId = -1;

            if (index != -1)
            {
               //get the orderId from the GridView
               DataKey key = OrdersGridView.DataKeys[index];
               orderId = (int)key.Value;
            }

            cmdString.Append("select d.UnitPrice, d.OrderQty, p.Name as 'ProductName' ");
            cmdString.Append("from SalesLT.SalesOrderDetail d ");
            cmdString.Append("inner join SalesLT.Product p on d.ProductId = p.ProductId ");
            cmdString.AppendFormat("where d.SalesOrderId = {0}", orderId.ToString());
            break;
         case "Customer":
            cmdString.Append("select CustomerID, CompanyName from SalesLT.Customer");
            break;
         case "Product":
            cmdString.Append("select ProductID, Name from SalesLT.Product");
            break;
         default:
            throw new ArgumentException("GetDataReader was given an incorrect request for data");
      }

      SqlCommand cmd = new SqlCommand(cmdString.ToString(), conn);

      return cmd.ExecuteReader();
   }

   protected void OrdersGridView_SelectedIndexChanged(object sender, EventArgs e)
   {
      SqlConnection conn = new SqlConnection(connectionString);

      try
      {
         conn.Open();
         BindOrdersGridView(conn);
         SqlDataReader drDetails = GetDataReader(conn, "OrderDetails");

         if (drDetails.HasRows)
         {
            OrderDetailsPanel.Visible = true;
            OrderDetailsView.DataSource = drDetails;
            OrderDetailsView.DataBind();
         }
         else
         {
            OrderDetailsPanel.Visible = false;
         }
      }
      finally
      {
         if (conn.State != ConnectionState.Closed)
         {
            conn.Close();
         }
      }
   }

   protected void btnAdd_Click(object sender, EventArgs e)
   {
      int ProductId = Convert.ToInt32(ddlProduct.SelectedValue);
      int Quantity = Convert.ToInt32(txtQuantity.Text);
      int Discount = Convert.ToInt32(txtDiscount.Text);
      int PricePerUnit = Convert.ToInt32(txtUnitPrice.Text);
      int CustomerId = Convert.ToInt32(ddlCompany.SelectedValue);

      string whichTransaction = rbTransactionType.SelectedValue.ToString();

      if (whichTransaction == "DB")
      {
         PerformDBTransaction(CustomerId, ProductId, Quantity, Discount, PricePerUnit);
      }
      else
      {
         PerformConnectionTransaction(CustomerId, ProductId, Quantity, Discount, PricePerUnit);
      }
   }

   private void PerformConnectionTransaction(int CustomerId, int ProductId, int Quantity, int Discount, int PricePerUnit)
   {
      // Get connection
      SqlConnection conn = new SqlConnection(connectionString);

      // Setup command to run sproc spAddOrder
      SqlCommand cmd = new SqlCommand("spAddOrder", conn);
      cmd.CommandType = CommandType.StoredProcedure;

      // Setup Parameters for spAddOrder
      SqlParameter customerIdParam = cmd.Parameters.Add("@CustomerID", SqlDbType.Int);
      customerIdParam.Value = CustomerId;
      customerIdParam.Direction = ParameterDirection.Input;

      SqlParameter salesOrderIdParam = cmd.Parameters.Add("@SalesOrderID", SqlDbType.Int);
      salesOrderIdParam.Direction = ParameterDirection.Output;

      // Declare transaction
      SqlTransaction transaction = null;
      int OrderID = -1;

      try
      {
         // Open connection 
         // Create transaction and add to command
         conn.Open();
         transaction = conn.BeginTransaction();
         cmd.Transaction = transaction;

         // Execute the stored procedure and get the ID for the new order
         cmd.ExecuteNonQuery();
         OrderID = Convert.ToInt32(cmd.Parameters["@SalesOrderID"].Value);

         // Now add the details for the order
         StringBuilder cmdAddDetails = new StringBuilder("insert into SalesLT.SalesOrderDetail ");
         cmdAddDetails.Append("(SalesOrderID, OrderQty, ProductID, UnitPrice, UnitPriceDiscount) ");
         cmdAddDetails.AppendFormat("values ({0}, {1}, {2}, {3}, {4})",
            OrderID.ToString(), Quantity, ProductId, PricePerUnit, Discount);

         // Re-use the command object for this update and execute it
         cmd.CommandType = CommandType.Text;
         cmd.CommandText = cmdAddDetails.ToString();
         cmd.ExecuteNonQuery();

         // commit the transaction
         transaction.Commit();

         BindOrdersGridView(conn);
      }
      catch (Exception e)
      {
         Trace.Write(e.Message);
         transaction.Rollback();
      }
      finally
      {
         if (conn.State != ConnectionState.Closed)
         {
            conn.Close();
         }
      }

      //Reset the form
      txtDiscount.Text = string.Empty;
      txtQuantity.Text = string.Empty;
      txtUnitPrice.Text = string.Empty;
      lblNewOrderID.Text = OrderID.ToString();
   }

   private void PerformDBTransaction(int CustomerId, int ProductId, int Quantity, int Discount, int PricePerUnit)
   {
      // Create connection and command
      SqlConnection conn = new SqlConnection(connectionString);
      SqlCommand cmd = new SqlCommand("spAddOrderTransactions", conn);
      cmd.CommandType = CommandType.StoredProcedure;

      // Add Input Parameters
      cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = CustomerId;
      cmd.Parameters.Add("@ProductId", SqlDbType.Int).Value = ProductId;
      cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = Quantity;
      cmd.Parameters.Add("@Discount", SqlDbType.Money).Value = Discount;
      cmd.Parameters.Add("@UnitPrice", SqlDbType.Money).Value = PricePerUnit;

      // Add Output Parameter
      SqlParameter salesOrderIdParam = cmd.Parameters.Add("@SalesOrderId", SqlDbType.Int);
      salesOrderIdParam.Direction = ParameterDirection.Output;

      // Setup new order id
      int OrderId = -1;

      try
      {
         conn.Open();

         // run transaction in DB
         cmd.ExecuteNonQuery();

         // get new order id
         OrderId = Convert.ToInt32(salesOrderIdParam.Value);

         // update gridview
         BindOrdersGridView(conn);
      }
      catch (Exception e)
      {
         Trace.Write(e.Message);
      }
      finally
      {
         if (conn.State != ConnectionState.Closed)
         {
            conn.Close();
         }
      }

      //Reset the form
      txtDiscount.Text = string.Empty;
      txtQuantity.Text = string.Empty;
      txtUnitPrice.Text = string.Empty;
      lblNewOrderID.Text = OrderId.ToString();
   }
}
