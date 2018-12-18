Imports Microsoft.VisualBasic

Public Class Class1

    Public Shared Function GetTime() As String
        Return DateTime.Now.ToLongTimeString()
    End Function

End Class
