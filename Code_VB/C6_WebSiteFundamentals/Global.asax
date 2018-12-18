<%@ Application Language="VB" %>
<%@ Import Namespace="System.IO" %>

<script runat="server">

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs on application startup
        Application("strStartMsg") = "The application has started."
        Dim Books As String() = {"SciFi", "Novels", "Computers", "History", "Religion"}
        Application("arBooks") = Books
        WriteFile("Application Starting")
    End Sub
    
    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs on application shutdown
        Application("strEndMsg") = "The application is ending."
        WriteFile("Application Ending")
    End Sub
        
    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when an unhandled error occurs
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when a new session is started
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when a session ends. 
        ' Note: The Session_End event is raised only when the sessionstate mode
        ' is set to InProc in the Web.config file. If session mode is set to StateServer 
        ' or SQLServer, the event is not raised.
    End Sub
    
    Private Sub WriteFile(ByVal strText As String)
        Dim writer As New StreamWriter("D:\test.txt", True)
        Dim str As String
        str = (DateTime.Now.ToString() & " ") + strText
        writer.WriteLine(str)
        writer.Close()
    End Sub


</script>