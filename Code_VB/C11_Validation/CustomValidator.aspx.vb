
Partial Class CustomValidator
    Inherits System.Web.UI.Page


    Protected Sub cvalEvenNumber_ServerValidate(ByVal source As Object, ByVal args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles cvalEvenNumber.ServerValidate
        args.IsValid = False
        Dim evenNumber As Integer = Int32.Parse(args.Value)
        If evenNumber Mod 2 = 0 Then
            args.IsValid = True
        End If
    End Sub
End Class
