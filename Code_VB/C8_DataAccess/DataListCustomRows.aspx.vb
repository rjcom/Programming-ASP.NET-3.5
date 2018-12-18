
Partial Class DataListCustomRows
    Inherits System.Web.UI.Page

    Protected Sub DataList1_EditCommand(ByVal source As Object, ByVal e As DataListCommandEventArgs)
        DataList1.SelectedIndex = -1
        DataList1.EditItemIndex = e.Item.ItemIndex
        DataBind()
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
        dsCustomers.UpdateParameters("NameStyle").DefaultValue = DirectCast(e.Item.FindControl("NameStyleCheckBox"), CheckBox).Checked.ToString()
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
        DataBind()
    End Sub
    Protected Sub DataList1_CancelCommand(ByVal source As Object, ByVal e As DataListCommandEventArgs)
        DataList1.EditItemIndex = -1
        DataList1.SelectedIndex = -1
        lblInfo.Text = ""

        DataList1.DataBind()
    End Sub

    Protected Sub DataList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim info As New StringBuilder()
        info.AppendFormat("You are viewing record {0} of {1} <br />", DataList1.SelectedIndex.ToString(), DataList1.Items.Count.ToString())
        info.AppendFormat("You are viewing record {0} of {1} <br />", DataList1.SelectedIndex.ToString(), DataList1.DataKeys.Count)

        info.Append("Using DataKey<br />")
        info.AppendFormat("{0} : {1}<br />", DataList1.DataKeyField, DataList1.SelectedValue.ToString())

        lblInfo.Text = info.ToString()

        DataList1.DataBind()
    End Sub


End Class
