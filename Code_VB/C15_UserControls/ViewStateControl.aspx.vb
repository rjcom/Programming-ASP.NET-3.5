Imports System 
Imports System.Web.UI 

Public Partial Class ViewStateControl 
    Inherits Page 
    Protected Sub btnSize_Click(ByVal sender As Object, ByVal e As EventArgs) 
        sizeControl.Size += 2 
    End Sub 
End Class 
