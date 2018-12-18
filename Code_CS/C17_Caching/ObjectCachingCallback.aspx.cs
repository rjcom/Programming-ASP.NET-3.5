using System;
using System.Data;
using System.IO;
using System.Web.Caching;
using System.Web.UI;
using System.Xml;

public partial class ObjectCachingCallback : Page
{
   public static CacheItemRemovedCallback onRemove = null;

   protected void Page_Load(object sender, EventArgs e)
   {
      CreateGridView();
   }

   private void CreateGridView()
   {
      DataSet dsGrid;
      dsGrid = (DataSet)Cache["GridViewDataSet"];

      onRemove = new CacheItemRemovedCallback(this.RemovedCallback);

      if (dsGrid == null)
      {
         dsGrid = GetDataSet();
         string[] fileDependsArray = { Server.MapPath("Customers.xml") };
         string[] cacheDependsArray = { "Depend0", "Depend1", "Depend2" };
         CacheDependency cacheDepends = new CacheDependency
            (fileDependsArray, cacheDependsArray);
         Cache.Insert("GridViewDataSet", dsGrid, cacheDepends,
            DateTime.Now.AddSeconds(10), Cache.NoSlidingExpiration, 
            CacheItemPriority.Default, 
            onRemove);
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

   public void RemovedCallback(string cacheKey, Object cacheObject, CacheItemRemovedReason reasonToRemove)    
   {       
      WriteFile("Cache removed for following reason: " +          
         reasonToRemove.ToString());    
   }     
   
   private void WriteFile(string strText)    
   {       
      StreamWriter writer = new StreamWriter("~\test.txt", true);       
      writer.WriteLine(String.Format("{0} {1}",
         DateTime.Now.ToString(), strText));       
      writer.Close();    
   }

   protected void btnClear_Click(object sender, EventArgs e)
   {
      Cache.Remove("GridViewDataSet");
      CreateGridView();
   }

   protected void btnInit_Click(object sender, EventArgs e)
   {
      //  Initialize caches to depend on.       
      Cache["Depend0"] = "This is the first dependency.";
      Cache["Depend1"] = "This is the 2nd dependency.";
      Cache["Depend2"] = "This is the 3rd dependency.";
   }

   protected void btnChange_Click(object sender, EventArgs e)
   {
      Cache["Depend0"] = "This is a changed first dependency.";
   }
}
