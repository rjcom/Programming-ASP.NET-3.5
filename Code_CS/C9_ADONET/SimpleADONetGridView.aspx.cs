using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

public partial class SimpleADONetGridView : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // 1. Create the connection string and command string
       string connectionString = 
         "Data Source=(local)\\sql2k5;Initial Catalog=AdventureWorksLT;Integrated Security=True";

       string commandString = "Select [CustomerId], [FirstName], [LastName], [EmailAddress]  from SalesLT.Customer";

       // 2. Pass the strings to the SqlDataAdapter constructor
       SqlDataAdapter dataAdapter = new SqlDataAdapter(commandString, connectionString);

       // 3. Create a DataSet
       DataSet dataSet = new DataSet();
       // 4. fill the dataset object         
       dataAdapter.Fill(dataSet,"Customers");          
       
       // 5. Get the table from the dataset         
       DataTable dataTable = dataSet.Tables["Customers"];          
       
       // 6. Bind to the Gridview         
       GridView1.DataSource=dataTable;
       GridView1.DataBind();
    }
}
