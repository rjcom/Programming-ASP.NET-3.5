
Partial Class WizardDemo
    Inherits System.Web.UI.Page

    Protected Sub Wizard1_ActiveStepChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Wizard1.ActiveStepChanged
        lblActiveStep.Text = Wizard1.ActiveStep.Title
        lblActiveStepIndex.Text = Wizard1.ActiveStepIndex.ToString()
        lblStepType.Text = Wizard1.ActiveStep.StepType.ToString()

        ' get the history
        Dim steps As ICollection = Wizard1.GetHistory()
        Dim str As String = ""
        For Each [step] As WizardStep In steps
            str += [step].Title & "<br/>"
        Next
        lblHistory.Text = str
    End Sub

    Protected Sub Wizard1_CancelButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles Wizard1.CancelButtonClick
        lblActiveStep.Text = ""
        lblActiveStepIndex.Text = ""
        lblStepType.Text = ""
        lblButtonInfo.Text = "Canceled"
        Wizard1.Visible = False
    End Sub

    Protected Sub Button_Click(ByVal sender As Object, ByVal e As WizardNavigationEventArgs)
        Dim str As String = ("Current Index: " & e.CurrentStepIndex.ToString() & ". Next Step: ") + e.NextStepIndex.ToString()
        lblButtonInfo.Text = str
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Dim index As Integer = DropDownList1.SelectedIndex
        Dim [step] As WizardStepBase = Wizard1.WizardSteps(index)
        Wizard1.MoveTo([step])
    End Sub


End Class
