Imports System
Imports System.IO

Public Class GlobalMembers
    Public Shared successRate As Integer = 50

    Public Sub New()
    End Sub

    Protected Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        WriteFile("Application Starting")
    End Sub

    Protected Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        WriteFile("Application Ending")
    End Sub

    Public Sub WriteFile(ByVal strText As String)
        Using writer As New StreamWriter(HttpContext.Current.Server.MapPath("test.txt"), True)
            Dim str As String
            str = (DateTime.Now.ToString() & " ") + strText
            writer.WriteLine(str)
            writer.Close()
        End Using
    End Sub

    Public Shared Sub StaticWriteFile(ByVal strText As String)
        Using writer As New StreamWriter(HttpContext.Current.Server.MapPath("test.txt"), True)
            Dim str As String
            str = (DateTime.Now.ToString() & " ") + strText
            writer.WriteLine(str)
            writer.Close()
        End Using
    End Sub
End Class