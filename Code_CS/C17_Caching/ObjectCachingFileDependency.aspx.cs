using System;
using System.Data;
using System.Web.Caching;
using System.Web.UI;
using System.Xml;

public partial class ObjectCachingFileDependency : Page
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
         CacheDependency fileDepends = 
            new CacheDependency(Server.MapPath("Customers.xml"));
         Cache.Insert("GridViewDataSet", dsGrid, fileDepends);
         lblMessage.Text = "Data from XML file.";
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
      DataSet dsData = new DataSet();
      XmlDataDocument doc = new XmlDataDocument();
      doc.DataSet.ReadXml(Server.MapPath("Customers.xml"));
      dsData = doc.DataSet;
      return dsData;
   }


   protected void btnClear_Click(object sender, EventArgs e)
   {
      Cache.Remove("GridViewDataSet");
      CreateGridView();
   }
}
