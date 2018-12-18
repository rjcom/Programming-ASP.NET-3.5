Imports System 
Imports System.Web.UI 

Public Partial Class UserControlEvents 
    Inherits Page 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) 
        AddHandler CustomerDL1.EditRecord, AddressOf CustomerDL1_EditRecord 
        AddHandler CustomerDL1.FinishedEditRecord, AddressOf CustomerDL1_FinishedEditRecord 
    End Sub 
    
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) 
        Label1.Text = "Changed!" 
    End Sub 
    
    Protected Sub CustomerDL1_EditRecord(ByVal sender As Object, ByVal e As CustomerDataList.ChangedRecordEventArgs) 
        lblDisplayCompany.Text = "Editing " & e.CompanyName 
    End Sub 
    
    Protected Sub CustomerDL1_FinishedEditRecord(ByVal sender As Object, ByVal e As EventArgs) 
        lblDisplayCompany.Text = [String].Empty 
    End Sub 
End Class 


