<%@ Application Language="VB" %>

<script runat="server">

    Private Sub Profile_MigrateAnonymous(ByVal sender As Object, ByVal e As ProfileMigrateEventArgs)
        
        Dim anonymousProfile As ProfileCommon = Profile.GetProfile(e.AnonymousID)
    
        If anonymousProfile IsNot Nothing AndAlso anonymousProfile.favoriteBooks IsNot Nothing Then
            For Each s As String In anonymousProfile.favoriteBooks
                Profile.favoriteBooks.Remove(s)
                ' Remove duplicates 
                Profile.favoriteBooks.Add(s)
            Next
            anonymousProfile.favoriteBooks.Clear()
        End If
        
    End Sub
    
    
    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs on application startup
    End Sub
    
    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs on application shutdown
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
       
</script>