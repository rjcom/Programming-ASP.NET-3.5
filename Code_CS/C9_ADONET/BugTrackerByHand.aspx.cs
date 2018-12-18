using System;
using System.Data;
using System.Web.UI;

public partial class BugTrackerByHand : Page
{
   protected void Page_Load(object sender, EventArgs e)
   {
      if (!IsPostBack)
      {
         // call the method whichthat creates the tables and the relations
         DataSet ds = CreateDataSet();

         // set the data source for the grid to the first table
         BugsGridView.DataSource = ds.Tables["Bugs"];
         BugsGridView.DataBind();

         BugConstraintsGridView.DataSource = ds.Tables["Bugs"].Constraints;
         BugConstraintsGridView.DataBind();
      }
   }

   private DataSet CreateDataSet()
   {
      // Create a new DataSet object for tables and realtions
      DataSet dataSet = new DataSet();

      // Create the Bugs table and add it to the DataSet
      DataTable tblBugs = CreateBugsTable();
      dataSet.Tables.Add(tblBugs);

      // Create the Product Table and add it to the DataSet
      DataTable tblProduct = CreateProductTable();
      dataSet.Tables.Add(tblProduct);

      // Create the People Table and add it to the DataSet
      DataTable tblPeople = CreatePeopleTable();
      dataSet.Tables.Add(tblPeople);

      // Create the Foreign Key Constraint People.PersonID = Bugs.ReporterID
      CreateForeignKeyAndDataRelation(dataSet, "BugToPerson", tblPeople, "PersonID", tblBugs, "ReporterID");

      // Create the Foreign Key Constraint Product.ProductID = Bugs.ProductID
      CreateForeignKeyAndDataRelation(dataSet, "BugToProduct", tblProduct, "ProductID", tblBugs, "ProductID");

      return dataSet;
   }

   #region Generic Table Methods

   private void AddNewPrimaryKeyColumn(DataTable table, string ColumnName)
   {
      AddNewColumn(table, "System.Int32", ColumnName, false);
      DataColumn PkColumn = table.Columns[ColumnName];

      // Set column as auto-increment field
      PkColumn.AutoIncrement = true;       // autoincrementing
      PkColumn.AutoIncrementSeed = 1;      // starts at 1
      PkColumn.AutoIncrementStep = 1;      // increments by 1

      // Make sure all values are unique
      string constraintName = String.Format("Unique_{0}", ColumnName);
      UniqueConstraint constraint = new UniqueConstraint(constraintName, PkColumn);
      table.Constraints.Add(constraint);

      // Set column as primary key for table
      DataColumn[] columnArray = new DataColumn[] { PkColumn };
      table.PrimaryKey = columnArray;
   }

   private void AddNewColumn(DataTable table, string ColumnType, string ColumnName, bool AllowNulls, object DefaultValue, int MaxLength)
   {
      DataColumn newColumn = table.Columns.Add(ColumnName, Type.GetType(ColumnType));
      newColumn.AllowDBNull = AllowNulls;
      newColumn.MaxLength = MaxLength;
      newColumn.DefaultValue = DefaultValue;
   }

   private void AddNewColumn(DataTable table, string ColumnType, string ColumnName, bool AllowNulls, object DefaultValue)
   {
      AddNewColumn(table, ColumnType, ColumnName, AllowNulls, DefaultValue, -1);
   }

   private void AddNewColumn(DataTable table, string ColumnType, string ColumnName, bool AllowNulls)
   {
      AddNewColumn(table, ColumnType, ColumnName, AllowNulls, null, -1);
   }

   private void CreateForeignKeyAndDataRelation(DataSet dataSet, string relationName, DataTable parentTable, string primaryKeyColumnName, DataTable childTable, string foreignKeyColumnName)
   {
      // Get references to related columns
      DataColumn primaryKeyColumn = parentTable.Columns[primaryKeyColumnName];
      DataColumn foreignKeyColumn = childTable.Columns[foreignKeyColumnName];
      String foreignKeyConstraintName = String.Format("FK_{0}", relationName);

      // Create foreign key constraint
      ForeignKeyConstraint fk = new ForeignKeyConstraint(foreignKeyConstraintName, primaryKeyColumn, foreignKeyColumn);
      fk.DeleteRule = Rule.Cascade;   // if parent row is deleted, all rows related in child table are deleted too
      fk.UpdateRule = Rule.Cascade;
      childTable.Constraints.Add(fk);  // add the new constraint

      // Add a DataRelation representing the FKConstraint to the DataSet
      DataRelation relation = new DataRelation(relationName, primaryKeyColumn, foreignKeyColumn);
      dataSet.Relations.Add(relation);
   }

   #endregion

   #region Bugs Table

   private DataTable CreateBugsTable()
   {
      DataTable tblBugs = new DataTable("Bugs");

      // Add columns
      AddNewPrimaryKeyColumn(tblBugs, "BugID");
      AddNewColumn(tblBugs, "System.Int32", "ProductID", false, 1);
      AddNewColumn(tblBugs, "System.String", "Version", false, "0.1", 50);
      AddNewColumn(tblBugs, "System.String", "Description", false, "", 8000);
      AddNewColumn(tblBugs, "System.Int32", "ReporterID", false);

      // Add some rows to the table
      AddNewBug(tblBugs, 1, "0.1", "Crashes on load", 5);
      AddNewBug(tblBugs, 1, "0.1", "Does not report correct owner of bug", 5);
      AddNewBug(tblBugs, 1, "0.1", "Does not show history of previous action", 6);
      AddNewBug(tblBugs, 1, "0.1", "Fails to reload properly", 5);
      AddNewBug(tblBugs, 2, "0.1", "Loses data overnight", 5);
      AddNewBug(tblBugs, 2, "0.1", "HTML is not shown properly", 6);
      return tblBugs;
   }

   private void AddNewBug(DataTable bugTable, int product, string version, string description, int reporter)
   {
      DataRow newRow = bugTable.NewRow();
      newRow["ProductID"] = product;
      newRow["Version"] = version;
      newRow["Description"] = description;
      newRow["ReporterID"] = reporter;
      bugTable.Rows.Add(newRow);
   }


   #endregion

   #region Product Table

   private DataTable CreateProductTable()
   {
      DataTable tblProduct = new DataTable("lkProduct");

      // Add columns
      AddNewPrimaryKeyColumn(tblProduct, "ProductID");
      AddNewColumn(tblProduct, "System.String", "ProductDescription", false, "", 8000);

      // Add rows to the Product table
      AddNewProduct(tblProduct, "BugX Bug Tracking");
      AddNewProduct(tblProduct, "PIM - My Personal Information Manager");
      return tblProduct;
   }

   private void AddNewProduct(DataTable productTable, string description)
   {
      DataRow newRow = productTable.NewRow();
      newRow["ProductDescription"] = description;
      productTable.Rows.Add(newRow);
   }

   #endregion

   #region People Table

   private DataTable CreatePeopleTable()
   {
      DataTable tblPeople = new DataTable("People");

      // Add column
      AddNewPrimaryKeyColumn(tblPeople, "PersonID");
      AddNewColumn(tblPeople, "System.String", "FullName", false, "", 8000);
      AddNewColumn(tblPeople, "System.String", "Email", false, "", 100);
      AddNewColumn(tblPeople, "System.String", "Phone", false, "", 20);
      AddNewColumn(tblPeople, "System.Int32", "Role", false, 0);

      // Add new people
      AddNewPerson(tblPeople, "Dan Maharry", "danm@hmobius.com", "212-555-0285", 1);
      AddNewPerson(tblPeople, "Jesse Liberty", "jliberty@libertyassociates.com", "617-555-7301", 1);
      AddNewPerson(tblPeople, "Dan Hurwitz", "dhurwitz@stersol.com", "781-555-3375", 1);
      AddNewPerson(tblPeople, "John Galt", "jGalt@franconia.com", "617-555-9876", 1);
      AddNewPerson(tblPeople, "John Osborn", "jOsborn@oreilly.com", "617-555-3232", 3);
      AddNewPerson(tblPeople, "Ron Petrusha", "ron@oreilly.com", "707-555-0515", 2);
      AddNewPerson(tblPeople, "Tatiana Diaz", "tatiana@oreilly.com", "617-555-1234", 2);
      return tblPeople;
   }

   private void AddNewPerson(DataTable table, string name, string email, string phone, int role)
   {
      DataRow newRow = table.NewRow();
      newRow["FullName"] = name;
      newRow["email"] = email;
      newRow["Phone"] = phone;
      newRow["Role"] = role;
      table.Rows.Add(newRow);
   }

   #endregion

}
