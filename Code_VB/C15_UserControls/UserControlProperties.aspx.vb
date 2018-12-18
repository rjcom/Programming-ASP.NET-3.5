Imports System 
Imports System.Web.UI 
Imports System.Web.UI.WebControls 

Public Partial Class UserControlProperties 
    Inherits Page 
    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) 
        CustomerDL1.NumOfColumns = Convert.ToInt32(ddlColumns.SelectedValue) 
        
        Select Case ddlDirection.SelectedValue 
            Case "Horizontal" 
                CustomerDL1.Direction = RepeatDirection.Horizontal 
                Exit Select 
            Case "Vertical" 
                CustomerDL1.Direction = RepeatDirection.Vertical 
                Exit Select 
        End Select 
    End Sub 
End Class 

