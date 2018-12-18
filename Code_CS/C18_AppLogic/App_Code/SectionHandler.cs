using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;  
using System.Xml;

public class DataSetSectionHandler : IConfigurationSectionHandler
{
   public Object Create(Object parent, Object configContext,  XmlNode section)    
   {       
      string strSql;       
      strSql = section.Attributes.Item(0).Value;        
      string connectionString = "server=(local)\\sql2k5;Integrated Security=true;database=AdventureWorksLT";        
      
      // create the data set command object and the DataSet       
      SqlDataAdapter da = new SqlDataAdapter(strSql, connectionString);        
      DataSet dsData = new DataSet();        
      
      // fill the data set object       
      da.Fill(dsData, "Customers");        
      return dsData;    }
}
