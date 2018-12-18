using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpdatingDBDirectly : Page
{
   private readonly string connectionString = "Data Source=(local)\\sql2k5;Initial Catalog=AdventureWorksLT;Integrated Security=True";

   protected void Page_Load(object sender, EventArgs e)
   {
      if (!IsPostBack)
      {
         PopulateCategoryList();
         PopulateGrid();
      }
   }

   private void PopulateCategoryList()
   {
      // Create connection to AdventureWorksLT
      SqlConnection connection = new SqlConnection(connectionString);

      // Create SqlCommand
      StringBuilder cmdString = new StringBuilder("SELECT DISTINCT ProductCategoryID, Name FROM SalesLT.ProductCategory ");
      cmdString.Append("WHERE (ParentProductCategoryID IS NULL) ORDER BY ProductCategoryID");
      SqlCommand cmd = new SqlCommand(cmdString.ToString(), connection);

      try
      {
         connection.Open();
         SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

         while (dr.Read())
         {
            ddlParentCategory.Items.Add(new ListItem(dr["Name"].ToString(), dr["ProductCategoryID"].ToString()));
         }

         dr.Close();
      }
      finally
      {
         if (connection.State != ConnectionState.Closed)
         {
            connection.Close();
         }
      }
   }

   private void PopulateGrid()
   {
      // Create connection to AdventureWorksLT
      SqlConnection connection = new SqlConnection(connectionString);

      // Create SqlCommand string
      StringBuilder cmdString = new StringBuilder("SELECT child.ProductCategoryId, child.Name AS 'Category', child.ParentProductCategoryID, parent.Name AS 'ParentCategory'");
      cmdString.Append("FROM SalesLT.ProductCategory AS child INNER JOIN ");
      cmdString.Append("SalesLT.ProductCategory AS parent ON child.ParentProductCategoryID = parent.ProductCategoryID");

      SqlCommand cmd = new SqlCommand(cmdString.ToString(), connection);

      try
      {
         connection.Open();
         SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
         CategoryGridView.DataSource = dr;
         CategoryGridView.DataBind();

         dr.Close();
      }
      finally
      {
         if (connection.State != ConnectionState.Closed)
         {
            connection.Close();
         }
      }      
   }    


   protected void btnAdd_Click(object sender, EventArgs e)
   {
      String insertCommand = String.Format("insert into SalesLT.ProductCategory ([ParentProductCategoryID], [Name]) values ('{0}', '{1}')",
         ddlParentCategory.SelectedValue, txtName.Text);
      UpdateDB(insertCommand);
      PopulateGrid();
   }

   protected void btnEdit_Click(object sender, EventArgs e)
   {
      String updateCommand = String.Format("Update SalesLT.ProductCategory SET Name='{0}', ParentProductCategoryID='{1}' where ProductCategoryID='{2}'",
         txtName.Text, ddlParentCategory.SelectedValue, hdnCategoryID.Value);
      UpdateDB(updateCommand);
      PopulateGrid();
   }
   protected void btnDelete_Click(object sender, EventArgs e)
   {
      string deleteCommand = String.Format("delete from SalesLT.ProductCategory where ProductCategoryID ='{0}'", hdnCategoryID.Value);
      UpdateDB(deleteCommand);
      PopulateGrid();
   }

   private void UpdateDB(string cmdString)
   {
      SqlConnection connection = new SqlConnection(connectionString);
      SqlCommand command = new SqlCommand(cmdString, connection);

      try
      {
         connection.Open();
         command.ExecuteNonQuery();
      }
      finally
      {
         if (connection.State != ConnectionState.Closed)
         {
            connection.Close();
         }
      }
   }

   protected void CategoryGridView_SelectedIndexChanged(object sender, EventArgs e)
   {
      int selectedIndex = CategoryGridView.SelectedIndex;

      if (selectedIndex != -1)
      {
         TableCellCollection selectedValues = CategoryGridView.Rows[selectedIndex].Cells;
         
         // Have to know the order of these cells in the Grid
         hdnCategoryID.Value = selectedValues[1].Text;
         txtName.Text = selectedValues[2].Text;
         ddlParentCategory.SelectedValue = selectedValues[3].Text;
      }
   }
}
