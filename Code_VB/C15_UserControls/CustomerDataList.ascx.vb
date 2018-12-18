Imports System 
Imports System.Text 
Imports System.Web.UI 
Imports System.Web.UI.WebControls 

Public Partial Class CustomerDataList 
    Inherits UserControl 
    Public Class ChangedRecordEventArgs 
        Inherits EventArgs 
        Private m_companyName As String 
        
        Public ReadOnly Property CompanyName() As String 
            Get 
                Return m_companyName 
            End Get 
        End Property 
        
        Public Sub New(ByVal companyName As String) 
            Me.m_companyName = companyName 
        End Sub 
    End Class 
    
    Private m_numOfColumns As Integer = 3 
    Private m_direction As RepeatDirection = RepeatDirection.Horizontal 
    
    Public Property NumOfColumns() As Integer 
        Get 
            Return m_numOfColumns 
        End Get 
        Set(ByVal value As Integer) 
            m_numOfColumns = value 
        End Set 
    End Property 
    
    Public Property Direction() As RepeatDirection 
        Get 
            Return m_direction 
        End Get 
        Set(ByVal value As RepeatDirection) 
            m_direction = value 
        End Set 
    End Property 
    
    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As EventArgs) 
        DataList1.RepeatColumns = NumOfColumns 
        DataList1.RepeatDirection = Direction 
    End Sub 
    
    Public Delegate Sub EditRecordHandler(ByVal sender As Object, ByVal e As ChangedRecordEventArgs) 
    Public Event EditRecord As EditRecordHandler 
    
    Public Delegate Sub FinishedEditRecordHandler(ByVal sender As Object, ByVal e As EventArgs) 
    Public Event FinishedEditRecord As FinishedEditRecordHandler 
    
    Protected Overridable Sub OnEditRecord(ByVal e As ChangedRecordEventArgs) 
        RaiseEvent EditRecord(Me, e) 
    End Sub 
    
    Protected Overridable Sub OnFinishedEditRecord(ByVal e As EventArgs) 
        RaiseEvent FinishedEditRecord(Me, e) 
    End Sub 
    
    
    Protected Sub DataList1_EditCommand(ByVal source As Object, ByVal e As DataListCommandEventArgs) 
        DataList1.SelectedIndex = -1 
        DataList1.EditItemIndex = e.Item.ItemIndex 
        DataBind() 
        
        ' Now raise OnEditRecord event 
        Dim lbl As Label = DirectCast(e.Item.FindControl("CompanyNameLabel"), Label) 
        Dim companyName As String = lbl.Text 
        Dim cre As New ChangedRecordEventArgs(companyName) 
        OnEditRecord(cre) 
    End Sub 
    
    Protected Sub DataList1_DeleteCommand(ByVal source As Object, ByVal e As DataListCommandEventArgs) 
        ' (1) Get the recordID from the selected item 
        Dim recordID As String = (DataList1.DataKeys(e.Item.ItemIndex)).ToString() 
        
        ' (2) Get a reference to the customerID parameter 
        Dim param As Parameter = dsCustomers.DeleteParameters("CustomerID") 
        
        ' (3) Set the parameter's default value to the value for 
        ' the record to delete 
        param.DefaultValue = recordID 
        
        ' (4) Delete the record 
        dsCustomers.Delete() 
        
        ' (5) Rebind the list 
        DataBind() 
    End Sub 
    Protected Sub DataList1_UpdateCommand(ByVal source As Object, ByVal e As DataListCommandEventArgs) 
        dsCustomers.UpdateParameters("CustomerID").DefaultValue = (DataList1.DataKeys(e.Item.ItemIndex)).ToString() 
        dsCustomers.UpdateParameters("NameStyle").DefaultValue = DirectCast(e.Item.FindControl("NameStyleTextBox"), CheckBox).Checked.ToString() 
        dsCustomers.UpdateParameters("Title").DefaultValue = DirectCast(e.Item.FindControl("TitleTextBox"), TextBox).Text 
        dsCustomers.UpdateParameters("FirstName").DefaultValue = DirectCast(e.Item.FindControl("FirstNameTextBox"), TextBox).Text 
        dsCustomers.UpdateParameters("MiddleName").DefaultValue = DirectCast(e.Item.FindControl("MiddleNameTextBox"), TextBox).Text 
        dsCustomers.UpdateParameters("LastName").DefaultValue = DirectCast(e.Item.FindControl("LastNameTextBox"), TextBox).Text 
        dsCustomers.UpdateParameters("Suffix").DefaultValue = DirectCast(e.Item.FindControl("SuffixTextBox"), TextBox).Text 
        dsCustomers.UpdateParameters("CompanyName").DefaultValue = DirectCast(e.Item.FindControl("CompanyNameTextBox"), TextBox).Text 
        dsCustomers.UpdateParameters("SalesPerson").DefaultValue = DirectCast(e.Item.FindControl("SalesPersonTextBox"), TextBox).Text 
        dsCustomers.UpdateParameters("EmailAddress").DefaultValue = DirectCast(e.Item.FindControl("EmailAddressTextBox"), TextBox).Text 
        dsCustomers.UpdateParameters("Phone").DefaultValue = DirectCast(e.Item.FindControl("PhoneTextBox"), TextBox).Text 
        
        dsCustomers.Update() 
        
        DataList1.EditItemIndex = -1 
        DataList1.DataBind() 
        
        OnFinishedEditRecord(New EventArgs()) 
    End Sub 
    Protected Sub DataList1_CancelCommand(ByVal source As Object, ByVal e As DataListCommandEventArgs) 
        DataList1.EditItemIndex = -1 
        DataList1.SelectedIndex = -1 
        
        DataList1.DataBind() 
        
        OnFinishedEditRecord(New EventArgs()) 
    End Sub 
    
    Protected Sub DataList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) 
        Dim info As New StringBuilder() 
        info.AppendFormat("You are viewing record {0} of {1} <br />", DataList1.SelectedIndex.ToString(), DataList1.Items.Count.ToString()) 
        info.AppendFormat("You are viewing record {0} of {1} <br />", DataList1.SelectedIndex.ToString(), DataList1.DataKeys.Count) 
        
        info.Append("Using DataKey<br />") 
        info.AppendFormat("{0} : {1}<br />", DataList1.DataKeyField, DataList1.SelectedValue.ToString()) 
        
        DataList1.DataBind() 
    End Sub 
End Class 
