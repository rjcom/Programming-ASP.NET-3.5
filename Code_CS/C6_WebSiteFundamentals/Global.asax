<%@ Application Language="C#" CodeBehind   %>
<%@ Import Namespace="System.IO" %>

<script RunAt="server">

   void Application_Start(object sender, EventArgs e)
   {
      // Code that runs on application startup        
      Application["strStartMsg"] = "The application has started.";
      string[] Books = { "SciFi", "Novels", "Computers", "History", "Religion" };
      Application["arBooks"] = Books;
      WriteFile("Application Starting");
   }

   void Application_End(object sender, EventArgs e)
   {
      //  Code that runs on application shutdown        
      Application["strEndMsg"] = "The application is ending.";
      WriteFile("Application Ending");
   }

   void Application_Error(object sender, EventArgs e)
   {
      // Code that runs when an unhandled error occurs

   }

   void Session_Start(object sender, EventArgs e)
   {
      // Code that runs when a new session is started

   }

   void Session_End(object sender, EventArgs e)
   {
      // Code that runs when a session ends. 
      // Note: The Session_End event is raised only when the sessionstate mode
      // is set to InProc in the Web.config file. If session mode is set to StateServer 
      // or SQLServer, the event is not raised.

   }

   void WriteFile(string strText)
   {
      StreamWriter writer = new StreamWriter(@"C:\test.txt", true); 
      string str; 
      str = DateTime.Now.ToString() + "  " + strText; 
      writer.WriteLine(str); 
      writer.Close();
   }
</script>

